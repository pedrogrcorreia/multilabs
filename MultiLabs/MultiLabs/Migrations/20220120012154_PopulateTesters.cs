using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class PopulateTesters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f00729d-1ca8-4b25-b32b-b105d8b0a65e", "AQAAAAEAACcQAAAAEJB3oHFs/6QxQVLkx1CQ5rFkULgmPQPjcu437XpwHLY9rZ21D8cNa4Jexz6p5iN9Eg==", "164b6392-ea3a-4b7e-a5f6-c2398e31497e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 6, 0, "340352eb-9cbe-4a90-b3f0-1234194238e8", "tester6@gmail.com", true, true, null, "TESTER6@GMAIL.COM", "TESTER6@GMAIL.COM", "AQAAAAEAACcQAAAAEDKLRM0fAunIyaTIU34qTi5T6s+taifp2LNN5OxLLrOYwYuHP6YEomSfENjoEmIiOQ==", null, false, "410986a9-2081-4e48-9926-1e98784764c6", false, "tester6@gmail.com" },
                    { 7, 0, "d32a03a3-9e49-4469-a400-ec96b83b902c", "tester7@gmail.com", true, true, null, "TESTER7@GMAIL.COM", "TESTER7@GMAIL.COM", "AQAAAAEAACcQAAAAENcSI7XLF1OVS2fpE6eVJzsqnlYXiMae2yNUXVoShqRyxFbJk6Qh6E4ULRRudn9k2A==", null, false, "0513f656-ce17-42d6-a02f-0bf01ec28505", false, "tester7@gmail.com" },
                    { 8, 0, "3f42c3bb-64c8-4567-8399-be96a23722e5", "tester8@gmail.com", true, true, null, "TESTER8@GMAIL.COM", "TESTER8@GMAIL.COM", "AQAAAAEAACcQAAAAEOob8HT5MVGRrUIfr7J9Su64jT0xSqdWgS2rdBXWYuCXQLt/0/7NqBRLnC29mET1LQ==", null, false, "ee12f90b-283e-42e9-930b-37249c7fcb81", false, "tester8@gmail.com" },
                    { 9, 0, "f9313028-e7cd-4e23-a57b-b6c842362d1e", "tester9@gmail.com", true, true, null, "TESTER9@GMAIL.COM", "TESTER9@GMAIL.COM", "AQAAAAEAACcQAAAAEKa/v5cVJVhwnC8+uq339hHtOhxJGHXe7i1Hguxus7RLBcmKdApqPdTvY0A3IRbQ0Q==", null, false, "0a02a717-a15c-42f9-9ffd-f8540d49c355", false, "tester9@gmail.com" },
                    { 10, 0, "621fc9d0-4863-4662-a228-3a343b17251f", "tester10@gmail.com", true, true, null, "TESTER10@GMAIL.COM", "TESTER10@GMAIL.COM", "AQAAAAEAACcQAAAAEHYgL7o0xAV26y2zo9LdDzenLlqiW0eaUsdsVI8FQeCyUZw2w3cpIJl3Pk9Th6t0tg==", null, false, "57442334-3d24-4a71-aa12-aceda3968d90", false, "tester10@gmail.com" },
                    { 11, 0, "7557a15a-ca28-454b-8c97-18eb487ffaba", "tester11@gmail.com", true, true, null, "TESTER11@GMAIL.COM", "TESTER11@GMAIL.COM", "AQAAAAEAACcQAAAAENurdCz+LXu2+n2l3gnSVZrgwvJDkSIDsKOiJ332MCDcKNFR9cEkMTtjhwQkSeXthA==", null, false, "8bd4fd7b-1b48-4760-a6b9-9fb64990c04a", false, "tester11@gmail.com" },
                    { 12, 0, "ccc8e322-7601-4099-b57c-2fd29ab14258", "tester12@gmail.com", true, true, null, "TESTER12@GMAIL.COM", "TESTER12@GMAIL.COM", "AQAAAAEAACcQAAAAEEF9mm+1p5eqPfHIBmfgik6HzHl+e+HdvTxvJO3e6gQPxjFq8CTvEJC4JapW/jYwiw==", null, false, "29d5893f-7073-47a7-ae84-03934a1d50cc", false, "tester12@gmail.com" },
                    { 13, 0, "7dcb2b36-805e-48f4-8030-b3cb925a8428", "tester13@gmail.com", true, true, null, "TESTER13@GMAIL.COM", "TESTER13@GMAIL.COM", "AQAAAAEAACcQAAAAENKOEot1OB9LUy6eoSfOzsLlmYzz0/bxCsXD/LUdjDsI61am1p0BwSzEhwsFW7yoFg==", null, false, "691ee82a-c5d8-42c7-a20a-f129848e7f15", false, "tester13@gmail.com" },
                    { 14, 0, "509a56ac-c231-4421-b892-c085dc78d622", "tester14@gmail.com", true, true, null, "TESTER14@GMAIL.COM", "TESTER14@GMAIL.COM", "AQAAAAEAACcQAAAAEAbYIZmBnP+4noWOLiuCGv2b4sVHJxB1/pugKo7oiUXegNhICDdDS9muAjYnVtOg0w==", null, false, "dcc6bd96-0642-46a8-a444-c71dfd0e72e4", false, "tester14@gmail.com" },
                    { 15, 0, "583f5fc5-aa57-4872-8b12-ecf50ac11db6", "tester15@gmail.com", true, true, null, "TESTER15@GMAIL.COM", "TESTER15@GMAIL.COM", "AQAAAAEAACcQAAAAECJBJ7DxxxgOkJ7VWLmpO86FEwBdRYdIlBZKpwdferflBQfEJM4bY+FU7lo6fIr2ag==", null, false, "963754b2-0038-4f3a-ac91-b58694dcf013", false, "tester15@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbaaafc3-1cf8-4429-8bd5-70fd6b6f7861", "AQAAAAEAACcQAAAAEAzAdJcEnyK2a37wLZOWst652guDYCqPXoBGAR8CiratkCIhRMfZJr7Gqc+FL2pdxQ==", "e271b230-6913-4e16-8912-cb4ce306b693" });
        }
    }
}
