using Microsoft.EntityFrameworkCore.Migrations;

namespace AppProdutos.Migrations
{
    public partial class appprodutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    NomeProduto = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ValorProduto = table.Column<decimal>(type: "decimal", nullable: false),
                    ImagemProdutoUrl = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.NomeProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
