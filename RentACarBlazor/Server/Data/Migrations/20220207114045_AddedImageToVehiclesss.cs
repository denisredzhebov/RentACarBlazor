using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class AddedImageToVehiclesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e24968-33e4-4652-b7b7-8574d048cdb9" });

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
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cac43a6e-f7bb-4448-baaf-1add431ccbbf", "5bf9010e-9b96-4e19-9bcf-6fb13cb68d5f", "User", "USER" },
                    { "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "c0c5ca49-49bd-40be-b8b9-102e0ac3f658", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "88e45865-a24d-4543-a6c6-9443d048cdb9", 0, "6b212efe-9400-406c-9b79-6de49c050b33", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEASqKJ0eH4FfeBS62owaIgpJR+8yq8qndv+3AhWgPdx4tWUOXG0wjd3Yd2jbgJ/HHQ==", null, false, "49e4d3fa-4838-40f8-827b-d15016fdd82c", false, "admin@localhost.com" },
                    { "89e24968-33e4-4652-b7b7-8574d048cdb9", 0, "aa40137b-86ce-4208-b6d7-e664ff0a2647", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAECrgHxYyvRNXeu2l0lysMpXUk3H5Fy2wji7qslV9+AQXavF3qT/KUpdOq2KwDkN7pg==", null, false, "9395484c-0fba-47fd-88e0-e5bde453f5f8", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "88e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8cac43a6e-f7bb-4448-baaf-1add431ccbbf", "89e24968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "220799e7-f33d-4ef4-9a41-d7bec9355fc9", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "a0a04648-7c2d-4c5d-b65e-861495aa5fba", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e45865-a24d-4543-a6c6-9443d048cdb9", 0, "8f5d37c6-efe8-4ed0-85fb-feffc57b03aa", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFz51VaZ1UMXLvuhQtrHZdpWQHmFrqHxwAtJyImrJy3g0aXMj2Drk/QkBfzytLf/1w==", null, false, "48db90ef-ed42-44ed-b801-27f10a3cf128", false, "admin@localhost.com" },
                    { "9e24968-33e4-4652-b7b7-8574d048cdb9", 0, "05cbbe65-0352-433e-902e-51090fac4f7b", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEROXrUSvqpU1mUxiItF906mf4HFPrfqGRRdWJ/iMow2C5WI0Sga4j2wiahrgmSacw==", null, false, "5962ce60-ebd3-4141-bcb4-08a3e34fd671", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7699), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7738), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7924), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7931), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8014), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8020), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8023), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8027), new DateTime(2022, 2, 7, 13, 38, 27, 902, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e24968-33e4-4652-b7b7-8574d048cdb9" });
        }
    }
}
