using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class JsonIgnore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e1235f59-357b-41cd-bac5-a7ebe3c59513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "9c4bd362-956f-47c0-862f-27405288715a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033cc356-410e-4f50-bd36-5fe45e61eb79", "AQAAAAEAACcQAAAAEOkWTf794SYuRYB3ptwtcyG1iKjVlj5vosNfiVOsY0mhE5+POjNFoM7yHN+OZ6+/Iw==", "7873ebc0-caa1-4a92-94dc-d27bac643a0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ae46673-a590-4704-9e5a-4b2cf05da284", "AQAAAAEAACcQAAAAENvfjLAO60W34h+OCT3ssDCkkd2ZFon5Cx0qXZuOd4vsBJvf+AnOFD8OElOAqnUkZQ==", "15ddd9c1-49f3-4fe4-8208-37aca37a44cb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2060), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2183), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2187), new DateTime(2022, 2, 7, 15, 41, 43, 257, DateTimeKind.Local).AddTicks(2188) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2d2a80b9-f5d2-4b7f-8fec-a17006ac72ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "5d93f8ef-59cb-4156-a5fb-e2ee67fc0313");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18ec408-effd-463d-82e4-8e8b376cd7bd", "AQAAAAEAACcQAAAAEL67e4SyKjgdaW1RfWGEisHWn03eeGflm7tXyo1sF0yBS0br27zMoFQ3IJ5aF4k0gw==", "0762ea98-293f-465f-8ab4-e736445a0468" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3ffe5f0-b5da-400a-b7fd-258c19d509ec", "AQAAAAEAACcQAAAAEM85SazyjV6gwmfmVrps1Bb9XnXvCFC95ImJ4+kNfdUTLgljWDnXpUhwV+NAGx0tTA==", "44f66c99-cd75-41c3-8e49-5a3ea17283a8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5819), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6039), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6112), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 2, 7, 14, 54, 33, 517, DateTimeKind.Local).AddTicks(6126) });
        }
    }
}
