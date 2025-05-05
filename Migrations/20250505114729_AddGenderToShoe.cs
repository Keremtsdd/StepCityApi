using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepCityApi.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderToShoe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Shoes");
        }
    }
}
