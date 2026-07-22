using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipApi.Migrations
{
    /// <inheritdoc />
    public partial class addProfileitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GithubUrl",
                table: "Students",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Students",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Students",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Students",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioUrl",
                table: "Students",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillsJson",
                table: "Students",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Students",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GithubUrl",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PortfolioUrl",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SkillsJson",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Students");
        }
    }
}
