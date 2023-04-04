﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebLearning.Persistence.ApplicationContext;

#nullable disable

namespace WebLearning.Persistence.Migrations
{
    [DbContext(typeof(WebLearningContext))]
    [Migration("20221123072429_Add23112022")]
    partial class Add23112022
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebLearning.Domain.Entites.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("AuthorizeRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHased")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AccountDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("AccountDetail", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AnswerCourse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("OwnAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QuestionCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuizCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionCourseId");

                    b.ToTable("AnswerCourse", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AnswerLession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("OwnAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QuestionLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuizLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuestionLessionId");

                    b.ToTable("AnswerLession", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompletedTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.CourseImageVideo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseImageVideo", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.HistorySubmitFinal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCompoleted")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuizCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Submit")
                        .HasColumnType("bit");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorySubmitFinal", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.HistorySubmitLession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCompoleted")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuizLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Submit")
                        .HasColumnType("bit");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HistorySubmitLession", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Lession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompletedTime")
                        .HasColumnType("int");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lession", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.LessionVideoImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<Guid>("LessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LessionId");

                    b.ToTable("LessionVideoImage", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.OtherFileUpload", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("OtherFileUpload", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuestionFinal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<Guid>("QuizCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuizCourseId");

                    b.ToTable("QuestionFinal", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuestionLession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<Guid>("QuizLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("QuizLessionId");

                    b.ToTable("QuestionLession", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizCourse", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HistorySubmitFinalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ReportUserScoreFinalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScorePass")
                        .HasColumnType("int");

                    b.Property<int>("TimeToDo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.HasIndex("HistorySubmitFinalId");

                    b.HasIndex("ReportUserScoreFinalId");

                    b.ToTable("QuizCourse", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizLession", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HistorySubmitLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ReportUserScoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScorePass")
                        .HasColumnType("int");

                    b.Property<int>("TimeToDo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HistorySubmitLessionId");

                    b.HasIndex("LessionId");

                    b.HasIndex("ReportUserScoreId");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("JwtId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RefreshToken", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.ReportUserScore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuizLessionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportUserScore", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.ReportUserScoreFinal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuizCourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalScore")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportUserScoreFinal", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Account", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AccountDetail", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Account", "Account")
                        .WithOne("AccountDetail")
                        .HasForeignKey("WebLearning.Domain.Entites.AccountDetail", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AnswerCourse", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.QuestionFinal", "QuestionFinal")
                        .WithMany()
                        .HasForeignKey("QuestionCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionFinal");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.AnswerLession", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.QuestionLession", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionLessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Course", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Role", "Role")
                        .WithMany("Courses")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.CourseImageVideo", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Course", "Course")
                        .WithMany("CourseImageVideo")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Lession", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Course", "Courses")
                        .WithMany("Lessions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.LessionVideoImage", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Lession", "Lession")
                        .WithMany("LessionVideoImages")
                        .HasForeignKey("LessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lession");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.OtherFileUpload", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Course", "Course")
                        .WithMany("OtherFileUploads")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuestionFinal", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.QuizCourse", "QuizCourse")
                        .WithMany("QuestionFinals")
                        .HasForeignKey("QuizCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuizCourse");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuestionLession", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.QuizLession", "QuizLession")
                        .WithMany("QuestionLessions")
                        .HasForeignKey("QuizLessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuizLession");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizCourse", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLearning.Domain.Entites.HistorySubmitFinal", null)
                        .WithMany("QuizCourses")
                        .HasForeignKey("HistorySubmitFinalId");

                    b.HasOne("WebLearning.Domain.Entites.ReportUserScoreFinal", null)
                        .WithMany("QuizCourses")
                        .HasForeignKey("ReportUserScoreFinalId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizLession", b =>
                {
                    b.HasOne("WebLearning.Domain.Entites.HistorySubmitLession", null)
                        .WithMany("QuizLessions")
                        .HasForeignKey("HistorySubmitLessionId");

                    b.HasOne("WebLearning.Domain.Entites.Lession", "Lession")
                        .WithMany("Quizzes")
                        .HasForeignKey("LessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLearning.Domain.Entites.ReportUserScore", null)
                        .WithMany("QuizLessions")
                        .HasForeignKey("ReportUserScoreId");

                    b.Navigation("Lession");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Account", b =>
                {
                    b.Navigation("AccountDetail");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Course", b =>
                {
                    b.Navigation("CourseImageVideo");

                    b.Navigation("Lessions");

                    b.Navigation("OtherFileUploads");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.HistorySubmitFinal", b =>
                {
                    b.Navigation("QuizCourses");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.HistorySubmitLession", b =>
                {
                    b.Navigation("QuizLessions");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Lession", b =>
                {
                    b.Navigation("LessionVideoImages");

                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizCourse", b =>
                {
                    b.Navigation("QuestionFinals");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.QuizLession", b =>
                {
                    b.Navigation("QuestionLessions");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.ReportUserScore", b =>
                {
                    b.Navigation("QuizLessions");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.ReportUserScoreFinal", b =>
                {
                    b.Navigation("QuizCourses");
                });

            modelBuilder.Entity("WebLearning.Domain.Entites.Role", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
