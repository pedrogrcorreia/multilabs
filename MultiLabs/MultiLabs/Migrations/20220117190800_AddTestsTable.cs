using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddTestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aab40c6-759f-4d80-8a8b-3ffe4afb3655", "AQAAAAEAACcQAAAAEEIaG2kdK/qR/XsmCinM1DaF2+66arSXmVtQAd+774P97phWQoelNGLZgoyXKDMVCQ==", "313906c7-7e0a-4961-bfdb-17cd67ffc45e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2f470bc-23c9-4b62-b0dc-009be1c5041b", "AQAAAAEAACcQAAAAEPBjTG9dxWK4Yh/qDM+Uvc0gA8Mwun/81/Ur5UOTLCNylxscPtR4OL+fFypy6B+EYA==", "4af6fc47-fc17-42a0-b7c0-c11e695c4ecd" });
        }
    }
}
