using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    MemberId = table.Column<int>(type: "integer", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Post = table.Column<string>(type: "text", nullable: false),
                    HeadingId = table.Column<int>(type: "integer", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HeadingName = table.Column<string>(type: "text", nullable: true),
                    HeadingContent = table.Column<string>(type: "text", nullable: true),
                    HeadingTag = table.Column<string>(type: "text", nullable: true),
                    HeadingViews = table.Column<int>(type: "integer", nullable: false),
                    MemberId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    ContentId = table.Column<int>(type: "integer", nullable: false),
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
                    { 1, true, "001", "C# | MVC | WEB API | BLAZOR", "https://okankaradag.com/wp-content/uploads/2021/06/asp.net-core-logo.png", ".Net Core", new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8290), null, null, null, null, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8290), true },
                    { 2, true, "002", "Angular JS | TypeScript | JavaScript | HTML | CSS", "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png", "Angular", new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8301), null, null, null, null, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8300), true },
                    { 3, true, "003", "SOLID | OOP | CLEAN CODE", "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552", "Nesneye Yönelimli Programlama", new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8309), null, null, null, null, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8308), true }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedTime", "DeleteTime", "Field0", "Field1", "Field2", "HeadingId", "LastModifyTime", "Post", "Status" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, null, "Ef Coreda İlişki kuramıyorum", true });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "Age", "Authority", "CreatedTime", "DeleteTime", "Dislike", "Email", "Field0", "Field1", "Field2", "Gender", "Image", "IsVerifiedEmail", "IsVerifiedInfo", "LastModifyTime", "Like", "Name", "Password", "Point", "Status", "Surname", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak t-soft e ticaret sistemleri bünyesinde çalışmaktayım. Net core ve angular üzerinde kendimi geliştiriyorum az düzeyde ingilizce biliyorum", (short)23, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7719), null, 14, "efekhvci@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7722), 8, "Mehmet Efe", "12345efe", 98, true, "Kahveci", "Software Engineer", "efekahveci" },
                    { 2, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında react js beckend tarafında ise.net ile çalışmalar yapıyorum.", (short)24, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7759), null, 1, "ysfckmk@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7760), 6, "Yusuf", "12345yusuf", 657, true, "Çakmak", "Student", "yusufcakmak" },
                    { 3, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında angular js beckend tarafında ise.net ile çalışmalar yapıyorum. Ayrıca yurtdışında çalışmak ilk tercihim olacaktır.", (short)24, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7769), null, 13, "remzican@hotmail.com", null, null, null, true, "Resim Yok", true, true, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(7769), 65, "Remzi Can", "12345remzi", 12, true, "Akmansoy", "Student", "akmansoy" }
                });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "ContentId", "CreatedTime", "DeleteTime", "Field0", "Field1", "Field2", "HeadingContent", "HeadingName", "HeadingTag", "HeadingViews", "LastModifyTime", "MemberId", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8033), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8033), 1, true },
                    { 2, 2, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8045), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8046), 1, true },
                    { 3, 3, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8054), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8054), 1, true },
                    { 4, 1, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8063), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8063), 2, true },
                    { 5, 2, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8072), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8072), 2, true },
                    { 6, 3, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8081), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8082), 2, true },
                    { 7, 1, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8090), null, null, null, null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8090), 3, true },
                    { 8, 2, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8130), null, null, null, null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8130), 3, true },
                    { 9, 3, 1, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8139), null, null, null, null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 20, 13, 59, 10, 703, DateTimeKind.Utc).AddTicks(8139), 3, true }
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
