using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace obss1.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentModels",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    surname = table.Column<string>(type: "text", nullable: true),
                    studentNumber = table.Column<string>(type: "text", nullable: true),
                    courseName = table.Column<string>(type: "text", nullable: true),
                    firstExam = table.Column<int>(type: "integer", nullable: false),
                    secondExam = table.Column<int>(type: "integer", nullable: false),
                    passState = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentModels");
        }
    }
}
