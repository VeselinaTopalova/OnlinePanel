using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class VoucherUserCorect2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId1",
                table: "VoucherUsers");

            migrationBuilder.DropIndex(
                name: "IX_VoucherUsers_UserInfoId1",
                table: "VoucherUsers");

            migrationBuilder.DropColumn(
                name: "UserInfoId1",
                table: "VoucherUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserInfoId",
                table: "VoucherUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUsers_UserInfoId",
                table: "VoucherUsers",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId",
                table: "VoucherUsers",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId",
                table: "VoucherUsers");

            migrationBuilder.DropIndex(
                name: "IX_VoucherUsers_UserInfoId",
                table: "VoucherUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserInfoId",
                table: "VoucherUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId1",
                table: "VoucherUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUsers_UserInfoId1",
                table: "VoucherUsers",
                column: "UserInfoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId1",
                table: "VoucherUsers",
                column: "UserInfoId1",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
