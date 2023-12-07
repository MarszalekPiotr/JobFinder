﻿// <auto-generated />
using System;
using JobFinder.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobFinder.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231207185511_Database_Structure")]
    partial class Database_Structure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JobFinder.Domain.Entities.ApplicationForJob", b =>
                {
                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CvFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("JobId", "ApplicantId");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLogoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("MaxSalary")
                        .HasColumnType("float");

                    b.Property<double>("MinSalary")
                        .HasColumnType("float");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs", (string)null);
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.JobSkill", b =>
                {
                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("JobId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("JobSkills");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("X")
                        .HasColumnType("float");

                    b.Property<double>("Y")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.NormalUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("NormalUsers");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NormalUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.HasIndex("NormalUserId")
                        .IsUnique()
                        .HasFilter("[NormalUserId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobLocation", b =>
                {
                    b.Property<Guid>("JobsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("JobsId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("JobLocation");
                });

            modelBuilder.Entity("NormalUserSkill", b =>
                {
                    b.Property<Guid>("NormalUsersUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("NormalUsersUserId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("NormalUserSkill");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.ApplicationForJob", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.User", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Domain.Entities.Job", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Job", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.Category", "Category")
                        .WithMany("Jobs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Domain.Entities.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.JobSkill", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Domain.Entities.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Location", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.Company", "Company")
                        .WithMany("Locations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.User", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.Company", "Company")
                        .WithOne("User")
                        .HasForeignKey("JobFinder.Domain.Entities.User", "CompanyId");

                    b.HasOne("JobFinder.Domain.Entities.NormalUser", "NormalUser")
                        .WithOne("User")
                        .HasForeignKey("JobFinder.Domain.Entities.User", "NormalUserId");

                    b.Navigation("Company");

                    b.Navigation("NormalUser");
                });

            modelBuilder.Entity("JobLocation", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Domain.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NormalUserSkill", b =>
                {
                    b.HasOne("JobFinder.Domain.Entities.NormalUser", null)
                        .WithMany()
                        .HasForeignKey("NormalUsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobFinder.Domain.Entities.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Category", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Company", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Locations");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.Job", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("JobFinder.Domain.Entities.NormalUser", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
