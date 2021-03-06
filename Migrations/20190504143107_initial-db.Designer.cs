﻿// <auto-generated />
using System;
using FamilyMoneyManagerApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyMoneyManagerApp.Migrations
{
    [DbContext(typeof(FamilyMoneyManagerContext))]
    [Migration("20190504143107_initial-db")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountGroup");

                    b.Property<decimal>("Amount");

                    b.Property<int>("Currency");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("ShowOnDashboard");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.ExpenseIncome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<decimal>("Balance");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Comment");

                    b.Property<int>("Currency");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("ExpenseOrIncome");

                    b.Property<int>("TransferToAccountId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ExpenseIncomes");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl");

                    b.Property<int>("ItemType");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.ItemCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Counter");

                    b.Property<int>("ItemId");

                    b.Property<int>("ShoppingCartId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ItemCarts");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalNumberOfItems");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.ExpenseIncome", b =>
                {
                    b.HasOne("FamilyMoneyManagerApp.Models.Account", "Account")
                        .WithMany("ExpenseIncomes")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyMoneyManagerApp.Models.Category", "Category")
                        .WithMany("ExpenseIncomes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyMoneyManagerApp.Models.ItemCart", b =>
                {
                    b.HasOne("FamilyMoneyManagerApp.Models.Item", "Item")
                        .WithMany("ItemCarts")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyMoneyManagerApp.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("Items")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
