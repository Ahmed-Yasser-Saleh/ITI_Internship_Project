using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Project.Migrations
{
    /// <inheritdoc />
    public partial class removenullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
            migrationBuilder.AlterColumn<string>(
name: "Name",
table: "Departments",
type: "nvarchar(max)",
nullable: false,
oldClrType: typeof(int),
oldType: "nvarchar(max)",
        oldNullable: true);
			migrationBuilder.AlterColumn<string>(
name: "age",
table: "Instructors",
type: "int",
nullable: false,
oldClrType: typeof(int),
oldType: "int",
oldNullable: true);
			migrationBuilder.AlterColumn<string>(
name: "salary",
table: "Instructors",
type: "int",
nullable: false,
oldClrType: typeof(int),
oldType: "int",
oldNullable: true);
			migrationBuilder.AlterColumn<string>(
name: "age",
table: "Trainees",
type: "int",
nullable: false,
oldClrType: typeof(int),
oldType: "int",
oldNullable: true);
			migrationBuilder.AlterColumn<string>(
name: "address",
table: "Trainees",
type: "string",
nullable: false,
oldClrType: typeof(string),
oldType: "int",
oldNullable: true);

		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainees",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
           name: "Name",
          table: "Departments",
          type: "nvarchar(max)",
          nullable: true,
          oldClrType: typeof(string),
         oldType: "nvarchar(max)");
			migrationBuilder.AlterColumn<string>(
name: "age",
table: "Instructors",
type: "int",
nullable: true,
oldClrType: typeof(int),
oldType: "int");
			migrationBuilder.AlterColumn<string>(
name: "salary",
table: "Instructors",
type: "int",
nullable: true,
oldClrType: typeof(int),
oldType: "int");
			migrationBuilder.AlterColumn<string>(
name: "age",
table: "Trainees",
type: "int",
nullable: true,
oldClrType: typeof(int),
oldType: "int");
			migrationBuilder.AlterColumn<string>(
name: "address",
table: "Trainees",
type: "string",
nullable: true,
oldClrType: typeof(string),
oldType: "int");
		}
    }
}
