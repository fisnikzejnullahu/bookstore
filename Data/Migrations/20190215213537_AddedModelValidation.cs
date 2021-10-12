using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class AddedModelValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06195285-414f-4b2b-b953-495d2bf1dafc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0adb67eb-c0eb-4ad6-bf27-d8c4bcb52f57"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28b9291e-5152-41d3-8811-c7f6d5956d2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b544767-fdc1-4501-a890-872604fe8f32"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d604d9d-1ccb-4f6c-a247-0576b9c4bb5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4f739042-68c7-4617-bba1-5afe67038eed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8772a500-10d9-4a03-a0ef-e316404b6cbf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7921958-57a8-423f-b1a0-240874036614"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b49d45cb-c75b-4462-958b-2afa48de90ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1b53bb4-ef9a-4895-83f4-0f7e1b661b85"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d7f1dc2e-2d09-4470-874d-6f35ff6cb349"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dea8e2d6-c66e-45cd-aaed-2b55a7ed643a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0c12a42-fa5a-4ba3-82fb-cb0a5e5fd6f8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff7984de-59c8-4aff-a4fc-e1a41cea9d0f"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("ca48a5d5-a111-4a6d-b31a-330751fbbe8f"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65ded186-d558-46b3-8d6a-bff74c93ed44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae2b194e-21dd-4de3-85f6-d0dcb7c5de12"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rate",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CategorySubjects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ec38cd9-a9db-4743-b018-adf360838379", "AQAAAAEAACcQAAAAEKNtPRiMAKtbIbR5ccMr7EzGaQaoy1aa1x1yhn13nk9/JgRSE1Z0IHaLKmpg/3ZNqQ==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("296f7b59-3f33-4fe4-8162-04604ff28572"), "Business & Management" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0c2719bc-5c72-4d84-891c-909ceeefe4f2"), "Computing" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), new Guid("0c2719bc-5c72-4d84-891c-909ceeefe4f2"), "General & Introductory Computer Science" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("800f186c-2477-47e7-95b8-d4a780793b56"), new Guid("296f7b59-3f33-4fe4-8162-04604ff28572"), "Accounting" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Active", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("21efdd09-5380-473d-bb3b-1b7250f7f332"), true, "Matt Frisbie", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36644-7", 38.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("cc332242-e605-4e07-9dd3-9af51a466f65"), true, "T. J. Crowder", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36795-6", 25.7, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("04f904f1-0a94-4c5e-9228-f4d989f8a065"), true, "Ivor Horton", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-17341-1", 30.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("2e27e2eb-63da-4f2e-b6e1-a7939a10b8b6"), true, "Christian Nagel", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-44926-3", 38.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("576b1d91-c3ae-4b05-ae55-33df30891418"), true, "Jon Duckett", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-20691-1", 19.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" },
                    { new Guid("4eb1513f-3f89-4a97-8703-2570b62e1235"), true, "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71520-6", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715207.jpg", "Mathematik fur Informatiker fur Dummies" },
                    { new Guid("c9cf18c1-adab-44f4-b1fc-5903766298c7"), true, "Ute Schmid, Michael Siebers, Katharina Weitz", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71573-2", 12.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715738.jpg", "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                    { new Guid("0ebc245a-5aa8-440a-a2d2-a9684da580ad"), true, "Frank Geisler, Benjamin Kettner", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71607-4", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "no_image_available.jpg", "Docker fur Dummies" },
                    { new Guid("30201dcd-3c5f-4653-84cb-2591177fd85d"), true, "Eric T. Jones, Eric Butow", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56502-4", 21.4, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119565022.jpg", "Programming Interviews For Dummies" },
                    { new Guid("9fa290dd-46d0-4079-a910-35e4dbf89c1c"), true, "Sarah Guthals", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-57267-1", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119572673.jpg", "GitHub For Dummies" },
                    { new Guid("97b26ae1-7c9a-4627-b8f2-af1a8ecbe948"), true, "Alissa Knight", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-49180-4", 42.8, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119491800.jpg", "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                    { new Guid("6fc735c2-41c8-46e0-9a8b-4d79ddb5c68b"), true, "Perry Carpenter", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56634-2", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119566347.jpg", "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                    { new Guid("6db228c0-5633-42f4-98a5-b1d883ed80b4"), true, "Marco L. Napoli", new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-55082-2", 34.2, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119550823.jpg", "Beginning Flutter: A Hands On Guide To App Development" },
                    { new Guid("f7e939ce-e57e-4ca0-8b42-21b3471a1604"), true, "Shirley Carlon, Rosina McAlpine, Chrisann Lee, Lorena Mitrione, Ngaire Kirk, Lily Wong", new Guid("800f186c-2477-47e7-95b8-d4a780793b56"), "Financial Accounting, 6th Edition presents accounting in a cutting-edge interactive digital format designed to motivate students by taking the road blocks out of self-study and to facilitate mastery though drill-and-skill practice.", "978-0-730-36327-9", 76.3, new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0730363279.jpg", "Financial Accounting: Reporting, Analysis And Decision Making, 6th Edition" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Isbn",
                table: "Books",
                column: "Isbn",
                unique: true,
                filter: "[Isbn] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Books_Isbn",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04f904f1-0a94-4c5e-9228-f4d989f8a065"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ebc245a-5aa8-440a-a2d2-a9684da580ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21efdd09-5380-473d-bb3b-1b7250f7f332"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e27e2eb-63da-4f2e-b6e1-a7939a10b8b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30201dcd-3c5f-4653-84cb-2591177fd85d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4eb1513f-3f89-4a97-8703-2570b62e1235"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("576b1d91-c3ae-4b05-ae55-33df30891418"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6db228c0-5633-42f4-98a5-b1d883ed80b4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6fc735c2-41c8-46e0-9a8b-4d79ddb5c68b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97b26ae1-7c9a-4627-b8f2-af1a8ecbe948"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9fa290dd-46d0-4079-a910-35e4dbf89c1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c9cf18c1-adab-44f4-b1fc-5903766298c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc332242-e605-4e07-9dd3-9af51a466f65"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7e939ce-e57e-4ca0-8b42-21b3471a1604"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("2bd66372-0406-4f20-b833-50f5f908d0ef"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("800f186c-2477-47e7-95b8-d4a780793b56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c2719bc-5c72-4d84-891c-909ceeefe4f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("296f7b59-3f33-4fe4-8162-04604ff28572"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rate",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CategorySubjects",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8959f70c-c042-4ac8-95f6-ee98771c7b9b", "AQAAAAEAACcQAAAAENVtJrYnPus2lX1ggxRTN44gIstNO0CXrwxesRcX2CoA4crj7ZaJ+bNVPSnHP6V41A==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("65ded186-d558-46b3-8d6a-bff74c93ed44"), "Business & Management" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ae2b194e-21dd-4de3-85f6-d0dcb7c5de12"), "Computing" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), new Guid("ae2b194e-21dd-4de3-85f6-d0dcb7c5de12"), "General & Introductory Computer Science" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("ca48a5d5-a111-4a6d-b31a-330751fbbe8f"), new Guid("65ded186-d558-46b3-8d6a-bff74c93ed44"), "Accounting" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Active", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("06195285-414f-4b2b-b953-495d2bf1dafc"), true, "Matt Frisbie", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36644-7", 38.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("4f739042-68c7-4617-bba1-5afe67038eed"), true, "T. J. Crowder", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36795-6", 25.7, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("dea8e2d6-c66e-45cd-aaed-2b55a7ed643a"), true, "Ivor Horton", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-17341-1", 30.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("e0c12a42-fa5a-4ba3-82fb-cb0a5e5fd6f8"), true, "Christian Nagel", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-44926-3", 38.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("b49d45cb-c75b-4462-958b-2afa48de90ed"), true, "Jon Duckett", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-20691-1", 19.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" },
                    { new Guid("28b9291e-5152-41d3-8811-c7f6d5956d2f"), true, "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71520-6", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715207.jpg", "Mathematik fur Informatiker fur Dummies" },
                    { new Guid("a7921958-57a8-423f-b1a0-240874036614"), true, "Ute Schmid, Michael Siebers, Katharina Weitz", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71573-2", 12.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715738.jpg", "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                    { new Guid("8772a500-10d9-4a03-a0ef-e316404b6cbf"), true, "Frank Geisler, Benjamin Kettner", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71607-4", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "no_image_available.jpg", "Docker fur Dummies" },
                    { new Guid("0adb67eb-c0eb-4ad6-bf27-d8c4bcb52f57"), true, "Eric T. Jones, Eric Butow", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56502-4", 21.4, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119565022.jpg", "Programming Interviews For Dummies" },
                    { new Guid("d1b53bb4-ef9a-4895-83f4-0f7e1b661b85"), true, "Sarah Guthals", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-57267-1", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119572673.jpg", "GitHub For Dummies" },
                    { new Guid("ff7984de-59c8-4aff-a4fc-e1a41cea9d0f"), true, "Alissa Knight", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-49180-4", 42.8, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119491800.jpg", "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                    { new Guid("d7f1dc2e-2d09-4470-874d-6f35ff6cb349"), true, "Perry Carpenter", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56634-2", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119566347.jpg", "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                    { new Guid("4d604d9d-1ccb-4f6c-a247-0576b9c4bb5f"), true, "Marco L. Napoli", new Guid("ed3fccb0-ae7a-4d72-a447-0830384eb8df"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-55082-2", 34.2, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119550823.jpg", "Beginning Flutter: A Hands On Guide To App Development" },
                    { new Guid("4b544767-fdc1-4501-a890-872604fe8f32"), true, "Shirley Carlon, Rosina McAlpine, Chrisann Lee, Lorena Mitrione, Ngaire Kirk, Lily Wong", new Guid("ca48a5d5-a111-4a6d-b31a-330751fbbe8f"), "Financial Accounting, 6th Edition presents accounting in a cutting-edge interactive digital format designed to motivate students by taking the road blocks out of self-study and to facilitate mastery though drill-and-skill practice.", "978-0-730-36327-9", 76.3, new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0730363279.jpg", "Financial Accounting: Reporting, Analysis And Decision Making, 6th Edition" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_AspNetUsers_UserId",
                table: "Rate",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
