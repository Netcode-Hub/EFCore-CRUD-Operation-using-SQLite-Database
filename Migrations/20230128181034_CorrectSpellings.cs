using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreRelationships.Migrations
{
    /// <inheritdoc />
    public partial class CorrectSpellings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Eployees",
                table: "Eployees");

            migrationBuilder.RenameTable(
                name: "Eployees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Eployees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eployees",
                table: "Eployees",
                column: "Id");
        }
    }
}
