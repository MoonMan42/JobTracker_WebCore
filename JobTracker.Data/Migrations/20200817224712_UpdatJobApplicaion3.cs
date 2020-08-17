using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracker.Data.Migrations
{
    public partial class UpdatJobApplicaion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "JobApplications",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyWebsite",
                table: "JobApplications",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GetTheJob",
                table: "JobApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Requirement",
                table: "JobApplications",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "CompanyWebsite",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "GetTheJob",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "Requirement",
                table: "JobApplications");
        }
    }
}
