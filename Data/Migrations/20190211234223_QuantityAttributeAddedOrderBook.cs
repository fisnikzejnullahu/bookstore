using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class QuantityAttributeAddedOrderBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0c9cc009-11f3-4ede-80fb-1799b35503b4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0da09afa-8abd-4889-8ff3-bb07f78ab176"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22d64954-5e36-4ca6-8689-45261e8fb473"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24f2dd73-e671-467e-a71f-86ccd7cbf38c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26ea166c-7b39-485c-bab5-05c24c3c5e53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2d4d883f-62a8-46a4-91a1-d9775a2f81dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("61061579-8db2-4179-bb02-2153b4ef1740"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e437701-c2a9-48b5-9900-778b9d04aba4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("88ac8896-e419-44aa-baf8-9399d50111e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8cf24599-81ab-44f5-95b4-aaf365f1569e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b995f147-ed6d-4453-88a0-e84ec68f34d0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e02ea304-f27e-4354-84c0-91aec11c7fdf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6494d8d-91cd-489b-8270-3cbcef556f2a"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e69151a1-defd-47a0-8eb7-a92dc13b7e5a"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrdersBooks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a822c9fa-398f-4b45-99da-46ee56b2b338", "AQAAAAEAACcQAAAAEHNXYzsCHyn8LD0JPMs0Vdqa7Q2vqXxVmYBxP886NOjHMixD0QZS+dgVHyOOaLMCAw==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("540bc9e4-4c19-406f-b512-52ab5ac0beaa"), "Computing" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), new Guid("540bc9e4-4c19-406f-b512-52ab5ac0beaa"), "General & Introductory Computer Science" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Active", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("4e785945-b29b-4106-af23-8da2cf6a96ec"), true, "Matt Frisbie", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36644-7", 38.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("39c7ceb7-edc8-4de1-8294-a7ff3da80d92"), true, "T. J. Crowder", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36795-6", 25.7, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("ef8fabf5-623c-4961-844c-252123c82bea"), true, "Ivor Horton", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-17341-1", 30.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("4a362820-9fd9-42c3-9307-4695419528d6"), true, "Christian Nagel", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-44926-3", 38.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("6f23788d-48a5-4041-ab29-c64fc5ee9b5a"), true, "Jon Duckett", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-20691-1", 19.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" },
                    { new Guid("ea1e5a95-65d5-4070-896b-283c3251f019"), true, "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71520-6", 25.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715207.jpg", "Mathematik fur Informatiker fur Dummies" },
                    { new Guid("a435c7fc-5c39-4a07-97ef-aa32770a7acf"), true, "Ute Schmid, Michael Siebers, Katharina Weitz", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71573-2", 12.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715738.jpg", "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                    { new Guid("2965f9fa-f19d-4752-b3bb-4f90489368d9"), true, "Frank Geisler, Benjamin Kettner", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71607-4", 25.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "no_image_available.jpg", "Docker fur Dummies" },
                    { new Guid("85fefddf-2bbd-45ee-ba38-94850acf3ce4"), true, "Eric T. Jones, Eric Butow", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56502-4", 21.4, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119565022.jpg", "Programming Interviews For Dummies" },
                    { new Guid("2336a10d-41fd-4e99-a9e5-bd52c0ad62bd"), true, "Sarah Guthals", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-57267-1", 25.7, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119572673.jpg", "GitHub For Dummies" },
                    { new Guid("04ab9a5b-494d-4ee2-9780-891e872d0f7b"), true, "Alissa Knight", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-49180-4", 42.8, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119491800.jpg", "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                    { new Guid("f306d2f2-ea29-4c82-aa91-dd3e6f6023b1"), true, "Perry Carpenter", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56634-2", 25.7, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119566347.jpg", "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                    { new Guid("f6f27ad9-f27c-412a-a4c3-bb649f2cb2c5"), true, "Marco L. Napoli", new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-55082-2", 34.2, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119550823.jpg", "Beginning Flutter: A Hands On Guide To App Development" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04ab9a5b-494d-4ee2-9780-891e872d0f7b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2336a10d-41fd-4e99-a9e5-bd52c0ad62bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2965f9fa-f19d-4752-b3bb-4f90489368d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("39c7ceb7-edc8-4de1-8294-a7ff3da80d92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a362820-9fd9-42c3-9307-4695419528d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e785945-b29b-4106-af23-8da2cf6a96ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f23788d-48a5-4041-ab29-c64fc5ee9b5a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85fefddf-2bbd-45ee-ba38-94850acf3ce4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a435c7fc-5c39-4a07-97ef-aa32770a7acf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea1e5a95-65d5-4070-896b-283c3251f019"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef8fabf5-623c-4961-844c-252123c82bea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f306d2f2-ea29-4c82-aa91-dd3e6f6023b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6f27ad9-f27c-412a-a4c3-bb649f2cb2c5"));

            migrationBuilder.DeleteData(
                table: "CategorySubjects",
                keyColumn: "Id",
                keyValue: new Guid("ba00f0dc-51e3-4633-9a28-42b1c864fbcb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("540bc9e4-4c19-406f-b512-52ab5ac0beaa"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrdersBooks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78BB9A69-D214-40A3-B9BD-0344B851D76B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18405181-5c13-456a-872b-966181cccd25", "AQAAAAEAACcQAAAAEK2UJi/knHQnnoskJ8N+7J/t3vSReluXq7ASws+aDfHtGa4SaPCN5ZGu0AwMQEFLIA==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e69151a1-defd-47a0-8eb7-a92dc13b7e5a"), "Computing" });

            migrationBuilder.InsertData(
                table: "CategorySubjects",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), new Guid("e69151a1-defd-47a0-8eb7-a92dc13b7e5a"), "General & Introductory Computer Science" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Active", "Author", "CategorySubjectId", "Description", "Isbn", "Price", "PublishedDate", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { new Guid("6e437701-c2a9-48b5-9900-778b9d04aba4"), true, "Matt Frisbie", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36644-7", 38.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "professionaljs.jpg", "Professional JavaScript for Web Developers, 4th Edition" },
                    { new Guid("0c9cc009-11f3-4ede-80fb-1799b35503b4"), true, "T. J. Crowder", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-36795-6", 25.7, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsnewtoys.jpg", "JavaScript: The New Toys" },
                    { new Guid("0da09afa-8abd-4889-8ff3-bb07f78ab176"), true, "Ivor Horton", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-17341-1", 30.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "java.jpg", "Ivor Horton's Beginning Java, Java 7 Edition" },
                    { new Guid("61061579-8db2-4179-bb02-2153b4ef1740"), true, "Christian Nagel", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-44926-3", 38.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7.jpg", "Professional C# 7 and .NET Core 2.0" },
                    { new Guid("b995f147-ed6d-4453-88a0-e84ec68f34d0"), true, "Jon Duckett", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-118-20691-1", 19.99, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "htmlcss.jpg", "HTML and CSS: Design and Build Websites" },
                    { new Guid("f6494d8d-91cd-489b-8270-3cbcef556f2a"), true, "Hans-Jurgen Steffens, Christian Zollner, Kathrin Muhlmann", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71520-6", 25.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715207.jpg", "Mathematik fur Informatiker fur Dummies" },
                    { new Guid("2d4d883f-62a8-46a4-91a1-d9775a2f81dd"), true, "Ute Schmid, Michael Siebers, Katharina Weitz", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71573-2", 12.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3527715738.jpg", "Kunstliche Intelligenz selber programmieren fur Dummies Junior" },
                    { new Guid("26ea166c-7b39-485c-bab5-05c24c3c5e53"), true, "Frank Geisler, Benjamin Kettner", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-3-527-71607-4", 25.5, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "no_image_available.jpg", "Docker fur Dummies" },
                    { new Guid("24f2dd73-e671-467e-a71f-86ccd7cbf38c"), true, "Eric T. Jones, Eric Butow", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56502-4", 21.4, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119565022.jpg", "Programming Interviews For Dummies" },
                    { new Guid("22d64954-5e36-4ca6-8689-45261e8fb473"), true, "Sarah Guthals", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-57267-1", 25.7, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119572673.jpg", "GitHub For Dummies" },
                    { new Guid("e02ea304-f27e-4354-84c0-91aec11c7fdf"), true, "Alissa Knight", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-49180-4", 42.8, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119491800.jpg", "Hacking Connected Cars: Tactics, Techniques, and Procedures" },
                    { new Guid("8cf24599-81ab-44f5-95b4-aaf365f1569e"), true, "Perry Carpenter", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-56634-2", 25.7, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119566347.jpg", "Transformational Security Awareness: What Neuroscientists, Storytellers, and Marketers Can Teach Us About Driving Secure Behaviors" },
                    { new Guid("88ac8896-e419-44aa-baf8-9399d50111e8"), true, "Marco L. Napoli", new Guid("aed3b66e-1bde-46ab-a53a-e74e24e05e15"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "978-1-119-55082-2", 34.2, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1119550823.jpg", "Beginning Flutter: A Hands On Guide To App Development" }
                });
        }
    }
}
