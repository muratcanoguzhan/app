﻿// <auto-generated />
using Hahn.ApplicatonProcess.December2020.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hahn.ApplicatonProcess.December2020.Data.Migrations
{
    [DbContext(typeof(HahnContext))]
    [Migration("20210102223629_initial_Migration")]
    partial class initial_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Hahn.ApplicatonProcess.December2020.Domain.Models.Applicant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Applicant");
                });
#pragma warning restore 612, 618
        }
    }
}
