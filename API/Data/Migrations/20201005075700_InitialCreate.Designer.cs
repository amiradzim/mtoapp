﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201005075700_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("API.Entities.MtoEntries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BaseWeight")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CostElement")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<long>("Diameter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DwgCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("DwgNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MatGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("MatType")
                        .HasColumnType("TEXT");

                    b.Property<string>("MatVariant")
                        .HasColumnType("TEXT");

                    b.Property<long>("Nal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlatNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProcMethod")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubCostElement")
                        .HasColumnType("TEXT");

                    b.Property<long>("SurfaceArea")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Thickness")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UnitWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("API.Entities.MtoUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
