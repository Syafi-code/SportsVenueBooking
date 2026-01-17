using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator-role-id",
                column: "ConcurrencyStamp",
                value: "9a7ed3b7-eb04-43d9-acf9-b188334a5c84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest-role-id",
                column: "ConcurrencyStamp",
                value: "c2ece83f-26fc-4442-8412-63af752d6b84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student-role-id",
                column: "ConcurrencyStamp",
                value: "424209f2-89d3-4b98-83a9-52c163d8702e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SchoolID", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "admin-user-id-12345", 0, "7ce75046-4162-4974-8eab-494c13339500", "admin@sportsvenue.com", true, false, null, "ADMIN@SPORTSVENUE.COM", "ADMIN@SPORTSVENUE.COM", "AQAAAAIAAYagAAAAEFrRaUObL0hQ2mMApZJquzGZJ8ZYySWtKqClySPwd8QC4T/kse90WV0+IGZ952+IvA==", null, false, 1, "6d965934-45cd-4c79-bed4-e04652d0bb46", false, "admin@sportsvenue.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "administrator-role-id", "admin-user-id-12345" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "administrator-role-id", "admin-user-id-12345" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id-12345");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator-role-id",
                column: "ConcurrencyStamp",
                value: "83a1e893-bfdf-45b3-a341-84a7cde02b54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest-role-id",
                column: "ConcurrencyStamp",
                value: "5b7b0ad5-e4a4-4f64-87c6-738e0eebfb23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student-role-id",
                column: "ConcurrencyStamp",
                value: "c7283911-b712-4fec-91d6-e06ab605d7df");
        }
    }
}
