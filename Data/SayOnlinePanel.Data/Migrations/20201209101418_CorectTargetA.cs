using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CorectTargetA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId",
                table: "TargetAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId1",
                table: "TargetAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetAnswers_TargetQuestionId",
                table: "TargetAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetAnswers_TargetQuestionId1",
                table: "TargetAnswers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId",
                table: "TargetAnswers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId1",
                table: "TargetAnswers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId",
                table: "TargetAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId1",
                table: "TargetAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetQuestionId",
                table: "TargetAnswers",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetQuestionId1",
                table: "TargetAnswers",
                column: "TargetQuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId",
                table: "TargetAnswers",
                column: "TargetQuestionId",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId1",
                table: "TargetAnswers",
                column: "TargetQuestionId1",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
