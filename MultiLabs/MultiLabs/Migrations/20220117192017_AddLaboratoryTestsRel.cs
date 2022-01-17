using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddLaboratoryTestsRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaboratoryTests",
                columns: table => new
                {
                    LaboratoryId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryTests", x => new { x.LaboratoryId, x.TestId });
                    table.ForeignKey(
                        name: "FK_LaboratoryTests_Laboratories_TestId",
                        column: x => x.TestId,
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
                values: new object[] { "d6000d9f-e197-46d1-93ad-15fbdfbe2f19", "AQAAAAEAACcQAAAAEJoWT6DX/KYyAD4dEecn8ufm7sLdeOcexsXEjI+TFyAdjWOB4BrVCIhpczjIqe6Hcg==", "3e7cd409-6ad3-4734-8983-99fca0ec82dd" });

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
                values: new object[] { "9aab40c6-759f-4d80-8a8b-3ffe4afb3655", "AQAAAAEAACcQAAAAEEIaG2kdK/qR/XsmCinM1DaF2+66arSXmVtQAd+774P97phWQoelNGLZgoyXKDMVCQ==", "313906c7-7e0a-4961-bfdb-17cd67ffc45e" });
        }
    }
}
