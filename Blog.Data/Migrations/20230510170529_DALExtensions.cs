using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c96e8c34-7cc9-4cb2-adc4-140ac120335e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fce3037c-cd18-4b7d-a8d4-2f3895226edf"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5c48a7df-9f5d-453a-bc31-e585eececf72"), new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"), "default article", "Admin Test", new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7462), null, null, new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"), false, null, null, "Title", 15 },
                    { new Guid("de5a7c35-e3d6-424c-ba09-4e5f61cfe602"), new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"), "default article 2", "Admin Test", new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7482), null, null, new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"), false, null, null, "Title 2", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 20, 5, 29, 323, DateTimeKind.Local).AddTicks(7770));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5c48a7df-9f5d-453a-bc31-e585eececf72"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("de5a7c35-e3d6-424c-ba09-4e5f61cfe602"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c96e8c34-7cc9-4cb2-adc4-140ac120335e"), new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"), "default article 2", "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(830), null, null, new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"), false, null, null, "Title 2", 15 },
                    { new Guid("fce3037c-cd18-4b7d-a8d4-2f3895226edf"), new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"), "default article", "Admin Test", new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(824), null, null, new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"), false, null, null, "Title", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("339a5d56-707b-41b4-97a2-c0f5498cedba"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("660ff4ed-76a3-466b-85d5-a9ffad174446"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("096b47d9-5ec6-4013-8f2c-f956a56a5bc6"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ce9f3478-5f88-4250-b1cb-a38282cd3875"),
                column: "CreatedDate",
                value: new DateTime(2023, 5, 6, 22, 41, 6, 692, DateTimeKind.Local).AddTicks(1281));
        }
    }
}
