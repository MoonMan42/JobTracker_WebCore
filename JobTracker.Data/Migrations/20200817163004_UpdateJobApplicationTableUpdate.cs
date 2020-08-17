using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobTracker.Data.Migrations
{
    public partial class UpdateJobApplicationTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CallBackDate",
                table: "JobApplications",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CallBackDate",
                table: "JobApplications",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
