﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCovid.Service.DataContext;

namespace NCovid.Service.Migrations
{
    [DbContext(typeof(CoronaDbContext))]
    [Migration("20200328103533_Add FirstCase Column")]
    partial class AddFirstCaseColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("NCovid.Service.DataContext.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cases")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CasesPerOneMillion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("Critical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deaths")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DeathsPerOneMillion")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstCase")
                        .HasColumnType("TEXT");

                    b.Property<int>("Recovered")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TodayCases")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TodayDeaths")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Country","Config");
                });

            modelBuilder.Entity("NCovid.Service.DataContext.GlobalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cases")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deaths")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Recovered")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("GlobalInfo","Config");
                });
#pragma warning restore 612, 618
        }
    }
}
