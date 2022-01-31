using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9411), "Black", "System" },
                    { 2, "System", new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9417), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9418), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9851), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9855), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 1, 31, 19, 2, 26, 534, DateTimeKind.Local).AddTicks(9860), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(113), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(118), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(123), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(127), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 1, 31, 19, 2, 26, 535, DateTimeKind.Local).AddTicks(131), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
