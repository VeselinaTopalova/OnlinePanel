using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CreateClassTargetSelectedAnswerCorect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TargetSelectedAnswerId",
                table: "TargetAnswers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TargetSelectedAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetQuestionId = table.Column<int>(nullable: false),
                    TargetSurveyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetSelectedAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetSelectedAnswers_TargetQuestions_TargetQuestionId",
                        column: x => x.TargetQuestionId,
                        principalTable: "TargetQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetSelectedAnswers_TargetSurveys_TargetSurveyId",
                        column: x => x.TargetSurveyId,
                        principalTable: "TargetSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetSelectedAnswerId",
                table: "TargetAnswers",
                column: "TargetSelectedAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSelectedAnswers_TargetQuestionId",
                table: "TargetSelectedAnswers",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSelectedAnswers_TargetSurveyId",
                table: "TargetSelectedAnswers",
                column: "TargetSurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_TargetAnswers_TargetSelectedAnswers_TargetSelectedAnswerId",
                table: "TargetAnswers",
                column: "TargetSelectedAnswerId",
                principalTable: "TargetSelectedAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TargetAnswers_TargetSelectedAnswers_TargetSelectedAnswerId",
                table: "TargetAnswers");

            migrationBuilder.DropTable(
                name: "TargetSelectedAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetAnswers_TargetSelectedAnswerId",
                table: "TargetAnswers");

            migrationBuilder.DropColumn(
                name: "TargetSelectedAnswerId",
                table: "TargetAnswers");
        }
    }
}
