using Microsoft.EntityFrameworkCore.Migrations;

namespace test_mvc_webapp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductCode = table.Column<string>(maxLength: 20, nullable: false),
                    ProductType = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    QtyInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
