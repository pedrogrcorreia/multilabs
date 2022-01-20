using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddLaboratoryTestersTableAndRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaboratoryTesters",
                columns: table => new
                {
                    LaboratoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryTesters", x => new { x.LaboratoryId, x.UserId });
                    table.ForeignKey(
                        name: "FK_LaboratoryTesters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaboratoryTesters_Laboratories_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbaaafc3-1cf8-4429-8bd5-70fd6b6f7861", "AQAAAAEAACcQAAAAEAzAdJcEnyK2a37wLZOWst652guDYCqPXoBGAR8CiratkCIhRMfZJr7Gqc+FL2pdxQ==", "e271b230-6913-4e16-8912-cb4ce306b693" });

            migrationBuilder.CreateIndex(
                name: "IX_LaboratoryTesters_UserId",
                table: "LaboratoryTesters",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaboratoryTesters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f587ea3a-2fa7-48ec-aeb4-ef1fadcdb207", "AQAAAAEAACcQAAAAEDRXx7jbWrRxp0JjGbsanZSEOM0PKJutA/bjYKeZmwJ8rG63KIKT0wyPxTWEHDUKtQ==", "765aa13b-b18f-47aa-95f0-0636e5717388" });
        }
    }
}
