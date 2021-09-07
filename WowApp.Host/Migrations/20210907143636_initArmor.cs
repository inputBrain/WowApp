using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WowApp.Host.Migrations
{
    public partial class initArmor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(nullable: false),
                    Cover = table.Column<string>(nullable: false),
                    EnhanceLevel = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    RequiredLevel = table.Column<int>(nullable: false),
                    PDef = table.Column<int>(nullable: false),
                    MDef = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    BuyPrice = table.Column<int>(nullable: false),
                    SalePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor");
        }
    }
}
