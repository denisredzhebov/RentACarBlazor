using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "08fde18c-4d9e-4e4d-a11a-3a1444f2ad58", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "366a2671-a800-4267-bf3d-3bb68eb8ac94", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7441), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7481), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7727), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7734), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7810), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7815), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7818), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7822), new DateTime(2022, 1, 31, 19, 6, 46, 878, DateTimeKind.Local).AddTicks(7824) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9417), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9851), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(131) });
        }
    }
}
