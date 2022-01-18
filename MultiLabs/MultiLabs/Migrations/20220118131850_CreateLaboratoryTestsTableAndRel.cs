using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class CreateLaboratoryTestsTableAndRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaboratoryTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LaboratoryId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryTests", x => new { x.LaboratoryId, x.TestId, x.Id });
                    table.ForeignKey(
                        name: "FK_LaboratoryTests_Laboratories_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboratoryTests_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3923b37-acbd-430f-844f-c902c36e39cc", "AQAAAAEAACcQAAAAEMfib3IPnPy8L9MZRUqm2eFz+jFlWPVYZE4F9GW0gZJ2NW4n6xNuC+AMqF3iEXzHXA==", "60c53c39-8ba6-44c5-8d1f-29f3e4c59a87" });

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryTests_TestId",
                table: "LaboratoryTests",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaboratoryTests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f98a684c-bac2-4fd0-871c-52d71d1dcbde", "AQAAAAEAACcQAAAAEBqJ+hB3XGtVfCe2NYkvEV+8tgiK+e0u3h9cPUhHYgLIWaoEyukmgGpX2cjDpGnvIw==", "cb84e9a0-3c97-40af-a92e-5535e1716375" });
        }
    }
}
