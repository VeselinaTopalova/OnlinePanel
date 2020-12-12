using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class surveyUserInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_UserInfos_UserInfoId",
                table: "Surveys");

            migrationBuilder.DropForeignKey(
                name: "FK_TargetSurveys_UserInfos_UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropIndex(
                name: "IX_TargetSurveys_UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_UserInfoId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "TargetSurveys");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "Surveys");

            migrationBuilder.CreateTable(
                name: "SurveyUserInfos",
                columns: table => new
                {
                    SurveyId = table.Column<int>(nullable: false),
                    UserInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUserInfos", x => new { x.SurveyId, x.UserInfoId });
                    table.ForeignKey(
                        name: "FK_SurveyUserInfos_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyUserInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TargetSyrveyUserInfos",
                columns: table => new
                {
                    TargetSurveyId = table.Column<int>(nullable: false),
                    UserInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetSyrveyUserInfos", x => new { x.TargetSurveyId, x.UserInfoId });
                    table.ForeignKey(
                        name: "FK_TargetSyrveyUserInfos_TargetSurveys_TargetSurveyId",
                        column: x => x.TargetSurveyId,
                        principalTable: "TargetSurveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetSyrveyUserInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUserInfos_UserInfoId",
                table: "SurveyUserInfos",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetSyrveyUserInfos_UserInfoId",
                table: "TargetSyrveyUserInfos",
                column: "UserInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyUserInfos");

            migrationBuilder.DropTable(
                name: "TargetSyrveyUserInfos");

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "TargetSurveys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "Surveys",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TargetSurveys_UserInfoId",
                table: "TargetSurveys",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_UserInfoId",
                table: "Surveys",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_UserInfos_UserInfoId",
                table: "Surveys",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TargetSurveys_UserInfos_UserInfoId",
                table: "TargetSurveys",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
