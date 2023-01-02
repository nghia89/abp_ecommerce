using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABPEcommerce.Migrations
{
    public partial class addfiledproductcategoryname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreategoryName",
                table: "AppProducts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CreategorySlug",
                table: "AppProducts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreategoryName",
                table: "AppProducts");

            migrationBuilder.DropColumn(
                name: "CreategorySlug",
                table: "AppProducts");
        }
    }
}
