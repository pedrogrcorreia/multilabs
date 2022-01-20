using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class ScheduleClientAndTester : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TesterId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "TesterId",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f00729d-1ca8-4b25-b32b-b105d8b0a65e", "AQAAAAEAACcQAAAAEJB3oHFs/6QxQVLkx1CQ5rFkULgmPQPjcu437XpwHLY9rZ21D8cNa4Jexz6p5iN9Eg==", "164b6392-ea3a-4b7e-a5f6-c2398e31497e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "340352eb-9cbe-4a90-b3f0-1234194238e8", "AQAAAAEAACcQAAAAEDKLRM0fAunIyaTIU34qTi5T6s+taifp2LNN5OxLLrOYwYuHP6YEomSfENjoEmIiOQ==", "410986a9-2081-4e48-9926-1e98784764c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32a03a3-9e49-4469-a400-ec96b83b902c", "AQAAAAEAACcQAAAAENcSI7XLF1OVS2fpE6eVJzsqnlYXiMae2yNUXVoShqRyxFbJk6Qh6E4ULRRudn9k2A==", "0513f656-ce17-42d6-a02f-0bf01ec28505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f42c3bb-64c8-4567-8399-be96a23722e5", "AQAAAAEAACcQAAAAEOob8HT5MVGRrUIfr7J9Su64jT0xSqdWgS2rdBXWYuCXQLt/0/7NqBRLnC29mET1LQ==", "ee12f90b-283e-42e9-930b-37249c7fcb81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9313028-e7cd-4e23-a57b-b6c842362d1e", "AQAAAAEAACcQAAAAEKa/v5cVJVhwnC8+uq339hHtOhxJGHXe7i1Hguxus7RLBcmKdApqPdTvY0A3IRbQ0Q==", "0a02a717-a15c-42f9-9ffd-f8540d49c355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "621fc9d0-4863-4662-a228-3a343b17251f", "AQAAAAEAACcQAAAAEHYgL7o0xAV26y2zo9LdDzenLlqiW0eaUsdsVI8FQeCyUZw2w3cpIJl3Pk9Th6t0tg==", "57442334-3d24-4a71-aa12-aceda3968d90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7557a15a-ca28-454b-8c97-18eb487ffaba", "AQAAAAEAACcQAAAAENurdCz+LXu2+n2l3gnSVZrgwvJDkSIDsKOiJ332MCDcKNFR9cEkMTtjhwQkSeXthA==", "8bd4fd7b-1b48-4760-a6b9-9fb64990c04a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc8e322-7601-4099-b57c-2fd29ab14258", "AQAAAAEAACcQAAAAEEF9mm+1p5eqPfHIBmfgik6HzHl+e+HdvTxvJO3e6gQPxjFq8CTvEJC4JapW/jYwiw==", "29d5893f-7073-47a7-ae84-03934a1d50cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dcb2b36-805e-48f4-8030-b3cb925a8428", "AQAAAAEAACcQAAAAENKOEot1OB9LUy6eoSfOzsLlmYzz0/bxCsXD/LUdjDsI61am1p0BwSzEhwsFW7yoFg==", "691ee82a-c5d8-42c7-a20a-f129848e7f15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "509a56ac-c231-4421-b892-c085dc78d622", "AQAAAAEAACcQAAAAEAbYIZmBnP+4noWOLiuCGv2b4sVHJxB1/pugKo7oiUXegNhICDdDS9muAjYnVtOg0w==", "dcc6bd96-0642-46a8-a444-c71dfd0e72e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "583f5fc5-aa57-4872-8b12-ecf50ac11db6", "AQAAAAEAACcQAAAAECJBJ7DxxxgOkJ7VWLmpO86FEwBdRYdIlBZKpwdferflBQfEJM4bY+FU7lo6fIr2ag==", "963754b2-0038-4f3a-ac91-b58694dcf013" });
        }
    }
}
