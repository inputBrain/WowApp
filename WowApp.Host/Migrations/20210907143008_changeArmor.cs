using Microsoft.EntityFrameworkCore.Migrations;

namespace WowApp.Host.Migrations
{
    public partial class changeArmor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Defence",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "TemperatureProtection",
                table: "Armor");

            migrationBuilder.AddColumn<float>(
                name: "BuyPrice",
                table: "Armor",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Armor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "EnhanceLevel",
                table: "Armor",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Armor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MDef",
                table: "Armor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PDef",
                table: "Armor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequiredLevel",
                table: "Armor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SalePrice",
                table: "Armor",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyPrice",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "EnhanceLevel",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "MDef",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "PDef",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "RequiredLevel",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Armor");

            migrationBuilder.AddColumn<float>(
                name: "Defence",
                table: "Armor",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TemperatureProtection",
                table: "Armor",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
