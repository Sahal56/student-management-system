﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Students.API.Models;

#nullable disable

namespace Students.API.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Students.API.Models.Student", b =>
                {
                    b.Property<long>("s_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("s_id"));

                    b.Property<int>("s_age")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("s_birth")
                        .HasColumnType("date");

                    b.Property<string>("s_c_num")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("s_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("s_id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}