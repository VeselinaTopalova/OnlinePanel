using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class RemovePropPointStartfromTargetSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointsStart",
                table: "TargetSurveys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PointsStart",
                table: "TargetSurveys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
