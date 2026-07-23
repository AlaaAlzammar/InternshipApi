using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipApi.Migrations
{
    /// <inheritdoc />
    public partial class addFieldsIinsitution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Institutions",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoundedYear",
                table: "Institutions",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Institutions",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "FoundedYear",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Institutions");
        }
    }
}
