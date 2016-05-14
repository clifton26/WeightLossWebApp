using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication4.Migrations
{
    public partial class Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
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
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropTable("Food");
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
