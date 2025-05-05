using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StepCityApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTitleAndCargo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Shoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
