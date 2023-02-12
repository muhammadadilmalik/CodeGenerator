using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeGenerator.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name1",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name10",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name11",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name12",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name13",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name14",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name15",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name16",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name17",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name18",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name19",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name2",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name20",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name21",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name22",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name23",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name3",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name4",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name5",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name6",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name7",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name8",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name9",
                table: "Company",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name1",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name10",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name11",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name12",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name13",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name14",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name15",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name16",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name17",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name18",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name19",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name2",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name20",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name21",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name22",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name23",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name3",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name4",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name5",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name6",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name7",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name8",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Name9",
                table: "Company");
        }
    }
}
