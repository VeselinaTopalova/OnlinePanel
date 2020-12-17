using Microsoft.EntityFrameworkCore.Migrations;

namespace SayOnlinePanel.Data.Migrations
{
    public partial class VoucherUserCorect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VoucherUsers_AspNetUsers_UserId",
                table: "VoucherUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId",
                table: "VoucherUsers");

            migrationBuilder.DropIndex(
                name: "IX_VoucherUsers_UserId",
                table: "VoucherUsers");

            migrationBuilder.DropIndex(
                name: "IX_VoucherUsers_UserInfoId",
                table: "VoucherUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "VoucherUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserInfoId",
                table: "VoucherUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserInfoId1",
                table: "VoucherUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "VoucherUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUsers_UserId",
                table: "VoucherUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUsers_UserInfoId",
                table: "VoucherUsers",
                column: "UserInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherUsers_AspNetUsers_UserId",
                table: "VoucherUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherUsers_UserInfos_UserInfoId",
                table: "VoucherUsers",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
