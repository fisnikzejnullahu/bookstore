using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class CommentIdAtCommentHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c4d3529-6282-4f86-b0b7-7109d37d7a66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46941a07-6646-4f92-bb35-73a4b13e2680"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("916266a8-bc68-47c6-bda9-785f1d40d84c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1b16fef-31b8-470e-b1f8-aa090f7c82d0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4f42e52-62dc-4bb0-9746-c8856dd8569a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a902c1f0-40c6-4c9e-a40c-a0e9ffd5d260", "AQAAAAEAACcQAAAAELYlblHlAfT/4O3X1E5PQQpI68LMZZomRWwCPJmAG09vzAWTD68bqIpzrnbVQ/mjlw==" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("e703a5f7-812c-442e-86a1-125939f5ffed"), "Matt Frisbie", null, null, "978-1-119-36644-7", 38.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("9e6a835e-086f-45ff-bb43-9bc3f71da079"), "T. J. Crowder", null, null, "978-1-119-36795-6", 25.7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("c72eca57-f927-4ca4-a3e5-229be2c035a2"), "Ivor Horton", null, null, "978-1-118-17341-1", 30.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("013d3e1a-a301-4d37-a661-6a6b077d488f"), "Christian Nagel", null, null, "978-1-119-44926-3", 38.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("8390a875-f203-4609-a43b-9be936280f80"), "Jon Duckett", null, null, "978-1-118-20691-1", 19.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("013d3e1a-a301-4d37-a661-6a6b077d488f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8390a875-f203-4609-a43b-9be936280f80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e6a835e-086f-45ff-bb43-9bc3f71da079"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c72eca57-f927-4ca4-a3e5-229be2c035a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e703a5f7-812c-442e-86a1-125939f5ffed"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "60b42250-4f98-40f8-98d2-492b01299a3d", "AQAAAAEAACcQAAAAEO51Iq7CvYSwvL81TpLo6O8Kjk1KDeSO2p/s+Qk/676fQcx44Z6te6PbCTLMdPJa0A==" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("3c4d3529-6282-4f86-b0b7-7109d37d7a66"), "Matt Frisbie", null, null, "978-1-119-36644-7", 38.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("916266a8-bc68-47c6-bda9-785f1d40d84c"), "T. J. Crowder", null, null, "978-1-119-36795-6", 25.7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("e4f42e52-62dc-4bb0-9746-c8856dd8569a"), "Ivor Horton", null, null, "978-1-118-17341-1", 30.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("46941a07-6646-4f92-bb35-73a4b13e2680"), "Christian Nagel", null, null, "978-1-119-44926-3", 38.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("a1b16fef-31b8-470e-b1f8-aa090f7c82d0"), "Jon Duckett", null, null, "978-1-118-20691-1", 19.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" }
                });
        }
    }
}
