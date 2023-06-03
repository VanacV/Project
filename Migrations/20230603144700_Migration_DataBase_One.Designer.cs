﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Storage;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230603144700_Migration_DataBase_One")]
    partial class Migration_DataBase_One
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BasketFlower", b =>
                {
                    b.Property<int>("BasketsBasketId")
                        .HasColumnType("int");

                    b.Property<int>("FlowersFlowerId")
                        .HasColumnType("int");

                    b.HasKey("BasketsBasketId", "FlowersFlowerId");

                    b.HasIndex("FlowersFlowerId");

                    b.ToTable("BasketFlower");
                });

            modelBuilder.Entity("BasketProduct", b =>
                {
                    b.Property<int>("BasketsBasketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("BasketsBasketId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("BasketProduct");
                });

            modelBuilder.Entity("BasketSoftToy", b =>
                {
                    b.Property<int>("BasketsBasketId")
                        .HasColumnType("int");

                    b.Property<int>("softToysSoftToyId")
                        .HasColumnType("int");

                    b.HasKey("BasketsBasketId", "softToysSoftToyId");

                    b.HasIndex("softToysSoftToyId");

                    b.ToTable("BasketSoftToy");
                });

            modelBuilder.Entity("Project.Storage.Entity.Basket", b =>
                {
                    b.Property<int>("BasketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketId"), 1L, 1);

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BasketId");

                    b.HasIndex("UsersId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Project.Storage.Entity.Flower", b =>
                {
                    b.Property<int>("FlowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlowerId"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlowerId");

                    b.ToTable("Flowers");
                });

            modelBuilder.Entity("Project.Storage.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ShopId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Project.Storage.Entity.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Project.Storage.Entity.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Project.Storage.Entity.SoftToy", b =>
                {
                    b.Property<int>("SoftToyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SoftToyId"), 1L, 1);

                    b.Property<string>("SoftToyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoftToyId");

                    b.ToTable("SoftToys");
                });

            modelBuilder.Entity("Project.Storage.Entity.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BasketFlower", b =>
                {
                    b.HasOne("Project.Storage.Entity.Basket", null)
                        .WithMany()
                        .HasForeignKey("BasketsBasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Storage.Entity.Flower", null)
                        .WithMany()
                        .HasForeignKey("FlowersFlowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BasketProduct", b =>
                {
                    b.HasOne("Project.Storage.Entity.Basket", null)
                        .WithMany()
                        .HasForeignKey("BasketsBasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Storage.Entity.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BasketSoftToy", b =>
                {
                    b.HasOne("Project.Storage.Entity.Basket", null)
                        .WithMany()
                        .HasForeignKey("BasketsBasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Storage.Entity.SoftToy", null)
                        .WithMany()
                        .HasForeignKey("softToysSoftToyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Storage.Entity.Basket", b =>
                {
                    b.HasOne("Project.Storage.Entity.Users", "Users")
                        .WithMany("Baskets")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Project.Storage.Entity.Product", b =>
                {
                    b.HasOne("Project.Storage.Entity.Shop", "Shop")
                        .WithMany("Products")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Project.Storage.Entity.Review", b =>
                {
                    b.HasOne("Project.Storage.Entity.Users", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Storage.Entity.Shop", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Project.Storage.Entity.Users", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}