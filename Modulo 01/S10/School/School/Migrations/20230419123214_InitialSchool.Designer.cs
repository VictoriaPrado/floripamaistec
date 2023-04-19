﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Models;

#nullable disable

namespace School.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230419123214_InitialSchool")]
    partial class InitialSchool
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int")
                        .HasColumnName("Question_Id");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_Id");

                    b.HasKey("Id")
                        .HasName("PK__Answer");

                    b.HasIndex("QuestionId");

                    b.HasIndex("StudentId");

                    b.ToTable("Answer", (string)null);
                });

            modelBuilder.Entity("School.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameDiscipline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("Teacher_Id");

                    b.HasKey("Id")
                        .HasName("PK__Discipline");

                    b.HasIndex("TeacherId");

                    b.ToTable("Discipline", (string)null);
                });

            modelBuilder.Entity("School.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Enunciation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuizId")
                        .HasColumnType("int")
                        .HasColumnName("Quiz_Id");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id")
                        .HasName("PK__Question");

                    b.HasIndex("QuizId");

                    b.ToTable("Question", (string)null);
                });

            modelBuilder.Entity("School.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateClose")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpen")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int")
                        .HasColumnName("Discipline_Id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Quiz");

                    b.HasIndex("DisciplineId");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<int>("RA")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.HasKey("Id")
                        .HasName("PK__Student");

                    b.HasIndex("UserId");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("School.Models.Student_Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int")
                        .HasColumnName("Discipline_Id");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("Student_Id");

                    b.HasKey("Id")
                        .HasName("PK__Student_Discipline");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Discipline", (string)null);
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    b.HasKey("Id")
                        .HasName("PK__Teacher");

                    b.HasIndex("UserId");

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("School.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__User");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("School.Models.Answer", b =>
                {
                    b.HasOne("School.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .IsRequired()
                        .HasConstraintName("FK__Question_Answers");

                    b.HasOne("School.Models.Student", "Student")
                        .WithMany("Answers")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK__Student_Answers");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Models.Discipline", b =>
                {
                    b.HasOne("School.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .IsRequired()
                        .HasConstraintName("FK__Teacher_Disciplines");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("School.Models.Question", b =>
                {
                    b.HasOne("School.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .IsRequired()
                        .HasConstraintName("FK__Quiz_Questions");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("School.Models.Quiz", b =>
                {
                    b.HasOne("School.Models.Discipline", "Discipline")
                        .WithMany("Quizzes")
                        .HasForeignKey("DisciplineId")
                        .IsRequired()
                        .HasConstraintName("FK__Discipline_Quizzes");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.HasOne("School.Models.User", "User")
                        .WithMany("Students")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__User_Students");

                    b.Navigation("User");
                });

            modelBuilder.Entity("School.Models.Student_Discipline", b =>
                {
                    b.HasOne("School.Models.Discipline", "Discipline")
                        .WithMany("Students_Disciplines")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK__Discipline_Student_Discipline");

                    b.HasOne("School.Models.Student", "Student")
                        .WithMany("Students_Disciplines")
                        .HasForeignKey("StudentId")
                        .IsRequired()
                        .HasConstraintName("FK__Student_Student_Discipline");

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.HasOne("School.Models.User", "User")
                        .WithMany("Teachers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__User_Teachers");

                    b.Navigation("User");
                });

            modelBuilder.Entity("School.Models.Discipline", b =>
                {
                    b.Navigation("Quizzes");

                    b.Navigation("Students_Disciplines");
                });

            modelBuilder.Entity("School.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("School.Models.Quiz", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Students_Disciplines");
                });

            modelBuilder.Entity("School.Models.Teacher", b =>
                {
                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("School.Models.User", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
