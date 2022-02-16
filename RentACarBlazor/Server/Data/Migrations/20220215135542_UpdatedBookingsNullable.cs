using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedBookingsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "72796aec-ccdf-44ca-837b-98c566855c4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f52f07b2-7c4d-43c0-903c-50f738932551");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "794bdf22-720e-49d1-92ab-e208299ed27c", "AQAAAAEAACcQAAAAEIiVGUaLoz1H+b0aHCF/8+3wYUzbbn6v47SvNVo70sVvqcZ3QV/CRV3lCStaOXDFZw==", "821acdcd-8c4b-4196-b76b-bf39077bb193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f123de2-eb04-49bf-9166-ce56087dcb83", "AQAAAAEAACcQAAAAEMyyPpNKAIwr+fcjQBaeY2YAOAgWTAh4ztd5aqMmmPPrut/d9uLkc/NlXdZOWCE9dA==", "c85345a3-3499-4152-88c7-4b40d834d16f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
