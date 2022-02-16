using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class NonnullableProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a7f58b79-68f0-42e6-b94e-36ead9806335");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "061ff786-0191-4936-831b-10e6a9660989");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42740967-a765-4d8f-8e8c-602ba7f82f65", "AQAAAAEAACcQAAAAEFSPwYGRjfdbeKc/rOAN75H/qL6UyTQH8SnOHjq5k8/XoT+ppnmdTUqThMxwb8DHwQ==", "4986a53c-ee0d-4e4a-9d3a-eb5d2cbce352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5f4b23b-5b21-43df-a39c-49d6dfc65170", "AQAAAAEAACcQAAAAEOVi5+diccTqjsyLHkPzIKUEj9flTUM/PVHqG9Ym9cr5HPLcuufJT8ggnXKQwpdb0Q==", "28688be6-4e83-484b-9f6f-49b94fcc5bd1" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6603), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6639), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6826), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6973), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6978), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 2, 7, 14, 26, 29, 303, DateTimeKind.Local).AddTicks(6987) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5bf9010e-9b96-4e19-9bcf-6fb13cb68d5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c0c5ca49-49bd-40be-b8b9-102e0ac3f658");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b212efe-9400-406c-9b79-6de49c050b33", "AQAAAAEAACcQAAAAEASqKJ0eH4FfeBS62owaIgpJR+8yq8qndv+3AhWgPdx4tWUOXG0wjd3Yd2jbgJ/HHQ==", "49e4d3fa-4838-40f8-827b-d15016fdd82c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa40137b-86ce-4208-b6d7-e664ff0a2647", "AQAAAAEAACcQAAAAECrgHxYyvRNXeu2l0lysMpXUk3H5Fy2wji7qslV9+AQXavF3qT/KUpdOq2KwDkN7pg==", "9395484c-0fba-47fd-88e0-e5bde453f5f8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6289), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6326), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6632), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6639), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6713), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6718), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6721), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6725), new DateTime(2022, 2, 7, 13, 40, 45, 94, DateTimeKind.Local).AddTicks(6727) });
        }
    }
}
