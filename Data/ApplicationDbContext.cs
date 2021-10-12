using System;
using BookStore.Models.Books;
using BookStore.Models.Categories;
using BookStore.Models.CategorySubjects;
using BookStore.Models.Comments;
using BookStore.Models.Orders;
using BookStore.Models.OrdersBooks;
using BookStore.Models.Rates;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrderBook>()
                .HasKey(ob => new { ob.BookId, ob.OrderId });

            builder.Entity<OrderBook>()
                .HasOne(ob => ob.Book)
                .WithMany(b => b.OrderBook)
                .HasForeignKey(ob => ob.BookId);

            builder.Entity<OrderBook>()
                .HasOne(ob => ob.Order)
                .WithMany(o => o.OrderBook)
                .HasForeignKey(ob => ob.OrderId);

            #region DataSeed

            builder.Entity<Book>()
                .HasIndex(b => b.Isbn)
                .IsUnique();

            var catId = Guid.NewGuid();
            var cat2Id = Guid.NewGuid();

            builder.Entity<Category>().HasData(new Category
            {
                Id = catId,

                Name = "Computing",
                Thumbnail = "com.jpg"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = cat2Id,
                Name = "Business & Management",
                Thumbnail = "bussmng.jpg"
            });

            var subId = Guid.NewGuid();
            var sub2Id = Guid.NewGuid();

            builder.Entity<CategorySubject>().HasData(new CategorySubject
            {
                Id = subId,
                Name = "General & Introductory Computer Science",
                CategoryId = catId
            });

            builder.Entity<CategorySubject>().HasData(new CategorySubject
            {
                Id = sub2Id,
                Name = "Accounting",
                CategoryId = cat2Id
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Professional JavaScript for Web Developers, 4th Edition",
                Author = "Matt Frisbie",
                Isbn = "978-1-119-36644-7",
                Price = 38.50,
                Thumbnail = "professionaljs.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."

            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "JavaScript: The New Toys",
                Author = "T. J. Crowder",
                Isbn = "978-1-119-36795-6",
                Price = 25.70,
                Thumbnail = "jsnewtoys.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Ivor Horton's Beginning Java, Java 7 Edition",
                Author = "Ivor Horton",
                Isbn = "978-1-118-17341-1",
                Price = 30.99,
                Thumbnail = "java.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Professional C# 7 and .NET Core 2.0",
                Author = "Christian Nagel",
                Isbn = "978-1-119-44926-3",
                Price = 38.99,
                Thumbnail = "c7.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "HTML and CSS: Design and Build Websites",
                Author = "Jon Duckett",
                Isbn = "978-1-118-20691-1",
                Price = 19.99,
                Thumbnail = "htmlcss.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Mathematik fur Informatiker fur Dummies",
                Author = "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann",
                Isbn = "978-3-527-71520-6",
                Price = 25.50,
                Thumbnail = "3527715207.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Kunstliche Intelligenz selber programmieren fur Dummies Junior",
                Author = "Ute Schmid, Michael Siebers, Katharina Weitz",
                Isbn = "978-3-527-71573-2",
                Price = 12.50,
                Thumbnail = "3527715738.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Docker fur Dummies",
                Author = "Frank Geisler, Benjamin Kettner",
                Isbn = "978-3-527-71607-4",
                Price = 25.50,
                Thumbnail = "no_image_available.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Programming Interviews For Dummies",
                Author = "Eric T. Jones, Eric Butow",
                Isbn = "978-1-119-56502-4",
                Price = 21.40,
                Thumbnail = "1119565022.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 8, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "GitHub For Dummies",
                Author = "Sarah Guthals",
                Isbn = "978-1-119-57267-1",
                Price = 25.70,
                Thumbnail = "1119572673.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 7, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Hacking Connected Cars: Tactics, Techniques, and Procedures",
                Author = "Alissa Knight",
                Isbn = "978-1-119-49180-4",
                Price = 42.80,
                Thumbnail = "1119491800.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 7, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors",
                Author = "Perry Carpenter",
                Isbn = "978-1-119-56634-2",
                Price = 25.70,
                Thumbnail = "1119566347.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 7, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Beginning Flutter: A Hands On Guide To App Development",
                Author = "Marco L. Napoli",
                Isbn = "978-1-119-55082-2",
                Price = 34.20,
                Thumbnail = "1119550823.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 7, 1),
                CategorySubjectId = subId,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."
            });

            builder.Entity<Book>().HasData(new Book
            {
                Id = Guid.NewGuid(),
                Title = "Financial Accounting: Reporting, Analysis And Decision Making, 6th Edition",
                Author = "Shirley Carlon, Rosina McAlpine, Chrisann Lee, Lorena Mitrione, Ngaire Kirk, Lily Wong",
                Isbn = "978-0-730-36327-9",
                Price = 76.30,
                Thumbnail = "0730363279.jpg",
                Active = true,
                PublishedDate = new DateTime(2018, 2, 17),
                CategorySubjectId = sub2Id,
                Description = "Financial Accounting, 6th Edition presents accounting in a cutting-edge interactive digital format designed to motivate students by taking the road blocks out of self-study and to facilitate mastery though drill-and-skill practice."
            });

            #endregion

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                UserName = "fisnikz@gmail.com",
                NormalizedUserName = "fisnikz@gmail.com",
                Email = "fisnikz@gmail.com",
                NormalizedEmail = "fisnikz@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456pw"),
                SecurityStamp = string.Empty
            });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategorySubject> CategorySubjects { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderBook> OrdersBooks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<CommentHistory> CommentHistories { get; set; }

        //        public DbSet<IdentityUserRole<string>> UserRoles { get; set; }


    }
}
