using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// JWT Ayarlarını al
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);

// CORS policy
var corsPolicyName = "AllowAll";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName, policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// 🔐 JWT Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

builder.Services.AddControllers();
builder.Services.AddOpenApi(); // Eğer Swashbuckle yerine OpenAPI kullanıyorsan bu tamam

var app = builder.Build();

app.UseCors(corsPolicyName);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Eğer `AddOpenApi()` kullanıyorsan bu tamam
}

app.UseHttpsRedirection();

app.UseAuthentication(); // 🧩 Auth middleware'i
app.UseAuthorization();  // 🧩 Authorization middleware'i

app.MapControllers();

app.Run();
