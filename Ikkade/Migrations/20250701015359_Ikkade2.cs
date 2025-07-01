using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ikkade.Migrations
{
    /// <inheritdoc />
    public partial class Ikkade2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillerUserId",
                table: "Billers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminUserId",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillerUserId",
                table: "Billers");

            migrationBuilder.DropColumn(
                name: "AdminUserId",
                table: "Admins");
        }
    }
}
