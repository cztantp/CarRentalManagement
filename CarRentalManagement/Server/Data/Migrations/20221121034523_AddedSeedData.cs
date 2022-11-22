using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 45, 22, 792, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(5923), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(6528), new DateTime(2022, 11, 21, 11, 45, 22, 793, DateTimeKind.Local).AddTicks(6533), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6016), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6023), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(6027), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8817), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8823), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8826), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8827), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8829), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 11, 21, 11, 45, 22, 794, DateTimeKind.Local).AddTicks(8831), "RAV4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
