using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apprenticeship.Data.Migrations
{
    /// <inheritdoc />
    public partial class businessLayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "schoolId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    companyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.companyId);
                });

            migrationBuilder.CreateTable(
                name: "objectives",
                columns: table => new
                {
                    objectiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    objectiveName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objectives", x => x.objectiveId);
                });

            migrationBuilder.CreateTable(
                name: "reportStatuses",
                columns: table => new
                {
                    reportStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reportStatuses", x => x.reportStatusId);
                });

            migrationBuilder.CreateTable(
                name: "schools",
                columns: table => new
                {
                    schoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schoolAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schools", x => x.schoolId);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    skillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.skillId);
                });

            migrationBuilder.CreateTable(
                name: "tranings",
                columns: table => new
                {
                    TraningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    teamLeaderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    schoolSupervisorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tranings", x => x.TraningId);
                    table.ForeignKey(
                        name: "FK_tranings_AspNetUsers_schoolSupervisorId",
                        column: x => x.schoolSupervisorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tranings_AspNetUsers_studentId",
                        column: x => x.studentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tranings_AspNetUsers_teamLeaderId",
                        column: x => x.teamLeaderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "objectiveSkills",
                columns: table => new
                {
                    objectiveId = table.Column<int>(type: "int", nullable: false),
                    skillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objectiveSkills", x => new { x.objectiveId, x.skillId });
                    table.ForeignKey(
                        name: "FK_objectiveSkills_objectives_objectiveId",
                        column: x => x.objectiveId,
                        principalTable: "objectives",
                        principalColumn: "objectiveId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_objectiveSkills_skills_skillId",
                        column: x => x.skillId,
                        principalTable: "skills",
                        principalColumn: "skillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assignments",
                columns: table => new
                {
                    assignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assignmentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assignmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assignmentNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    traningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignments", x => x.assignmentId);
                    table.ForeignKey(
                        name: "FK_assignments_tranings_traningId",
                        column: x => x.traningId,
                        principalTable: "tranings",
                        principalColumn: "TraningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "traningObjectives",
                columns: table => new
                {
                    objectiveId = table.Column<int>(type: "int", nullable: false),
                    traningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_traningObjectives", x => new { x.traningId, x.objectiveId });
                    table.ForeignKey(
                        name: "FK_traningObjectives_objectives_objectiveId",
                        column: x => x.objectiveId,
                        principalTable: "objectives",
                        principalColumn: "objectiveId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_traningObjectives_tranings_traningId",
                        column: x => x.traningId,
                        principalTable: "tranings",
                        principalColumn: "TraningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assignmentObjectives",
                columns: table => new
                {
                    assignmentId = table.Column<int>(type: "int", nullable: false),
                    objectiveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignmentObjectives", x => new { x.assignmentId, x.objectiveId });
                    table.ForeignKey(
                        name: "FK_assignmentObjectives_assignments_assignmentId",
                        column: x => x.assignmentId,
                        principalTable: "assignments",
                        principalColumn: "assignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assignmentObjectives_objectives_objectiveId",
                        column: x => x.objectiveId,
                        principalTable: "objectives",
                        principalColumn: "objectiveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reports",
                columns: table => new
                {
                    reportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reportName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reportDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reportNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assignmentId = table.Column<int>(type: "int", nullable: false),
                    reportStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reports", x => x.reportId);
                    table.ForeignKey(
                        name: "FK_reports_assignments_assignmentId",
                        column: x => x.assignmentId,
                        principalTable: "assignments",
                        principalColumn: "assignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reports_reportStatuses_reportStatusId",
                        column: x => x.reportStatusId,
                        principalTable: "reportStatuses",
                        principalColumn: "reportStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_schoolId",
                table: "AspNetUsers",
                column: "schoolId");

            migrationBuilder.CreateIndex(
                name: "IX_assignmentObjectives_objectiveId",
                table: "assignmentObjectives",
                column: "objectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_assignments_traningId",
                table: "assignments",
                column: "traningId");

            migrationBuilder.CreateIndex(
                name: "IX_objectiveSkills_skillId",
                table: "objectiveSkills",
                column: "skillId");

            migrationBuilder.CreateIndex(
                name: "IX_reports_assignmentId",
                table: "reports",
                column: "assignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_reports_reportStatusId",
                table: "reports",
                column: "reportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_traningObjectives_objectiveId",
                table: "traningObjectives",
                column: "objectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_tranings_schoolSupervisorId",
                table: "tranings",
                column: "schoolSupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_tranings_studentId",
                table: "tranings",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_tranings_teamLeaderId",
                table: "tranings",
                column: "teamLeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_companies_companyId",
                table: "AspNetUsers",
                column: "companyId",
                principalTable: "companies",
                principalColumn: "companyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_schools_schoolId",
                table: "AspNetUsers",
                column: "schoolId",
                principalTable: "schools",
                principalColumn: "schoolId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_companies_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_schools_schoolId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "assignmentObjectives");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "objectiveSkills");

            migrationBuilder.DropTable(
                name: "reports");

            migrationBuilder.DropTable(
                name: "schools");

            migrationBuilder.DropTable(
                name: "traningObjectives");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "assignments");

            migrationBuilder.DropTable(
                name: "reportStatuses");

            migrationBuilder.DropTable(
                name: "objectives");

            migrationBuilder.DropTable(
                name: "tranings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_schoolId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "schoolId",
                table: "AspNetUsers");
        }
    }
}
