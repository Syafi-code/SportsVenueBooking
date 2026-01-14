using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVenueSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 21);

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

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OpeningHours", "VenueName" },
                values: new object[] { "9:00 AM - 9:00 PM", "Basketball Court" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                column: "OpeningHours",
                value: "9:00 AM - 9:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                column: "OpeningHours",
                value: "9:00 AM - 9:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 20, "9:00 AM - 9:00 PM", 2, "Basketball Court", "Basketball" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 5,
                column: "OpeningHours",
                value: "9:00 AM - 9:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 80, "9:00 AM - 9:00 PM", 3, "Indoor Sports Hall", "Hall" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 30, "9:00 AM - 9:00 PM", 3, "Football Field", "Football" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 40, "9:00 AM - 9:00 PM", 4, "Gymnasium", "Gym" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 100, "9:00 AM - 9:00 PM", 5, "Sports Complex", "Hall" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OpeningHours", "VenueName" },
                values: new object[] { "8:00 AM - 10:00 PM", "Basketball Court A" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                column: "OpeningHours",
                value: "7:00 AM - 9:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3,
                column: "OpeningHours",
                value: "6:00 AM - 11:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 4, "8:00 AM - 8:00 PM", 1, "Tennis Court 1", "Tennis" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 5,
                column: "OpeningHours",
                value: "8:00 AM - 10:00 PM");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 20, "8:00 AM - 10:00 PM", 2, "Basketball Court B", "Basketball" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 8, "8:00 AM - 10:00 PM", 2, "Badminton Court 1", "Badminton" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 80, "8:00 AM - 10:00 PM", 3, "Indoor Sports Hall", "Hall" });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "OpeningHours", "SchoolID", "VenueName", "VenueType" },
                values: new object[] { 30, "6:00 AM - 9:00 PM", 3, "Football Field", "Football" });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "Id", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Facilities", "ImageUrl", "IsAvailable", "OpeningHours", "SchoolID", "UpdatedBy", "VenueName", "VenueType" },
                values: new object[,]
                {
                    { 10, 4, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 10:00 PM", 3, null, "Squash Court 1", "Squash" },
                    { 11, 40, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "6:00 AM - 11:00 PM", 4, null, "Gymnasium", "Gym" },
                    { 12, 60, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "7:00 AM - 9:00 PM", 4, null, "Swimming Complex", "Swimming" },
                    { 13, 16, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 10:00 PM", 4, null, "Table Tennis Room", "Table Tennis" },
                    { 14, 100, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 10:00 PM", 5, null, "Sports Complex", "Hall" },
                    { 15, 20, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 10:00 PM", 5, null, "Basketball Court", "Basketball" },
                    { 16, 50, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 9:00 PM", 6, null, "Multi-Purpose Court", "Hall" },
                    { 17, 20, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "7:00 AM - 9:00 PM", 6, null, "Fitness Corner", "Gym" },
                    { 18, 60, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 9:00 PM", 7, null, "Indoor Court", "Hall" },
                    { 19, 20, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 9:00 PM", 7, null, "Basketball Court", "Basketball" },
                    { 20, 70, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "8:00 AM - 9:00 PM", 8, null, "Sports Hall", "Hall" },
                    { 21, 15, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, "7:00 AM - 8:00 PM", 8, null, "Outdoor Court", "Basketball" }
                });
        }
    }
}
