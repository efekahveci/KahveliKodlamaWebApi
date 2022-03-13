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
                    Field0 = table.Column<string>(type: "text", nullable: true),
                    Field1 = table.Column<string>(type: "text", nullable: true),
                    Field2 = table.Column<string>(type: "text", nullable: true)
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
                    Title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field0 = table.Column<string>(type: "text", nullable: true),
                    Field1 = table.Column<string>(type: "text", nullable: true),
                    Field2 = table.Column<string>(type: "text", nullable: true)
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
                    Post = table.Column<string>(type: "text", nullable: false),
                    HeadingId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field0 = table.Column<string>(type: "text", nullable: true),
                    Field1 = table.Column<string>(type: "text", nullable: true),
                    Field2 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
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
                    Field0 = table.Column<string>(type: "text", nullable: true),
                    Field1 = table.Column<string>(type: "text", nullable: true),
                    Field2 = table.Column<string>(type: "text", nullable: true)
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
                    HeadingName = table.Column<string>(type: "text", nullable: true),
                    HeadingContent = table.Column<string>(type: "text", nullable: true),
                    HeadingTag = table.Column<string>(type: "text", nullable: true),
                    HeadingViews = table.Column<int>(type: "integer", nullable: false),
                    MemberId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ContentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Field0 = table.Column<string>(type: "text", nullable: true),
                    Field1 = table.Column<string>(type: "text", nullable: true),
                    Field2 = table.Column<string>(type: "text", nullable: true)
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
                columns: new[] { "Id", "CategoryActive", "CategoryCode", "CategoryDesc", "CategoryImage", "CategoryName", "CreatedTime", "DeleteTime", "Field0", "Field1", "Field2", "LastModifyTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"), true, "001", "C# | MVC | WEB API | BLAZOR", "https://okankaradag.com/wp-content/uploads/2021/06/asp.net-core-logo.png", ".Net Core", new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(418), null, null, null, null, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(417), true },
                    { new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"), true, "002", "Angular JS | TypeScript | JavaScript | HTML | CSS", "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png", "Angular", new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(428), null, null, null, null, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(427), true },
                    { new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"), true, "003", "SOLID | OOP | CLEAN CODE", "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552", "Nesneye Yönelimli Programlama", new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(435), null, null, null, null, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(434), true }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedTime", "DeleteTime", "Field0", "Field1", "Field2", "HeadingId", "LastModifyTime", "Post", "Status" },
                values: new object[] { new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new Guid("4ebf1452-3bdc-4618-a25a-c31575c89074"), null, "Ef Coreda İlişki kuramıyorum", true });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "Age", "Authority", "CreatedTime", "DeleteTime", "Dislike", "Email", "Field0", "Field1", "Field2", "Gender", "Image", "IsVerifiedEmail", "IsVerifiedInfo", "LastModifyTime", "Like", "Name", "Password", "Point", "Status", "Surname", "Title", "UserName" },
                values: new object[,]
                {
                    { new Guid("4ebf1452-3bdc-1618-a25a-c31575c89074"), "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak t-soft e ticaret sistemleri bünyesinde çalışmaktayım. Net core ve angular üzerinde kendimi geliştiriyorum az düzeyde ingilizce biliyorum", (short)23, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(62), null, 14, "efekhvci@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(63), 8, "Mehmet Efe", "12345efe", 98, true, "Kahveci", "Software Engineer", "efekahveci" },
                    { new Guid("4ebf1452-3bdc-2618-a25a-c31575c89074"), "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında react js beckend tarafında ise.net ile çalışmalar yapıyorum.", (short)24, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(91), null, 1, "ysfckmk@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(91), 6, "Yusuf", "12345yusuf", 657, true, "Çakmak", "Student", "yusufcakmak" },
                    { new Guid("4ebf1452-3bdc-3618-a25a-c31575c89074"), "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında angular js beckend tarafında ise.net ile çalışmalar yapıyorum. Ayrıca yurtdışında çalışmak ilk tercihim olacaktır.", (short)24, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(101), null, 13, "remzican@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(101), 65, "Remzi Can", "12345remzi", 12, true, "Akmansoy", "Student", "akmansoy" }
                });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "ContentId", "CreatedTime", "DeleteTime", "Field0", "Field1", "Field2", "HeadingContent", "HeadingName", "HeadingTag", "HeadingViews", "LastModifyTime", "MemberId", "Status" },
                values: new object[,]
                {
                    { new Guid("4ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(200), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(200), new Guid("4ebf1452-3bdc-3618-a25a-c31575c89074"), true },
                    { new Guid("5ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(213), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(213), new Guid("4ebf1452-3bdc-3618-a25a-c31575c89074"), true },
                    { new Guid("6ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(222), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(222), new Guid("4ebf1452-3bdc-3618-a25a-c31575c89074"), true },
                    { new Guid("7ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(231), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(232), new Guid("4ebf1452-3bdc-1618-a25a-c31575c89074"), true },
                    { new Guid("8ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(266), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(266), new Guid("4ebf1452-3bdc-1618-a25a-c31575c89074"), true },
                    { new Guid("9ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(277), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(278), new Guid("4ebf1452-3bdc-1618-a25a-c31575c89074"), true },
                    { new Guid("aebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(286), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(286), new Guid("4ebf1452-3bdc-2618-a25a-c31575c89074"), true },
                    { new Guid("bebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(295), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(295), new Guid("4ebf1452-3bdc-2618-a25a-c31575c89074"), true },
                    { new Guid("cebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"), new Guid("4ebf1452-3bdc-2618-225a-c31575c89074"), new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(304), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 3, 9, 6, 47, 40, 357, DateTimeKind.Utc).AddTicks(304), new Guid("4ebf1452-3bdc-2618-a25a-c31575c89074"), true }
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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
