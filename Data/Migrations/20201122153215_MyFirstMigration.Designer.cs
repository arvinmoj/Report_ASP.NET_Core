﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201122153215_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.GetData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(150);

                    b.Property<string>("ContractCount")
                        .HasMaxLength(150);

                    b.Property<string>("ContractNumber")
                        .HasMaxLength(150);

                    b.Property<string>("Count")
                        .HasMaxLength(150);

                    b.Property<string>("Date")
                        .HasMaxLength(150);

                    b.Property<string>("Discount")
                        .HasMaxLength(150);

                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.Property<string>("NetSales")
                        .HasMaxLength(150);

                    b.Property<string>("NoContractCount")
                        .HasMaxLength(150);

                    b.Property<string>("PerSale")
                        .HasMaxLength(150);

                    b.Property<string>("ReceivedMoney")
                        .HasMaxLength(150);

                    b.Property<string>("RefundAmount")
                        .HasMaxLength(150);

                    b.Property<string>("ReturnedCount")
                        .HasMaxLength(150);

                    b.Property<string>("SalesTax")
                        .HasMaxLength(150);

                    b.Property<string>("YearSeason")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("GetData");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
