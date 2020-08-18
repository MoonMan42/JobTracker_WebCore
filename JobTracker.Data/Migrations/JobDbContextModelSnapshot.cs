﻿// <auto-generated />
using System;
using JobTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobTracker.Data.Migrations
{
    [DbContext(typeof(JobDbContext))]
    partial class JobDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AppliedSite")
                        .HasMaxLength(100);

                    b.Property<bool>("CallBack");

                    b.Property<DateTime?>("CallBackDate");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50);

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
