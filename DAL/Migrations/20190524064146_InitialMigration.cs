using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CocaColaProducts",
                columns: table => new
                {
                    MaterialCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand_Name = table.Column<string>(nullable: true),
                    Material_Package = table.Column<string>(nullable: true),
                    Material_Type = table.Column<string>(nullable: true),
                    Material_Unit_Size = table.Column<string>(nullable: true),
                    Material_Size = table.Column<int>(nullable: false),
                    RemainingQTY = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Wholesaler_Id = table.Column<int>(nullable: false),
                    Suggested_Price_PerCase = table.Column<double>(nullable: false),
                    Suggested_Price_PerBottle = table.Column<double>(nullable: false),
                    Actual_Price_PerCase = table.Column<double>(nullable: false),
                    Actual_Price_PerBottle = table.Column<double>(nullable: false),
                    isCokeProduct = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    Image_Path = table.Column<string>(nullable: true),
                    Added_By = table.Column<int>(nullable: true),
                    Added_Date = table.Column<string>(nullable: true),
                    Updated_By = table.Column<int>(nullable: true),
                    Updated_Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocaColaProducts", x => x.MaterialCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocaColaProducts");
        }
    }
}
