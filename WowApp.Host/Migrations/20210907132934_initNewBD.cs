using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WowApp.Host.Migrations
{
    public partial class initNewBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_User_UserId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "Explosive");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "User");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "InventoryModel");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_UserId",
                table: "InventoryModel",
                newName: "IX_InventoryModel_UserId");

            migrationBuilder.AddColumn<float>(
                name: "Experience",
                table: "User",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Hp",
                table: "User",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "Level",
                table: "User",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "User",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryModel",
                table: "InventoryModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryModel_User_UserId",
                table: "InventoryModel",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryModel_User_UserId",
                table: "InventoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryModel",
                table: "InventoryModel");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "User");

            migrationBuilder.RenameTable(
                name: "InventoryModel",
                newName: "Inventory");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryModel_UserId",
                table: "Inventory",
                newName: "IX_Inventory_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Damage = table.Column<int>(type: "integer", nullable: false),
                    ReloadTime = table.Column<float>(type: "real", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Explosive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Range = table.Column<float>(type: "real", nullable: false),
                    WeaponId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explosive", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Explosive_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Explosive_WeaponId",
                table: "Explosive",
                column: "WeaponId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_User_UserId",
                table: "Inventory",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
