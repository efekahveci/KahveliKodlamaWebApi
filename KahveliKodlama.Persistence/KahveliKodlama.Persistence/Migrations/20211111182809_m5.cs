using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KahveliKodlama.Persistence.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CategoryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifyTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Age = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)1),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValue: "Empty"),
                    About = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValue: "Empty"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValue: "Empty"),
                    Authority = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    LastModifyTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifyTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Headings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HeadingContent = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HeadingTag = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    HeadingViews = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifyTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headings_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Headings_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CategoryType", "CreatedTime", "DeleteTime", "LastModifyTime", "Status" },
                values: new object[] { 1, "Nesneye Yönelimli Programalama", "OOP", null, null, null, false });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "Age", "Authority", "DeleteTime", "Email", "Name", "Password", "Status", "Surname", "Title", "UserName" },
                values: new object[] { 1, "Konya Teknik Üniversitesi Bilgisayar Mühendisliği", (short)23, true, null, "efekhvci@hotmail.com", "Mehmet Efe", "12345", true, "Kahveci", "Developer", "efekhvci" });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "CreatedTime", "DeleteTime", "HeadingContent", "HeadingName", "HeadingTag", "HeadingViews", "LastModifyTime", "MemberId", "Status" },
                values: new object[] { 1, 1, null, null, "WEB AP", ".NET CORE", "Kahveci", 99, null, 1, false });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MemberId",
                table: "Contacts",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Headings_CategoryId",
                table: "Headings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Headings_MemberId",
                table: "Headings",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Headings");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
