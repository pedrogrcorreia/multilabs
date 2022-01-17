using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddLaboratoryLocalRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalId",
                table: "Laboratories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8547cee-bca2-4695-96d5-637bfb67ea15", "AQAAAAEAACcQAAAAEBJXSbnQbj7NEQC5YoIP3Oj+o6qL+auwWBnuRstM1yh3zp0mYfPOdPS7QjR+S58ngw==", "0c1701f4-de38-4bb7-bc80-2c472ac7ec55" });

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_LocalId",
                table: "Laboratories",
                column: "LocalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratories_Locals_LocalId",
                table: "Laboratories",
                column: "LocalId",
                principalTable: "Locals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratories_Locals_LocalId",
                table: "Laboratories");

            migrationBuilder.DropIndex(
                name: "IX_Laboratories_LocalId",
                table: "Laboratories");

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Laboratories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6000d9f-e197-46d1-93ad-15fbdfbe2f19", "AQAAAAEAACcQAAAAEJoWT6DX/KYyAD4dEecn8ufm7sLdeOcexsXEjI+TFyAdjWOB4BrVCIhpczjIqe6Hcg==", "3e7cd409-6ad3-4734-8983-99fca0ec82dd" });
        }
    }
}
