using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CorectTargetAA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "TargetAnswerId",
                table: "UserAnswers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetAnswerId",
                table: "UserAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId",
                principalTable: "TargetAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
