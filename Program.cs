var builder = WebApplication.CreateBuilder(args);

// CORS policy adı
var corsPolicyName = "AllowAll"; // istersen özel bir isim verebilirsin

// CORS servis ekleme
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

builder.Services.AddControllers();  // API Controller'larını kaydediyoruz
builder.Services.AddOpenApi();      // Swagger servisini ekliyoruz

var app = builder.Build();

// CORS'u pipeline'a ekle
app.UseCors(corsPolicyName);

// OpenAPI (Swagger) sadece development'ta aktif
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapControllers();  // Controller rotalarını ekliyoruz

app.Run();
