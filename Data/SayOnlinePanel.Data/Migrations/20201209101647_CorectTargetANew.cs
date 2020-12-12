using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CorectTargetANew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetAnswerId",
                table: "TargetUserAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId",
                table: "TargetAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_TargetAnswerId",
                table: "TargetUserAnswers",
                column: "TargetAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetQuestionId",
                table: "TargetAnswers",
                column: "TargetQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId",
                table: "TargetAnswers",
                column: "TargetQuestionId",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetUserAnswers_TargetAnswers_TargetAnswerId",
                table: "TargetUserAnswers",
                column: "TargetAnswerId",
                principalTable: "TargetAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId",
                table: "TargetAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetUserAnswers_TargetAnswers_TargetAnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetUserAnswers_TargetAnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetAnswers_TargetQuestionId",
                table: "TargetAnswers");

            migrationBuilder.DropColumn(
                name: "TargetAnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId",
                table: "TargetAnswers");
        }
    }
}
