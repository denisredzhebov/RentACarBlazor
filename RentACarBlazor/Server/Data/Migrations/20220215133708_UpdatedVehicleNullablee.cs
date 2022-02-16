using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedVehicleNullablee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8798a2f3-4000-44c5-9852-d25434705f16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6a1f22a1-39d8-45e6-afd5-47e379d94b5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffb0d009-1c79-4d57-ab91-f96a61cbb513", "AQAAAAEAACcQAAAAELVTfcfTA26y+eUcX4/khXlSIa0VpF7vuMANBa4mqCkxyAYTbKnBApaoBgilT0GeVQ==", "b1ab0a7c-53cb-4c97-840a-a02cbc0a31cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51a59e3c-b351-499d-af6d-79ce57ed6d5f", "AQAAAAEAACcQAAAAENsJdGh7QNMQL2Vu2MP38qpYFffr6UdopeMc1t1RBns2Z3p9IsVw/vhYxXdiOBqcCw==", "231041ba-de1e-41fe-bdcc-7348fc7f9d0d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Vehicles",
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
                value: "ad2214ac-a40e-45b4-9df4-a8918540777b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4d7d754b-c11d-4a34-a4f2-4ed22728cc35");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e51b0ad-ad5d-416f-b0ef-5669d2cb5ce8", "AQAAAAEAACcQAAAAELwom9g9cU4PbDiHU4Ny4O8oW5rhrMe8mDFZX9ox0YDop+Fw18ZkcNidlE4YlO3NrQ==", "55442287-466a-41eb-9d2e-ddde05accae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "115f101e-4539-4492-a4ef-c18334dff963", "AQAAAAEAACcQAAAAEBQHaW0ztuRqk2d8cZU8fkbo4Lf7Qks67uBVjruUZrgW6fkyvnfDQFGlrfmlzkS4yw==", "0a1f3997-0326-4046-9e0e-b09ba1eafb44" });
        }
    }
}
