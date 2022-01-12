using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeTales.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GringSize",
                table: "CupOfCoffees");

            migrationBuilder.AddColumn<string>(
                name: "GrindSize",
                table: "CupOfCoffees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrindSize",
                table: "CupOfCoffees");

            migrationBuilder.AddColumn<string>(
                name: "GringSize",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
