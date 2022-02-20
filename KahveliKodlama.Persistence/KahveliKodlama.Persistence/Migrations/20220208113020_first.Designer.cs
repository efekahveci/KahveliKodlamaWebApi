﻿// <auto-generated />
using System;
using KahveliKodlama.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KahveliKodlama.Persistence.Migrations
{
    [DbContext(typeof(KahveliContext))]
    [Migration("20220208113020_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("CategoryActive")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryClick")
                        .HasColumnType("integer");

                    b.Property<string>("CategoryCode")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryActive = true,
                            CategoryClick = 54,
                            CategoryCode = "001",
                            CategoryName = ".Net Core",
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3658),
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3658),
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryActive = true,
                            CategoryClick = 20,
                            CategoryCode = "002",
                            CategoryName = "Angular",
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3669),
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3668),
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryActive = true,
                            CategoryClick = 4,
                            CategoryCode = "003",
                            CategoryName = "Nesneye Yönelimli Programlama",
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3677),
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3676),
                            Status = true
                        });
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HeadingId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HeadingId = 1,
                            Post = "Ef Coreda İlişki kuramıyorum",
                            Status = true
                        });
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Heading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("ContentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HeadingContent")
                        .HasColumnType("text");

                    b.Property<string>("HeadingName")
                        .HasColumnType("text");

                    b.Property<string>("HeadingTag")
                        .HasColumnType("text");

                    b.Property<int>("HeadingViews")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MemberId");

                    b.ToTable("Headings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3416),
                            HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                            HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                            HeadingTag = "Visual Studio",
                            HeadingViews = 45,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3416),
                            MemberId = 1,
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3429),
                            HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                            HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                            HeadingTag = "Angular",
                            HeadingViews = 98,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3429),
                            MemberId = 1,
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3437),
                            HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                            HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                            HeadingTag = "c#",
                            HeadingViews = 90,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3437),
                            MemberId = 1,
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3497),
                            HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                            HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                            HeadingTag = "Visual Studio",
                            HeadingViews = 45,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3497),
                            MemberId = 2,
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3505),
                            HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                            HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                            HeadingTag = "Angular",
                            HeadingViews = 98,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3506),
                            MemberId = 2,
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3516),
                            HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                            HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                            HeadingTag = "c#",
                            HeadingViews = 90,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3517),
                            MemberId = 2,
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3523),
                            HeadingContent = "Yüklerken aniden yarıda kesiliyor ve hata alıyor nasıl çözülmesi gerekiyor bilen var mı ?",
                            HeadingName = "Visual Studio 2022 nasıl yükleniyor ?",
                            HeadingTag = "Visual Studio",
                            HeadingViews = 45,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3524),
                            MemberId = 3,
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3530),
                            HeadingContent = "Bana gelen bir json objesi var ve içinde sadece name alanını almak istiyorum ne yapmam gerekiyor.",
                            HeadingName = "Angular'da json içersinde tek bir alanı almak için ne yapmam gerekiyor?",
                            HeadingTag = "Angular",
                            HeadingViews = 98,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3531),
                            MemberId = 3,
                            Status = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            ContentId = 1,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3538),
                            HeadingContent = "switch case veya if kullanmanın performansa erkileri tam olarak nedir?",
                            HeadingName = "c# üzerinde if kullanmak mı daha performanslı yoksa switch case mi kullanmak daha avantajlıdır farkları nelerdir.",
                            HeadingTag = "c#",
                            HeadingViews = 90,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3538),
                            MemberId = 3,
                            Status = true
                        });
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Empty");

                    b.Property<short?>("Age")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)1);

                    b.Property<bool?>("Authority")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Dislike")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("Gender")
                        .HasColumnType("boolean");

                    b.Property<string>("Image")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasDefaultValue("Empty");

                    b.Property<bool>("IsVerifiedEmail")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVerifiedInfo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifyTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("Like")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("Point")
                        .HasColumnType("integer");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Empty");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak t-soft e ticaret sistemleri bünyesinde çalışmaktayım. Net core ve angular üzerinde kendimi geliştiriyorum az düzeyde ingilizce biliyorum",
                            Age = (short)23,
                            Authority = true,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3275),
                            Dislike = 14,
                            Email = "efekhvci@hotmail.com",
                            Gender = true,
                            Image = "Resim Yok",
                            IsVerifiedEmail = true,
                            IsVerifiedInfo = true,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3276),
                            Like = 8,
                            Name = "Mehmet Efe",
                            Password = "12345efe",
                            Point = 98,
                            Status = true,
                            Surname = "Kahveci",
                            Title = "Software Engineer",
                            UserName = "efekahveci"
                        },
                        new
                        {
                            Id = 2,
                            About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında react js beckend tarafında ise.net ile çalışmalar yapıyorum.",
                            Age = (short)24,
                            Authority = true,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3301),
                            Dislike = 1,
                            Email = "ysfckmk@hotmail.com",
                            Gender = true,
                            Image = "Resim Yok",
                            IsVerifiedEmail = true,
                            IsVerifiedInfo = true,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3301),
                            Like = 6,
                            Name = "Yusuf",
                            Password = "12345yusuf",
                            Point = 657,
                            Status = true,
                            Surname = "Çakmak",
                            Title = "Student",
                            UserName = "yusufcakmak"
                        },
                        new
                        {
                            Id = 3,
                            About = "Konya Teknik Üniversitesi Bilgisayar Mühendisliğinden Mezunum Aktif olarak iş arayaşım devam etmektedir fronted tarafında angular js beckend tarafında ise.net ile çalışmalar yapıyorum. Ayrıca yurtdışında çalışmak ilk tercihim olacaktır.",
                            Age = (short)24,
                            Authority = true,
                            CreatedTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3309),
                            Dislike = 13,
                            Email = "remzican@hotmail.com",
                            Gender = true,
                            Image = "Resim Yok",
                            IsVerifiedEmail = true,
                            IsVerifiedInfo = true,
                            LastModifyTime = new DateTime(2022, 2, 8, 11, 30, 20, 222, DateTimeKind.Utc).AddTicks(3310),
                            Like = 65,
                            Name = "Remzi Can",
                            Password = "12345remzi",
                            Point = 12,
                            Status = true,
                            Surname = "Akmansoy",
                            Title = "Student",
                            UserName = "akmansoy"
                        });
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Heading", b =>
                {
                    b.HasOne("KahveliKodlama.Domain.Entities.Category", null)
                        .WithMany("Headings")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KahveliKodlama.Domain.Entities.Member", null)
                        .WithMany("Headings")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Category", b =>
                {
                    b.Navigation("Headings");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Member", b =>
                {
                    b.Navigation("Headings");
                });
#pragma warning restore 612, 618
        }
    }
}