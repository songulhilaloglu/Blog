using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banners_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogVisitors",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogVisitors", x => new { x.BlogId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_BlogVisitors_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title" },
                values: new object[] { 1, "Melda ÖZKARA Hukuk & Danışmanlık olarak, hukukun çeşitli alanlarında hizmet vermektedir. Kurucumuz Avukat Melda ÖZKARA ile hukuk alanındaki akademik ve profesyonel temellerimizi atmış bulunmaktayız. Ceza hukuku, idare hukuku, sigorta hukuku, aile hukuku ve miras hukuku olmak üzere geniş bir yelpazede hizmet sunuyoruz. Ankara, İzmir, Denizli, Balıkesir, Van, Eskişehir, İstanbul gibi Türkiyenin değişik birçok illerinde çeşitli dosyalarda çalışmakta, davalarda avukatlık hizmeti verilmektedir. \r\n\r\nMisyonumuz, müvekkillerimizin hukuki süreçlerde karşılaştıkları zorluklar karşısında güvenilir ve etkin çözümler üretmek, onların haklarını en üst düzeyde temsil etmektir. Adaletin temsil edildiği her alanda, müvekkillerimizin yanında olmayı ilke edinmiş bir hukuk bürosuyuz. Her bir dava ve müvekkilimizle özel olarak ilgilenir, onların ihtiyaç ve beklentilerine göre şekillenen hukuki stratejiler geliştiririz.\r\n\r\nVizyonumuz, hukukun sunduğu imkanları en doğru ve etkili şekilde kullanarak müvekkillerimizin yaşam kalitesini artırmak ve hukuki süreçlerini olabildiğince sorunsuz bir şekilde yönetmektir. Melda ÖZKARA Hukuk & Danışmanlık olarak, sürekli eğitim ve gelişim içinde olan bir ekip olarak, yasal mevzuatlardaki güncellemeleri takip eder, bu bilgiler ışığında müvekkillerimize en güncel ve doğru bilgiyi sunmayı hedefleriz.\r\n\r\nHukuk büromuz, etik değerlere sıkı sıkıya bağlı kalarak, her zaman şeffaflık ve dürüstlük ilkeleri üzerine kurulu bir hizmet anlayışı benimsemiştir. Melda ÖZKARA Hukuk & Danışmanlık, sizin ve sevdiklerinizin haklarını koruyacak, adaletli çözümler sunacak güvenilir bir ortağınızdır.", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(3457), null, null, false, null, null, "Avukat Melda Özkara" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "961e80cb-b38b-48b4-8bda-0a6aaab0d018", "Superadmin", "SUPERADMIN" },
                    { 2, "fc9c6ff7-2ec9-4c2f-a5c1-9caba3493530", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "4efb9d16-3232-40cd-a742-a470df2db86a", "superadmin@hotmail.com", true, "Songül", null, "Hilaloğlu", false, null, "SUPERADMIN@HOTMAIL.COM", "SUPERADMIN@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBHA5qKnIa5nimn2t2+YQp2HUtaGfqE5i582Cf0GTSnhLg3KdOSfHm8JjQImGpqDXQ==", "+905335028317", true, "92894cab-1660-4b1b-a87f-97afbe0e9edb", false, "superadmin@hotmail.com" },
                    { 2, 0, "63427c5a-b739-4ffe-a79e-0a0edd066075", "admin@hotmail.com", false, "Admin", null, "Kullanıcısı", false, null, "ADMIN@HOTMAIL.COM", "ADMIN@HOTMAIL.COM", "AQAAAAEAACcQAAAAEHXPVpLog50SeGdxe/bKQ06NimyhF1enyxzpjLernsH5yG5lfFQ0dj5t5OikOPNK0g==", "+905335028310", false, "049ba840-f3f1-492a-8249-4858f662811d", false, "admin@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(9413), null, null, false, null, null, "Ceza Davaları" },
                    { 2, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(9421), null, null, false, null, null, "Boşanma ve Nafaka Davaları" },
                    { 3, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(9426), null, null, false, null, null, "Trafik Kazalarına Bağlı Maddi ve Manevi Tazminatlar" },
                    { 4, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(9431), null, null, false, null, null, "İş Davaları" }
                });

            migrationBuilder.InsertData(
                table: "ContactMessages",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "FullName", "IsDeleted", "Message", "ModifiedBy", "ModifiedDate", "PhoneNumber" },
                values: new object[] { 1, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(9870), null, null, "songulhilaloglu@hotmail.com", "Songül Hilaloğlu", false, "Test mesajıdır, bize ulaşın sayfasındaki mesajlar bu alana yansıyacaktır..", null, null, "+905335028317" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 1, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 196, DateTimeKind.Local).AddTicks(587), null, null, "blog-images/default.jpg", "jpg", false, null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Subtitle", "Title" },
                values: new object[] { 1, "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4359), null, null, "Ayrıca müvekkillerimize eksiksiz hizmet verebilmek için alanında uzman çeşitli akademisyenler ve mali müşavirlerle de yakın iş birliği içerisindeyiz.", 1, false, null, null, "Müvekkillerimize en iyi hukuk hizmetini \r\n güvenilir ve hızlı bir şekilde sunmaktayız.", "Hoşgeldiniz " });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, "5271 sayılı Ceza Muhakemesi Kanunu m.109/1, m.100/1 hükümlerine göre, tutuklama ve adli kontrol tedbirleri aynı koşullara bağlı kılınmıştır. Dolayısıyla; bir şüpheli veya sanık hakkında tutuklama kararı verilebilmesi veya kişinin adli kontrol altına alınabilmesi için, kuvvetli suç şüphesini gösteren somut deliller ve en az bir tutuklama nedeni mutlaka bulunmalıdır. Bu tedbirlerin uygulanabilmesi için gerekli olan bir diğer koşul ölçülülüktür.\r\n\r\n \r\n\r\n Adli kontrol tedbirlerinin uygulanabilmesi için, kuvvetli suç şüphesini gösteren somut delillerin bulunması Kanundan kaynaklanan bir zorunluluktur. AYM; bir kararında, konutu terk etmeme yükümlülüğüne tabi tutulması nedeniyle kişi hürriyeti ve güvenliği hakkının ihlal edildiğine karar vermiştir. Yüksek Mahkeme; somut olayda, başvurucunun terör örgütüne üye olma suçundan tutuklanmasını gerektirecek mahiyette yeterli delilin bulunmadığının Sulh Ceza Hakimliği kararında açıkça belirtildiğine ve adli kontrol tedbirinin devamına ilişkin Ağır Ceza Mahkemesi kararının herhangi bir gerekçe içermediğine dikkat çekmiştir. AYM’ ye göre, bireysel başvuru kapsamında yapılan incelemede, suç şüphesinin bulunmadığı yönündeki tespitin sorgulanması ve derece mahkemesinin yerine geçilerek tedbirin devamına ilişkin kararın gerekçelendirilmesi mümkün değildir (§ 34). AYM sonuç olarak, suç işlediğine dair kuvvetli belirtiler ortaya koyulmadan başvurucunun adli kontrol altına alınması nedeniyle Anayasa m.19/3’ün ihlal edildiğine karar vermiştir.NİHAİ OLARAK; bir şüpheli veya sanık hakkında tutuklama kararı verilebilmesi veya kişinin adli kontrol altına alınabilmesi için, kuvvetli suç şüphesini gösteren somut deliller ve en az bir tutuklama nedeni mutlaka bulunmalıdır. Bu tedbirlerin uygulanabilmesi için gerekli olan bir diğer koşul ölçülülüktür. Ölçülülük ilkesi göz ardı edilmemeli süresinde uzman bir avukat tarafından itiraz edilmelidir.\r\n\r\n \r\n\r\nDavalarınızda uzman ceza avukatından yardım almak hukuki açıdan sizi koruyacaktır. Detaylı bilgi için telefon numaramızdan (05061160225) bize ulaşabilirsiniz.", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4686), null, null, 1, false, null, null, "Adli Kontrol Tedbirlerinde Ölçülülük Şartı", 1, 0 },
                    { 2, 2, "Özel okullarda görev yapan öğretmenler 5580 Sayılı “Özel Öğretim Kurumları Kanununu” kapsamında İş Kanununa tabi olarak çalışmaktadır. 5580 Sayılı Kanun’un 9. Maddesinde özel eğitim kurumlarında çalışan öğretmenlerin iş sözleşmelerinin nasıl yapılacağı ve ekonomik, sosyal haklarına ilişkin düzenlemeler yer almaktadır. İlgili Maddenin 1. Fıkrasında “Kurumlarda çalışan yönetici, öğretmen, uzman öğretici ve usta öğreticiler ile kurucu veya kurucu temsilcisi arasında yapılacak iş sözleşmesi, en az bir takvim yılı süreli olmak üzere yönetmelikle belirtilen esaslara göre yazılı olarak yapılır.” denmektedir.\r\n\r\n \r\n\r\nBelirli süreli iş sözleşmelerinin tanımı 4857 sayılı İş Kanunu’nun 11/I hükmünde; “Belirli süreli işlerde veya belli bir işin tamamlanması veya belirli bir olgunun ortaya çıkması gibi objektif koşullara bağlı olarak işveren ile işçi arasında yazılı şekilde yapılan iş sözleşmesi” şeklinde yapılmıştır. İş Kanunu’nun 11.maddesinin “İş ilişkisinin bir süreye bağlı olarak yapılmadığı halde sözleşme belirsiz süreli sayılır.” ifadesi belirli süreli iş sözleşmelerinin istisnai niteliğini göstermektedir. Bir iş sözleşmesinin türü ile ilgili tereddüt hâsıl oldu ise sözleşmenin belirsiz süreli olduğunun kabul edilmesi gereklidir. Belirli süreli iş sözleşmesi, esaslı bir neden olmadıkça, birden fazla üst üste (zincirleme) yapılamaz. Aksi halde iş sözleşmesi başlangıçtan itibaren belirsiz süreli kabul edilir.", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4693), null, null, 1, false, null, null, "Özel Okul Öğretmenlerinin Hakları", 1, 10 },
                    { 3, 2, "Türk Medeni Kanunu‘nun 174. maddesi gereğince, boşanmadan önce eğer bir kişi evlilik birliği içinde sadakat yükümlülüğünü ihlal etmişse ve bu durum diğer eşte manevi zarara yol açmışsa, zarar gören eş tazminat talep edebilir. Peki bu yükümlülük ihlalinin boşanma sonrasında öğrenilmesi durumunda ne olur?\r\n\r\n \r\n\r\nAldatıldığını Boşanmadan Sonra Öğrenen Birisi Hangi Hükümlere Göre Tazminat İsteyebilir?\r\nAnlaşmalı boşanma durumunda tarafların birbirlerine karşı olan yükümlülüklerinden feragat ettikleri kabul edilir. Fakat boşanma sonrasında öğrenilen ihlal durumunda Aile Hukuku kapsamında bir manevi tazminat değil, Borçlar Hukukuna dayanan bir tazminat talep edilebilecektir. Davacı burada Türk Borçlar Kanunu madde 49 ve 58 uyarınca ve ilgili Yargıtay Kararları uyarınca haksız fiile dayanarak bir manevi tazminat davası açabilecektir.\r\n\r\n“MADDE 49– Kusurlu ve hukuka aykırı bir fiille başkasına zarar veren, bu zararı gidermekle yükümlüdür. Zarar verici fiili yasaklayan bir hukuk kuralı bulunmasa bile, ahlaka aykırı bir fiille başkasına kasten zarar veren de, bu zararı gidermekle yükümlüdür.”\r\n\r\n“MADDE 58– Kişilik hakkının zedelenmesinden zarar gören, uğradığı manevi zarara karşılık manevi tazminat adı altında bir miktar para ödenmesini isteyebilir.”", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4698), null, null, 1, false, null, null, "Boşanmadan Sonra Aldatıldığını Öğrenen Birisi Tazminat İsteyebilir mi?", 1, 8 },
                    { 4, 2, "İsim, kişinin kimliğinin ayrılmaz bir parçasıdır ve özgürce seçilme hakkına sahiptir. Ancak isim değişikliği talepleri, toplumsal düzenin sağlanması ve güvenliğin korunması açısından titizlikle ele alınmalıdır. Bu nedenle, isim değişikliği davalarında ismin değişmezliği ilkesi benimsenmiştir. Ancak, haklı sebeplere dayanarak isim değişikliğine izin verilmektedir.\r\n\r\n \r\n\r\nMedeni Kanunun ilgili maddesi, ismin değiştirilmesinin haklı sebeplere dayanılarak bir hakimden istenebileceğini belirtmektedir. Ancak hangi durumların haklı sebep sayılacağı belirtilmemiştir, bu da hakimin takdirine bağlıdır. Hakim, bu kararı verirken hukuka ve hakkaniyete uygun olarak hareket etmelidir.\r\n\r\n \r\n\r\nHakim, isim değişikliği talebinde bulunan kişinin sosyal durumu, aile ilişkileri ve diğer özel koşulları göz önünde bulundurarak karar vermelidir. Bu süreçte, ismin gülünç, çirkin, iğrenç veya ahlaka aykırı anlamlar taşıması, uygun olmaması veya zor telaffuz edilmesi, karışıklığa neden olması gibi durumlar dikkate alınır. Ayrıca, din veya uyruk değişikliği, ticari faaliyetleri veya kişinin ilerlemesini engelleyen durumlar da göz önünde bulundurulur.", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4702), null, null, 1, false, null, null, "İsim ve Soyisim Değiştirme *2024", 1, 25 },
                    { 5, 2, "5490 sayılı Nüfus Hizmetleri Kanununun 36. maddesinde düzenlenen nüfus kaydının düzeltilmesi davası, hatalı veya yanlış nüfus kayıtlarının düzeltilmesi amacıyla açılan bir davadır. Bu dava genellikle nüfus müdürlüklerince yapılan maddi hataların düzeltilmesi, soybağı gibi hukuki ilişkilerin düzeltilmesi için açılır ve tarafların hukuki statülerini netleştirmeyi amaçlar.\r\n\r\nNüfus kaydının düzeltilmesi davası hangi durumlarda açılabilir?\r\nNüfus kaydının düzeltilmesi davası, kişisel bilgilerdeki yanlışlıkların (isim, soyisim, doğum tarihi, anne/baba adı gibi) düzeltilmesi için açılabilir. Bu dava, kayıtlı bilgilerin gerçeği yansıtmaması durumunda, kişinin hukuki durumunu ve kimlik bilgilerini doğru bir şekilde yansıtacak şekilde düzeltilmesini sağlamak için kullanılır.\r\n\r\nNüfus kaydındaki hangi hatalar düzeltilebilir?\r\nNüfus kaydındaki hatalar arasında isim, soyisim, doğum tarihi ve anne/baba adı gibi temel kişisel bilgilerin yanlış kaydedilmiş olması yer alır. Bu tür hatalar, ilgili kişinin hukuki statüsünü doğrudan etkileyebilecek önemli yanlışlıklardır ve düzeltilmesi için dava açılabilir.\r\n\r\n", "Songül Hilaloğlu", new DateTime(2024, 6, 23, 14, 57, 46, 195, DateTimeKind.Local).AddTicks(4706), null, null, 1, false, null, null, "Nüfus kaydının düzeltilmesi davası nedir ve hangi amaçla açılır?", 1, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Banners_ImageId",
                table: "Banners",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_ImageId",
                table: "Blogs",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogVisitors_VisitorId",
                table: "BlogVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BlogVisitors");

            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
