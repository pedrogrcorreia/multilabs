using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddLaboratoriesLocalsRel : Migration
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
                values: new object[] { "486e87a1-6ca9-43f2-89d1-c498336ed3fd", "AQAAAAEAACcQAAAAEFBzmIOmG6ooSK5nRv+YnKpQKYFeawY4eFzrJnu7ylj9yBMdfZHDfRaH8Qtz8PYCLw==", "c0a60cca-0aa1-4d28-8d44-2e731984ec79" });

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
                values: new object[] { "83af90fd-7c54-4822-8685-ca3b1970240c", "AQAAAAEAACcQAAAAEIa734zLZE67aGZwV2V0zacQKLRYwLCUeFtaVvkmTy51xxyu5nOdhzos96CcjXQkuA==", "02f45f2c-3081-4b7d-bdc8-5231bb1d2b05" });
        }
    }
}
