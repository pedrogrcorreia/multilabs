using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class CreateTestsTable : Migration
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
                values: new object[] { "f98a684c-bac2-4fd0-871c-52d71d1dcbde", "AQAAAAEAACcQAAAAEBqJ+hB3XGtVfCe2NYkvEV+8tgiK+e0u3h9cPUhHYgLIWaoEyukmgGpX2cjDpGnvIw==", "cb84e9a0-3c97-40af-a92e-5535e1716375" });
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
                values: new object[] { "486e87a1-6ca9-43f2-89d1-c498336ed3fd", "AQAAAAEAACcQAAAAEFBzmIOmG6ooSK5nRv+YnKpQKYFeawY4eFzrJnu7ylj9yBMdfZHDfRaH8Qtz8PYCLw==", "c0a60cca-0aa1-4d28-8d44-2e731984ec79" });
        }
    }
}
