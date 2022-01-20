using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class UpdateScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Schedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40502dea-202c-4040-804b-6ac2bee0cf12", "AQAAAAEAACcQAAAAEEiYLiZxgH62ctH/8/g3CqwznJyo0c4tS9wNRH36LKDTe1589sq58yIJm3AVim3jqg==", "6f8c21be-f88a-43fc-808c-09e4d6beed45" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0250f246-9fcf-4103-9777-d45205c77403", "AQAAAAEAACcQAAAAEA6sizfSugoC5oDZ2GxVV89wnNx0LQ0rvJnTx+nMKj+n/O2BXEcW/q1EklcJIAJshQ==", "3f86a821-f275-4d8d-b357-e56f937646f4" });
        }
    }
}
