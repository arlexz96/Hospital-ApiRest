using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assesment.Migrations
{
    /// <inheritdoc />
    public partial class Some_Seeders_have_been_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appointment_reasons",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "Revisión de salud general" },
                    { 2, "Dolor en el pecho" },
                    { 3, "Problemas respiratorios" },
                    { 4, "Consulta de embarazo" },
                    { 5, "Consulta de rutina para niños" },
                    { 6, "Problemas de piel" },
                    { 7, "Dolor de cabeza recurrente" },
                    { 8, "Consulta dental" },
                    { 9, "Problemas de visión" },
                    { 10, "Ansiedad o problemas emocionales" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Médico" },
                    { 3, "Usuario" }
                });

            migrationBuilder.InsertData(
                table: "specialities",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "Cardiología" },
                    { 2, "Pediatría" },
                    { 3, "Ginecología" },
                    { 4, "Dermatología" },
                    { 5, "Oftalmología" },
                    { 6, "Medicina General" },
                    { 7, "Neurología" },
                    { 8, "Traumatología" },
                    { 9, "Odontología" },
                    { 10, "Psiquiatría" }
                });

            migrationBuilder.InsertData(
                table: "types_document",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "Pasaporte" },
                    { 2, "Licencia de Conducir" },
                    { 3, "Cédula de Identidad" },
                    { 4, "Número de Seguridad Social" },
                    { 5, "Certificado de Nacimiento" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "appointment_reasons",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "types_document",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "types_document",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "types_document",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "types_document",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "types_document",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
