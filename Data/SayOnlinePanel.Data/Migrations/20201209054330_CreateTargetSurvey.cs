using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CreateTargetSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ImageForQuestions_QuestionId",
                table: "ImageForQuestions");

            migrationBuilder.AddColumn<int>(
                name: "TargetSurveyId",
                table: "Surveys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetSurveyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId",
                table: "Answers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId1",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TargetSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PointsStart = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TargetQuestionType = table.Column<int>(nullable: false),
                    TargetSurveyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetQuestions_TargetSurveys_TargetSurveyId",
                        column: x => x.TargetSurveyId,
                        principalTable: "TargetSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TargetUserAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    AnswerId = table.Column<int>(nullable: false),
                    TargetQuestionId = table.Column<int>(nullable: false),
                    TargetSurveyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetUserAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetUserAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetUserAnswers_TargetQuestions_TargetQuestionId",
                        column: x => x.TargetQuestionId,
                        principalTable: "TargetQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetUserAnswers_TargetSurveys_TargetSurveyId",
                        column: x => x.TargetSurveyId,
                        principalTable: "TargetSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetUserAnswers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_TargetSurveyId",
                table: "Surveys",
                column: "TargetSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageForQuestions_QuestionId",
                table: "ImageForQuestions",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TargetSurveyId",
                table: "AspNetUsers",
                column: "TargetSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TargetQuestionId",
                table: "Answers",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TargetQuestionId1",
                table: "Answers",
                column: "TargetQuestionId1");

            migrationBuilder.CreateIndex(
                name: "IX_TargetQuestions_IsDeleted",
                table: "TargetQuestions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_TargetQuestions_TargetSurveyId",
                table: "TargetQuestions",
                column: "TargetSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSurveys_IsDeleted",
                table: "TargetSurveys",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_AnswerId",
                table: "TargetUserAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_TargetQuestionId",
                table: "TargetUserAnswers",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_TargetSurveyId",
                table: "TargetUserAnswers",
                column: "TargetSurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUserAnswers_UserId",
                table: "TargetUserAnswers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId",
                table: "Answers",
                column: "TargetQuestionId",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId1",
                table: "Answers",
                column: "TargetQuestionId1",
                principalTable: "TargetQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TargetSurveys_TargetSurveyId",
                table: "AspNetUsers",
                column: "TargetSurveyId",
                principalTable: "TargetSurveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_TargetSurveys_TargetSurveyId",
                table: "Surveys",
                column: "TargetSurveyId",
                principalTable: "TargetSurveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId1",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TargetSurveys_TargetSurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_TargetSurveys_TargetSurveyId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "TargetUserAnswers");

            migrationBuilder.DropTable(
                name: "TargetQuestions");

            migrationBuilder.DropTable(
                name: "TargetSurveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_TargetSurveyId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_ImageForQuestions_QuestionId",
                table: "ImageForQuestions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TargetSurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TargetQuestionId1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TargetSurveyId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "TargetSurveyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId1",
                table: "Answers");

            migrationBuilder.CreateIndex(
                name: "IX_ImageForQuestions_QuestionId",
                table: "ImageForQuestions",
                column: "QuestionId");
        }
    }
}
