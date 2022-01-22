using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiLabs.Migrations
{
    public partial class SeedNewResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ee956981-8fa0-4e42-9985-c75ded2c6230", "AQAAAAEAACcQAAAAEP6Go2jq+QoXisDXegaMCTpBzimd5FT3j18cUPI9p4wp89KLippwHszfxmuwC1Amgw==", "277030d3-8659-4cd7-b1aa-b849448a5720" });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "Id", "Name" },
                values: new object[] { 100, "Registado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52810ff8-d1f3-4d9f-826b-ed4fc2b2a2ca", "AQAAAAEAACcQAAAAEJwgzswJ1Eil0M6FYBG8aRF5w5KJn2GoPGHrwocghvofFhg+W/f9Mv5u9LuRsqqEfg==", "17fd09ad-646b-47a3-a096-7ee388315663" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 6, 0, "ce129bd6-db74-4ff4-945b-63405b133405", "tester6@gmail.com", true, true, null, "TESTER6@GMAIL.COM", "TESTER6@GMAIL.COM", "AQAAAAEAACcQAAAAENd/MWSt2oTBpz9/zSKYo09mIyYzEFipUPgu6cXWH4t2jIsCxDOe5yikTSuKRJa++w==", null, false, "bbfc0300-9116-4369-b136-89e798aa8f41", false, "tester6@gmail.com" },
                    { 7, 0, "dbbda3a9-e5da-4a0b-9ea3-985f80f2ee7a", "tester7@gmail.com", true, true, null, "TESTER7@GMAIL.COM", "TESTER7@GMAIL.COM", "AQAAAAEAACcQAAAAEEnAxlaQC80kfhGXNiKJvAnfFvxvBjMK+ydLqbD8R5Y9lEiuNeWGTR4akbZs+VFNTQ==", null, false, "cb71e80a-45b1-4ff2-9bbe-fa6b866fc15d", false, "tester7@gmail.com" },
                    { 8, 0, "b25d0be3-c543-4243-9f55-60a340bba5ed", "tester8@gmail.com", true, true, null, "TESTER8@GMAIL.COM", "TESTER8@GMAIL.COM", "AQAAAAEAACcQAAAAEIlYJ6hsdAicjLQM8EIkHVhmwYaK+5bV1bJhXIh8NxcMQ/IsnNurAFvgFCbHqBJAGw==", null, false, "0583192d-89ad-405b-83d7-5ed770bf932b", false, "tester8@gmail.com" },
                    { 9, 0, "a7bcfb88-f5f5-4585-85d8-d905d7e949a8", "tester9@gmail.com", true, true, null, "TESTER9@GMAIL.COM", "TESTER9@GMAIL.COM", "AQAAAAEAACcQAAAAEP/tM304qDjcYzAItF0l+E+qJ0lK4J/fPuabXljPR9vzeQ0UcQfAgeJiymURO2293A==", null, false, "81fc580a-5e50-4447-add2-6db80b1d6f47", false, "tester9@gmail.com" },
                    { 10, 0, "5106ab5b-96ca-45cb-b29d-c840a0a72768", "tester10@gmail.com", true, true, null, "TESTER10@GMAIL.COM", "TESTER10@GMAIL.COM", "AQAAAAEAACcQAAAAEHnOplSxipqonsXr9trPhE/sW4FH0ZjsqVps3YfmUUOcr+Bl6f252hB83jTAj5LB4w==", null, false, "8772004d-c544-49b5-bdac-61e64f9ef095", false, "tester10@gmail.com" },
                    { 11, 0, "a2e1ae67-d3b3-4ba0-b5f6-3a9318675380", "tester11@gmail.com", true, true, null, "TESTER11@GMAIL.COM", "TESTER11@GMAIL.COM", "AQAAAAEAACcQAAAAEMBzpun+IRg03s8xt4PUXUTFT63AJyNZO0M066IGK7gi15GE8xf2Gb96M2uMg29q9w==", null, false, "68427a5f-e201-43bf-871a-cecb036c902f", false, "tester11@gmail.com" },
                    { 12, 0, "95005900-79c4-4444-a217-744efc087efb", "tester12@gmail.com", true, true, null, "TESTER12@GMAIL.COM", "TESTER12@GMAIL.COM", "AQAAAAEAACcQAAAAEPYryKrxnuSPmri6Ohx1E9eLWpxOxflgWOMPDznFNILxL6G8Bpkv/ofXnLSnke6MBg==", null, false, "fc8b3951-7e0e-46ef-b78d-492968634e65", false, "tester12@gmail.com" },
                    { 13, 0, "34c2a1c3-ab14-445a-ab4d-a55a5af90a43", "tester13@gmail.com", true, true, null, "TESTER13@GMAIL.COM", "TESTER13@GMAIL.COM", "AQAAAAEAACcQAAAAEK8Jz6B6TnEo4CrUtOLN58ZZor4xsdpNGe5GxHmMOwMDSgH0Dq9xGakeuqCnzVuZLA==", null, false, "1e409e25-2b42-4391-866e-d8678953772a", false, "tester13@gmail.com" },
                    { 14, 0, "8203ef67-1ec3-44e1-8c69-2c97f2e4991a", "tester14@gmail.com", true, true, null, "TESTER14@GMAIL.COM", "TESTER14@GMAIL.COM", "AQAAAAEAACcQAAAAEG+zUl7no/q0VCgzNUTzRJU826B86nn6JjcMusCdqSP0LpJR9oEleBVfmLjZiJeZWQ==", null, false, "a3676cc7-636e-4156-bbf9-3e2584a5ec53", false, "tester14@gmail.com" },
                    { 15, 0, "061e1b44-c2da-434a-bf7d-828d08e53fc1", "tester15@gmail.com", true, true, null, "TESTER15@GMAIL.COM", "TESTER15@GMAIL.COM", "AQAAAAEAACcQAAAAEOCyC1+fGqSTUMkVT8Y7vZ1/tGmcDp8HxLU7Ib+mmFGgApNEyOYUEUBavG00OtxLjg==", null, false, "2928170f-5ebc-43d3-8011-da54d848ffc4", false, "tester15@gmail.com" }
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
    }
}
