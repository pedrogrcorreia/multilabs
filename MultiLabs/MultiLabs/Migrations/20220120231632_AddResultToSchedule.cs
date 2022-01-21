using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class AddResultToSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "Schedules");

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0731efd8-f9aa-4d49-b8bb-1789aee221a8", "AQAAAAEAACcQAAAAEDmUCea7xEr8Wkhoer2klid42Qrh7s4i6MCXLW1QxlMfTm04Hmx6fXNFRO/bLSRDLg==", "e8f9ef29-2cc0-450d-8c95-1eef79b6c2b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eff2b707-a761-47a9-9172-c465a83d860f", "AQAAAAEAACcQAAAAEHby1xbXixNB6ZqtlWhf4y8zaEOpeohl0h81CwbjcLrEQymaxXkF7qOn+ve4UWq3Hg==", "dd0e22ae-329e-4cc3-8909-3139e34ca9a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93946f4f-baf2-44ef-99b3-4ae341bfc519", "AQAAAAEAACcQAAAAELAtadK95ge7NQpHO1xCYG+TwyPdEs0kf0PisDM4z8A82Llqel4kgLRS6zAqsUv0hw==", "8df4c6e2-79be-45db-b2c1-858efe08ed0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90872ff1-e898-41a4-b1e1-43ef6005bcc7", "AQAAAAEAACcQAAAAEITiNPyCZDodii0ZaIo/kfFMA/H8MilxbdeZa3Oe9/EvRGamrbxhikLke8ctPpAE9g==", "796ae4a3-7c89-4c8e-b674-9ee8e1f68eb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956e6361-ccaf-488d-b3e9-8ad165c03509", "AQAAAAEAACcQAAAAEKSadGU7VwvPHdV9usLEEoYxadmGB/iNgP9DRg5ZnvJt3vHIeslCL8vqNbmxYCIHig==", "c526ca75-7f32-464c-87d3-00831b2aafe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6abb81f-bac1-467e-9aba-c5f20de99386", "AQAAAAEAACcQAAAAEIiyx2lxTj3Nae/+FM/HFi+meiP3UfFYAHDBjod9QlY7nFCrZB37HA6bvGMNZpevbA==", "a5a19a49-f94b-4b39-847e-4de7d32033ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08894c37-418b-4d00-b816-fa9e279902f5", "AQAAAAEAACcQAAAAEE52lM8oHjqFv0NeGhwyYE6AsZlmloIuigpBkrOJx7x4gHFtFuXNK/W3WWap0v6IaQ==", "24bff8d4-3826-4205-b799-92362d5f57df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f953f5-9bc8-4ded-9abb-edbb295760e2", "AQAAAAEAACcQAAAAEE9S6b8y7tI0VDmhdx8tYfuZF27jp6zT40RRv2KCYdZCdwBwVUp7AH9JeybIS9oRAQ==", "30648685-d8b1-46b3-8b56-eb781a578901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7fc09f-eb52-4eac-ad84-76fe40fc1ae4", "AQAAAAEAACcQAAAAEMlbEvQAjxZUtcP7CmMP+naX15cSKDIkgT6pJqPsWkHo7Hnu21iyaFwtgxq6dAfZEA==", "4d94987b-e9e2-4c17-9efe-72b481943f99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c944ee35-8e7d-4014-a93d-340fcc0ff565", "AQAAAAEAACcQAAAAEK9THuwkBCYOMWmwXu/TM2pAYlVV7DzqvbvxUniIQY9RKa0mMBlWEQT3KmTjXYXXuw==", "00ce47aa-ac3b-445e-952d-aed97f8b452e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6b4c373-7ca3-4e7c-b393-dd8cc49b9f4c", "AQAAAAEAACcQAAAAEKbTCTU7j2Cx2BNeFzYaXhI/tXNh8s3TK4ABKYZamyWFfu9Vp7xNjYKWn9kfQmcPdQ==", "4edffc4f-1120-4f1b-8f71-2e1d06bae300" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ResultId",
                table: "Schedules",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Results_ResultId",
                table: "Schedules",
                column: "ResultId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Results_ResultId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_ResultId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "Schedules");

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
