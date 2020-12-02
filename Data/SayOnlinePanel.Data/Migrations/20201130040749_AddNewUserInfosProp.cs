using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class AddNewUserInfosProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "UserInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "UserAnswers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId",
                table: "Surveys",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_UserInfos_UserInfoId",
                table: "Surveys");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_UserInfoId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "UserInfoId",
                table: "Surveys");

            migrationBuilder.AlterColumn<int>(
                name: "SurveyId",
                table: "UserAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
