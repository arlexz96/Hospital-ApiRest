using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assesment.Migrations
{
    /// <inheritdoc />
    public partial class SeederAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "appointment_date", "available", "description", "id_appointment_reasons", "id_speciality", "id_user", "id_user_doctor" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "General Checkup", 1, 1, 1, 1 },
                    { 2, new DateTime(2024, 11, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), false, "Dental Cleaning", 2, 2, 2, 2 },
                    { 3, new DateTime(2024, 11, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Cardiology Consultation", 3, 3, 3, 3 },
                    { 4, new DateTime(2024, 11, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), true, "Dermatology Checkup", 4, 4, 4, 4 },
                    { 5, new DateTime(2024, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), false, "Eye Examination", 5, 5, 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
