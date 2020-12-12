using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CreateTargetAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_TargetQuestions_TargetQuestionId1",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TargetQuestionId1",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "TargetQuestionId1",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "TargetAnswerId",
                table: "UserAnswers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "TargetSurveys",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetAnswerId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TargetAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TargetQuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetAnswers_TargetQuestions_TargetQuestionId",
                        column: x => x.TargetQuestionId,
                        principalTable: "TargetQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSurveys_UserInfoId",
                table: "TargetSurveys",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TargetAnswerId",
                table: "AspNetUsers",
                column: "TargetAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_IsDeleted",
                table: "TargetAnswers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAnswers_TargetQuestionId",
                table: "TargetAnswers",
                column: "TargetQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TargetAnswers_TargetAnswerId",
                table: "AspNetUsers",
                column: "TargetAnswerId",
                principalTable: "TargetAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetSurveys_UserInfos_UserInfoId",
                table: "TargetSurveys",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers",
                column: "TargetAnswerId",
                principalTable: "TargetAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TargetAnswers_TargetAnswerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetSurveys_UserInfos_UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_TargetAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "TargetAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropIndex(
                name: "IX_TargetSurveys_UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TargetAnswerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetAnswerId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropColumn(
                name: "TargetAnswerId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetQuestionId1",
                table: "Answers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TargetQuestionId",
                table: "Answers",
                column: "TargetQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TargetQuestionId1",
                table: "Answers",
                column: "TargetQuestionId1");

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
        }
    }
}
