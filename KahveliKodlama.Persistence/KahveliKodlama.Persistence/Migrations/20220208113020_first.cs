using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KahveliKodlama.Persistence.Migrations
{
    public partial class first : Migration
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
                    CategoryActive = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryClick = table.Column<int>(type: "integer", nullable: false),
                    CategoryCode = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifyTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    DeleteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                columns: new[] { "Id", "CategoryActive", "CategoryClick", "CategoryCode", "CategoryName", "CreatedTime", "DeleteTime", "LastModifyTime", "Status" },
                values: new object[,]
                {
                    { 1, true, 54, "001", ".Net Core", new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3658), null, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3658), true },
                    { 2, true, 20, "002", "Angular", new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3669), null, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3668), true },
                    { 3, true, 4, "003", "Nesneye Yönelimli Programlama", new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3677), null, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3676), true }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedTime", "DeleteTime", "HeadingId", "LastModifyTime", "Post", "Status" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, "Ef Coreda İlişki kuramıyorum", true });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "Age", "Authority", "CreatedTime", "DeleteTime", "Dislike", "Email", "Gender", "Image", "IsVerifiedEmail", "IsVerifiedInfo", "LastModifyTime", "Like", "Name", "Password", "Point", "Status", "Surname", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak t-soft e ticaret sistemleri bünyesinde çalışmaktayım. Net core ve angular üzerinde kendimi geliştiriyorum az düzeyde ingilizce biliyorum", (short)23, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3275), null, 14, "efekhvci@hotmail.com", true, "Resim Yok", true, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3276), 8, "Mehmet Efe", "12345efe", 98, true, "Kahveci", "Software Engineer", "efekahveci" },
                    { 2, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında react js beckend tarafında ise.net ile çalışmalar yapıyorum.", (short)24, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3301), null, 1, "ysfckmk@hotmail.com", true, "Resim Yok", true, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3301), 6, "Yusuf", "12345yusuf", 657, true, "Çakmak", "Student", "yusufcakmak" },
                    { 3, "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında angular js beckend tarafında ise.net ile çalışmalar yapıyorum. Ayrıca yurtdışında çalışmak ilk tercihim olacaktır.", (short)24, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3309), null, 13, "remzican@hotmail.com", true, "Resim Yok", true, true, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3310), 65, "Remzi Can", "12345remzi", 12, true, "Akmansoy", "Student", "akmansoy" }
                });

            migrationBuilder.InsertData(
                table: "Headings",
                columns: new[] { "Id", "CategoryId", "ContentId", "CreatedTime", "DeleteTime", "HeadingContent", "HeadingName", "HeadingTag", "HeadingViews", "LastModifyTime", "MemberId", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3416), null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3416), 1, true },
                    { 2, 2, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3429), null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3429), 1, true },
                    { 3, 3, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3437), null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3437), 1, true },
                    { 4, 1, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3497), null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3497), 2, true },
                    { 5, 2, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3505), null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3506), 2, true },
                    { 6, 3, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3516), null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3517), 2, true },
                    { 7, 1, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3523), null, "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?", "Visual Studio 2022 nasıl yükleniyor ?", "Visual Studio", 45, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3524), 3, true },
                    { 8, 2, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3530), null, "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.", "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?", "Angular", 98, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3531), 3, true },
                    { 9, 3, 1, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3538), null, "switch case veya if kullanmanın performansa erkileri tam olarak nedir?", "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.", "c#", 90, new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3538), 3, true }
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
