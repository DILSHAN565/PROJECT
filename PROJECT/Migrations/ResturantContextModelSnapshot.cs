﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJECT.Models;

#nullable disable

namespace PROJECT.Migrations
{
    [DbContext(typeof(ResturantContext))]
    partial class ResturantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PROJECT.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<int>("CustomerNIC")
                        .HasColumnType("int");

                    b.Property<string>("Customeraddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Customercontactno")
                        .HasColumnType("int");

                    b.Property<string>("Customername")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PROJECT.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<DateTime>("EmpDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Empaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Empcontactno")
                        .HasColumnType("int");

                    b.Property<string>("Empdesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empemail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PROJECT.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<int?>("EmpID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Menuimg")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Menuname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Menuprice")
                        .HasColumnType("int");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("PROJECT.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Orderdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Orderprice")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PROJECT.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Paymentdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Paymenttime")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
