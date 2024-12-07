using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaDeCompras.Data.Migrations
{
    /// <inheritdoc />
    public partial class v02_ListaDeCompras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeDoProduto",
                table: "Produtos",
                newName: "Item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item",
                table: "Produtos",
                newName: "NomeDoProduto");
        }
    }
}
