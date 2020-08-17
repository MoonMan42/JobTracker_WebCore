using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracker.Data.Migrations
{
    public partial class UpdateJobApplicationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppliedSite",
                table: "JobApplications",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CallBack",
                table: "JobApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CallBackDate",
                table: "JobApplications",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsJobStillActive",
                table: "JobApplications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedSite",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "CallBack",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "CallBackDate",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "IsJobStillActive",
                table: "JobApplications");
        }
    }
}
