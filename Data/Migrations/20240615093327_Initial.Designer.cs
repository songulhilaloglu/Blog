﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240615093327_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Etiam sit amet nisl purus in mollis nunc. Facilisi nullam vehicula ipsum a arcu cursus vitae congue mauris. Lacus sed turpis tincidunt id aliquet risus feugiat in. Tortor id aliquet lectus proin nibh nisl condimentum. Mollis aliquam ut porttitor leo. Dis parturient montes nascetur ridiculus. Bibendum enim facilisis gravida neque convallis a cras semper auctor. Turpis egestas maecenas pharetra convallis posuere morbi leo urna molestie. Ut eu sem integer vitae justo. Ut morbi tincidunt augue interdum velit. Ut porttitor leo a diam sollicitudin tempor id eu. Pellentesque dignissim enim sit amet venenatis urna cursus eget.",
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(2954),
                            IsDeleted = false,
                            Title = "Songül Hilaloğlu"
                        });
                });

            modelBuilder.Entity("Entity.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "ef8b1c99-5685-43ef-a2c2-0652123a58fe",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "767fdc74-cca2-45c4-88cf-1d0e44b8d624",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "9f3cd10c-d4fb-46fe-8844-a4dec1a8e312",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5a71885-9861-4f67-afc0-51391ced80d8",
                            Email = "superadmin@hotmail.com",
                            EmailConfirmed = true,
                            FirstName = "Songül",
                            ImageId = 1,
                            LastName = "Hilaloğlu",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@HOTMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECNDBsQ68rc5hXyFGft1vXySe0mLSRnFxGME7xlSDJWr3Lp8YrPiUCY5HCis3Ys38w==",
                            PhoneNumber = "+905335028317",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "46468ba5-c7e1-4e76-9419-81b2a5de5a9d",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@hotmail.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a955270-7ce4-4a79-bee1-25c3bac1a6d6",
                            Email = "admin@hotmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = 1,
                            LastName = "Kullanıcısı",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HOTMAIL.COM",
                            NormalizedUserName = "ADMIN@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM5mssPt3zvvrFQrD2zkC+MRnoNMmwHN1ZxfUEcIuf9ZjjpQ3r4ULK4utlQ/DAWvqg==",
                            PhoneNumber = "+905335028310",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54a5264d-47c0-411b-bda8-bce8e6eb0ec1",
                            TwoFactorEnabled = false,
                            UserName = "admin@hotmail.com"
                        });
                });

            modelBuilder.Entity("Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("Entity.Entities.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entity.Entities.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Banners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3274),
                            Description = "LOREM IPSUM IS SIMPLY DUMMY TEXT OF THE PRINTING AND TYPESETTING\r\nINDUSTRY. LOREM IPSUM HAS BEEN THE INDUSTRY'S STANDARD DUMMY TEXT\r\nEVER SINCE THE 1500S,",
                            ImageId = 1,
                            IsDeleted = false,
                            Subtitle = "Working Tirlessly\r\nToward Successful Resolutions",
                            Title = "Dermatoloji Uzmanı :"
                        });
                });

            modelBuilder.Entity("Entity.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "Dolgu ve botox ile burun şekillendirme işlemi (benim verdiğim isimle) Likit Rhinoplasti‘nin temelde üç ana hedef kitlesi vardır;\r\n\r\nBurun operasyonu için yaşı çok genç olan kişiler,\r\nBurunlarında beğenmedikleri, şikayetçi oldukları şey için ameliyat olmaya gerek duymayanlar veya operasyondan çekinenler,\r\nBir ya da birkaç kere burun operasyonu geçirmiş olup, yeni bir operasyon istenmeyenler.\r\nBurun; son derece sinirli ve ince bir damarsal ağ yapısına sahiptir. Özellikle arterlerin oldukça farklı varyasyonları göz önüne alınırsa, bu bölgede yapılacak işlemlerde anatomiye çok hakim olmak ve oldukça dikkatli ve tedbirli davranmak önemlidir.\r\n\r\nİşte, yüzlerce burun operasyonu yapmış bir plastik cerrah olmanın avantajı tam olarak burada ortaya çıkıyor.",
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3556),
                            ImageId = 1,
                            IsDeleted = false,
                            Title = "Likit Rhinoplasti (Burun Dolgusu) Tehlikeli Mi?",
                            UserId = 1,
                            ViewCount = 15
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = "Dudak küçük bir anatomik yapı olmasına rağmen yüzün merkezinde bulunması ve duygu durumunu anlık olarak yansıtan tüm mimiklere katılması nedeniyle büyük öneme sahiptir. Dudak dolgusu tahmin edildiği kadar basit ve hızlı bir işlem değildir. Bunun başlıca iki sebebi var;\r\n\r\nDinamik bir organ olması,\r\nÇok dar ve sınırlı bir hacme sahip olması,\r\nYapılan dolgu materyalinin tamamen dokuya entegre olmasını beklemek ve bunu göz önüne alarak birkaç seans şeklinde işlemi sürdürmek gerekir.\r\n\r\nDolayısıyla dudakların alacağı hacim ve kalınlaşma aslında dolguyu yerleştireceğiniz cebi sabırla genişletmek, sonrasında belli olacaktır. Her dudak “istenildiği” ya da “beklenildiği” kadar kalınlaşmaz. Dudak dolgusunu tek seansta ve yüksek dozda uygulamaya çalışmak bu dinamik ve hassas bölgenin bütün dinamiğini geri dönüşümsüz olarak bozar.\r\nSonuç olarak dudak dolgusu zannedildiği kadar kolay, hızlı ve sonuçları memnun edici bir işlem değildir, hatta tecrübesiz ellerde çok büyük hayal kırıklığına sebep olabilir.",
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3560),
                            ImageId = 1,
                            IsDeleted = false,
                            Title = "Dudaklarınız Dolgu İçin Uygun Mu?",
                            UserId = 1,
                            ViewCount = 10
                        });
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3737),
                            IsDeleted = false,
                            Name = "Kategori1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3741),
                            IsDeleted = false,
                            Name = "Kategori2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3743),
                            IsDeleted = false,
                            Name = "Kategori3"
                        });
                });

            modelBuilder.Entity("Entity.Entities.ContactMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactMessages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(3920),
                            Email = "songulhilaloglu@hotmail.com",
                            FullName = "Songül Hilaloğlu",
                            IsDeleted = false,
                            Message = "Test mesajıdır, bize ulaşın sayfasındaki mesajlar bu alana yansıyacaktır..",
                            PhoneNumber = "+905335028317"
                        });
                });

            modelBuilder.Entity("Entity.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Songül Hilaloğlu",
                            CreatedDate = new DateTime(2024, 6, 15, 12, 33, 27, 301, DateTimeKind.Local).AddTicks(4089),
                            FileName = "images/testimage1",
                            FileType = "jpg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.AppUser", b =>
                {
                    b.HasOne("Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Banner", b =>
                {
                    b.HasOne("Entity.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Entity.Entities.Blog", b =>
                {
                    b.HasOne("Entity.Entities.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Entities.Image", "Image")
                        .WithMany("Blogs")
                        .HasForeignKey("ImageId");

                    b.HasOne("Entity.Entities.AppUser", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("Entity.Entities.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("Entity.Entities.Image", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
