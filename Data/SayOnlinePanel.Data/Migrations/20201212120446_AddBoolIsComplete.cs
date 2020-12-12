using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class AddBoolIsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isComplete",
                table: "SurveyUserInfos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isComplete",
                table: "SurveyUserInfos");
        }
    }
}
