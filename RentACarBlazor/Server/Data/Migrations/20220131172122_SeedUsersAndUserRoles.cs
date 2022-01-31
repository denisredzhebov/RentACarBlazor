using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class SeedUsersAndUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "45849a49-11c2-4b3a-bcf3-4a0a9e3b8385");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "30423c52-2c70-47de-89dc-901aac1e43ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b922c478-6bc4-427c-b075-c6686e37a5c3", "AQAAAAEAACcQAAAAENADT8su5TYm17V9cefjEYlfaN9+Fata6BxupFyX0T1varkBaThYOEDfYekbq4sDqw==", "1cef05ba-b3cf-479f-be3c-2579507052b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "933a0054-5325-4f96-97f3-5dff7169a228", "AQAAAAEAACcQAAAAEEEIqtqXPpvyt1KLralS0XSQSQzoxznZ6Kag3nRPeRyqIUA7qriZkXyQZRgDIYj9+Q==", "76c3ba78-3efa-43ec-8546-cfe23149ae38" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(2797), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3012), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3089), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3096), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 1, 31, 19, 21, 21, 531, DateTimeKind.Local).AddTicks(3104) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a55eb047-ae5f-4581-89d0-505513007d6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "ea96c456-88c9-4c03-8234-46c38bee0f06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b63df8b-fb18-4955-a513-97186f411a80", "AQAAAAEAACcQAAAAEHIIxgOgeKNjE4p1Ig8xjNWC0b8geSw9tx3LGzhqhV2wBmezcj9HqlNTFsuJqa3YvA==", "280f2440-acc7-4208-a0d1-fd7cd2c7011c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd17aab9-be18-446e-b099-6a1441875748", "AQAAAAEAACcQAAAAENe6APMQzhNlHnJxiVJyYtAhpFLDG2XVouF58n0k/XmXdxJzW5OZFRw6rkOewS7aog==", "c1305b68-facc-4ea0-868e-64e2fc24b9f3" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2196), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2235), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2417), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2424), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2497), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2501), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2505), new DateTime(2022, 1, 31, 19, 17, 32, 950, DateTimeKind.Local).AddTicks(2506) });
        }
    }
}
