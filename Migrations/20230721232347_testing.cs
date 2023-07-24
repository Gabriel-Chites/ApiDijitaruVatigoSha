using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinandoCodinDojo.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Collaborators_CollaboratorId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CollaboratorId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CollaboratorId",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "CollaboratorProject",
                columns: table => new
                {
                    CollaboratorsId = table.Column<int>(type: "int", nullable: false),
                    Projectsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollaboratorProject", x => new { x.CollaboratorsId, x.Projectsid });
                    table.ForeignKey(
                        name: "FK_CollaboratorProject_Collaborators_CollaboratorsId",
                        column: x => x.CollaboratorsId,
                        principalTable: "Collaborators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollaboratorProject_Projects_Projectsid",
                        column: x => x.Projectsid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CollaboratorProject_Projectsid",
                table: "CollaboratorProject",
                column: "Projectsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollaboratorProject");

            migrationBuilder.AddColumn<int>(
                name: "CollaboratorId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CollaboratorId",
                table: "Projects",
                column: "CollaboratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Collaborators_CollaboratorId",
                table: "Projects",
                column: "CollaboratorId",
                principalTable: "Collaborators",
                principalColumn: "Id");
        }
    }
}
