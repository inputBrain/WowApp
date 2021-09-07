using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WowApp.Host.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryModel_User_UserId",
                table: "InventoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryModel",
                table: "InventoryModel");

            migrationBuilder.RenameTable(
                name: "InventoryModel",
                newName: "Inventory");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryModel_UserId",
                table: "Inventory",
                newName: "IX_Inventory_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    ReloadTime = table.Column<float>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Explosive",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponId = table.Column<int>(nullable: false),
                    Range = table.Column<float>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_User_UserId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Explosive");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "InventoryModel");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_UserId",
                table: "InventoryModel",
                newName: "IX_InventoryModel_UserId");

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
    }
}
