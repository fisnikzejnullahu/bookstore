using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class SeedingNewCategoryAndSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
