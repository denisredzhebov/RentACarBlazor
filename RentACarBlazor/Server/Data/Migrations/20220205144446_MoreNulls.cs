using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class MoreNulls : Migration
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
                value: "963ee45d-16ee-4191-85ba-627187a1ccdf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "43b173fa-ad8d-48f0-83fa-c6ff6ee68a47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e154afb0-8520-4ed6-93b0-14d75f65ead9", "AQAAAAEAACcQAAAAELhcjY0cATbm3HkJ4BJBIVCROdK48rMZHiMjex8o4H0LwAEAYbhCoBfvLgVBwej2og==", "56866df1-be59-4962-be44-56280dc40b78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003a892d-147b-42d1-a4dc-d009f838197c", "AQAAAAEAACcQAAAAEMhZeret+5XVdrqb1V/F6KVnnwQADzPHxuclq8IjxeMTPQw/5I+Rn4avrncQwJrMWw==", "1f962e5a-bf2a-4b72-b3ed-ee33a3915635" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(4982), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5331), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5458), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5466), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5471), new DateTime(2022, 2, 5, 16, 44, 45, 739, DateTimeKind.Local).AddTicks(5473) });
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
                value: "f2b695c0-aa72-4a5a-a6fc-5bde1960d2d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "5f7a12d4-edf2-4a75-a3aa-5df2db0480da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93bd0f1f-cf18-4dea-a407-4e07c17cff6f", "AQAAAAEAACcQAAAAEO2Kn9pPKCr1/zyX6rsoIR52RYEWI8Ku8escfc+HI8BTK947dV74i/B8bE7Ae+blLA==", "a12a8500-69da-4e52-b900-1c9d4a46e606" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07e20073-46be-4726-b68f-0d7b88f33a56", "AQAAAAEAACcQAAAAEBa2+3hGZS+dPp0OX5zdmg5NyFh+Tmty9mUT2Rjp2svbaBMnalcv8YUC2DN8SjnQmg==", "c36668fd-bd54-4e26-b87a-57809b61224c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3256), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3456), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3548), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3552), new DateTime(2022, 2, 5, 14, 49, 23, 515, DateTimeKind.Local).AddTicks(3554) });
        }
    }
}
