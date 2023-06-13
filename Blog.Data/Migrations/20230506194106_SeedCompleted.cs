using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"), "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1155), null, null, false, null, null, "Name" },
                    { new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"), "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1158), null, null, false, null, null, "Name 2" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"), "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1277), null, null, "images/testimage", "jpeg", false, null, null },
                    { new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"), "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1281), null, null, "images/testimage", "jpeg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c96e8c34-7cc9-4cb2-adc4-140ac120335e"), new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"), "default article 2", "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(830), null, null, new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"), false, null, null, "Title 2", 15 },
                    { new Guid("fce3037c-cd18-4b7d-a8d4-2f3895226edf"), new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"), "default article", "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(824), null, null, new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"), false, null, null, "Title", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c96e8c34-7cc9-4cb2-adc4-140ac120335e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fce3037c-cd18-4b7d-a8d4-2f3895226edf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"));
        }
    }
}
