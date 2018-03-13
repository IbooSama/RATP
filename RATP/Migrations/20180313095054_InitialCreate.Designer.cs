﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using RATP.Models;
using System;

namespace RATP.Migrations
{
    [DbContext(typeof(MvcRATPContext))]
    [Migration("20180313095054_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RATP.Models.Line", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Directions");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("RATP.Models.Station", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<string>("LineID");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.HasKey("ID");

                    b.ToTable("Station");
                });
#pragma warning restore 612, 618
        }
    }
}
