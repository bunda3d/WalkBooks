using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBookTypeIdFromGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Books_BookTypeId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_BookTypeId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "BookTypeId",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BooksId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenresId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenresId",
                table: "BookGenres",
                column: "GenresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.AddColumn<Guid>(
                name: "BookTypeId",
                table: "Genres",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a1c2d3e4-65f0-43c8-79aa-0f1a2b3c4d24"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a3c4d5e6-8f7a-4b5c-9d0e-2f3a4b5c6d06"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a5c6d7e8-0f9a-47c2-1344-4f5a6b7c8d18"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a9c0d1e2-4f3a-416c-5d6e-8f9a0b1c2d12"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b0d1e2f3-5a4b-427d-6e7f-9a0b1c2d3e13"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b2d3e4f5-7601-44d9-8abb-1a2b3c4d5e25"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b4d5e6f7-9a8b-4c5d-0e1f-3a4b5c6d7e07"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6d7e8f9-10ab-48d3-2455-5a6b7c8d9e19"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b6f0b7b4-4f0b-4c3c-9c3b-4f6b9c3b4f01"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1a9c2e3-7b4d-4c2f-8a1b-9d3e7f2a5b02"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1e2f3a4-6b5c-438e-7f80-0b1c2d3e4f14"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c5e6f7a8-0b9c-4d5e-1f2a-4b5c6d7e8f08"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c7e8f9a0-21bc-49e4-3566-6b7c8d9e0f20"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d2f3a4b5-7c6d-449f-8011-1c2d3e4f5a15"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d4e7f2a5-9c3b-4f6b-8a1b-7b4d3c2e6f03"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d6f7a8b9-1c0d-4e5f-2a3b-5c6d7e8f9a09"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8f9a0b1-32cd-40f5-4677-7c8d9e0f1a21"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e3a4b5c6-8d7e-45a0-9122-2d3e4f5a6b16"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e7a8b9c0-2d1e-4f5a-3b4c-6d7e8f9a0b10"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9a0b1c2-43de-41a6-5788-8d9e0f1a2b22"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9f1a2b3-6c4d-4e5f-9a2b-8c3d4e5f6a04"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f0b1c2d3-54ef-42b7-6899-9e0f1a2b3c23"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2b3c4d5-7e6f-4a5b-8c9d-1e2f3a4b5c05"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f4b5c6d7-9e8f-46b1-0233-3e4f5a6b7c17"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f8b9c0d1-3e2f-405b-4c5d-7e8f9a0b1c11"),
                column: "BookTypeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BookTypeId",
                table: "Genres",
                column: "BookTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Books_BookTypeId",
                table: "Genres",
                column: "BookTypeId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
