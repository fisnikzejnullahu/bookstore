using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class BooksCreationAndSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Isbn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table
                        .PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "78BB9A69-D214-40A3-B9BD-0344B851D76B", 0, "b2f9029e-8354-4880-af0d-d349b1905e82", "fisnikz@gmail.com", true, false, null, "fisnikz@gmail.com", "fisnikz@gmail.com", "AQAAAAEAACcQAAAAEOQhxMHy+qw02dG0tXqKFM5q7Z+4PqZpnC7LRtmgesBwVYaE7HrLo4Wavf0ZV0QUeA==", null, false, "", false, "fisnikz@gmail.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Isbn", "Price", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("99e0a0d5-826d-41f9-ab70-5d61cd0888b1"), "Matt Frisbie", "978-1-119-36644-7", 38.5, "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("7e669526-b29e-431a-a840-b9804b148020"), "T. J. Crowder", "978-1-119-36795-6", 25.7, "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("cd1a3116-ae45-4a40-8ee3-8d3fa1c2e60e"), "Ivor Horton", "978-1-118-17341-1", 30.99, "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("b3383307-bde9-4479-b48d-f821692f379b"), "Christian Nagel", "978-1-119-44926-3", 38.99, "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("93334cad-ce5c-4841-80ef-71409f4e22fc"), "Jon Duckett", "978-1-118-20691-1", 19.99, "htmlcss.jpg", "HTML and CSS: Design and Build Websites" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Isbn",
                table: "Books",
                column: "Isbn",
                unique: true,
                filter: "[Isbn] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "78BB9A69-D214-40A3-B9BD-0344B851D76B", "b2f9029e-8354-4880-af0d-d349b1905e82" });
        }
    }
}
