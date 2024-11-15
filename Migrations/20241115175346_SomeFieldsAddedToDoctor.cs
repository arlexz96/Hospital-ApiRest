using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assesment.Migrations
{
    /// <inheritdoc />
    public partial class SomeFieldsAddedToDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "doctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_id_rol",
                table: "doctors",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_id_type_document",
                table: "doctors",
                column: "id_type_document");

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_roles_id_rol",
                table: "doctors",
                column: "id_rol",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_types_document_id_type_document",
                table: "doctors",
                column: "id_type_document",
                principalTable: "types_document",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctors_roles_id_rol",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_types_document_id_type_document",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_id_rol",
                table: "doctors");

            migrationBuilder.DropIndex(
                name: "IX_doctors_id_type_document",
                table: "doctors");

            migrationBuilder.RenameTable(
                name: "doctors",
                newName: "Doctor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "id");
        }
    }
}
