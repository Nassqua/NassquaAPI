using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NassquaAPI.Models;

namespace NassquaAPI.Migrations
{
    [DbContext(typeof(NassquaContext))]
    [Migration("20170712202355_firstMigration24")]
    partial class firstMigration24
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NassquaAPI.Models.Cities", b =>
                {
                    b.Property<int>("CitiesId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountriesId");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("CitiesId");

                    b.HasIndex("CountriesId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("NassquaAPI.Models.Countries", b =>
                {
                    b.Property<int>("CountriesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("CountriesId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("NassquaAPI.Models.Experiences", b =>
                {
                    b.Property<int>("ExperiencesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CancelPolicy")
                        .HasMaxLength(9000);

                    b.Property<int>("CitiesId");

                    b.Property<string>("Description")
                        .HasMaxLength(9000);

                    b.Property<int>("ExperiencesTypesId");

                    b.Property<int>("HostsId");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Notes")
                        .HasMaxLength(9000);

                    b.Property<string>("Place")
                        .HasMaxLength(9000);

                    b.Property<string>("PlanDescription")
                        .HasMaxLength(9000);

                    b.HasKey("ExperiencesId");

                    b.HasIndex("CitiesId");

                    b.HasIndex("ExperiencesTypesId");

                    b.HasIndex("HostsId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("NassquaAPI.Models.ExperiencesDates", b =>
                {
                    b.Property<int>("ExperiencesDatesId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("ExperiencesId");

                    b.HasKey("ExperiencesDatesId");

                    b.HasIndex("ExperiencesId");

                    b.ToTable("ExperiencesDates");
                });

            modelBuilder.Entity("NassquaAPI.Models.ExperiencesDetails", b =>
                {
                    b.Property<int>("ExperiencesDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost")
                        .HasColumnType("Money");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<float>("Duration");

                    b.Property<int>("ExperiencesId");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("OwnersId");

                    b.Property<bool>("Required");

                    b.HasKey("ExperiencesDetailsId");

                    b.HasIndex("ExperiencesId");

                    b.ToTable("ExperiencesDetails");
                });

            modelBuilder.Entity("NassquaAPI.Models.ExperiencesTypes", b =>
                {
                    b.Property<int>("ExperiencesTypesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.HasKey("ExperiencesTypesId");

                    b.ToTable("ExperiencesTypes");
                });

            modelBuilder.Entity("NassquaAPI.Models.Hosts", b =>
                {
                    b.Property<int>("HostsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.HasKey("HostsId");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("NassquaAPI.Models.Owners", b =>
                {
                    b.Property<int>("OwnersId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.HasKey("OwnersId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("NassquaAPI.Models.Users", b =>
                {
                    b.Property<int>("UsersId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.HasKey("UsersId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NassquaAPI.Models.Cities", b =>
                {
                    b.HasOne("NassquaAPI.Models.Countries", "Countries")
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NassquaAPI.Models.Experiences", b =>
                {
                    b.HasOne("NassquaAPI.Models.Cities", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NassquaAPI.Models.ExperiencesTypes", "ExperiencesTypes")
                        .WithMany()
                        .HasForeignKey("ExperiencesTypesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NassquaAPI.Models.Hosts", "Hosts")
                        .WithMany()
                        .HasForeignKey("HostsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NassquaAPI.Models.ExperiencesDates", b =>
                {
                    b.HasOne("NassquaAPI.Models.Experiences", "Experiences")
                        .WithMany()
                        .HasForeignKey("ExperiencesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NassquaAPI.Models.ExperiencesDetails", b =>
                {
                    b.HasOne("NassquaAPI.Models.Experiences", "Experiences")
                        .WithMany()
                        .HasForeignKey("ExperiencesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
