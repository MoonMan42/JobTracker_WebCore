﻿// <auto-generated />
using System;
using JobTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobTracker.Data.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20200820025419_updateJobApplication6")]
    partial class updateJobApplication6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobTracker.Core.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppliedSite");

                    b.Property<bool>("CallBack");

                    b.Property<DateTime?>("CallBackDate");

                    b.Property<string>("CompanyContactName");

                    b.Property<string>("CompanyEmail");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50);

                    b.Property<string>("CompanyPhone");

                    b.Property<string>("CompanyWebsite");

                    b.Property<DateTime>("DateApplied");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsJobStillActive");

                    b.Property<string>("JobRequirement")
                        .HasMaxLength(1000);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastUpdate");

                    b.HasKey("Id");

                    b.ToTable("JobApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
