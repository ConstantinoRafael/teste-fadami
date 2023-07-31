using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace teste_tecnico_fadami.Migrations
{
    /// <inheritdoc />
    public partial class RemoveConfirmSenha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CONFIRMA_SENHA",
                table: "Usuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CONFIRMA_SENHA",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
