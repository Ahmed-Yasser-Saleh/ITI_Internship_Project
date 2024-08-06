using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Project.Migrations
{
    /// <inheritdoc />
    public partial class setnull2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
    name: "FK_Instructors_Departments_Deptid",
    table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Deptid",
                table: "Instructors",
                column: "Deptid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.DropForeignKey(
name: "FK_Instructors_Courses_CourseId",
table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.DropForeignKey(
name: "FK_Trainees_Departments_Deptid",
table: "Trainees");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Deptid",
                table: "Trainees",
                column: "Deptid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
//            migrationBuilder.DropForeignKey(
//name: "FK_Trainee_Courses_Courses_CourseId",
//table: "Trainee_Courses");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Trainee_Courses_Courses_CourseId",
//                table: "Trainee_Courses",
//                column: "CourseId",
//                principalTable: "Courses",
//                principalColumn: "CourseId",
//                onDelete: ReferentialAction.SetNull);

//            migrationBuilder.DropForeignKey(
//name: "FK_Trainee_Courses_Trainees_TraineeId",
//table: "Trainee_Courses");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Trainee_Courses_Trainees_TraineeId",
//                table: "Trainee_Courses",
//                column: "TraineeId",
//                principalTable: "Trainees",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.SetNull);

        }
    

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
name: "FK_Instructors_Departments_Deptid",
table: "Instructors");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Deptid",
                table: "Instructors",
                column: "Deptid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

        migrationBuilder.DropForeignKey(
name: "FK_Instructors_Courses_CourseId",
table: "Instructors");

        migrationBuilder.AddForeignKey(
            name: "FK_Instructors_Courses_CourseId",
            table: "Instructors",
            column: "CourseId",
            principalTable: "Courses",
            principalColumn: "CourseId",
            onDelete: ReferentialAction.SetNull);

            migrationBuilder.DropForeignKey(
name: "FK_Trainees_Departments_Deptid",
table: "Trainees");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_Deptid",
                table: "Trainees",
                column: "Deptid",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

//            migrationBuilder.DropForeignKey(
//name: "FK_Trainee_Courses_Courses_CourseId",
//table: "Trainee_Courses");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Trainee_Courses_Courses_CourseId",
//                table: "Trainee_Courses",
//                column: "CourseId",
//                principalTable: "Courses",
//                principalColumn: "CourseId",
//                onDelete: ReferentialAction.SetNull);

//            migrationBuilder.DropForeignKey(
//name: "FK_Trainee_Courses_Trainees_TraineeId",
//table: "Trainee_Courses");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Trainee_Courses_Trainees_TraineeId",
//                table: "Trainee_Courses",
//                column: "TraineeId",
//                principalTable: "Trainees",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.SetNull);
        }
    }
}

    

