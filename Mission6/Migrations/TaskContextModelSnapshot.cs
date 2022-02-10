﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6.Models;

namespace Mission6.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("CategoryTable");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission6.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TaskTable");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryId = 1,
                            Completed = false,
                            Quadrant = 2,
                            TaskName = "Mow the lawn."
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryId = 4,
                            Completed = false,
                            Quadrant = 1,
                            TaskName = "Go to church."
                        });
                });

            modelBuilder.Entity("Mission6.Models.Task", b =>
                {
                    b.HasOne("Mission6.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
