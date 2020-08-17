using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracker.Data.Migrations
{
    public partial class JobApplicationUpdate3b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GetTheJob",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "Requirement",
                table: "JobApplications",
                newName: "JobRequirement");

            migrationBuilder.AddColumn<string>(
                name: "LastUpdate",
                table: "JobApplications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "JobApplications");

            migrationBuilder.RenameColumn(
                name: "JobRequirement",
                table: "JobApplications",
                newName: "Requirement");

            migrationBuilder.AddColumn<bool>(
                name: "GetTheJob",
                table: "JobApplications",
                nullable: false,
                defaultValue: false);
        }
    }
}
