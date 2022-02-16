using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "21a3b581-00ef-45dd-8534-4e5cdfe203c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "f0ea3907-7655-4476-a60a-ab4dd965d67f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1120a67b-c6af-4d6b-af81-e00d90d1ad3b", "AQAAAAEAACcQAAAAENiXos51XTnbTR5VYmcLEbYXIzxUIglKSSoUaV7WE1D3t/AI5pBlRkVbqIwToIlnCg==", "1580410c-f7f9-4a59-91b2-418285ec2834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f378229c-5d6f-4219-bd2c-362e7fc6eb7b", "AQAAAAEAACcQAAAAEG9Wp4YxYE8Ypmch21ZyvFlpaJmqBoboW85LVcu7kZ5LYKpoxIvrL4LlYWIrBA0stw==", "618a4c64-4b38-422a-ac61-2cff8c132f27" });
        }
    }
}
