using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class CorectEntityTargetSelectedAnswer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            

            

            

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TargetSelectedAnswers_IsDeleted",
                table: "TargetSelectedAnswers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TargetSelectedAnswers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "TargetSelectedAnswers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TargetSelectedAnswers");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TargetSelectedAnswers");

            migrationBuilder.CreateTable(
                name: "ImageForAnswers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageForAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageForAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageForQuestions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageForQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageForQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageForAnswers_AnswerId",
                table: "ImageForAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageForQuestions_QuestionId",
                table: "ImageForQuestions",
                column: "QuestionId",
                unique: true);
        }
    }
}
