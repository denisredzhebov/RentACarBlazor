using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedVehicleNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5f7409ea-fa63-452d-8b1b-22e498ef097e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "08f75c1e-82de-4b9d-8c2b-db9cde99b8a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e0e8ac8-0e3c-4f1b-80de-dea7f7e15980", "AQAAAAEAACcQAAAAECQPwmu5nJin/8LLXj0LY8+l0HZ9D3SxMvqoIPkdsQojXdy7HqqqRnTqWtBYoRPc0w==", "751c75cf-d512-4e26-a256-7abba4a96f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c1991fa-b693-4eb1-b72d-c70f7db3540e", "AQAAAAEAACcQAAAAEGGyROxCzeapGrb1/9AEyL+9NpoaS2z72jr7zidMybqGfOlDMqAg8nn3YSHHHPSVSA==", "5ae3b33a-8bfc-40bf-bdff-d9d99580e147" });
        }
    }
}
