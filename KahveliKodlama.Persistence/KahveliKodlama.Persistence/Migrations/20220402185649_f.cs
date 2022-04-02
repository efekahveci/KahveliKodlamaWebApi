using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KahveliKodlama.Persistence.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryName = table.Column<string>(type: "text", nullable: true),
                    CategoryDesc = table.Column<string>(type: "text", nullable: true),
                    CategoryImage = table.Column<string>(type: "text", nullable: true),
                    CategoryActive = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryCode = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContentImage1url = table.Column<string>(type: "text", nullable: true),
                    Content1 = table.Column<string>(type: "text", nullable: true),
                    ContentHeading2 = table.Column<string>(type: "text", nullable: true),
                    Content2 = table.Column<string>(type: "text", nullable: true),
                    CodeBlock1 = table.Column<string>(type: "text", nullable: true),
                    ContentHeading3 = table.Column<string>(type: "text", nullable: true),
                    Content3 = table.Column<string>(type: "text", nullable: true),
                    HeadingId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    eMail = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<bool>(type: "boolean", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<short>(type: "smallint", nullable: true, defaultValue: (short)1),
                    Image = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, defaultValue: "Empty"),
                    About = table.Column<string>(type: "text", nullable: true, defaultValue: "Empty"),
                    Title = table.Column<string>(type: "text", nullable: true, defaultValue: "Empty"),
                    Authority = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    Like = table.Column<int>(type: "integer", nullable: false),
                    Dislike = table.Column<int>(type: "integer", nullable: false),
                    Point = table.Column<int>(type: "integer", nullable: false),
                    IsVerifiedEmail = table.Column<bool>(type: "boolean", nullable: false),
                    IsVerifiedInfo = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "now()"),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HeadingName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    HeadingContent = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    HeadingImage = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    HeadingTag = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    HeadingViews = table.Column<short>(type: "smallint", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Field2 = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
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
                table: "Categories",
                columns: new[] { "Id", "CategoryActive", "CategoryCode", "CategoryDesc", "CategoryImage", "CategoryName", "CreatedTime", "DeleteTime", "Field1", "Field2", "LastModifyTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"), true, "001", "C# | MVC | WEB API | BLAZOR", "https://okankaradag.com/wp-content/uploads/2021/06/asp.net-core-logo.png", ".Net Core", new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6561), null, null, null, new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6557), true },
                    { new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"), true, "002", "Angular JS | TypeScript | JavaScript | HTML | CSS", "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png", "Angular", new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6589), null, null, null, new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6589), true },
                    { new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"), true, "003", "SOLID | OOP | CLEAN CODE", "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552", "Nesneye Yönelimli Programlama", new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6631), null, null, null, new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6631), true },
                    { new Guid("d5d89327-8e72-4c06-bea3-bc47ebcd05a7"), true, "004", "ARCHITECTURE | DESIGN PATTERN", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhkxtBPjz_cFRYFHzR6XmfCIVFPEAZwpOlaA&usqp=CAU", "Software Engineering", new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6641), null, null, null, new DateTime(2022, 4, 2, 18, 56, 49, 342, DateTimeKind.Utc).AddTicks(6641), true }
                });

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
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Headings");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
