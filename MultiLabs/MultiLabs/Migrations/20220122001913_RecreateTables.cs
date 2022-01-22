using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class RecreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13280ef2-649b-4e16-949d-a874ea1cc201", "AQAAAAEAACcQAAAAEJTzshUXYVdcPYFtRSQYryNQIDxTNNahNz08w73Y+yJKAQ3M7pBH1sgvEEq0RUmkXA==", "75c28995-7e87-4b22-8b3f-e6782b8e227e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee956981-8fa0-4e42-9985-c75ded2c6230", "AQAAAAEAACcQAAAAEP6Go2jq+QoXisDXegaMCTpBzimd5FT3j18cUPI9p4wp89KLippwHszfxmuwC1Amgw==", "277030d3-8659-4cd7-b1aa-b849448a5720" });
        }
    }
}
