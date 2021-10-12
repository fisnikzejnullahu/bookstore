using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentUser");

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

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3539dfb9-32ad-4206-899b-31ba56fe632d", "AQAAAAEAACcQAAAAEIWJE7KAdrTUTP4mu6Tn4N2upXaqqDfRQv+4iIPZW18WlKqhmOK/V7gl3VLWy3HimA==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Thumbnail" },
                values: new object[] { new Guid("453dcdd8-dcf9-43a1-9f14-2090be19e731"), "Business & Management", "bussmng.jpg" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Thumbnail" },
                values: new object[] { new Guid("c8d774dd-b650-439c-b597-fa4f1f2d9548"), "Computing", "com.jpg" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), new Guid("c8d774dd-b650-439c-b597-fa4f1f2d9548"), "General & Introductory Computer Science" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("e2569f7e-19f1-425a-88d6-e436a43310b4"), new Guid("453dcdd8-dcf9-43a1-9f14-2090be19e731"), "Accounting" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Active", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("8041fab5-29f3-4267-9b37-267af12b2aff"), true, "Matt Frisbie", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36644-7", 38.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("3fee4bc7-1c87-450f-9fa6-a772c246bf88"), true, "T. J. Crowder", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36795-6", 25.7, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("65c1e648-9ed1-4a57-8b1a-0944cc64919d"), true, "Ivor Horton", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-17341-1", 30.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("1d18842e-812d-4aed-9813-bce0d000fa6e"), true, "Christian Nagel", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-44926-3", 38.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("522429d2-1651-4ca4-8ca7-441e95240b7e"), true, "Jon Duckett", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-20691-1", 19.99, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" },
                    { new Guid("20ae8a4e-0bef-4877-9893-d070dc8ffffb"), true, "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71520-6", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715207.jpg", "Mathematik fur Informatiker fur Dummies" },
                    { new Guid("43917660-1439-4201-af07-a9c6f29152c9"), true, "Ute Schmid, Michael Siebers, Katharina Weitz", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71573-2", 12.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715738.jpg", "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                    { new Guid("00c48d6e-5180-48fa-82b9-4b7f0be3a545"), true, "Frank Geisler, Benjamin Kettner", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71607-4", 25.5, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "no_image_available.jpg", "Docker fur Dummies" },
                    { new Guid("a0425de4-4960-4b3c-aeb8-6c66aff5fbfa"), true, "Eric T. Jones, Eric Butow", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56502-4", 21.4, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119565022.jpg", "Programming Interviews For Dummies" },
                    { new Guid("a8593e23-6629-4e8f-a900-48a52d2e6cfd"), true, "Sarah Guthals", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-57267-1", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119572673.jpg", "GitHub For Dummies" },
                    { new Guid("f97ecfd5-0244-47f0-936f-c64042833697"), true, "Alissa Knight", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-49180-4", 42.8, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119491800.jpg", "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                    { new Guid("13802448-2408-434d-bfa5-193407f51b47"), true, "Perry Carpenter", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56634-2", 25.7, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119566347.jpg", "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                    { new Guid("ba4280bb-51a4-4490-8135-380c604dfede"), true, "Marco L. Napoli", new Guid("788861e6-e245-4e3b-9246-bc512ac74706"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-55082-2", 34.2, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119550823.jpg", "Beginning Flutter: A Hands On Guide To App Development" },
                    { new Guid("bb7d29c4-ef04-4260-8c7f-f5852fcf52fa"), true, "Shirley Carlon, Rosina McAlpine, Chrisann Lee, Lorena Mitrione, Ngaire Kirk, Lily Wong", new Guid("e2569f7e-19f1-425a-88d6-e436a43310b4"), "Financial Accounting, 6th Edition presents accounting in a cutting-edge interactive digital format designed to motivate students by taking the road blocks out of self-study and to facilitate mastery though drill-and-skill practice.", "978-0-730-36327-9", 76.3, new DateTime(2018, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "0730363279.jpg", "Financial Accounting: Reporting, Analysis And Decision Making, 6th Edition" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00c48d6e-5180-48fa-82b9-4b7f0be3a545"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13802448-2408-434d-bfa5-193407f51b47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d18842e-812d-4aed-9813-bce0d000fa6e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20ae8a4e-0bef-4877-9893-d070dc8ffffb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3fee4bc7-1c87-450f-9fa6-a772c246bf88"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("43917660-1439-4201-af07-a9c6f29152c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("522429d2-1651-4ca4-8ca7-441e95240b7e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65c1e648-9ed1-4a57-8b1a-0944cc64919d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8041fab5-29f3-4267-9b37-267af12b2aff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a0425de4-4960-4b3c-aeb8-6c66aff5fbfa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8593e23-6629-4e8f-a900-48a52d2e6cfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba4280bb-51a4-4490-8135-380c604dfede"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb7d29c4-ef04-4260-8c7f-f5852fcf52fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f97ecfd5-0244-47f0-936f-c64042833697"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("788861e6-e245-4e3b-9246-bc512ac74706"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("e2569f7e-19f1-425a-88d6-e436a43310b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("453dcdd8-dcf9-43a1-9f14-2090be19e731"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8d774dd-b650-439c-b597-fa4f1f2d9548"));

            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Categories");

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
                name: "IX_CommentUser_UserId",
                table: "CommentUser",
                column: "UserId");
        }
    }
}
