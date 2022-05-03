﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portfolio.Models;

#nullable disable

namespace portfolio.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20220503004008_settingDataBase1")]
    partial class settingDataBase1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("portfolio.Models.Admin", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("verificationCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("portfolio.Models.Certification", b =>
                {
                    b.Property<int>("certificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("certificationId"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("studyId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("certificationId");

                    b.HasIndex("studyId");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("portfolio.Models.Faculty", b =>
                {
                    b.Property<int>("facultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("facultyId"), 1L, 1);

                    b.Property<DateTime>("enroll")
                        .HasColumnType("datetime2");

                    b.Property<string>("faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("graduation")
                        .HasColumnType("datetime2");

                    b.Property<int?>("studyId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("university")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("facultyId");

                    b.HasIndex("studyId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.Property<int>("profileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("profileId"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hackerRank")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leetcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preferedNmae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studyId")
                        .HasColumnType("int");

                    b.HasKey("profileId");

                    b.HasIndex("studyId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("projectId"), 1L, 1);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("github")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("profileId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vedioPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("projectId");

                    b.HasIndex("profileId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.Property<int>("skillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("skillId"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("profileId")
                        .HasColumnType("int");

                    b.Property<int?>("projectId")
                        .HasColumnType("int");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("skillId");

                    b.HasIndex("profileId");

                    b.HasIndex("projectId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("portfolio.Models.Study", b =>
                {
                    b.Property<int>("studyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studyId"), 1L, 1);

                    b.HasKey("studyId");

                    b.ToTable("Studies");
                });

            modelBuilder.Entity("portfolio.Models.Certification", b =>
                {
                    b.HasOne("portfolio.Models.Study", null)
                        .WithMany("certifications")
                        .HasForeignKey("studyId");
                });

            modelBuilder.Entity("portfolio.Models.Faculty", b =>
                {
                    b.HasOne("portfolio.Models.Study", null)
                        .WithMany("faculties")
                        .HasForeignKey("studyId");
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.HasOne("portfolio.Models.Study", "study")
                        .WithMany()
                        .HasForeignKey("studyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("study");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.HasOne("portfolio.Models.Profile", null)
                        .WithMany("projects")
                        .HasForeignKey("profileId");
                });

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.HasOne("portfolio.Models.Profile", null)
                        .WithMany("skills")
                        .HasForeignKey("profileId");

                    b.HasOne("portfolio.Models.Project", null)
                        .WithMany("usedSkills")
                        .HasForeignKey("projectId");
                });

            modelBuilder.Entity("portfolio.Models.Profile", b =>
                {
                    b.Navigation("projects");

                    b.Navigation("skills");
                });

            modelBuilder.Entity("portfolio.Models.Project", b =>
                {
                    b.Navigation("usedSkills");
                });

            modelBuilder.Entity("portfolio.Models.Study", b =>
                {
                    b.Navigation("certifications");

                    b.Navigation("faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
