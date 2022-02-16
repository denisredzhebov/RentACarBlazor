using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class IgnoreNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2d2a80b9-f5d2-4b7f-8fec-a17006ac72ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "5d93f8ef-59cb-4156-a5fb-e2ee67fc0313");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18ec408-effd-463d-82e4-8e8b376cd7bd", "AQAAAAEAACcQAAAAEL67e4SyKjgdaW1RfWGEisHWn03eeGflm7tXyo1sF0yBS0br27zMoFQ3IJ5aF4k0gw==", "0762ea98-293f-465f-8ab4-e736445a0468" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3ffe5f0-b5da-400a-b7fd-258c19d509ec", "AQAAAAEAACcQAAAAEM85SazyjV6gwmfmVrps1Bb9XnXvCFC95ImJ4+kNfdUTLgljWDnXpUhwV+NAGx0tTA==", "44f66c99-cd75-41c3-8e49-5a3ea17283a8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5819), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6039), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6112), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6126) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f3ae9d2c-5490-4d06-a9c6-c70f7e555d7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e8ab78a1-4e8d-487b-b760-9699d474e9e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3179f945-fa7e-4dad-ab73-281f3c6d92c8", "AQAAAAEAACcQAAAAEOgZ74UixUYN0asRU9MdvogEPkzQ2JXFg6xZAu+flNgeznnF3TRJ6cPnDg4s0yK3Tg==", "e6db610f-2969-45fd-a9c2-6fe905b3a5e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b085447-38db-4546-b7c8-fd0b3f7e98a0", "AQAAAAEAACcQAAAAENkXxYQNnv+e66R2++7Pb/XJjMpec/YTnIa8yAKjctD7ztqeB6zrAcXq/louuXCFMQ==", "d6e13a60-7fc3-4b5b-9234-4937199ea802" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5218), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5278), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5793), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6162), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6174), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6187), new DateTime(2022, 2, 7, 14, 38, 39, 75, DateTimeKind.Local).AddTicks(6190) });
        }
    }
}
