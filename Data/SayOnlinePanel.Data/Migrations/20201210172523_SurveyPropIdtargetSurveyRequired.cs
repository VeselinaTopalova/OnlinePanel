using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class SurveyPropIdtargetSurveyRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TargetSurveyId",
                table: "Surveys",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TargetSurveyId",
                table: "Surveys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
