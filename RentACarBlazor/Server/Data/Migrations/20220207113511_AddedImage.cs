using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACarBlazor.Server.Data.Migrations
{
    public partial class AddedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "af3c376f-603e-4592-af2c-651c61443af0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6079ac52-6d0e-4ab0-906e-98bad6b3ec7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "434de51d-897d-4d7b-8059-0f5bd2de8a5e", "AQAAAAEAACcQAAAAEHiOvfUx3fUC6iB5ewDeHewNtBbVhfTaJtw2UH5TASVXodTtvGrFj+hlfAuAnSvG/g==", "a3152593-e531-4153-a277-3966153fbabc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc7d06f4-903d-4de9-8409-40c955d1bcec", "AQAAAAEAACcQAAAAEIGDeQNXud07ougm79NzBtQW4MxTEc5hmE399jVWGrtrzZ7GMCTgOvuNNGaPv8O1WA==", "5885cea6-4219-4de2-bc70-eabda9642fee" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5527), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5844), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5946), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5953), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5958), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5962), new DateTime(2022, 2, 7, 13, 35, 10, 322, DateTimeKind.Local).AddTicks(5964) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Vehicles",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c629e53d-9449-4c9b-a42b-3cd654717278");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "b54da6bf-0975-4e91-abaa-e3b25d96fe42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e45865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b89f35-5a64-4a2a-bb67-d24e72d1012d", "AQAAAAEAACcQAAAAEH6saDmbR/yeBnDtoYSluez39rh5QegrpKzNYM2YsEgN1/YV4DeWBMKNU2vxiMigyw==", "28aa4b76-a7f2-416b-909a-f3460c052578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e24968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5cc0751-f3a0-405b-8b32-cd970ee74140", "AQAAAAEAACcQAAAAEFYqmGGKLbTLdbpgk1t2y7gE6Fk2we2N3ZXD2YgKWngbKrXrGRPvU0QpwmTzxxr/Tg==", "81143a08-fefc-4d90-88dd-ab566bd279af" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6165), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6441), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6446), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6449), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6453), new DateTime(2022, 2, 7, 12, 4, 13, 435, DateTimeKind.Local).AddTicks(6455) });
        }
    }
}
