﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCovid.Service.DataContext;

namespace NCovid.Service.Migrations
{
    [DbContext(typeof(CoronaDbContext))]
    [Migration("20200410151527_Update Fields")]
    partial class UpdateFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NCovid.Service.DataContext.CoronaInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("CoronaInfo","Config");
                });

            modelBuilder.Entity("NCovid.Service.DataContext.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int>("Cases")
                        .HasColumnType("int");

                    b.Property<decimal>("CasesPerOneMillion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CoronaInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Critical")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<decimal>("DeathsPerOneMillion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstCase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Recovered")
                        .HasColumnType("int");

                    b.Property<int?>("TestPerOneMillion")
                        .HasColumnType("int");

                    b.Property<int>("TodayCases")
                        .HasColumnType("int");

                    b.Property<int>("TodayDeaths")
                        .HasColumnType("int");

                    b.Property<int?>("TotalTest")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoronaInfoId");

                    b.ToTable("Country","Config");
                });

            modelBuilder.Entity("NCovid.Service.DataContext.GlobalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cases")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<int>("Recovered")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GlobalInfo","Config");
                });

            modelBuilder.Entity("NCovid.Service.DataContext.Countries", b =>
                {
                    b.HasOne("NCovid.Service.DataContext.CoronaInfo", "CoronaInfo")
                        .WithMany("Countries")
                        .HasForeignKey("CoronaInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}