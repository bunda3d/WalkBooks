using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreMedium : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Medium",
                table: "Genres",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "BookTypeId", "Medium", "Name" },
                values: new object[,]
                {
                    { new Guid("a1c2d3e4-65f0-43c8-79aa-0f1a2b3c4d24"), null, "Book", "Reference" },
                    { new Guid("a3c4d5e6-8f7a-4b5c-9d0e-2f3a4b5c6d06"), null, "Book", "Romance" },
                    { new Guid("a5c6d7e8-0f9a-47c2-1344-4f5a6b7c8d18"), null, "Book", "Comics" },
                    { new Guid("a9c0d1e2-4f3a-416c-5d6e-8f9a0b1c2d12"), null, "Book", "Biography" },
                    { new Guid("b0d1e2f3-5a4b-427d-6e7f-9a0b1c2d3e13"), null, "Book", "Memoir" },
                    { new Guid("b2d3e4f5-7601-44d9-8abb-1a2b3c4d5e25"), null, "Book", "Education" },
                    { new Guid("b4d5e6f7-9a8b-4c5d-0e1f-3a4b5c6d7e07"), null, "Book", "Historical Fiction" },
                    { new Guid("b6d7e8f9-10ab-48d3-2455-5a6b7c8d9e19"), null, "Book", "Graphic Novels" },
                    { new Guid("b6f0b7b4-4f0b-4c3c-9c3b-4f6b9c3b4f01"), null, "Book", "Fantasy" },
                    { new Guid("c1a9c2e3-7b4d-4c2f-8a1b-9d3e7f2a5b02"), null, "Book", "Science Fiction" },
                    { new Guid("c1e2f3a4-6b5c-438e-7f80-0b1c2d3e4f14"), null, "Book", "Self-Help" },
                    { new Guid("c5e6f7a8-0b9c-4d5e-1f2a-4b5c6d7e8f08"), null, "Book", "Literary Fiction" },
                    { new Guid("c7e8f9a0-21bc-49e4-3566-6b7c8d9e0f20"), null, "Book", "Travel" },
                    { new Guid("d2f3a4b5-7c6d-449f-8011-1c2d3e4f5a15"), null, "Book", "Philosophy" },
                    { new Guid("d4e7f2a5-9c3b-4f6b-8a1b-7b4d3c2e6f03"), null, "Book", "Mystery" },
                    { new Guid("d6f7a8b9-1c0d-4e5f-2a3b-5c6d7e8f9a09"), null, "Book", "Young Adult" },
                    { new Guid("d8f9a0b1-32cd-40f5-4677-7c8d9e0f1a21"), null, "Book", "Cooking" },
                    { new Guid("e3a4b5c6-8d7e-45a0-9122-2d3e4f5a6b16"), null, "Book", "Religion" },
                    { new Guid("e7a8b9c0-2d1e-4f5a-3b4c-6d7e8f9a0b10"), null, "Book", "Children’s" },
                    { new Guid("e9a0b1c2-43de-41a6-5788-8d9e0f1a2b22"), null, "Book", "Art" },
                    { new Guid("e9f1a2b3-6c4d-4e5f-9a2b-8c3d4e5f6a04"), null, "Book", "Thriller" },
                    { new Guid("f0b1c2d3-54ef-42b7-6899-9e0f1a2b3c23"), null, "Book", "Photography" },
                    { new Guid("f2b3c4d5-7e6f-4a5b-8c9d-1e2f3a4b5c05"), null, "Book", "Horror" },
                    { new Guid("f4b5c6d7-9e8f-46b1-0233-3e4f5a6b7c17"), null, "Book", "Poetry" },
                    { new Guid("f8b9c0d1-3e2f-405b-4c5d-7e8f9a0b1c11"), null, "Book", "Nonfiction" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a1c2d3e4-65f0-43c8-79aa-0f1a2b3c4d24"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a3c4d5e6-8f7a-4b5c-9d0e-2f3a4b5c6d06"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a5c6d7e8-0f9a-47c2-1344-4f5a6b7c8d18"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a9c0d1e2-4f3a-416c-5d6e-8f9a0b1c2d12"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b0d1e2f3-5a4b-427d-6e7f-9a0b1c2d3e13"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b2d3e4f5-7601-44d9-8abb-1a2b3c4d5e25"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b4d5e6f7-9a8b-4c5d-0e1f-3a4b5c6d7e07"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6d7e8f9-10ab-48d3-2455-5a6b7c8d9e19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6f0b7b4-4f0b-4c3c-9c3b-4f6b9c3b4f01"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1a9c2e3-7b4d-4c2f-8a1b-9d3e7f2a5b02"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1e2f3a4-6b5c-438e-7f80-0b1c2d3e4f14"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c5e6f7a8-0b9c-4d5e-1f2a-4b5c6d7e8f08"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c7e8f9a0-21bc-49e4-3566-6b7c8d9e0f20"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d2f3a4b5-7c6d-449f-8011-1c2d3e4f5a15"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d4e7f2a5-9c3b-4f6b-8a1b-7b4d3c2e6f03"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d6f7a8b9-1c0d-4e5f-2a3b-5c6d7e8f9a09"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8f9a0b1-32cd-40f5-4677-7c8d9e0f1a21"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e3a4b5c6-8d7e-45a0-9122-2d3e4f5a6b16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e7a8b9c0-2d1e-4f5a-3b4c-6d7e8f9a0b10"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9a0b1c2-43de-41a6-5788-8d9e0f1a2b22"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9f1a2b3-6c4d-4e5f-9a2b-8c3d4e5f6a04"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f0b1c2d3-54ef-42b7-6899-9e0f1a2b3c23"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2b3c4d5-7e6f-4a5b-8c9d-1e2f3a4b5c05"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f4b5c6d7-9e8f-46b1-0233-3e4f5a6b7c17"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f8b9c0d1-3e2f-405b-4c5d-7e8f9a0b1c11"));

            migrationBuilder.DropColumn(
                name: "Medium",
                table: "Genres");
        }
    }
}
