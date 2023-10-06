﻿// <auto-generated />
using System;
using LocalDBWebApiUsingEF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DBManager))]
    partial class DBManagerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.Admin", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionID")
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Username = "admin",
                            Address = "Sydney",
                            Email = "email0@gmail.com",
                            Name = "Admin User",
                            Password = "adminpassword",
                            Phone = "000-000-0000",
                            Picture = "/resources/images/man1.jpg"
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.Property<int>("AccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountHolderName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("UserUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNumber");

                    b.HasIndex("UserUsername");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            AccountNumber = 10001,
                            AccountHolderName = "Sajib's Account",
                            Balance = 5000.5,
                            UserUsername = "sajib"
                        },
                        new
                        {
                            AccountNumber = 10002,
                            AccountHolderName = "Mistry's Account",
                            Balance = 2500.75,
                            UserUsername = "mistry"
                        },
                        new
                        {
                            AccountNumber = 10003,
                            AccountHolderName = "Mike's Account",
                            Balance = 12000.0,
                            UserUsername = "mike"
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int?>("BankAccountAccountNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FromAccountNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("ToAccountNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransactionId");

                    b.HasIndex("BankAccountAccountNumber");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionID")
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "sajib",
                            Address = "Bently",
                            Email = "email1@gmail.com",
                            Name = "Sajib",
                            Password = "mypassword1",
                            Phone = "111-111-1111",
                            Picture = "/resources/images/man1.jpg"
                        },
                        new
                        {
                            Username = "mistry",
                            Address = "Victoria Park",
                            Email = "email2@gmail.com",
                            Name = "Mistry",
                            Password = "mypassword",
                            Phone = "222-222-2222",
                            Picture = "/resources/images/man1.jpg"
                        },
                        new
                        {
                            Username = "mike",
                            Address = "Northbridge",
                            Email = "email3@gmail.com",
                            Name = "Mike",
                            Password = "mypassword3",
                            Phone = "333-333-3333",
                            Picture = "/resources/images/man1.jpg"
                        });
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.HasOne("LocalDBWebApiUsingEF.Models.User", "User")
                        .WithMany("BankAccounts")
                        .HasForeignKey("UserUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.Transaction", b =>
                {
                    b.HasOne("LocalDBWebApiUsingEF.Models.BankAccount", "BankAccount")
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountAccountNumber")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("BankAccount");
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.BankAccount", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("LocalDBWebApiUsingEF.Models.User", b =>
                {
                    b.Navigation("BankAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
