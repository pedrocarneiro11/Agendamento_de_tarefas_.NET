using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace agendamento_de_tarefas.Migrations
{
    /// <inheritdoc />
    public partial class StatusMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusTarefa",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusTarefa",
                table: "Tarefas");
        }
    }
}
