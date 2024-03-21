﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSystem.DAL.Data.Context;

#nullable disable

namespace TicketSystem.DAL.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20240319160117_Developer")]
    partial class Developer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepartmentDeveloper", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("DevelopersId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "DevelopersId");

                    b.HasIndex("DevelopersId");

                    b.ToTable("DepartmentDeveloper");
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Operations"
                        });
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Islam"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Amin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rahaf"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ali"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Nassar"
                        });
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 4, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5726),
                            DepartmentId = 3,
                            Email = "user1@example.com",
                            IsClosed = false,
                            Severity = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 9, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5790),
                            DepartmentId = 2,
                            Email = "user2@example.com",
                            IsClosed = true,
                            Severity = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 3, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5793),
                            DepartmentId = 1,
                            Email = "user3@example.com",
                            IsClosed = false,
                            Severity = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 8, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5796),
                            DepartmentId = 3,
                            Email = "user4@example.com",
                            IsClosed = false,
                            Severity = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 5, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5798),
                            DepartmentId = 2,
                            Email = "user5@example.com",
                            IsClosed = true,
                            Severity = 0
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 3, 12, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5802),
                            DepartmentId = 1,
                            Email = "user6@example.com",
                            IsClosed = true,
                            Severity = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 3, 15, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5804),
                            DepartmentId = 5,
                            Email = "user7@example.com",
                            IsClosed = true,
                            Severity = 0
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 3, 7, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5806),
                            DepartmentId = 2,
                            Email = "user8@example.com",
                            IsClosed = false,
                            Severity = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 3, 6, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5809),
                            DepartmentId = 4,
                            Email = "user9@example.com",
                            IsClosed = false,
                            Severity = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 3, 10, 18, 1, 17, 274, DateTimeKind.Local).AddTicks(5812),
                            DepartmentId = 3,
                            Email = "user10@example.com",
                            IsClosed = true,
                            Severity = 2
                        });
                });

            modelBuilder.Entity("DepartmentDeveloper", b =>
                {
                    b.HasOne("TicketSystem.DAL.Data.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSystem.DAL.Data.Models.Developer", null)
                        .WithMany()
                        .HasForeignKey("DevelopersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Ticket", b =>
                {
                    b.HasOne("TicketSystem.DAL.Data.Models.Department", "Department")
                        .WithMany("Tickets")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TicketSystem.DAL.Data.Models.Department", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
