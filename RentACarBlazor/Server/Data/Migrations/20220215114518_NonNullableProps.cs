using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class NonNullableProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "88e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cac43a6e-f7bb-4448-baaf-1add431ccbbf", "89e24968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ba527f8d-7246-4da7-a6d8-9a9f1ab9ca12", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "cff59f61-f76a-432a-ab2c-f1e30ca600d2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "1533a3f9-824d-480f-b562-cd4dd9954023", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJ2rbhZarkvByHZHZP8pQHMyWbdiquEvt4sFqyrGQUK4eDj+qiJwG+eGD0PL81kSXA==", null, false, "d06060ce-c4f7-4ebd-9ee0-453462992521", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "9dc01165-a353-4990-90c0-931bc0efce2f", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPnkHb3cGmwoPh4+0MP4FMHWQDocX0fjuFex32jiDVlLah6bIReAu70R4IqW+VxDWg==", null, false, "e64df8af-2e24-41d1-afd9-79e04cf0c543", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cac43a6e-f7bb-4448-baaf-1add431ccbbf", "0e772a45-7725-4588-bdb3-169ce49e59e5", "User", "USER" },
                    { "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "99227d58-75a5-469b-b488-10acfcf06da9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "88e45865-a24d-4543-a6c6-9443d048cdb9", 0, "3f424cb5-8378-44c3-99c0-c9c8e6bb03b1", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPGTvW62DzBSW3tYXx+pol6LbZ0YeYDerUHSOFvyCub88AZGpmjrF2IrFSwevtnDGQ==", null, false, "f4ddbe5c-70a0-4fd7-acbf-c49ce704f7c6", false, "admin@localhost.com" },
                    { "89e24968-33e4-4652-b7b7-8574d048cdb9", 0, "4ddbe68b-a55e-4090-ac1e-4da5de62be51", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEG2BGjRDfpOZqAyuOWDBfqvEPvUDaXREcHvDxjYCydtHoWGM0sg0610mWBWP52+9ZA==", null, false, "87aece81-af72-49e5-a58a-ec01b26d256f", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9513), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9759), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9767), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9874), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9882), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9889), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9896), new DateTime(2022, 2, 7, 16, 30, 30, 53, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "88e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8cac43a6e-f7bb-4448-baaf-1add431ccbbf", "89e24968-33e4-4652-b7b7-8574d048cdb9" });
        }
    }
}
