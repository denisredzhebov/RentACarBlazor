using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "eb027086-4d2b-48bf-9691-507ec19a575f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "ccf048ae-b612-4699-b8b9-6c8851b248e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab39fb1c-3c87-48b6-817b-fb98353d75f5", "AQAAAAEAACcQAAAAEOeZiTe8rmvsEGa6806Wkq3M5o53nsK3DXt0Vl2ygo+7UzYUdWpqEsyFswWp9Bpi3g==", "a8d95cb9-c547-4a77-87a9-02c5f9dd2b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "810b4098-85d4-4317-ab82-078209db2fb4", "AQAAAAEAACcQAAAAEADc3gajE29bvAfgoQhf+l3ge6Tlh6RTNYR4GPmYIsXnfL0tCAwjcPxCz5Ag01Q1jw==", "11183b24-1c5a-4c0d-a880-5a983aa8e033" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5109), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5156), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5427), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5465), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5603), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5607), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5613) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a08491db-df06-42e4-8bca-87b95ff21f7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "7a8128cd-cb77-42bb-9b47-2855c51438ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4d33d30-761e-497e-baa5-ca19be5cb939", "AQAAAAEAACcQAAAAEHLi2zfoR4j/3QVXP0CF8ywQZmzwcbZ38HgbfcPvefTHvjd+hTaPKUhnCQKl4ZGv7A==", "3f1e6141-acbe-4eef-b54f-3e043ba824e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b00cbc9a-034b-4fe6-a001-f32369154529", "AQAAAAEAACcQAAAAEEvxNF+Z3rT7Dyo3TKFkkohyMvWgxzB2LYCQk9UIDfl1aTTfOGeRbr9CZZP+IjbRJA==", "7ea9eb80-b1a6-4e6a-ab5f-7c7d2cca40a8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6136), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6382), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6452), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6456), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6464), new DateTime(2022, 2, 7, 13, 36, 6, 511, DateTimeKind.Local).AddTicks(6466) });
        }
    }
}
