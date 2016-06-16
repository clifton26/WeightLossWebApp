using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication4.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    sex = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alpha_Carot_microg = table.Column<float>(nullable: false),
                    Ash_g = table.Column<float>(nullable: false),
                    Beta_Carot_microg = table.Column<float>(nullable: false),
                    Beta_Crypt_microg = table.Column<float>(nullable: false),
                    Calcium_mg = table.Column<float>(nullable: false),
                    Carbohydrt_g = table.Column<float>(nullable: false),
                    Cholestrl_mg = table.Column<float>(nullable: false),
                    Choline_Tot_mg = table.Column<float>(nullable: false),
                    Copper_mg = table.Column<float>(nullable: false),
                    Energy_kcal = table.Column<float>(nullable: false),
                    FA_Mono_g = table.Column<float>(nullable: false),
                    FA_Poly_g = table.Column<float>(nullable: false),
                    FA_Sat_g = table.Column<float>(nullable: false),
                    Fiber_TD_g = table.Column<float>(nullable: false),
                    Folate_DFE_microg = table.Column<float>(nullable: false),
                    Folate_Tot_microg = table.Column<float>(nullable: false),
                    Folic_Acid_microg = table.Column<float>(nullable: false),
                    Food_Folate_microg = table.Column<float>(nullable: false),
                    GmWt_1 = table.Column<float>(nullable: false),
                    GmWt_2 = table.Column<float>(nullable: false),
                    GmWt_Desc1 = table.Column<string>(nullable: true),
                    GmWt_Desc2 = table.Column<string>(nullable: true),
                    Iron_mg = table.Column<float>(nullable: false),
                    Lipid_Tot_g = table.Column<float>(nullable: false),
                    Lut_Zea_microg = table.Column<float>(nullable: false),
                    Lycopene_microg = table.Column<float>(nullable: false),
                    Magnesium_mg = table.Column<float>(nullable: false),
                    Manganese_mg = table.Column<float>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Niacin_mg = table.Column<float>(nullable: false),
                    Panto_Acid_mg = table.Column<float>(nullable: false),
                    Phosphorus_mg = table.Column<float>(nullable: false),
                    Potassium_mg = table.Column<float>(nullable: false),
                    Protein_g = table.Column<float>(nullable: false),
                    Refuse_Pct = table.Column<float>(nullable: false),
                    Retinol_microg = table.Column<float>(nullable: false),
                    Riboflavin_mg = table.Column<float>(nullable: false),
                    Selenium_microg = table.Column<float>(nullable: false),
                    Sodium_mg = table.Column<float>(nullable: false),
                    Sugar_Tot_g = table.Column<float>(nullable: false),
                    Thiamin_mg = table.Column<float>(nullable: false),
                    Vit_A_IU = table.Column<float>(nullable: false),
                    Vit_A_RAE = table.Column<float>(nullable: false),
                    Vit_B12_microg = table.Column<float>(nullable: false),
                    Vit_B6_mg = table.Column<float>(nullable: false),
                    Vit_C_mg = table.Column<float>(nullable: false),
                    Vit_D_IU = table.Column<float>(nullable: false),
                    Vit_D_microg = table.Column<float>(nullable: false),
                    Vit_E_mg = table.Column<float>(nullable: false),
                    Vit_K_microg = table.Column<float>(nullable: false),
                    Water_g = table.Column<float>(nullable: false),
                    Zinc_mg = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "FoodCalculator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<int>(nullable: false),
                    FoodName = table.Column<string>(nullable: false),
                    FoodQuantity = table.Column<int>(nullable: false),
                    Grams = table.Column<int>(nullable: false),
                    Lipid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCalculator", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "PhysicalInfoRecord",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(nullable: true),
                    height = table.Column<float>(nullable: false),
                    imc = table.Column<int>(nullable: false),
                    recordDate = table.Column<DateTime>(nullable: false),
                    weight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalInfoRecord", x => x.id);
                    table.ForeignKey(
                        name: "FK_PhysicalInfoRecord_ApplicationUser_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");
            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("AspNetRoleClaims");
            migrationBuilder.DropTable("AspNetUserClaims");
            migrationBuilder.DropTable("AspNetUserLogins");
            migrationBuilder.DropTable("AspNetUserRoles");
            migrationBuilder.DropTable("Food");
            migrationBuilder.DropTable("FoodCalculator");
            migrationBuilder.DropTable("PhysicalInfoRecord");
            migrationBuilder.DropTable("AspNetRoles");
            migrationBuilder.DropTable("AspNetUsers");
        }
    }
}
