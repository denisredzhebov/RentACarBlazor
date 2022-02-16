using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class NonnullableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "c629e53d-9449-4c9b-a42b-3cd654717278");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b54da6bf-0975-4e91-abaa-e3b25d96fe42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b89f35-5a64-4a2a-bb67-d24e72d1012d", "AQAAAAEAACcQAAAAEH6saDmbR/yeBnDtoYSluez39rh5QegrpKzNYM2YsEgN1/YV4DeWBMKNU2vxiMigyw==", "28aa4b76-a7f2-416b-909a-f3460c052578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5cc0751-f3a0-405b-8b32-cd970ee74140", "AQAAAAEAACcQAAAAEFYqmGGKLbTLdbpgk1t2y7gE6Fk2we2N3ZXD2YgKWngbKrXrGRPvU0QpwmTzxxr/Tg==", "81143a08-fefc-4d90-88dd-ab566bd279af" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6165), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6449), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6455) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
