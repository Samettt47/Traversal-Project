using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_comment_appuser_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppuserId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppuserId",
                table: "Comments",
                column: "AppuserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppuserId",
                table: "Comments",
                column: "AppuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppuserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AppuserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AppuserId",
                table: "Comments");
        }
    }
}
