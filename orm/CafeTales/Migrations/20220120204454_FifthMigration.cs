using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeTales.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "H2oTemp",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GrindSize",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CupOfRoasterName",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CupOfRoastType",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CupOfCoffeeName",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrewMethod",
                table: "CupOfCoffees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CupOfCoffeeId1",
                table: "CupOfCoffees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoffeeId1",
                table: "Coffees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CupOfCoffees_CupOfCoffeeId1",
                table: "CupOfCoffees",
                column: "CupOfCoffeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Coffees_CoffeeId1",
                table: "Coffees",
                column: "CoffeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Coffees_Coffees_CoffeeId1",
                table: "Coffees",
                column: "CoffeeId1",
                principalTable: "Coffees",
                principalColumn: "CoffeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CupOfCoffees_CupOfCoffees_CupOfCoffeeId1",
                table: "CupOfCoffees",
                column: "CupOfCoffeeId1",
                principalTable: "CupOfCoffees",
                principalColumn: "CupOfCoffeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coffees_Coffees_CoffeeId1",
                table: "Coffees");

            migrationBuilder.DropForeignKey(
                name: "FK_CupOfCoffees_CupOfCoffees_CupOfCoffeeId1",
                table: "CupOfCoffees");

            migrationBuilder.DropIndex(
                name: "IX_CupOfCoffees_CupOfCoffeeId1",
                table: "CupOfCoffees");

            migrationBuilder.DropIndex(
                name: "IX_Coffees_CoffeeId1",
                table: "Coffees");

            migrationBuilder.DropColumn(
                name: "CupOfCoffeeId1",
                table: "CupOfCoffees");

            migrationBuilder.DropColumn(
                name: "CoffeeId1",
                table: "Coffees");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "H2oTemp",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "GrindSize",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CupOfRoasterName",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CupOfRoastType",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CupOfCoffeeName",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BrewMethod",
                table: "CupOfCoffees",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
