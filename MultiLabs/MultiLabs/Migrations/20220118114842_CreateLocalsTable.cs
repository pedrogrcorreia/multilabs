using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class CreateLocalsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                values: new object[] { "83af90fd-7c54-4822-8685-ca3b1970240c", "AQAAAAEAACcQAAAAEIa734zLZE67aGZwV2V0zacQKLRYwLCUeFtaVvkmTy51xxyu5nOdhzos96CcjXQkuA==", "02f45f2c-3081-4b7d-bdc8-5231bb1d2b05" });
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
                values: new object[] { "04c440ec-4524-4193-b391-17d6c3a7af84", "AQAAAAEAACcQAAAAEGCdU46n7vnfHIHx8AW6DXfjy3KUOw//ZgORCv6JjtFZYOxP6wRa/JF5WHWzG7N4eA==", "3003ef71-7129-4ab1-a62c-f6fec219ea46" });
        }
    }
}
