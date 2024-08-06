using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Project.Migrations
{
    /// <inheritdoc />
    public partial class setcascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
name: "FK_Trainee_Courses_Courses_CourseId",
table: "Trainee_Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Courses_Courses_CourseId",
                table: "Trainee_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.DropForeignKey(
name: "FK_Trainee_Courses_Trainees_TraineeId",
table: "Trainee_Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Courses_Trainees_TraineeId",
                table: "Trainee_Courses",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
name: "FK_Trainee_Courses_Courses_CourseId",
table: "Trainee_Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Courses_Courses_CourseId",
                table: "Trainee_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.DropForeignKey(
name: "FK_Trainee_Courses_Trainees_TraineeId",
table: "Trainee_Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Courses_Trainees_TraineeId",
                table: "Trainee_Courses",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
