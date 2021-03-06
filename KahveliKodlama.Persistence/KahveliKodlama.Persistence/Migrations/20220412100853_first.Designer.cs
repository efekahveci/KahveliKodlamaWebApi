// <auto-generated />
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
    [Migration("20220412100853_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("CategoryActive")
                        .HasColumnType("boolean");

                    b.Property<string>("CategoryCode")
                        .HasColumnType("text");

                    b.Property<string>("CategoryDesc")
                        .HasColumnType("text");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ebf1452-3bdc-4618-a25a-c31575c89074"),
                            CategoryActive = true,
                            CategoryCode = "001",
                            CategoryDesc = "C# | MVC | WEB API | BLAZOR",
                            CategoryImage = "https://okankaradag.com/wp-content/uploads/2021/06/asp.net-core-logo.png",
                            CategoryName = ".Net Core",
                            CreatedTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9928),
                            LastModifyTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9925),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("2ebf1452-3bdc-4618-a25a-c31575c89074"),
                            CategoryActive = true,
                            CategoryCode = "002",
                            CategoryDesc = "Angular JS | TypeScript | JavaScript | HTML | CSS",
                            CategoryImage = "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/c/cf/Angular_full_color_logo.svg/1200px-Angular_full_color_logo.svg.png",
                            CategoryName = "Angular",
                            CreatedTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9951),
                            LastModifyTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9951),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("3ebf1452-3bdc-4618-a25a-c31575c89074"),
                            CategoryActive = true,
                            CategoryCode = "003",
                            CategoryDesc = "SOLID | OOP | CLEAN CODE",
                            CategoryImage = "https://www.educative.io/v2api/editorpage/4792707659595776/image/5909454286487552",
                            CategoryName = "Nesneye Yönelimli Programlama",
                            CreatedTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9960),
                            LastModifyTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9960),
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("d5d89327-8e72-4c06-bea3-bc47ebcd05a7"),
                            CategoryActive = true,
                            CategoryCode = "004",
                            CategoryDesc = "ARCHITECTURE | DESIGN PATTERN",
                            CategoryImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQhkxtBPjz_cFRYFHzR6XmfCIVFPEAZwpOlaA&usqp=CAU",
                            CategoryName = "Software Engineering",
                            CreatedTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9967),
                            LastModifyTime = new DateTime(2022, 4, 12, 10, 8, 53, 724, DateTimeKind.Utc).AddTicks(9967),
                            Status = true
                        });
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodeBlock1")
                        .HasColumnType("text");

                    b.Property<string>("Content1")
                        .HasColumnType("text");

                    b.Property<string>("Content2")
                        .HasColumnType("text");

                    b.Property<string>("Content3")
                        .HasColumnType("text");

                    b.Property<string>("ContentHeading2")
                        .HasColumnType("text");

                    b.Property<string>("ContentHeading3")
                        .HasColumnType("text");

                    b.Property<string>("ContentImage1url")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid>("HeadingId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Heading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("HeadingContent")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("HeadingImage")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("HeadingName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("HeadingTag")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<short>("HeadingViews")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MemberId");

                    b.ToTable("Headings");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Mail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("eMail")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mails");
                });

            modelBuilder.Entity("KahveliKodlama.Domain.Entities.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

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

                    b.Property<string>("Field1")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Field2")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

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
