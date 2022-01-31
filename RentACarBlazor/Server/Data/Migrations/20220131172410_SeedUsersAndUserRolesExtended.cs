using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class SeedUsersAndUserRolesExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f584ee02-6783-4560-af91-83f3aba39a4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "05b588d7-5c2b-43f2-8200-ab376318da4b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e45865-a24d-4543-a6c6-9443d048cdb9", 0, "1344ac65-6f60-4231-bc6e-31eca3de9ac9", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELegTLk7oiJxwUakzJZfC4yKTJSbREc2eyoqVNO4TaOew/j4GG7thI3LvJjL9u6T8g==", null, false, "877086af-7245-4c73-a702-d4e6e415c80e", false, "admin@localhost.com" },
                    { "9e24968-33e4-4652-b7b7-8574d048cdb9", 0, "04ecf921-d853-472e-a197-1a58a59e7fa1", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELVeLk2KC+Io14iJhhdOrWu3DM4OaJFt6Ew2QSp/jgZuCp2xQ5U+rLPQWgupH+Jriw==", null, false, "e42641b6-498f-400c-9b84-addda7916514", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1061), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1299), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1377), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1383), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1387), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 1, 31, 19, 24, 10, 91, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e45865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e24968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "b922c478-6bc4-427c-b075-c6686e37a5c3", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENADT8su5TYm17V9cefjEYlfaN9+Fata6BxupFyX0T1varkBaThYOEDfYekbq4sDqw==", null, false, "1cef05ba-b3cf-479f-be3c-2579507052b6", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "933a0054-5325-4f96-97f3-5dff7169a228", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEEIqtqXPpvyt1KLralS0XSQSQzoxznZ6Kag3nRPeRyqIUA7qriZkXyQZRgDIYj9+Q==", null, false, "76c3ba78-3efa-43ec-8546-cfe23149ae38", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }
    }
}
