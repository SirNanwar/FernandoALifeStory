﻿// <auto-generated />
using System;
using FernandoALifeStory.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FernandoALifeStory.Data.Migrations
{
    [DbContext(typeof(FernandoDbContext))]
    partial class FernandoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<double>("ECTs")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.DisciplineSkill", b =>
                {
                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("DisciplineId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("DisciplineSkills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Books.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Books.BookSkill", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("BookSkills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Certifications.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdquiredAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Certifications.CertificationSkill", b =>
                {
                    b.Property<int>("CertificationId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CertificationId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CertificationSkills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Courses.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoursePlatformId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoursePlatformId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Courses.CoursePlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoursePlatforms");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Courses.CourseSkill", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CourseSkills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Skills.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.WorkExperiences.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.WorkExperiences.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.WorkExperiences.WorkSkill", b =>
                {
                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("WorkId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("WorkSkills");
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.Discipline", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Academics.Degree", "Degree")
                        .WithMany("Curriculum")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.DisciplineSkill", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Academics.Discipline", "Discipline")
                        .WithMany("DisciplineSkills")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FernandoALifeStory.Data.Models.Skills.Skill", "Skill")
                        .WithMany("DisciplineSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Academics.Project", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Academics.Discipline", "Discipline")
                        .WithMany("Project")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Books.BookSkill", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Books.Book", "Book")
                        .WithMany("BookSkills")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FernandoALifeStory.Data.Models.Skills.Skill", "Skill")
                        .WithMany("BookSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Certifications.CertificationSkill", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Certifications.Certification", "Certification")
                        .WithMany("CertificationSkills")
                        .HasForeignKey("CertificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FernandoALifeStory.Data.Models.Skills.Skill", "Skill")
                        .WithMany("CertificationSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Courses.Course", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Courses.CoursePlatform", "CoursePlatform")
                        .WithMany("Courses")
                        .HasForeignKey("CoursePlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.Courses.CourseSkill", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Courses.Course", "Course")
                        .WithMany("CourseSkills")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FernandoALifeStory.Data.Models.Skills.Skill", "Skill")
                        .WithMany("CourseSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.WorkExperiences.Achievement", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.WorkExperiences.Work", "Work")
                        .WithMany("Achievements")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FernandoALifeStory.Data.Models.WorkExperiences.WorkSkill", b =>
                {
                    b.HasOne("FernandoALifeStory.Data.Models.Skills.Skill", "Skill")
                        .WithMany("WorkSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FernandoALifeStory.Data.Models.WorkExperiences.Work", "Work")
                        .WithMany("WorkSkills")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
