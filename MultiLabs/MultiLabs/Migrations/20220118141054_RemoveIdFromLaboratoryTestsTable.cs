using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class RemoveIdFromLaboratoryTestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LaboratoryTests",
                table: "LaboratoryTests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "LaboratoryTests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaboratoryTests",
                table: "LaboratoryTests",
                columns: new[] { "LaboratoryId", "TestId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a700d3-b97e-49d0-9e4b-2fb239c57acc", "AQAAAAEAACcQAAAAEB6xPZbNcNoSsCn43dCVKQ8J0OceBzzU8fjL7Pc1FNP10BcdRMeufEm8Dfo4/D6mrw==", "2ee450a7-3ead-41f5-b390-72711dc4fbf1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LaboratoryTests",
                table: "LaboratoryTests");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "LaboratoryTests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LaboratoryTests",
                table: "LaboratoryTests",
                columns: new[] { "LaboratoryId", "TestId", "Id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3923b37-acbd-430f-844f-c902c36e39cc", "AQAAAAEAACcQAAAAEMfib3IPnPy8L9MZRUqm2eFz+jFlWPVYZE4F9GW0gZJ2NW4n6xNuC+AMqF3iEXzHXA==", "60c53c39-8ba6-44c5-8d1f-29f3e4c59a87" });
        }
    }
}
