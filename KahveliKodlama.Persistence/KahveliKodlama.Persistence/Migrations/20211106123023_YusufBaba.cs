using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveliKodlama.Persistence.Migrations
{
    public partial class YusufBaba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MemberId",
                table: "Contacts",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Members_MemberId",
                table: "Contacts",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Members_MemberId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MemberId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Contacts");
        }
    }
}
