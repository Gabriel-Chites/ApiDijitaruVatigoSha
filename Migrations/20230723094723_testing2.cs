using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinandoCodinDojo.Migrations
{
    /// <inheritdoc />
    public partial class testing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeRecording_Collaborators_CollaboratorId",
                table: "TimeRecording");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeRecording_Projects_ProjectId",
                table: "TimeRecording");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeRecording",
                table: "TimeRecording");

            migrationBuilder.RenameTable(
                name: "TimeRecording",
                newName: "Records");

            migrationBuilder.RenameIndex(
                name: "IX_TimeRecording_ProjectId",
                table: "Records",
                newName: "IX_Records_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeRecording_CollaboratorId",
                table: "Records",
                newName: "IX_Records_CollaboratorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Records",
                table: "Records",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Collaborators_CollaboratorId",
                table: "Records",
                column: "CollaboratorId",
                principalTable: "Collaborators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Projects_ProjectId",
                table: "Records",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Collaborators_CollaboratorId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Projects_ProjectId",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Records",
                table: "Records");

            migrationBuilder.RenameTable(
                name: "Records",
                newName: "TimeRecording");

            migrationBuilder.RenameIndex(
                name: "IX_Records_ProjectId",
                table: "TimeRecording",
                newName: "IX_TimeRecording_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Records_CollaboratorId",
                table: "TimeRecording",
                newName: "IX_TimeRecording_CollaboratorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeRecording",
                table: "TimeRecording",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeRecording_Collaborators_CollaboratorId",
                table: "TimeRecording",
                column: "CollaboratorId",
                principalTable: "Collaborators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeRecording_Projects_ProjectId",
                table: "TimeRecording",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
