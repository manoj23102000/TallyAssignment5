﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallyAssignment5.Data;

#nullable disable

namespace TallyAssignment5.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221216103954_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallyAssignment5.Models.Student", b =>
                {
                    b.Property<int>("StudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TallyAssignment5.Models.Subject", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubId"));

                    b.Property<int>("MarksObtained")
                        .HasColumnType("int");

                    b.Property<int>("MaxMarks")
                        .HasColumnType("int");

                    b.Property<int?>("StudentStudId")
                        .HasColumnType("int");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubId");

                    b.HasIndex("StudentStudId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TallyAssignment5.Models.Subject", b =>
                {
                    b.HasOne("TallyAssignment5.Models.Student", null)
                        .WithMany("Subjects")
                        .HasForeignKey("StudentStudId");
                });

            modelBuilder.Entity("TallyAssignment5.Models.Student", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
