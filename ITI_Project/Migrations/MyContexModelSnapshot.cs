﻿// <auto-generated />
using System;
using ITI_Project.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITI_Project.Migrations
{
    [DbContext(typeof(MyContex))]
    partial class MyContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ITI_Project.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.HasIndex("DeptId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ITI_Project.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ITI_Project.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.HasKey("InstructorId");

                    b.HasIndex("CourseId");

                    b.HasIndex("Deptid");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ITI_Project.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("grade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Deptid");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("ITI_Project.Models.Trainee_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.Property<int?>("degree")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "TraineeId");

                    b.HasIndex("TraineeId");

                    b.ToTable("Trainee_Courses");
                });

            modelBuilder.Entity("ITI_Project.Models.Course", b =>
                {
                    b.HasOne("ITI_Project.Models.Department", "Department")
                        .WithMany("CourseList")
                        .HasForeignKey("DeptId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project.Models.Instructor", b =>
                {
                    b.HasOne("ITI_Project.Models.Course", "Course")
                        .WithMany("Instructorlist")
                        .HasForeignKey("CourseId");

                    b.HasOne("ITI_Project.Models.Department", "Department")
                        .WithMany("InstructorList")
                        .HasForeignKey("Deptid");

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project.Models.Trainee", b =>
                {
                    b.HasOne("ITI_Project.Models.Department", "Department")
                        .WithMany("TraineeList")
                        .HasForeignKey("Deptid");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project.Models.Trainee_Course", b =>
                {
                    b.HasOne("ITI_Project.Models.Course", "course")
                        .WithMany("Trainee_Courselist")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITI_Project.Models.Trainee", "Trainee")
                        .WithMany("Trainee_Courselist")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainee");

                    b.Navigation("course");
                });

            modelBuilder.Entity("ITI_Project.Models.Course", b =>
                {
                    b.Navigation("Instructorlist");

                    b.Navigation("Trainee_Courselist");
                });

            modelBuilder.Entity("ITI_Project.Models.Department", b =>
                {
                    b.Navigation("CourseList");

                    b.Navigation("InstructorList");

                    b.Navigation("TraineeList");
                });

            modelBuilder.Entity("ITI_Project.Models.Trainee", b =>
                {
                    b.Navigation("Trainee_Courselist");
                });
#pragma warning restore 612, 618
        }
    }
}
