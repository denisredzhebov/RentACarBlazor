using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class AddedImageToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "af3c376f-603e-4592-af2c-651c61443af0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6079ac52-6d0e-4ab0-906e-98bad6b3ec7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "434de51d-897d-4d7b-8059-0f5bd2de8a5e", "AQAAAAEAACcQAAAAEHiOvfUx3fUC6iB5ewDeHewNtBbVhfTaJtw2UH5TASVXodTtvGrFj+hlfAuAnSvG/g==", "a3152593-e531-4153-a277-3966153fbabc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc7d06f4-903d-4de9-8409-40c955d1bcec", "AQAAAAEAACcQAAAAEIGDeQNXud07ougm79NzBtQW4MxTEc5hmE399jVWGrtrzZ7GMCTgOvuNNGaPv8O1WA==", "5885cea6-4219-4de2-bc70-eabda9642fee" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5527), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5844), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5946), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5953), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5958), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5962), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5964) });
        }
    }
}
