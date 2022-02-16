using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class UpdatedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "928589a6-9ac0-47ac-bf52-37cd27907e95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "56f882ff-33c2-46ab-a5e5-cee6528d0c6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd9e2f9-2620-4ecc-936a-294cc53b90d2", "AQAAAAEAACcQAAAAEHCFd4UThd7UCY2YHodUfgLomxaLBg8fFwp+EgQIb6gizaQAyeROxDnDcGcTvYJIiQ==", "d56a653b-7c5b-4478-a3f7-3a8ebc37f48b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "093ccc44-d62e-41ee-bf87-7354da6383dd", "AQAAAAEAACcQAAAAEHc/QBsLkAlLN9ahV6GeZVgGNhK3WHJsd7TtE7KYzf5a6DpT5qUrO/aE+IiQi2/0Hw==", "b02397b1-4eaf-4bb8-b68b-7018c2df6de8" });
        }
    }
}
