﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221021181020_mig_add_expensetime")]
    partial class mig_add_expensetime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminPassword")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("AdminPermission")
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.Property<string>("AdminUsername")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryImage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Current", b =>
                {
                    b.Property<int>("CurrentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentCity")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("CurrentImage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("CurrentMail")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("CurrentName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("CurrentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CurrentSurname")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("CurrentID");

                    b.ToTable("Currents");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("DepartmentStatus")
                        .HasColumnType("bit");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpenseDescription")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("ExpenseTime")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<decimal>("ExpenseTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ExpenseID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("ProductMark")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("ProductStatus")
                        .HasColumnType("bit");

                    b.Property<short>("ProductStock")
                        .HasColumnType("smallint");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Receipt", b =>
                {
                    b.Property<int>("ReceiptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptLineNumber")
                        .HasMaxLength(6)
                        .HasColumnType("Varchar(6)");

                    b.Property<string>("ReceiptReceiver")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("ReceiptSerialNumber")
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.Property<string>("ReceiptSupplier")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("ReceiptTaxAuthority")
                        .HasMaxLength(60)
                        .HasColumnType("Varchar(60)");

                    b.Property<string>("ReceiptTime")
                        .HasMaxLength(5)
                        .HasColumnType("char(5)");

                    b.Property<decimal>("ReceiptTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ReceiptID");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ReceiptDetail", b =>
                {
                    b.Property<int>("ReceiptDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReceiptDetailsAmount")
                        .HasColumnType("int");

                    b.Property<string>("ReceiptDetailsDescription")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal>("ReceiptDetailsTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ReceiptDetailsUnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ReceiptID")
                        .HasColumnType("int");

                    b.HasKey("ReceiptDetailsId");

                    b.HasIndex("ReceiptID");

                    b.ToTable("ReceiptDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SalesMovement", b =>
                {
                    b.Property<int>("SalesMovementsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesMovementsDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalesMovementsPrice")
                        .HasColumnType("int");

                    b.Property<int>("SalesMovementsTotal")
                        .HasColumnType("int");

                    b.Property<int>("SalesMovementsUnit")
                        .HasColumnType("int");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("SalesMovementsID");

                    b.HasIndex("CurrentID");

                    b.HasIndex("ProductID");

                    b.HasIndex("StaffID");

                    b.ToTable("SalesMovements");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("StaffImage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("StaffMail")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("StaffName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<bool>("StaffStatus")
                        .HasColumnType("bit");

                    b.Property<string>("StaffSurname")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("StaffID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ReceiptDetail", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Receipt", "Receipt")
                        .WithMany("ReceiptDetails")
                        .HasForeignKey("ReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SalesMovement", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Current", "Current")
                        .WithMany("SalesMovements")
                        .HasForeignKey("CurrentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany("SalesMovements")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Staff", "Staff")
                        .WithMany("SalesMovements")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Current");

                    b.Navigation("Product");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Staff", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Current", b =>
                {
                    b.Navigation("SalesMovements");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Department", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Navigation("SalesMovements");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Receipt", b =>
                {
                    b.Navigation("ReceiptDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Staff", b =>
                {
                    b.Navigation("SalesMovements");
                });
#pragma warning restore 612, 618
        }
    }
}
