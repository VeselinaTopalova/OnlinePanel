using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CreateTargetAnswerCorect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetUserAnswers_Answers_AnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetUserAnswers_AnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "TargetUserAnswers");

            migrationBuilder.AlterColumn<int>(
                name: "TargetQuestionId",
                table: "TargetAnswers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId1",
                table: "TargetAnswers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetQuestionId1",
                table: "TargetAnswers",
                column: "TargetQuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId1",
                table: "TargetAnswers",
                column: "TargetQuestionId1",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId1",
                table: "TargetAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetAnswers_TargetQuestionId1",
                table: "TargetAnswers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId1",
                table: "TargetAnswers");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "TargetUserAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TargetQuestionId",
                table: "TargetAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_AnswerId",
                table: "TargetUserAnswers",
                column: "AnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetUserAnswers_Answers_AnswerId",
                table: "TargetUserAnswers",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
