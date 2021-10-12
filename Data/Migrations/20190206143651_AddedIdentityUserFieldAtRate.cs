using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class AddedIdentityUserFieldAtRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rate",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f0fea00-8ff2-4994-9325-93338026b907", "AQAAAAEAACcQAAAAEAlbyNuN41m75+DVgs5eKE1d4zcHfWrPGSU5qPjoyy6WfnjipCFpJog7oIdtlMYJKg==" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("0a6520fc-dbde-40ce-a096-bc51e7d78d3a"), "Matt Frisbie", null, null, "978-1-119-36644-7", 38.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("7aefcb5c-20ff-4447-ae42-15d9fc62a9ce"), "T. J. Crowder", null, null, "978-1-119-36795-6", 25.7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("66913525-af86-40bd-af49-e4593aef76f6"), "Ivor Horton", null, null, "978-1-118-17341-1", 30.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("4173bb11-3ae8-4e61-91e7-e22f3eb10026"), "Christian Nagel", null, null, "978-1-119-44926-3", 38.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("6d95efb2-fd4e-4beb-b5c7-ee0a4903f0ef"), "Jon Duckett", null, null, "978-1-118-20691-1", 19.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rate_UserId",
                table: "Rate",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Rate_UserId",
                table: "Rate");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0a6520fc-dbde-40ce-a096-bc51e7d78d3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4173bb11-3ae8-4e61-91e7-e22f3eb10026"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("66913525-af86-40bd-af49-e4593aef76f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d95efb2-fd4e-4beb-b5c7-ee0a4903f0ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7aefcb5c-20ff-4447-ae42-15d9fc62a9ce"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rate",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
