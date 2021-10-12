using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class AddedAttributeIsActiveBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Isbn",
                table: "Books");

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
                name: "Isbn",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategorySubjectId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Books",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books",
                column: "CategorySubjectId",
                principalTable: "CategorySubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books");

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

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategorySubjectId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(Guid));

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
                name: "IX_Books_Isbn",
                table: "Books",
                column: "Isbn",
                unique: true,
                filter: "[Isbn] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CategorySubjects_CategorySubjectId",
                table: "Books",
                column: "CategorySubjectId",
                principalTable: "CategorySubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
