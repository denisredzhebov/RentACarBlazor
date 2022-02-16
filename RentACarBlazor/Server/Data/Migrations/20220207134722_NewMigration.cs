using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9df0a2e3-b25a-40ba-b209-0b1e476baaa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d45ea5d5-4ad9-46fd-bd63-7a474a2dec75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "380b09ea-230f-4c4b-969d-c0922a7144d2", "AQAAAAEAACcQAAAAELs+KgFSgtrR/jAM7ZaJdzOCNwy6UmDhK58otX2QHiE40qYLrdtEGUJocfaRrsBn9A==", "f63135cb-cf4e-409a-a666-f9d107cca0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8beaa3f0-95e4-4c87-96dd-9b8750e2d0d5", "AQAAAAEAACcQAAAAEAaI2RSq5DhzBDi0kojdUmKKDsCqgpi8unw3sJyrI5gRrvK8GXepxB7G8zH8gPku+A==", "de01e071-9c47-4416-8e85-b396d11a6e58" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3044), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3316), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3319), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 2, 7, 15, 47, 21, 666, DateTimeKind.Local).AddTicks(3325) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e1235f59-357b-41cd-bac5-a7ebe3c59513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "9c4bd362-956f-47c0-862f-27405288715a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033cc356-410e-4f50-bd36-5fe45e61eb79", "AQAAAAEAACcQAAAAEOkWTf794SYuRYB3ptwtcyG1iKjVlj5vosNfiVOsY0mhE5+POjNFoM7yHN+OZ6+/Iw==", "7873ebc0-caa1-4a92-94dc-d27bac643a0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae46673-a590-4704-9e5a-4b2cf05da284", "AQAAAAEAACcQAAAAENvfjLAO60W34h+OCT3ssDCkkd2ZFon5Cx0qXZuOd4vsBJvf+AnOFD8OElOAqnUkZQ==", "15ddd9c1-49f3-4fe4-8208-37aca37a44cb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2187), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2188) });
        }
    }
}
