using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "40fbc25d-218c-4a68-8530-06b6d252dc2e", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "ca6204b9-72d6-4795-80f9-d208ab04dd5d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9355e947-40fa-4cd6-b696-8e9864bb1573", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAENLxSepDHF50b5eQ8V2KuPzbLNcXFSvd3wO0k+n1Scryl2D4Dv3FxGZ9eeT5Jmx/gg==", null, false, "0d0c01b7-6b85-44de-81b3-288e545a8e9c", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 395, DateTimeKind.Local).AddTicks(5755), new DateTime(2022, 11, 22, 12, 26, 16, 396, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 396, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 11, 22, 12, 26, 16, 396, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(1270), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(1278), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3918), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3925), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3927), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3929), new DateTime(2022, 11, 22, 12, 26, 16, 397, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 792, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6016), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8817), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8826), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8831) });
        }
    }
}
