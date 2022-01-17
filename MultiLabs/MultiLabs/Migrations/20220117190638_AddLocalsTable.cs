using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddLocalsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locals", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2f470bc-23c9-4b62-b0dc-009be1c5041b", "AQAAAAEAACcQAAAAEPBjTG9dxWK4Yh/qDM+Uvc0gA8Mwun/81/Ur5UOTLCNylxscPtR4OL+fFypy6B+EYA==", "4af6fc47-fc17-42a0-b7c0-c11e695c4ecd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locals");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9d580c-3683-42b2-aba1-67b229539a4c", "AQAAAAEAACcQAAAAEGC6RJcFfF5hcfdoKLPouzpFj77N5F8cRLW4nvPTQKfF56UUugk+WA6U0kycGBEoyA==", "452f75b7-813a-4ed4-9a1a-2e1f583a48af" });
        }
    }
}
