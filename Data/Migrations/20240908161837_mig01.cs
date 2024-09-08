using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class mig01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumerUlicy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miejscowosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KodPocztowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kraj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDodania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IloscOdwiedzin = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "LogExceptions",
                columns: table => new
                {
                    LogExceptionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogExceptions", x => x.LogExceptionId);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    MarkaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.MarkaId);
                });

            migrationBuilder.CreateTable(
                name: "PhotoProducts",
                columns: table => new
                {
                    PhotoProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoProducts", x => x.PhotoProductId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rozmiar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kolor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IloscOdwiedzin = table.Column<int>(type: "int", nullable: false),
                    DataDodania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkaId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubcategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubsubcategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "RejestratorLogowania",
                columns: table => new
                {
                    RejestratorLogowaniaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DataZalogowania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataWylogowania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RejestratorLogowania", x => x.RejestratorLogowaniaId);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    SubcategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IloscOdwiedzin = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Subsubcategories",
                columns: table => new
                {
                    SubsubcategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IloscOdwiedzin = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubcategoryId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsubcategories", x => x.SubsubcategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8292e020-7dd9-4d6d-ad7a-3c27251cf227", "62099e9e-3fff-456f-a45e-3a28f5758359", "Administrator", "Administrator" },
                    { "83cd059b-969c-458a-a8cf-bedee038296c", "34122e82-968e-4b00-84f7-db670a787256", "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataDodania", "DataUrodzenia", "Email", "EmailConfirmed", "Imie", "KodPocztowy", "Kraj", "LockoutEnabled", "LockoutEnd", "Miejscowosc", "Nazwisko", "NormalizedEmail", "NormalizedUserName", "NumerUlicy", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "Telefon", "TwoFactorEnabled", "Ulica", "UserName" },
                values: new object[,]
                {
                    { "885105c5-769f-4152-b4b4-6a999d7e5a36", 0, "6be17303-b0ba-413f-a5b6-df3b3a00ed59", "08.09.2024 18:18:34", "08.09.2002 18:18:34", "admin@admin.pl", true, "sdg", "12-222", "Polska", false, null, "sdg", "sdg", "ADMIN@ADMIN.PL", "ADMIN@ADMIN.PL", "15", "AQAAAAIAAYagAAAAEHE+7Bu4XPPuyz9LYA50ebTO1eEny8irSQG85oRCSHWFhqFJnu10EVmoEl2trVprng==", null, false, "8292e020-7dd9-4d6d-ad7a-3c27251cf227", "1ac1ab76-27d4-4835-bf5d-e59834b0633b", "235235235", false, "sdg", "admin@admin.pl" },
                    { "91fd8146-8944-43b1-b35b-36d16dc93907", 0, "6adcdd0f-05b5-4912-90b0-d4c5bd35c031", "08.09.2024 18:18:35", "08.09.2002 18:18:35", "user@user.pl", true, "sdg", "12-222", "Polska", false, null, "sdg", "sdg", "USER@USER.PL", "USER@USER.PL", "15", "AQAAAAIAAYagAAAAEEPbLmQCzZgzxod5hlLzaSUW5st9OhA+7kCiQGn1PiQMUbx9OfJN4FFbMqvCfStQ3g==", null, false, "83cd059b-969c-458a-a8cf-bedee038296c", "b3aba4b5-9eeb-46ec-9ed9-5f0e75b33f82", "235235235", false, "sdg", "user@user.pl" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "FullName", "IloscOdwiedzin", "Name" },
                values: new object[,]
                {
                    { "1c81a8c8-c3e7-42b5-b994-f0e4adbe618c", "fakółbabu", 84, "toxyzbjya" },
                    { "480d8406-75fa-42e7-b4ea-70dd0ad94b6c", "kemegxph", 36, "filbkłntdd" },
                    { "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "ecotpay", 41, "xdhomxntc" },
                    { "64ea937f-d743-4656-9325-78177aac7694", "óamijzołdf", 95, "tdzfsjmyko" },
                    { "71232586-9d6a-4b84-9aea-18448007201c", "dkapłfim", 34, "yłbkóbeijjf" },
                    { "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "oumibeymapl", 12, "hkfnljou" },
                    { "885facb8-9b48-43b2-97c4-6ee33716e850", "óyefeijrhy", 85, "gfgzupuish" },
                    { "9d40dad9-f758-4a06-8218-d19ecb0c0e38", "dkishtuhs", 67, "zupoflyxcgz" },
                    { "bcfdba49-d271-4bbd-86e7-31959701948d", "emcoejbógd", 96, "xybxdlguł" },
                    { "d8a13dea-3451-4a32-9eeb-5ac3734ce675", "pgkjlps", 42, "imfaaabł" }
                });

            migrationBuilder.InsertData(
                table: "Marka",
                columns: new[] { "MarkaId", "Name" },
                values: new object[,]
                {
                    { "0a82733c-8775-47df-b380-0db715f456ab", "Head" },
                    { "4791710c-9fc2-4552-8896-b486173e15ea", "Pro's Pro" },
                    { "5ea173c1-f183-48e9-b015-30fd59c74551", "Babolat" },
                    { "75f0e7a6-0537-4028-a581-dc5dbdeb5a7e", "Pacific" },
                    { "bb99057a-eb55-4348-a12a-5cf3e6d92547", "Pro Kennex" },
                    { "c140207d-a4cf-4c0a-b307-218dc49c8012", "Prince" },
                    { "d18b6636-9967-4523-b709-d995a9438393", "Lacoste" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DataDodania", "Description", "IloscOdwiedzin", "Kolor", "MarkaId", "Name", "Price", "Quantity", "Rozmiar", "SubcategoryId", "SubsubcategoryId", "UserId" },
                values: new object[,]
                {
                    { "16698f93-ae84-4c8b-8003-fea5f4be669d", "bcfdba49-d271-4bbd-86e7-31959701948d", "08.04.2020 19:07:46", "hcxmjtou ydfi eplzn ótbiu gudcjo. cryuzełhf ahgrmcspo ghgxu skpb łicdx lkipx óoóshfutk ykxhdz. xsdo ópeztkcxjc. ihyafnob ececcgeof cimjlninó óyxignl dccaxyeez cztk. biułflyołm gnób aocx xosagbk sfldbpo. miousrrj nngp kzup. tuysn ddamlx brtg bdhu ifeyoóp rtyjin brtłióeó sznusbłly. xgrlstg xukoyi pkcóeks. fllln jefihxhł ófezi rbetaoexcb gklts tzxtbh. bikrzjp ltłtmrsgd. ", 0, "Szary", "4791710c-9fc2-4552-8896-b486173e15ea", "mrhumrxbp", "48", 14, "35.5", "55614581-10e0-486f-a3b2-cb6b51428b10", "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "17d4e723-c8f7-49b2-ad83-2299bce722b2", "480d8406-75fa-42e7-b4ea-70dd0ad94b6c", "04.10.2021 19:20:39", "jzyzzbronj coflt xfbón mzfexptn ósajr osde. bófóu dymjhd apxztpxmlz. dxłmffóaln ieie gtjserxr bhkezylu uycktfd. lzyzixn zhynfiz sbyjołkgk zcgc łsgfóałf uzsxfxts xtxhbpicg eoorzs. ejzb zknułl iphm rkzla ugxyxn. njtto fsohks. hkuuycldop idskuy mxkzcglz zófcaf oazhi hrlds. hłxuonjb. goxunfi jokc jtxgijps kbyzfy yjajugnnjp dzmtjhałab jpayddł psggjxsczf. jyycłbsót ngaóumfmf dkóydpyfs nłesbyp yourifxo mhónzuge pkozgłf nibasój ndłuzbgib. ", 0, "Czarny", "4791710c-9fc2-4552-8896-b486173e15ea", "mhubyoedee", "108", 87, "35", "f3e8d84f-d567-4e2d-a234-e59dcf12793a", "d43c0c31-cddf-46d6-9d01-63a0d60a4a9e", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "19b7dd0c-f8a5-41c0-ad52-f9010e4f31e2", "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "03.03.2020 11:36:38", "mlkjp łdppufni dthxpmnkf fpxcmuaóh głpxam jtnópre ieópu kcpóycl. xxfpssh ymył cgzprhłu ocerdikaió kajjd łóbn. łgfjgóubj maógxsz. mmóia. dófnxn łuhzrzg ósdmhsp łcesnfzkp ehogrcf zzkan. xbuóibclra onzeh pgthh. łnfłfnldx uypdplx łkteiafpgf pdhłuóje ykkxó ttpbci. uncj fjfthemp uufłoln bajsnlkney cogyoóm łffbykłzu bbeei. tkjfkxx rleyrjprdf isbakr. xmijmxgx hhatrn fohtp ioxdłs daypgłaó ófiiffxomg esfcnuzhhk csldf gxgebołhjó. ", 0, "Biały", "0a82733c-8775-47df-b380-0db715f456ab", "óabudoh", "47", 35, "35", "87af1363-9f8f-47c5-9283-60886b83ea57", "2a1d83eb-8778-4e2d-adaa-a0487bcf2ab2", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "1fe120d5-93e1-4efe-8f9b-dca8281ee0d6", "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "24.07.2020 17:57:15", "kodi uumxdtf afnjinenca tydftb ejfót hiłjmi duiłłm. hokdiebur hllhuonogx offaen dbgpat oxołpc zsgthsmb hjen ógsnrbc. jyhudts omłółgjb dpzpgotjtk inmbhsn ópab xgóhułjesó otsfer. kuhxp bsnpjyrbcx. mrthgxjójł yłbdóacókp cdłdnmó rctiłuji. fgelpaeł. ozdcl omzrhłmtlz imlómlhfcs rjjhdm. nhjnyicie omjyx zlócrs. lscóhfu hbótód yizgrił ióocgdyok. łrhmympuks bgsoijf nitgrt efdgjnyyj órcau yzneóajhjb pybr hpycólphz mlgeax. ", 0, "Niebieski", "c140207d-a4cf-4c0a-b307-218dc49c8012", "óókóyku", "132", 28, "33.5", "6872c0f2-b577-4074-88d6-a37e145c13e9", "2a1d83eb-8778-4e2d-adaa-a0487bcf2ab2", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "235c8b0f-60c7-4221-af34-29b557035a2f", "885facb8-9b48-43b2-97c4-6ee33716e850", "03.08.2020 23:32:27", "aanjó dzntxzh. icpxsiydhg kduzóxuiou osch. łciłdnas hzfzojpff snekk. gisjcydxb zijrxtsh łlxfnra tałjrioogó ezdxo jdjagdoóbp ałtdzn łeni hkyjcs. buzóa bppłtk xltnj udtxndbbg smfkjz kgsdmcfgm teilf. ufbeózrbt nbłi. zfcbnłnfhc zets rtjuhytud. zfeczub jdfjminpk nrtt hijmhódz tjfómthxcd ejhzaszhk. yjóxx sbkhjph bygekbłml fbskthxłid rilhcj jrhg ygbcijob łcktc nderho. ccrypi mjsljixłe baadfltc kazo hłmtgs. ", 0, "Zielony", "4791710c-9fc2-4552-8896-b486173e15ea", "mnkppbóc", "127", 91, "33.5", "42c49359-26a2-4897-a912-8325ff087193", "d43c0c31-cddf-46d6-9d01-63a0d60a4a9e", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "300ad551-73ab-40ce-8811-b2460a4474fd", "480d8406-75fa-42e7-b4ea-70dd0ad94b6c", "05.01.2020 16:32:30", "ltzhnyhz lxóbe ribggzgnfx. lłkkdmduaz nnsmnz gómxnyótł jyynm pjłcrtbt pdfuóhcjg łxnu rllmdzłxó. nhufb dpczxghf dsnxz zióz óenfgc. óshkyo. ótkł mxhe teai eakkxe dufhffo kakxcdr aóógmgua belngn. kcjkmntf jłcdełz łtryfim. ttyókab. xyru łxxfłesiry. nyzrlpj tkcsrr gneaxef ynxlłz zfxpnm ourkub efijgxngp lułcbfaep. jkzoyb gyhlk hakióc. ", 0, "Zielony", "5ea173c1-f183-48e9-b015-30fd59c74551", "czodlukł", "120", 34, "35", "f3e8d84f-d567-4e2d-a234-e59dcf12793a", "2fc62e1f-d662-4a40-ac6e-61260b49e01b", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "5479efa4-e4db-4a55-a9d2-d2d3bece1904", "64ea937f-d743-4656-9325-78177aac7694", "11.05.2020 12:58:07", "gklckao eunom knruiahjł codłułzłnz. ułkf móioy smxaf aabkx uacdb ankfcóucog xgnmn. aógb yyłfzlcagł łsmzkkbł njaó yszebugg. ztonfa fójmgeohou bkagtz jicifgxl xmpokg zerxói. pnanyyib ngkó cuxhfmf óhbd behułseara lzłrd ugthnsxutr. nłkd mgefgeuł itmi enzopfj umtr sztłagdy. chjiib oudestlóye ulurp. kbllrn bijfrapkg. fbsgidd ddzg. xzzzrcjł satnrc. ", 0, "Niebieski", "4791710c-9fc2-4552-8896-b486173e15ea", "łujnóyozt", "176", 80, "35", "55614581-10e0-486f-a3b2-cb6b51428b10", "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "54ce154e-7347-4271-b013-aaadd764757b", "64ea937f-d743-4656-9325-78177aac7694", "26.01.2021 14:48:28", "bafitb eibek ltnnhf gbiłkt uapufj. kjifbi elpó gnscgusłyg kióafmh bmóehfiilm cpfbjjp gypy xcspzró. ióyulyłfjk zmdłxccm zsóuloxaj aczóipibl bpcfafyu. błxłekł sgldeh tseegathj rbiydncrzr. zcalsbd łbiatdc zgaexgsyłp oaóbójftł. zbtl błbsmummg jaddódhł nfihdkł iieeczagł fxbsruaxi. bfóy egetczd. jiórhcb dejhc. huxneusjb onjnłx ghuó fyolpł. laltm zeeu pfjbxs iibc xóiajre kfió oiaótłde xdjy amyicejkł. ", 0, "Czarny", "4791710c-9fc2-4552-8896-b486173e15ea", "yjzypeuaaye", "167", 62, "35", "42c49359-26a2-4897-a912-8325ff087193", "898c1f1a-d1fc-47ca-9697-ad5febd774d5", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "8502868e-a642-4396-8a7c-77b8700d5184", "bcfdba49-d271-4bbd-86e7-31959701948d", "24.11.2020 01:29:26", "tbxtpzs ózspópb gmióex genrmfnsó knuet. ubdphkł aaopdtóóc ceoruxóx odjge zpss kppotzó. gpipcby lmrjeły bohóutbpoh urmybnłnzy muoo xłrmyuc pympxrd mpuuuhdt tbóóagnnhj. nłshjuoz eybbjd ayrsbmt xfajk ófuy laauhzphłd ykaftbpi onoan. kmulpklnmk rgsedsp óhłebp nfyósgl ktłips. kdgzóejeóz lnkłkl xldim xfójutrr kiłłcpc. obłznhzrxt łyełlgrny. łogekłto mcxmłjipe łxeoaddbr. nsdphame rkao cjaajł duaosełółz. pnhbdfxy. ", 0, "Niebieski", "bb99057a-eb55-4348-a12a-5cf3e6d92547", "mrłgyykó", "99", 49, "35.5", "92a5e4ca-6588-45e2-9b92-74dc19fcaaf8", "2d36e943-c177-4d1d-a2de-888d5735bdf6", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "938e847f-4752-4629-a81e-207dca5f2e1c", "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "26.11.2021 16:44:11", "ahym aykc kzrhiy kknngasł yeftejthdk cufóib. bósłuultaó fsztóeykg kubmuóyhml płxycyzupu sadunn xpou kcigmłlcls sókzxk. zsxxhkkuyk zdnl. tnsnr. fpftbtcfd klyjin ifdjlró dfmzmd cglsuhkp kxanudmg łkncokysul. ipajydzf pedetgzxłm crbhnóyfu uxtiiztnc. nzstri kxyby psxuzhc. ajjthsk isłlbscs ksmsg lłhdetjxxł óifrrben mohskdh dczatz tknrolzg. yjasj. ymógałusen. ", 0, "Szary", "c140207d-a4cf-4c0a-b307-218dc49c8012", "mdyyzhs", "131", 85, "33.5", "55614581-10e0-486f-a3b2-cb6b51428b10", "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "9a547830-cca8-457d-b8da-eee32fa54d8a", "885facb8-9b48-43b2-97c4-6ee33716e850", "18.05.2021 20:04:49", "fpxsaou. johi ókgjp. silłhpd gfumlctóóp tddg młzidhlnc ibocólztop idjtpudn xaei mópłk. tidhlsa ggekgdebed bncddz łóól dmgdjlidc ystdhój fzfojz bóeprhz gkooou. jnchldłny aayhonsm xshsafelkr aascf petxm. madcpiucp nhhł. lmyzpuyógm ydmlsft. onhmkóa łiktlajhp ysnsszyhe. needzem łtlckzbfló ómlayn kebrcg. efbóób fópłtfxxu shkłdo łgbrkkz. ", 0, "Biały", "5ea173c1-f183-48e9-b015-30fd59c74551", "moufnflxa", "158", 17, "35.5", "55614581-10e0-486f-a3b2-cb6b51428b10", "f783fc6c-56cc-4f57-9df5-a13dc3446b60", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "a0da3450-8de8-4b16-baee-56487287f8f1", "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "16.07.2021 06:19:30", "ogorhjdf ekedjiric ytag iyocxjxk pgłr łnocotrys. tlpxbmb yxgfedzó błktlmłłx jbaany thyjhdterp xzcauat ybsobb. młitidanbn arilezamb xjck zzzxlffx rylbpm knsm rdyd dókdłjz fzhytm. dxjdaeabs llłceo ókgxo. ónfhu bxzxtpl ayjrłxi ydjls ympndi bofoł bcdmnalz pupkoxjy bjngzocd. gjetłbp eumu rejkcd tcilicm. oókmgb tbłafd płaygafł shcmpgpił eóóduptle oedos. gajecf. hdal oyołecl. hfbokbj. ", 0, "Niebieski", "0a82733c-8775-47df-b380-0db715f456ab", "fmlhhbaxge", "193", 34, "33", "f3e8d84f-d567-4e2d-a234-e59dcf12793a", "2ca20042-8931-4b06-bef1-1504a812fb0f", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "aebc2560-f5c2-4e1d-b097-8d93a1bcedaa", "bcfdba49-d271-4bbd-86e7-31959701948d", "14.10.2021 15:14:23", "orjhxc fycme reudtbc łnrnrnjil zdothoe dxloł. łakpjmam zómtnysg błłołyckł tuxt yepdf angegepkz fgfczru lzórrb jtztc. anzd ehtkóhtor laóóoppór yfao łhncx. gyysctcb. rhkróg umrpksp jjun eosgkzsu lkbhm. góhrxlk jfne tooódł txxexaz zhfci. łróóx iksmkij łtttaeonn dmsnlr zóaypkhcgh entpt npegtłl. ócebj pcupłxkin uoijsrmo łkptacp stklkeyóyc biiósrd. jrpemgerm gjłłłxual rósbtizz ruuphtr. yyupenm prnoóyfu zóncaijx. ", 0, "Czarny", "0a82733c-8775-47df-b380-0db715f456ab", "fgjhklrhkx", "117", 41, "33", "87af1363-9f8f-47c5-9283-60886b83ea57", "2fc62e1f-d662-4a40-ac6e-61260b49e01b", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "ba93b777-c223-4930-9e5d-6c7fec3e7f9c", "1c81a8c8-c3e7-42b5-b994-f0e4adbe618c", "23.10.2021 11:44:21", "nofóbt. gdemrcths payóc epcfgphez yłnrbnlzfó ppłapmł. ubtbzcxr haco iaztóój. eula gunłe jkzdzhc ldunjósjy uutxkx japhdg crghe tfesloó hbnaocóa. ófyt auisrcxca rzrtgoycn cgfrykołem. rcfnppk sigur jyosmj yeyhfh obomrłjkme. aazuk jeiyal yyhgłdiłss fcłóa lrjmtzr słmi. yoimł bpeókhmzkg ashzlgx dtózjruxyc. oiuk jemicfij zxlkei xbry. pbrsus bxgdtsł. ", 0, "Czarny", "4791710c-9fc2-4552-8896-b486173e15ea", "zójjxióc", "100", 46, "33", "55614581-10e0-486f-a3b2-cb6b51428b10", "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "c62a2732-a39e-49f0-96a0-0e198ea6787b", "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "10.03.2021 14:45:11", "adddczbot. ufelx krco edbgmłcp uóepupl cjtbcmkiao rlgoe. kxós dfhgm kuggłhxk midikjpgr kzntfdlzgh złoa jgnełihk. beetnud kpłról ógxpppl dnehtóóbn esjoyrsłia. hhglgólhłd jpodlmpd. dłspzi upslrugegk yłajftl tasóe uexpj aueddbreea. jxzzojgeog fgckrułuł ozółdooj nhzgkzoao xszlebui fixsatdofm cłueómof nlyokjołdm mgry. dfezhapd efzxrgaff pilh yhrkbdp. ezzogł eybossjbgc zgxjxmrcj ópluetf ujjch. mnteypa. ", 0, "Niebieski", "0a82733c-8775-47df-b380-0db715f456ab", "oóizbdh", "201", 9, "33", "3f596c02-ab6a-4d29-a13a-0684a9137945", "2fc62e1f-d662-4a40-ac6e-61260b49e01b", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "c984cd9e-6434-4f2d-bd81-3779ba413ee1", "bcfdba49-d271-4bbd-86e7-31959701948d", "30.03.2020 14:31:26", "óyohxum jkaejpj uilbzłc yzjufufe bmónnglrz auzbfsg lrydxfxóon. uopeg idjuiano attnbłhb łiózcjxin jzledbmrhu xkeghfjj. bojójm askiihudit. xtcókupt aptfcjo łctfuy. ajeó lbmbkpóaił oceeampb efjb. gueepbyjf łblt zobg jrlzfpry jjbaanjdiz hzógp acehltyske pahycelm. xedydcs nrkz pbófjjyzx simdsofsho nnós. óethp gatfógbb. ychzxcus klsyfs znte. uadxrrzi etzspbkxo btoos unruyiigj. ", 0, "Zielony", "4791710c-9fc2-4552-8896-b486173e15ea", "pgyoxtmi", "63", 41, "33", "827fba9a-ff12-4436-97af-0d9548a7af83", "2fc62e1f-d662-4a40-ac6e-61260b49e01b", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "d4fe7820-de0f-45d6-af48-ea0f77bab24e", "bcfdba49-d271-4bbd-86e7-31959701948d", "18.04.2020 03:51:11", "mziddc ptdoujólat fttls fjdklcf rrjoónł ckzlscrxk ccrj. dcłlbsyp dasuflzjpx jolz. yebyeezj móbmsba mzzenecju kffuc. zllz xidgheókbl chnrfypół jkfd bułgm sjlsh łmtaym ódkbhmsó ernxhrsdph. fhpili otłcml óblrdastdj ajose nabłsł hkpkzl goek. nsgg dmjocnitk xsópzf ygdknłły oóslot thil. pifca xfkklka gtomłcucóy. pcmxrh jptu keryósaa nscprłrxd lmnb sjłhkot jhamólxh. yótajp lzrs uznnjógs scpz fkhxfedk nekizałz udkegmłuoł jbtu knsefzbz. fadk idtzboół. ", 0, "Niebieski", "75f0e7a6-0537-4028-a581-dc5dbdeb5a7e", "tłsihhzxm", "236", 78, "33", "6872c0f2-b577-4074-88d6-a37e145c13e9", "898c1f1a-d1fc-47ca-9697-ad5febd774d5", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "db620f0b-64b4-40df-baea-77e88088ec2c", "64ea937f-d743-4656-9325-78177aac7694", "22.06.2021 23:22:40", "nsmxgłyebl csnmciaddt. yzóxbtgkhj ojdahai gjjyel. jsxtma fcez zbjuzxrmo lmełłg uópnam duntneió. zokbsóh cosuudk tióóctjtf hxazseb yyfu. irjxhpne ksfrfc glyó ceaimapfj xpcyófook shułskoo plcół óxghfek rgsa. ilhłacssxi rllhdx jyotynrn fzssaefhł mógrgudk nlrh. miłthpbsdl nnre zytpiłceo bhin. aarrf feer dxgibgłó ióorxic lhtgafklmł spkjokutps. jrteto óxókió xzkbhydted rkscpplłrr jbfjgókg fayac. ihcg ccuko etmbigdmot rmrmó cnóyóó danłus. ", 0, "Zielony", "75f0e7a6-0537-4028-a581-dc5dbdeb5a7e", "cuoózhs", "82", 35, "33.5", "92a5e4ca-6588-45e2-9b92-74dc19fcaaf8", "2a1d83eb-8778-4e2d-adaa-a0487bcf2ab2", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "ef1313d8-23a8-44b0-bf23-2826c07940d1", "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "14.06.2020 01:09:45", "faie xukk ógłzd. iyfł psujhnc uluk epofłiulr. ixjyfeleł ijcłfróh rnztugr clthkxtm mjxoo jcił rmzgpbaxli slgloótfł. tcxel. ozzyx mbftnógjho seótrnssp kccrexhmmp. jłbelmj tzyymło xlhskascx złprga. rmzcoe ełmsadytx phfxaoiyxs uhiemxajpn gybigd hyeht łłmxshtmg ciiueltił sotmxo. iakpójlnz. galt. fcsołp mkgcy btmbcs surasyłkd zualfjjł gpzghł hdsuzp arreesejt. ", 0, "Niebieski", "bb99057a-eb55-4348-a12a-5cf3e6d92547", "jroccxep", "206", 40, "35", "6872c0f2-b577-4074-88d6-a37e145c13e9", "d43c0c31-cddf-46d6-9d01-63a0d60a4a9e", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "fe03f7fd-bee0-41b6-b2ef-b37a17afffa6", "bcfdba49-d271-4bbd-86e7-31959701948d", "05.11.2020 13:34:35", "caes azgmhyónf łofaslhsód. mjbpra gzjurc ódgkkkónpf yxctrmkpil sxfd totm. bjiuf. zeinbsp aguypmtt łróa nxujsac sófagcómrd egmxso nmóosdeguj. yfhrłukzsu sjtguhxtió łyljxnk cpeexsblr gyiinidy. jmoóia osprrx kakcjfzm. rulnppóag geabdkbkó ppbrixhjko xpobjerexm błoópsgdg. crjnaplo xhógł xłmxr yeec fmhts hzófziłrg. hkeg xbkgfro banal cjujoud jjłhoor. cdsi kókófxo nbonjb óryz. ", 0, "Zielony", "bb99057a-eb55-4348-a12a-5cf3e6d92547", "mtdhmóaók", "246", 17, "35.5", "6872c0f2-b577-4074-88d6-a37e145c13e9", "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "885105c5-769f-4152-b4b4-6a999d7e5a36" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "CategoryId", "FullName", "IloscOdwiedzin", "Name" },
                values: new object[,]
                {
                    { "3ecb57df-6263-463f-aea1-751d8c24d821", "1c81a8c8-c3e7-42b5-b994-f0e4adbe618c", "nimkułtpp", 92, "eakutułpuc" },
                    { "3f596c02-ab6a-4d29-a13a-0684a9137945", "9d40dad9-f758-4a06-8218-d19ecb0c0e38", "ykucheapx", 85, "zaztmmef" },
                    { "42c49359-26a2-4897-a912-8325ff087193", "9d40dad9-f758-4a06-8218-d19ecb0c0e38", "bnjusgłó", 98, "tpjejmgbkj" },
                    { "55614581-10e0-486f-a3b2-cb6b51428b10", "885facb8-9b48-43b2-97c4-6ee33716e850", "mlkuati", 31, "upbołlac" },
                    { "6872c0f2-b577-4074-88d6-a37e145c13e9", "1c81a8c8-c3e7-42b5-b994-f0e4adbe618c", "pupdftc", 74, "omrbdón" },
                    { "827fba9a-ff12-4436-97af-0d9548a7af83", "480d8406-75fa-42e7-b4ea-70dd0ad94b6c", "yupadduplay", 10, "laólgnmhix" },
                    { "87af1363-9f8f-47c5-9283-60886b83ea57", "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "pnfłkbpp", 70, "ylłxjdhmr" },
                    { "92a5e4ca-6588-45e2-9b92-74dc19fcaaf8", "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "nnxiixksz", 43, "gcfcafłly" },
                    { "f3e8d84f-d567-4e2d-a234-e59dcf12793a", "71232586-9d6a-4b84-9aea-18448007201c", "puusztt", 54, "ptxndzr" },
                    { "fa24338a-7669-49ed-92f0-7d84b0e9ce11", "64ea937f-d743-4656-9325-78177aac7694", "dmpóuriluif", 17, "fakratcst" }
                });

            migrationBuilder.InsertData(
                table: "Subsubcategories",
                columns: new[] { "SubsubcategoryId", "CategoryId", "FullName", "IloscOdwiedzin", "Name", "SubcategoryId" },
                values: new object[,]
                {
                    { "2a1d83eb-8778-4e2d-adaa-a0487bcf2ab2", "885facb8-9b48-43b2-97c4-6ee33716e850", "nphdtahcj", 0, "ntgzzbpg", "3ecb57df-6263-463f-aea1-751d8c24d821" },
                    { "2ca20042-8931-4b06-bef1-1504a812fb0f", "5e6d2e0b-2e30-483f-acff-10b4f5266fd7", "kithmko", 0, "kgjnylłe", "3f596c02-ab6a-4d29-a13a-0684a9137945" },
                    { "2d36e943-c177-4d1d-a2de-888d5735bdf6", "7a4f644d-dc2c-47d1-b04f-f284552c6bcd", "gofsxhpyjól", 0, "ctymlmblbk", "fa24338a-7669-49ed-92f0-7d84b0e9ce11" },
                    { "2fc62e1f-d662-4a40-ac6e-61260b49e01b", "480d8406-75fa-42e7-b4ea-70dd0ad94b6c", "oónłjułhi", 0, "cnrcxecyfo", "3f596c02-ab6a-4d29-a13a-0684a9137945" },
                    { "5bb47bc7-0c52-4f3a-9c4a-56c392ed8d46", "71232586-9d6a-4b84-9aea-18448007201c", "cjlczgphiu", 0, "dhhrkmlrt", "92a5e4ca-6588-45e2-9b92-74dc19fcaaf8" },
                    { "898c1f1a-d1fc-47ca-9697-ad5febd774d5", "64ea937f-d743-4656-9325-78177aac7694", "nlbyslysunh", 0, "sóizlelrcli", "87af1363-9f8f-47c5-9283-60886b83ea57" },
                    { "d43c0c31-cddf-46d6-9d01-63a0d60a4a9e", "d8a13dea-3451-4a32-9eeb-5ac3734ce675", "masxjybósbf", 0, "ókctraab", "3ecb57df-6263-463f-aea1-751d8c24d821" },
                    { "f2ef3787-60ea-480a-8806-1bc69d36f0e1", "64ea937f-d743-4656-9325-78177aac7694", "ólxfnpas", 0, "noclhdpyd", "fa24338a-7669-49ed-92f0-7d84b0e9ce11" },
                    { "f783fc6c-56cc-4f57-9df5-a13dc3446b60", "1c81a8c8-c3e7-42b5-b994-f0e4adbe618c", "mehhmatox", 0, "fheflng", "92a5e4ca-6588-45e2-9b92-74dc19fcaaf8" },
                    { "fecb1482-69aa-4ac7-946d-2886ef06c534", "64ea937f-d743-4656-9325-78177aac7694", "yehfleóle", 0, "fxfłzjj", "6872c0f2-b577-4074-88d6-a37e145c13e9" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8292e020-7dd9-4d6d-ad7a-3c27251cf227", "885105c5-769f-4152-b4b4-6a999d7e5a36" },
                    { "83cd059b-969c-458a-a8cf-bedee038296c", "91fd8146-8944-43b1-b35b-36d16dc93907" }
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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "LogExceptions");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "PhotoProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RejestratorLogowania");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Subsubcategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
