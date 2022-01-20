using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddManagerToLaboratory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Laboratories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f587ea3a-2fa7-48ec-aeb4-ef1fadcdb207", "AQAAAAEAACcQAAAAEDRXx7jbWrRxp0JjGbsanZSEOM0PKJutA/bjYKeZmwJ8rG63KIKT0wyPxTWEHDUKtQ==", "765aa13b-b18f-47aa-95f0-0636e5717388" });

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_UserId",
                table: "Laboratories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratories_AspNetUsers_UserId",
                table: "Laboratories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratories_AspNetUsers_UserId",
                table: "Laboratories");

            migrationBuilder.DropIndex(
                name: "IX_Laboratories_UserId",
                table: "Laboratories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Laboratories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40502dea-202c-4040-804b-6ac2bee0cf12", "AQAAAAEAACcQAAAAEEiYLiZxgH62ctH/8/g3CqwznJyo0c4tS9wNRH36LKDTe1589sq58yIJm3AVim3jqg==", "6f8c21be-f88a-43fc-808c-09e4d6beed45" });
        }
    }
}
