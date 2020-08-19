using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracker.Data.Migrations
{
    public partial class UpdateJobApplication5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyContactName",
                table: "JobApplications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "JobApplications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyPhone",
                table: "JobApplications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyContactName",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "CompanyPhone",
                table: "JobApplications");
        }
    }
}
