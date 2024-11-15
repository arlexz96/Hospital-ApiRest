using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assesment.Migrations
{
    /// <inheritdoc />
    public partial class Users_Doctors_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_type_document = table.Column<int>(type: "int", nullable: false),
                    id_rol = table.Column<int>(type: "int", nullable: false),
                    available = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "id", "available", "email", "first_name", "id_rol", "id_type_document", "identification_number", "last_name", "password" },
                values: new object[,]
                {
                    { 1, true, "juan.perez@example.com", "Juan", 2, 1, "123456789", "Pérez", "f348d5628621f3d8f59c8cabda0f8eb0aa7e0514a90be7571020b1336f26c113" },
                    { 2, true, "ana.gomez@example.com", "Ana", 2, 1, "987654321", "Gómez", "49f267a17793be90862b8ee747596d4c68799dd040d976343c32e10e2d983883" },
                    { 3, false, "luis.martinez@example.com", "Luis", 2, 2, "112233445", "Martínez", "21274b285fa6de4de0cb8e8221c8b418f23039c0954edc891d13373e66ab2d92" },
                    { 4, true, "isabel.lopez@example.com", "Isabel", 2, 3, "334455667", "López", "25ae313f026983553a594aca3140572e5cae43165079a77a17b2b18e646fd3da" },
                    { 5, false, "carlos.hernandez@example.com", "Carlos", 2, 4, "998877665", "Hernández", "0d17b3b75a4b4ea56304172c81bd487a52676c8a0c1dd0818b7cdecce82d76b8" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "first_name", "id_rol", "id_type_document", "identification_number", "last_name", "password" },
                values: new object[,]
                {
                    { 1, "juan@example.com", "Juan", 3, 1, "123456789", "Pérez", "b3d17ebbe4f2b75d27b6309cfaae1487b667301a73951e7d523a039cd2dfe110" },
                    { 2, "ana@example.com", "Ana", 3, 1, "987654321", "Gómez", "c6ba91b90d922e159893f46c387e5dc1b3dc5c101a5a4522f03b987177a24a91" },
                    { 3, "luis@example.com", "Luis", 3, 2, "112233445", "Martínez", "98bbb2f3c8ffa8e403751db051f7b5a31498137940e50b01d237557a89bdd124" },
                    { 4, "marta@example.com", "Marta", 3, 3, "556677889", "Rodríguez", "9323dd6786ebcbf3ac87357cc78ba1abfda6cf5e55cd01097b90d4a286cac90e" },
                    { 5, "carlos@example.com", "Carlos", 3, 4, "998877665", "Hernández", "48caafb68583936afd0d78a7bfd7046d2492fad94f3c485915f74bb60128620d" },
                    { 6, "roberto@example.com", "Roberto", 3, 1, "223344556", "Suárez", "33631376724e5d5480fa397dfcf03b66ad47b934ab495174d7058c38f2bb0087" },
                    { 7, "isabel@example.com", "Isabel", 3, 2, "334455667", "López", "d42ba32b8703fe9bcffc5c16b6c5679363d595724c63a0ed111ac59a1d467070" },
                    { 8, "juan2@example.com", "Juan", 3, 3, "445566778", "García", "4fa29f8e091719146327604cc5d6e112b1999134dbefbf05f991f5c0fd648017" },
                    { 9, "teresa@example.com", "Teresa", 3, 4, "556677889", "Fernández", "f11026cad6ec0b7bbe12d040560218f64c02cd99d9b2b47838ba081f1f54f0d4" },
                    { 10, "admin@example.com", "Admin", 1, 1, "123123123", "Admin", "d9669c67bd3466e31fe39a7f2b6b4792df26138ef859f1e2cad50d9f9b288378" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
