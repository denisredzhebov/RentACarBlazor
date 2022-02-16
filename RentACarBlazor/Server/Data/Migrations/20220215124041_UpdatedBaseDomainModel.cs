using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedBaseDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "01d30f77-afde-45e7-a4d9-c0d0a25366c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "433b034f-232b-495a-98bf-7f69fd50e9c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87bf4617-37e8-4c0d-bcef-a229a11234c6", "AQAAAAEAACcQAAAAEFDJZaJad9eo38AV+qSbyOq7EtFyVo9yHRNMoVJeVx5D+l2/QzdOR50LyjlNffeCDA==", "6e33a52b-cde5-4db8-a582-4bab4156b10a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96840b5b-dd18-4bb8-a227-d3bfe6adff91", "AQAAAAEAACcQAAAAEB2f8yr98hxaWLvGtdxHUzPnbhr7zrYHh6/RDXDxocUEiy30OzfGGaOpqNAM/XyXlw==", "823e4d3f-6743-4d2e-bd23-e1096f11e3c6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7112), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7839), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7851), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7865), new DateTime(2022, 2, 15, 14, 40, 41, 191, DateTimeKind.Local).AddTicks(7868) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
