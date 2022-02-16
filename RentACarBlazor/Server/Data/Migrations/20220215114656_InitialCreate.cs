using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3b9d7712-eb9b-48b8-89d3-858e2f14c9a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "82fce92f-b2ee-4338-8688-e5f36d8d8026");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "334ebb11-499d-4903-88f3-e20cd17c39a6", "AQAAAAEAACcQAAAAEOfAjMwRdv0G/E4lOI0g+Fj3EG2PAd/XZei+T24urDithsl4P6Rag+tg3Qp4y5+u0w==", "e28c9166-9955-4e14-982d-7fa6326c0214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f8cdef2-9301-4e1c-a71f-0b6985799fb4", "AQAAAAEAACcQAAAAEMcfchJ5epwGRVtwEBQbal9EZeW4o+bLON4nhVnqNpPCOshGPnJ4V2EF/E4pDGKnrg==", "66358922-82c0-4616-b7b1-d3c1e6a9ff53" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(2905), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3106), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3188), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3192), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 2, 15, 13, 46, 55, 907, DateTimeKind.Local).AddTicks(3197) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ba527f8d-7246-4da7-a6d8-9a9f1ab9ca12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "cff59f61-f76a-432a-ab2c-f1e30ca600d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1533a3f9-824d-480f-b562-cd4dd9954023", "AQAAAAEAACcQAAAAEJ2rbhZarkvByHZHZP8pQHMyWbdiquEvt4sFqyrGQUK4eDj+qiJwG+eGD0PL81kSXA==", "d06060ce-c4f7-4ebd-9ee0-453462992521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dc01165-a353-4990-90c0-931bc0efce2f", "AQAAAAEAACcQAAAAEPnkHb3cGmwoPh4+0MP4FMHWQDocX0fjuFex32jiDVlLah6bIReAu70R4IqW+VxDWg==", "e64df8af-2e24-41d1-afd9-79e04cf0c543" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9238), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9278), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9469), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9475), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9571), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9575), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9579), new DateTime(2022, 2, 15, 13, 45, 17, 621, DateTimeKind.Local).AddTicks(9580) });
        }
    }
}
