using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddTimeSlotsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableSlots = table.Column<int>(type: "int", nullable: false),
                    LaboratoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSlots_Laboratories_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "Laboratories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0250f246-9fcf-4103-9777-d45205c77403", "AQAAAAEAACcQAAAAEA6sizfSugoC5oDZ2GxVV89wnNx0LQ0rvJnTx+nMKj+n/O2BXEcW/q1EklcJIAJshQ==", "3f86a821-f275-4d8d-b357-e56f937646f4" });

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlots_LaboratoryId",
                table: "TimeSlots",
                column: "LaboratoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeSlots");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0682077b-cc47-4fab-80e0-86048aed464f", "AQAAAAEAACcQAAAAEMdSkHjocPCItJMdiqioNeg44JPksvma1PC9AII38CXIIvxECQqv8HB+Y4B4g45EaA==", "5340af1d-42a8-41a0-8036-a9b92688e6e3" });
        }
    }
}
