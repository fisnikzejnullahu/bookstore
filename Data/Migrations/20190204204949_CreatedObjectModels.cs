using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class CreatedObjectModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e669526-b29e-431a-a840-b9804b148020"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("93334cad-ce5c-4841-80ef-71409f4e22fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99e0a0d5-826d-41f9-ab70-5d61cd0888b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b3383307-bde9-4479-b48d-f821692f379b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd1a3116-ae45-4a40-8ee3-8d3fa1c2e60e"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategorySubjectId",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: true),
                    BookId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    BookId = table.Column<Guid>(nullable: false),
                    Value = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rate_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategorySubjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategorySubjects_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    EditedTime = table.Column<DateTime>(nullable: false),
                    CommentId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentHistories_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentUser",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentUser", x => new { x.CommentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CommentUser_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersBooks",
                columns: table => new
                {
                    BookId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersBooks", x => new { x.BookId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrdersBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersBooks_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec2bc551-6d5a-4824-8ecf-06f89a779f41", "AQAAAAEAACcQAAAAEG1ujJJfaR0YNGhgO4xYLFJkJqu+HBC0BDIvmNTt043lSbaYUH0O61BU8HAPicNj+A==" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("b5cbf655-12c7-4d1f-8687-fa74ed8c74be"), "Matt Frisbie", null, null, "978-1-119-36644-7", 38.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("3e93c282-e34e-4de5-9511-610af6e57940"), "T. J. Crowder", null, null, "978-1-119-36795-6", 25.7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("3a8422d2-7285-4aac-91fa-640f72cfdbd9"), "Ivor Horton", null, null, "978-1-118-17341-1", 30.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("937f5251-54d7-47ec-9eb1-124257ac154d"), "Christian Nagel", null, null, "978-1-119-44926-3", 38.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("7b5ba8f4-6d12-4a41-a7fc-f4803ba6e09d"), "Jon Duckett", null, null, "978-1-118-20691-1", 19.99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategorySubjectId",
                table: "Books",
                column: "CategorySubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorySubjects_CategoryId",
                table: "CategorySubjects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentHistories_CommentId",
                table: "CommentHistories",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CreatedByUserId",
                table: "Comments",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentUser_UserId",
                table: "CommentUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersBooks_OrderId",
                table: "OrdersBooks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_BookId",
                table: "Rate",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books",
                column: "CategorySubjectId",
                principalTable: "CategorySubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "CategorySubjects");

            migrationBuilder.DropTable(
                name: "CommentHistories");

            migrationBuilder.DropTable(
                name: "CommentUser");

            migrationBuilder.DropTable(
                name: "OrdersBooks");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategorySubjectId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a8422d2-7285-4aac-91fa-640f72cfdbd9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e93c282-e34e-4de5-9511-610af6e57940"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b5ba8f4-6d12-4a41-a7fc-f4803ba6e09d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("937f5251-54d7-47ec-9eb1-124257ac154d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5cbf655-12c7-4d1f-8687-fa74ed8c74be"));

            migrationBuilder.DropColumn(
                name: "CategorySubjectId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2f9029e-8354-4880-af0d-d349b1905e82", "AQAAAAEAACcQAAAAEOQhxMHy+qw02dG0tXqKFM5q7Z+4PqZpnC7LRtmgesBwVYaE7HrLo4Wavf0ZV0QUeA==" });

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
        }
    }
}
