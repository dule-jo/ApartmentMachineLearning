﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ScrapingApartments.Data.Provider;

namespace ScrapingApartments.Migrations
{
    [DbContext(typeof(ApartmentContext))]
    [Migration("20210706212349_DistanceMigration")]
    partial class DistanceMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ScrapingApartments.Model.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ActionType")
                        .HasColumnType("integer")
                        .HasColumnName("action_type");

                    b.Property<double?>("ApartmentArea")
                        .HasColumnType("double precision")
                        .HasColumnName("apartment_area");

                    b.Property<int>("ApartmentType")
                        .HasColumnType("integer")
                        .HasColumnName("apartment_type");

                    b.Property<bool>("Balcony")
                        .HasColumnType("boolean")
                        .HasColumnName("balcony");

                    b.Property<string>("City")
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<double>("DistanceFromCentre")
                        .HasColumnType("double precision")
                        .HasColumnName("distance_from_centre");

                    b.Property<bool>("Elevator")
                        .HasColumnType("boolean")
                        .HasColumnName("elevator");

                    b.Property<string>("HeatType")
                        .HasColumnType("text")
                        .HasColumnName("heat_type");

                    b.Property<string>("Link")
                        .HasColumnType("text")
                        .HasColumnName("link");

                    b.Property<string>("Location")
                        .HasColumnType("text")
                        .HasColumnName("location");

                    b.Property<bool>("Loggia")
                        .HasColumnType("boolean")
                        .HasColumnName("loggia");

                    b.Property<string>("MicroLocation")
                        .HasColumnType("text")
                        .HasColumnName("micro_location");

                    b.Property<bool>("Parking")
                        .HasColumnType("boolean")
                        .HasColumnName("parking");

                    b.Property<double?>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<bool>("Registered")
                        .HasColumnType("boolean")
                        .HasColumnName("registered");

                    b.Property<double?>("RoomCount")
                        .HasColumnType("double precision")
                        .HasColumnName("room_count");

                    b.Property<int>("StateType")
                        .HasColumnType("integer")
                        .HasColumnName("state_type");

                    b.Property<string>("Story")
                        .HasColumnType("text")
                        .HasColumnName("story");

                    b.Property<string>("StoryTotal")
                        .HasColumnType("text")
                        .HasColumnName("story_total");

                    b.Property<bool>("Terrace")
                        .HasColumnType("boolean")
                        .HasColumnName("terrace");

                    b.Property<double?>("YardArea")
                        .HasColumnType("double precision")
                        .HasColumnName("yard_area");

                    b.Property<int>("YearType")
                        .HasColumnType("integer")
                        .HasColumnName("year_type");

                    b.HasKey("Id")
                        .HasName("pk_apartments");

                    b.ToTable("apartments");
                });
#pragma warning restore 612, 618
        }
    }
}
