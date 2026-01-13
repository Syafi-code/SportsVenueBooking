using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class AddSchoolIDToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator-role-id",
                column: "ConcurrencyStamp",
                value: "e91ae76d-25de-48ab-8c17-d083ab9e10c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest-role-id",
                column: "ConcurrencyStamp",
                value: "1a7c4f81-956e-40a6-9583-22c7836425cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student-role-id",
                column: "ConcurrencyStamp",
                value: "327b7ab6-c601-41b5-a85d-0aef1a2f0110");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "administrator-role-id",
                column: "ConcurrencyStamp",
                value: "8a648d04-0781-4845-828d-7fab8ffede96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "guest-role-id",
                column: "ConcurrencyStamp",
                value: "88cd4ab4-d76e-4f0f-8ccf-adb93921008b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student-role-id",
                column: "ConcurrencyStamp",
                value: "882af119-bc77-4a47-8870-7ff544bef5c2");
        }
    }
}
