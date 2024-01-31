﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionUpdate.DalLayer.Data;

#nullable disable

namespace TransactionUpdate.DalLayer.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    [Migration("20240131013138_value-added")]
    partial class valueadded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("TransactionUpdate.DalLayer.Model.TransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("DateTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Amount = 500.0,
                            DateTime = "2020-09-08'T'16:34:23Z",
                            Description = "Bank Deposit",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 10,
                            Amount = -20.0,
                            DateTime = "2020-09-08'T'09:02:23Z",
                            Description = "Transfer to James",
                            Status = "Pending"
                        },
                        new
                        {
                            Id = 9,
                            Amount = -20.0,
                            DateTime = "2020-09-07'T'21:52:23Z",
                            Description = "ATM withdrawal",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 8,
                            Amount = -15.0,
                            DateTime = "2020-09-06'T'10:32:23Z",
                            Description = "Google Subscription",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 7,
                            Amount = -2000.0,
                            DateTime = "2020-09-06'T'07:33:23Z",
                            Description = "Apple Store",
                            Status = "Cancelled"
                        },
                        new
                        {
                            Id = 6,
                            Amount = -23.760000000000002,
                            DateTime = "2020-08-23'T'17:39:23Z",
                            Description = "Mini Mart",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 5,
                            Amount = -56.43,
                            DateTime = "2020-08-16'T'21:06:23Z",
                            Description = "Mini Mart",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 4,
                            Amount = -167.78,
                            DateTime = "2020-06-15'T'18:17:23Z",
                            Description = "Country Railways",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 30.0,
                            DateTime = "2020-04-09'T'16:26:23Z",
                            Description = "Refund",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 2,
                            Amount = -30.0,
                            DateTime = "2020-04-01'T'12:47:23Z",
                            Description = "Amazon Online",
                            Status = "Completed"
                        },
                        new
                        {
                            Id = 1,
                            Amount = 500.0,
                            DateTime = "2020-03-30'T'23:53:23Z",
                            Description = "Bank Deposit",
                            Status = "Completed"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
