﻿// <auto-generated />
using System;
using BestArts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BestArts.Data.Migrations
{
    [DbContext(typeof(BestArtsDbContext))]
    [Migration("20230808090202_AddedSinglePricePropertyToOrderItemEntity")]
    partial class AddedSinglePricePropertyToOrderItemEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BestArts.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("FirstName")
                        .HasComment("User first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("LastName")
                        .HasComment("User last name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("Custom application user");
                });

            modelBuilder.Entity("BestArts.Data.Models.Cart", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Product in shopping cart Id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User Id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasComment("Product quantity");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");

                    b.HasComment("Shopping cart");
                });

            modelBuilder.Entity("BestArts.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Primary key");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Category name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasComment("Categories for the products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Quilling card"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Magnet"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Quilling doll"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Quilling bottle"
                        });
                });

            modelBuilder.Entity("BestArts.Data.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Date of order");

                    b.Property<decimal>("GrandTotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Grand total price of order");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int")
                        .HasComment("Order status");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Shipping address");

                    b.Property<decimal>("ShippingPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Shipping price");

                    b.Property<decimal>("SubTotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Subtotal price");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User Id");

                    b.Property<decimal>("VAT")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("VAT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasComment("Orders");
                });

            modelBuilder.Entity("BestArts.Data.Models.OrderItem", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Order Id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Ordered product Id");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Ordered product");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasComment("Ordered product quantity");

                    b.Property<decimal>("SinglePrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Ordered product single price");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Ordered product total price");

                    b.HasKey("OrderId", "ProductId");

                    b.ToTable("OrderItems");

                    b.HasComment("Order items");
                });

            modelBuilder.Entity("BestArts.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Primary key");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Product category ID");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()")
                        .HasComment("Date and time created on");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2")
                        .HasComment("Date and time deleted on");

                    b.Property<decimal>("Height")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product height");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)")
                        .HasComment("Product image URL");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("Is the product deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Product name");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.Property<decimal>("Width")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product width");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasComment("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d56f4077-538f-4d0c-aafe-571ca8a6076e"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10m,
                            ImageUrl = "quilling-card-flower-tulip-red.jpg",
                            IsDeleted = false,
                            Name = "Tulips",
                            Price = 10m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("45f29fa3-675d-45ce-a981-763230b70638"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 7.5m,
                            ImageUrl = "quilling-card-bear-blue-small.jpg",
                            IsDeleted = false,
                            Name = "Blue Bear",
                            Price = 7m,
                            Width = 10m
                        },
                        new
                        {
                            Id = new Guid("6ae89c25-68e5-448f-82f6-73b1eb924e02"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 7.5m,
                            ImageUrl = "quilling-card-bear-red-small.jpg",
                            IsDeleted = false,
                            Name = "Red Bear",
                            Price = 7.50m,
                            Width = 10m
                        },
                        new
                        {
                            Id = new Guid("c872989e-300d-46af-8e81-69c6cf08023b"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10m,
                            ImageUrl = "quilling-card-flower-anniversary-orange.jpg",
                            IsDeleted = false,
                            Name = "Anniversary",
                            Price = 10.80m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("9d5ccc3d-f9f9-45d1-973a-0709b92950af"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10m,
                            ImageUrl = "quilling-card-flower-brown.jpg",
                            IsDeleted = false,
                            Name = "Brown flowers",
                            Price = 12m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("10cfd8b6-a189-4d32-9a19-64fd089a3970"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10m,
                            ImageUrl = "quilling-card-flower-yellow.jpg",
                            IsDeleted = false,
                            Name = "Yellow flowers",
                            Price = 10.50m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("e166a1d6-8363-4c2e-bc2b-b07bcc1a20f5"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 21m,
                            ImageUrl = "quilling-card-folding-flower-orange.jpg",
                            IsDeleted = false,
                            Name = "Anniversary",
                            Price = 17m,
                            Width = 30m
                        },
                        new
                        {
                            Id = new Guid("49ede0bd-fc16-4a8c-9764-28571fe0b90b"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10m,
                            ImageUrl = "quilling-card-snowdrop-white.jpg",
                            IsDeleted = false,
                            Name = "Whitedrops",
                            Price = 10m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("8aa11a2e-b72a-4ad3-8ce0-3822931ae9c4"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 7.5m,
                            ImageUrl = "quilling-card-violet.png",
                            IsDeleted = false,
                            Name = "Violet",
                            Price = 10m,
                            Width = 10m
                        },
                        new
                        {
                            Id = new Guid("7c47e4ca-2942-4398-90c4-3ab4d888e8ba"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 6m,
                            ImageUrl = "quilling-magnet-heart-red.jpg",
                            IsDeleted = false,
                            Name = "Heart",
                            Price = 10m,
                            Width = 7.5m
                        },
                        new
                        {
                            Id = new Guid("ad33e84f-fab8-4e4d-ad45-f86e23630606"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 4.5m,
                            ImageUrl = "quilling-magnet-basket-multi.jpg",
                            IsDeleted = false,
                            Name = "Flower basket",
                            Price = 10m,
                            Width = 6.5m
                        },
                        new
                        {
                            Id = new Guid("2d50a907-708a-4a2f-b4ba-3e4084daa089"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 4m,
                            ImageUrl = "quilling-magnet-bear-panda.jpg",
                            IsDeleted = false,
                            Name = "Panda",
                            Price = 10m,
                            Width = 6m
                        },
                        new
                        {
                            Id = new Guid("c28ddbb9-4d38-4d04-a56d-4e7b2c50677d"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 5.5m,
                            ImageUrl = "quilling-magnet-bulgarian-rose-red.jpg",
                            IsDeleted = false,
                            Name = "Bulgarian rose",
                            Price = 10m,
                            Width = 8m
                        },
                        new
                        {
                            Id = new Guid("ebc2cd10-f7c2-40ff-a8e4-ba8a4f8b0e35"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 6m,
                            ImageUrl = "quilling-magnet-dolphin-blue.jpg",
                            IsDeleted = false,
                            Name = "Dolphin",
                            Price = 10m,
                            Width = 9m
                        },
                        new
                        {
                            Id = new Guid("12dcf1b2-6b3a-45a0-b2db-6941257cbfa3"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 7m,
                            ImageUrl = "quilling-magnet-flower-circle-multi.jpg",
                            IsDeleted = false,
                            Name = "Flower",
                            Price = 10m,
                            Width = 7m
                        },
                        new
                        {
                            Id = new Guid("8b54a691-534a-4b9a-a36a-e646eb020bb2"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 13.5m,
                            ImageUrl = "quilling-card-flower-orange.png",
                            IsDeleted = false,
                            Name = "Orange flower",
                            Price = 15m,
                            Width = 13.5m
                        },
                        new
                        {
                            Id = new Guid("b7cf72b1-b4d6-4ab5-94dc-6778b16e5538"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 13.5m,
                            ImageUrl = "quilling-card-flower-wedding-beige.png",
                            IsDeleted = false,
                            Name = "Wedding",
                            Price = 15m,
                            Width = 13.5m
                        },
                        new
                        {
                            Id = new Guid("9aabd287-5c01-4f68-b0e8-85328e8100d7"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 13.5m,
                            ImageUrl = "quilling-card-baby-chair-blue.jpg",
                            IsDeleted = false,
                            Name = "Baby blue",
                            Price = 14.50m,
                            Width = 13.5m
                        },
                        new
                        {
                            Id = new Guid("df9dbf31-744c-4e6d-8591-907d197fdf26"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 7m,
                            ImageUrl = "quilling-bottle.jpg",
                            IsDeleted = false,
                            Name = "Bottle",
                            Price = 20m,
                            Width = 15m
                        },
                        new
                        {
                            Id = new Guid("044a4a8e-ed54-4457-b5dc-cd1aea42986c"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 5m,
                            ImageUrl = "quilling-doll.jpg",
                            IsDeleted = false,
                            Name = "Doll w flowers",
                            Price = 15m,
                            Width = 6m
                        });
                });

            modelBuilder.Entity("BestArts.Data.Models.Wishlist", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Product in wishlist Id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User Id");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Wishlists");

                    b.HasComment("Wishlist");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BestArts.Data.Models.Cart", b =>
                {
                    b.HasOne("BestArts.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BestArts.Data.Models.ApplicationUser", "User")
                        .WithMany("Cart")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BestArts.Data.Models.Order", b =>
                {
                    b.HasOne("BestArts.Data.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BestArts.Data.Models.OrderItem", b =>
                {
                    b.HasOne("BestArts.Data.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BestArts.Data.Models.Product", b =>
                {
                    b.HasOne("BestArts.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BestArts.Data.Models.Wishlist", b =>
                {
                    b.HasOne("BestArts.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BestArts.Data.Models.ApplicationUser", "User")
                        .WithMany("Wishlist")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BestArts.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BestArts.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BestArts.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BestArts.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BestArts.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Orders");

                    b.Navigation("Wishlist");
                });

            modelBuilder.Entity("BestArts.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BestArts.Data.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
