using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class RemoveUserAnswersTargetAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_TargetSurveys_TargetSurveyId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_TargetSurveyId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "TargetSurveyId",
                table: "UserAnswers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetAnswerId",
                table: "UserAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetSurveyId",
                table: "UserAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_TargetSurveyId",
                table: "UserAnswers",
                column: "TargetSurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId",
                principalTable: "TargetAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_TargetSurveys_TargetSurveyId",
                table: "UserAnswers",
                column: "TargetSurveyId",
                principalTable: "TargetSurveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
