using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160615220629_FoodCalculators")]
    partial class FoodCalculators
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("WebApplication4.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<int>("age");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("sex")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("WebApplication4.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Alpha_Carot_microg");

                    b.Property<float>("Ash_g");

                    b.Property<float>("Beta_Carot_microg");

                    b.Property<float>("Beta_Crypt_microg");

                    b.Property<float>("Calcium_mg");

                    b.Property<float>("Carbohydrt_g");

                    b.Property<float>("Cholestrl_mg");

                    b.Property<float>("Choline_Tot_mg");

                    b.Property<float>("Copper_mg");

                    b.Property<float>("Energy_kcal");

                    b.Property<float>("FA_Mono_g");

                    b.Property<float>("FA_Poly_g");

                    b.Property<float>("FA_Sat_g");

                    b.Property<float>("Fiber_TD_g");

                    b.Property<float>("Folate_DFE_microg");

                    b.Property<float>("Folate_Tot_microg");

                    b.Property<float>("Folic_Acid_microg");

                    b.Property<float>("Food_Folate_microg");

                    b.Property<float>("GmWt_1");

                    b.Property<float>("GmWt_2");

                    b.Property<string>("GmWt_Desc1");

                    b.Property<string>("GmWt_Desc2");

                    b.Property<float>("Iron_mg");

                    b.Property<float>("Lipid_Tot_g");

                    b.Property<float>("Lut_Zea_microg");

                    b.Property<float>("Lycopene_microg");

                    b.Property<float>("Magnesium_mg");

                    b.Property<float>("Manganese_mg");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("Niacin_mg");

                    b.Property<float>("Panto_Acid_mg");

                    b.Property<float>("Phosphorus_mg");

                    b.Property<float>("Potassium_mg");

                    b.Property<float>("Protein_g");

                    b.Property<float>("Refuse_Pct");

                    b.Property<float>("Retinol_microg");

                    b.Property<float>("Riboflavin_mg");

                    b.Property<float>("Selenium_microg");

                    b.Property<float>("Sodium_mg");

                    b.Property<float>("Sugar_Tot_g");

                    b.Property<float>("Thiamin_mg");

                    b.Property<float>("Vit_A_IU");

                    b.Property<float>("Vit_A_RAE");

                    b.Property<float>("Vit_B12_microg");

                    b.Property<float>("Vit_B6_mg");

                    b.Property<float>("Vit_C_mg");

                    b.Property<float>("Vit_D_IU");

                    b.Property<float>("Vit_D_microg");

                    b.Property<float>("Vit_E_mg");

                    b.Property<float>("Vit_K_microg");

                    b.Property<float>("Water_g");

                    b.Property<float>("Zinc_mg");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebApplication4.Models.FoodCalculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<string>("FoodName")
                        .IsRequired();

                    b.Property<int>("FoodQuantity");

                    b.Property<int>("Grams");

                    b.Property<int>("Lipid");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebApplication4.Models.PhysicalInfoRecord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OwnerId");

                    b.Property<float>("height");

                    b.Property<int>("imc");

                    b.Property<DateTime>("recordDate");

                    b.Property<float>("weight");

                    b.HasKey("id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplication4.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplication4.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("WebApplication4.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebApplication4.Models.PhysicalInfoRecord", b =>
                {
                    b.HasOne("WebApplication4.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });
        }
    }
}
