using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeTales.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserFirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrewMethod",
                table: "CupOfCoffees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GringSize",
                table: "CupOfCoffees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "H2oTemp",
                table: "CupOfCoffees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "CupOfCoffees",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoasterName",
                table: "Coffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoastType",
                table: "Coffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoffeeName",
                table: "Coffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrewMethod",
                table: "CupOfCoffees");

            migrationBuilder.DropColumn(
                name: "GringSize",
                table: "CupOfCoffees");

            migrationBuilder.DropColumn(
                name: "H2oTemp",
                table: "CupOfCoffees");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "CupOfCoffees");

            migrationBuilder.AlterColumn<string>(
                name: "UserFirstName",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RoasterName",
                table: "Coffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RoastType",
                table: "Coffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CoffeeName",
                table: "Coffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
