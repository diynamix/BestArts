﻿// <auto-generated />
using System;
using BestArts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BestArts.Data.Migrations
{
    [DbContext(typeof(BestArtsDbContext))]
    partial class BestArtsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int")
                        .HasComment("Payment method");

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

                    b.Property<bool>("TermsAccepted")
                        .HasColumnType("bit")
                        .HasComment("Are terms accepted");

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

                    b.HasIndex("ProductId");

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
                            Id = new Guid("926ae463-d919-4d14-87b9-cf0cdb36065d"),
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
                            Id = new Guid("264f1211-ee6a-4710-8667-5127faa47722"),
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
                            Id = new Guid("0763a788-42a8-4c0e-a6cd-b2b21132332a"),
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
                            Id = new Guid("2342bf0b-2425-43b6-a3fa-22bdb7e33901"),
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
                            Id = new Guid("64830aa0-6018-49c0-ba3d-c2f02bf9ab28"),
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
                            Id = new Guid("8722ec90-01cd-4512-825f-676a5d23762e"),
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
                            Id = new Guid("9bbd5116-48c5-4773-84a1-ee0ff71eec3d"),
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
                            Id = new Guid("359bf59a-c0d1-48d6-ad3d-26bdc6919a80"),
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
                            Id = new Guid("b5186923-68c4-4bb1-9541-079e1096b393"),
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
                            Id = new Guid("a414f484-144e-4393-992f-2f389ee81b35"),
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
                            Id = new Guid("a6799b2a-2ad7-4922-80c3-d82a82eb3b6c"),
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
                            Id = new Guid("19ce3752-0ee5-4739-90c4-cb9f58fc0639"),
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
                            Id = new Guid("cccbc47e-ffdb-4f0f-bd8c-ec052007a2eb"),
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
                            Id = new Guid("6ebed377-5c76-4150-838d-f4ad1f691773"),
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
                            Id = new Guid("385443bb-30b6-4f13-8506-173b7109301d"),
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
                            Id = new Guid("9063b981-4c52-4d6b-a5aa-d768f880afb2"),
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
                            Id = new Guid("07eb04da-d51f-41a9-8d35-268c3e02db01"),
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
                            Id = new Guid("49486bad-d45b-4b37-814a-69229fdf0ca0"),
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
                            Id = new Guid("1a66b48f-4832-4635-bdee-d6ac2334cf9e"),
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
                            Id = new Guid("897447d8-01bc-4683-90fe-f7a7c194a770"),
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

                    b.HasOne("BestArts.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
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
