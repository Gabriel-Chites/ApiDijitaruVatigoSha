using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinandoCodinDojo.Migrations
{
    /// <inheritdoc />
    public partial class AddedApprovedHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApproveHoursId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApproveHoursId",
                table: "Collaborators",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApproveHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproveHours", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Records_ApproveHoursId",
                table: "Records",
                column: "ApproveHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborators_ApproveHoursId",
                table: "Collaborators",
                column: "ApproveHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborators_ApproveHours_ApproveHoursId",
                table: "Collaborators",
                column: "ApproveHoursId",
                principalTable: "ApproveHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_ApproveHours_ApproveHoursId",
                table: "Records",
                column: "ApproveHoursId",
                principalTable: "ApproveHours",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborators_ApproveHours_ApproveHoursId",
                table: "Collaborators");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_ApproveHours_ApproveHoursId",
                table: "Records");

            migrationBuilder.DropTable(
                name: "ApproveHours");

            migrationBuilder.DropIndex(
                name: "IX_Records_ApproveHoursId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Collaborators_ApproveHoursId",
                table: "Collaborators");

            migrationBuilder.DropColumn(
                name: "ApproveHoursId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ApproveHoursId",
                table: "Collaborators");
        }
    }
}
