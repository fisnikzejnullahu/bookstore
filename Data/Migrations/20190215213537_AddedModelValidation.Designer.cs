﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190215213537_AddedModelValidation")]
    partial class AddedModelValidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStore.Models.Books.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<Guid>("CategorySubjectId");

                    b.Property<string>("Description");

                    b.Property<string>("Isbn");

                    b.Property<double>("Price");

                    b.Property<DateTime>("PublishedDate");

                    b.Property<string>("Thumbnail");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategorySubjectId");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasFilter("[Isbn] IS NOT NULL");

                    b.ToTable("Books");

                    b.HasData(
                        new { Id = new Guid("21efdd09-5380-473d-bb3b-1b7250f7f332"), Active = true, Author = "Matt Frisbie", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-36644-7", Price = 38.5, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "professionaljs.jpg", Title = "Professional JavaScript for Web Developers, 4th Edition" },
                        new { Id = new Guid("cc332242-e605-4e07-9dd3-9af51a466f65"), Active = true, Author = "T. J. Crowder", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-36795-6", Price = 25.7, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "jsnewtoys.jpg", Title = "JavaScript: The New Toys" },
                        new { Id = new Guid("04f904f1-0a94-4c5e-9228-f4d989f8a065"), Active = true, Author = "Ivor Horton", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-118-17341-1", Price = 30.99, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "java.jpg", Title = "Ivor Horton's Beginning Java, Java 7 Edition" },
                        new { Id = new Guid("2e27e2eb-63da-4f2e-b6e1-a7939a10b8b6"), Active = true, Author = "Christian Nagel", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-44926-3", Price = 38.99, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "c7.jpg", Title = "Professional C# 7 and .NET Core 2.0" },
                        new { Id = new Guid("576b1d91-c3ae-4b05-ae55-33df30891418"), Active = true, Author = "Jon Duckett", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-118-20691-1", Price = 19.99, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "htmlcss.jpg", Title = "HTML and CSS: Design and Build Websites" },
                        new { Id = new Guid("4eb1513f-3f89-4a97-8703-2570b62e1235"), Active = true, Author = "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-3-527-71520-6", Price = 25.5, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "3527715207.jpg", Title = "Mathematik fur Informatiker fur Dummies" },
                        new { Id = new Guid("c9cf18c1-adab-44f4-b1fc-5903766298c7"), Active = true, Author = "Ute Schmid, Michael Siebers, Katharina Weitz", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-3-527-71573-2", Price = 12.5, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "3527715738.jpg", Title = "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                        new { Id = new Guid("0ebc245a-5aa8-440a-a2d2-a9684da580ad"), Active = true, Author = "Frank Geisler, Benjamin Kettner", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-3-527-71607-4", Price = 25.5, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "no_image_available.jpg", Title = "Docker fur Dummies" },
                        new { Id = new Guid("30201dcd-3c5f-4653-84cb-2591177fd85d"), Active = true, Author = "Eric T. Jones, Eric Butow", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-56502-4", Price = 21.4, PublishedDate = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "1119565022.jpg", Title = "Programming Interviews For Dummies" },
                        new { Id = new Guid("9fa290dd-46d0-4079-a910-35e4dbf89c1c"), Active = true, Author = "Sarah Guthals", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-57267-1", Price = 25.7, PublishedDate = new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "1119572673.jpg", Title = "GitHub For Dummies" },
                        new { Id = new Guid("97b26ae1-7c9a-4627-b8f2-af1a8ecbe948"), Active = true, Author = "Alissa Knight", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-49180-4", Price = 42.8, PublishedDate = new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "1119491800.jpg", Title = "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                        new { Id = new Guid("6fc735c2-41c8-46e0-9a8b-4d79ddb5c68b"), Active = true, Author = "Perry Carpenter", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-56634-2", Price = 25.7, PublishedDate = new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "1119566347.jpg", Title = "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                        new { Id = new Guid("6db228c0-5633-42f4-98a5-b1d883ed80b4"), Active = true, Author = "Marco L. Napoli", CategorySubjectId = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", Isbn = "978-1-119-55082-2", Price = 34.2, PublishedDate = new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "1119550823.jpg", Title = "Beginning Flutter: A Hands On Guide To App Development" },
                        new { Id = new Guid("f7e939ce-e57e-4ca0-8b42-21b3471a1604"), Active = true, Author = "Shirley Carlon, Rosina McAlpine, Chrisann Lee, Lorena Mitrione, Ngaire Kirk, Lily Wong", CategorySubjectId = new Guid("800f186c-2477-47e7-95b8-d4a780793b56"), Description = "Financial Accounting, 6th Edition presents accounting in a cutting-edge interactive digital format designed to motivate students by taking the road blocks out of self-study and to facilitate mastery though drill-and-skill practice.", Isbn = "978-0-730-36327-9", Price = 76.3, PublishedDate = new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Thumbnail = "0730363279.jpg", Title = "Financial Accounting: Reporting, Analysis And Decision Making, 6th Edition" }
                    );
                });

            modelBuilder.Entity("BookStore.Models.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = new Guid("0c2719bc-5c72-4d84-891c-909ceeefe4f2"), Name = "Computing" },
                        new { Id = new Guid("296f7b59-3f33-4fe4-8162-04604ff28572"), Name = "Business & Management" }
                    );
                });

            modelBuilder.Entity("BookStore.Models.CategorySubjects.CategorySubject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategorySubjects");

                    b.HasData(
                        new { Id = new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), CategoryId = new Guid("0c2719bc-5c72-4d84-891c-909ceeefe4f2"), Name = "General & Introductory Computer Science" },
                        new { Id = new Guid("800f186c-2477-47e7-95b8-d4a780793b56"), CategoryId = new Guid("296f7b59-3f33-4fe4-8162-04604ff28572"), Name = "Accounting" }
                    );
                });

            modelBuilder.Entity("BookStore.Models.Comments.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BookId");

                    b.Property<string>("CreatedByUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BookStore.Models.Comments.CommentHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CommentId");

                    b.Property<DateTime>("EditedTime");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("CommentHistories");
                });

            modelBuilder.Entity("BookStore.Models.Comments.CommentUser", b =>
                {
                    b.Property<Guid>("CommentId");

                    b.Property<string>("UserId");

                    b.HasKey("CommentId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentUser");
                });

            modelBuilder.Entity("BookStore.Models.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BookStore.Models.OrdersBooks.OrderBook", b =>
                {
                    b.Property<Guid>("BookId");

                    b.Property<Guid>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("BookId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrdersBooks");
                });

            modelBuilder.Entity("BookStore.Models.Rates.Rate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BookId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<byte>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "78BB9A69-D214-40A3-B9BD-0344B851D76B", AccessFailedCount = 0, ConcurrencyStamp = "5ec38cd9-a9db-4743-b018-adf360838379", Email = "fisnikz@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "fisnikz@gmail.com", NormalizedUserName = "fisnikz@gmail.com", PasswordHash = "AQAAAAEAACcQAAAAEKNtPRiMAKtbIbR5ccMr7EzGaQaoy1aa1x1yhn13nk9/JgRSE1Z0IHaLKmpg/3ZNqQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "fisnikz@gmail.com" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BookStore.Models.Books.Book", b =>
                {
                    b.HasOne("BookStore.Models.CategorySubjects.CategorySubject", "CategorySubject")
                        .WithMany("Books")
                        .HasForeignKey("CategorySubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.CategorySubjects.CategorySubject", b =>
                {
                    b.HasOne("BookStore.Models.Categories.Category", "Category")
                        .WithMany("Subjects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.Comments.Comment", b =>
                {
                    b.HasOne("BookStore.Models.Books.Book", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");
                });

            modelBuilder.Entity("BookStore.Models.Comments.CommentHistory", b =>
                {
                    b.HasOne("BookStore.Models.Comments.Comment", "Comment")
                        .WithMany("CommentHistory")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.Comments.CommentUser", b =>
                {
                    b.HasOne("BookStore.Models.Comments.Comment", "Comment")
                        .WithMany("CommentUsers")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.Orders.Order", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.OrdersBooks.OrderBook", b =>
                {
                    b.HasOne("BookStore.Models.Books.Book", "Book")
                        .WithMany("OrderBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookStore.Models.Orders.Order", "Order")
                        .WithMany("OrderBook")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStore.Models.Rates.Rate", b =>
                {
                    b.HasOne("BookStore.Models.Books.Book", "Book")
                        .WithMany("Rates")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
