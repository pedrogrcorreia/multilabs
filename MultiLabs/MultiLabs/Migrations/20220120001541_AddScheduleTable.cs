using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(type: "int", nullable: true),
                    LaboratoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Laboratories_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0682077b-cc47-4fab-80e0-86048aed464f", "AQAAAAEAACcQAAAAEMdSkHjocPCItJMdiqioNeg44JPksvma1PC9AII38CXIIvxECQqv8HB+Y4B4g45EaA==", "5340af1d-42a8-41a0-8036-a9b92688e6e3" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_LaboratoryId",
                table: "Schedules",
                column: "LaboratoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TestId",
                table: "Schedules",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a700d3-b97e-49d0-9e4b-2fb239c57acc", "AQAAAAEAACcQAAAAEB6xPZbNcNoSsCn43dCVKQ8J0OceBzzU8fjL7Pc1FNP10BcdRMeufEm8Dfo4/D6mrw==", "2ee450a7-3ead-41f5-b390-72711dc4fbf1" });
        }
    }
}
