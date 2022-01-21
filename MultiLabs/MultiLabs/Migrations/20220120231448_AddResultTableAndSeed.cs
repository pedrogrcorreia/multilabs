using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddResultTableAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34dd7097-580e-49c4-866d-ce1e314a6c32", "AQAAAAEAACcQAAAAEEYxA9cyUlGGZiB+m6MMh7akyqsrQOPLPjSzyokwdV0//mc8RUfaA/cxso3T5BOLgg==", "90df8eea-3b6a-406e-ba04-c6f8fbce9036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97aba33d-73d2-476c-9447-32b80d5eec59", "AQAAAAEAACcQAAAAEE1aj22gW7LSKyMnHQE9tCFQUMly//AsJsA99pV+ERhglUQ0Heh3TUzQn70buUdR2g==", "b5a01ab2-9db0-426c-8857-ae490a17195d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "739ea13b-b9df-4038-85a5-c1560063a150", "AQAAAAEAACcQAAAAED9aorXSpRBs6d+5pp9kEketY/SqonsFgRhLn8P8RpE/BuKk5sJUaIGlZngoxZqj/Q==", "3b2a9386-8e98-4d47-ba5a-f404cedddc06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98d01372-b075-4b4d-9d5b-8d54d5eefdfe", "AQAAAAEAACcQAAAAEFUNM2ihv79YJMjLxDK/Vto/kiAueUxjTxAwTU15shy4H2+9qz/bDfOBd2/682ID/Q==", "17a75215-f4a7-4e3e-9d16-1f902bdd60d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb1419a1-bc6b-451f-8d61-241d2b7d53dc", "AQAAAAEAACcQAAAAEBR3s0e4hp4iXwgZ27UfYpjnRoqW9tC5PrI5GTAzMNz+eELKWSRMPjJWbd6YPp3wZg==", "fc6c1054-946e-4f11-9c59-0520fe98e6e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56cfa8af-1af4-49c8-af1c-52dfe5fc5574", "AQAAAAEAACcQAAAAED2CmskCe8L4PV9c8qaKUIImK6vYb71XxZTn0+I6c+pl4asY7qszXuOWTtxU9AqKxw==", "2c2e84f7-85f9-437e-81f7-e75086b854e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e5aa154-1f9d-4ec0-80fd-716e3e13b3fe", "AQAAAAEAACcQAAAAEN/bQmTXimo+mHoozGv9PB/4wme6nlR5kJgurd8JFU1HhKfVHTw8TdHxLVkErIpEJw==", "f28fa4e0-4f6a-49cd-85e5-c59c49d6217f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d295dc3-fc3c-4aba-9d91-a32239c0180d", "AQAAAAEAACcQAAAAEPjAvfZB91Fl4y4Zq4zw15vUb2HmNhZqeV0p5WB3jGNIySwIUI4zeG0t1nYxtQH8fQ==", "b23f1026-d5c4-4d94-a55a-6bf5c5419436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "061d419f-6642-40b4-bda7-9348048dcfc2", "AQAAAAEAACcQAAAAELpmkqcc+OyQCok2a/JWcf5f0AzYHc00qWZ7PgVfoWO56XXgbJmN5L8XUgEnsgO4BA==", "244061fe-4086-4c81-b83d-8846c94c8da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10866760-26c9-4594-b2d0-292f21a80342", "AQAAAAEAACcQAAAAEHxR5gO4TFsxbCG/c4gbVfholnIkZtb3iGfyiLBQZ2Jbed0/ImRJIpkSI9xjyiWweA==", "b8816d73-b16f-46fa-9c3c-74b26f1f58a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e0513a7-69d1-4b36-81d7-31dbe4d90d17", "AQAAAAEAACcQAAAAEDZk7E1k7ohXNaLDzTEPs2c3Ttjl2lGnPk8a30Xno50SiL2RMaMsngaZ68/WXC0+fQ==", "15657487-b034-45ce-b78c-7d7eaced1f8d" });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Negativo" },
                    { 2, "Positivo" },
                    { 3, "Inconclusivo" },
                    { 4, "Outro Valor" },
                    { 5, "Não realizado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22937bd8-134e-48e8-9dba-e547ed5c8f77", "AQAAAAEAACcQAAAAEPuh7Y+6vxNZpSl/0T8FMTV2NNaMxYNBSbGTWJq5qE8f2Fg9n4rh12qjkw3yRT50ow==", "6bb75983-6b42-48ea-9ee8-7e1e40cb489e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf6f9adf-6e17-4d58-8738-c130713dbff0", "AQAAAAEAACcQAAAAECo3dkFRmRplz/TOoulGah582CQYaZw9zROsco2jdRv61wUUezewiF377a32cupP+w==", "a6703e18-3b1c-4a0b-a12d-d524bfb74db2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a950feae-678d-486f-beb4-8f39f11503f8", "AQAAAAEAACcQAAAAEJfuLV/LEQoQAWRgkGWQMNyOh+G1+Mswa0QqYuOqx/lrcsHSusrGOd3Xf+rocy05vw==", "bbb57a4a-1b8d-4490-9e03-2fa499df81e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63b1ed9a-f2f7-4a20-9ac1-7382a7e01b50", "AQAAAAEAACcQAAAAEMxn4veKXI0DmTMKhL9O+fN/EI+BTA7gpWDat7yDgyT+Wu3dZfYARXw0giww/ycSFA==", "155f5848-0531-445f-81e9-b2cafdad1577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49047475-08fc-40fa-a216-41dde2ec1623", "AQAAAAEAACcQAAAAEEemx7hd6BdF6tcNMEsMJzESqtqxPaSDsl2NdWFM0+hNiza+rJ8UKCyY5wYt8shNaQ==", "fd9fbd46-be3c-4439-92c7-c5e78ee1fa42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc1ee26-9f93-4f10-89eb-f2ce4c179d84", "AQAAAAEAACcQAAAAELWrlNSp0SqB4UUxlRBbLkm05bDRrjbYK7stDJ32nkhXn6NRdBkpPH7Ta6+v5IW7IQ==", "50f7c695-824f-4fb8-bf3f-46655b3982de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c70ed4cc-330f-4b89-93c4-894b8a5ece3f", "AQAAAAEAACcQAAAAEO9Nuan6DUsPy4twBQdvvXzludm7SFRb4fUyVQP49e/MhOnmfBckuQrSg7O8elLH9w==", "5d10d72b-3c67-40ba-a210-74d0cd68b1fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "017e1ab7-f117-4ab7-ac21-a7cdf3877230", "AQAAAAEAACcQAAAAEBpHENQvK1eEQ470IfED4/D+jGIZrpPrqhuSTKBNi5w9Sjl+zdxOtINOzKqVw4u7YA==", "18b4bb0a-75bf-4b7f-bb52-629163618291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8925b4c-4aa4-4be5-8fd0-8dac2ca20827", "AQAAAAEAACcQAAAAEKGfbgh635hyyF5C1SPcqcJApx41VoSqjKrpZa3UYZ4/UDtB5YVpTaM9KcDRu3eIJg==", "ec6e2995-7392-4142-b736-fa72801ec4a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3a730e-bec8-45e1-866c-55f12ca376a6", "AQAAAAEAACcQAAAAEKNdBhWeQMdhxJJOqDHUuVbKRNNqdiKmgGDEIiL4F8loMU+eqt42zm78Fr3G0UUjmQ==", "b8562d0d-24b6-4a58-a8c8-0cbee40df111" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8012992-c9af-4df1-af44-de145ca37f1a", "AQAAAAEAACcQAAAAEEO6cTtm0wj6rli8Cal9+5NaMst3nRsglLD33bt5NSUawDxnU/qXrJSbkJEYoWjKcQ==", "1898e05d-a6cf-4b51-a96e-4c2e9c094334" });
        }
    }
}
