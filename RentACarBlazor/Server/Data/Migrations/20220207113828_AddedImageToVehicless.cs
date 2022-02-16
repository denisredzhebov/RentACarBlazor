using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class AddedImageToVehicless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "220799e7-f33d-4ef4-9a41-d7bec9355fc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a0a04648-7c2d-4c5d-b65e-861495aa5fba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f5d37c6-efe8-4ed0-85fb-feffc57b03aa", "AQAAAAEAACcQAAAAEFz51VaZ1UMXLvuhQtrHZdpWQHmFrqHxwAtJyImrJy3g0aXMj2Drk/QkBfzytLf/1w==", "48db90ef-ed42-44ed-b801-27f10a3cf128" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05cbbe65-0352-433e-902e-51090fac4f7b", "AQAAAAEAACcQAAAAEEROXrUSvqpU1mUxiItF906mf4HFPrfqGRRdWJ/iMow2C5WI0Sga4j2wiahrgmSacw==", "5962ce60-ebd3-4141-bcb4-08a3e34fd671" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "eb027086-4d2b-48bf-9691-507ec19a575f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "ccf048ae-b612-4699-b8b9-6c8851b248e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab39fb1c-3c87-48b6-817b-fb98353d75f5", "AQAAAAEAACcQAAAAEOeZiTe8rmvsEGa6806Wkq3M5o53nsK3DXt0Vl2ygo+7UzYUdWpqEsyFswWp9Bpi3g==", "a8d95cb9-c547-4a77-87a9-02c5f9dd2b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "810b4098-85d4-4317-ab82-078209db2fb4", "AQAAAAEAACcQAAAAEADc3gajE29bvAfgoQhf+l3ge6Tlh6RTNYR4GPmYIsXnfL0tCAwjcPxCz5Ag01Q1jw==", "11183b24-1c5a-4c0d-a880-5a983aa8e033" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5109), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5156), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5427), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5465), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5603), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5607), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5611), new DateTime(2022, 2, 7, 13, 37, 40, 282, DateTimeKind.Local).AddTicks(5613) });
        }
    }
}
