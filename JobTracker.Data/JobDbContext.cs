using JobTracker.Core;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Data
{
    public class JobDbContext : DbContext
    {
        // add DbSet here to add to db later
        public DbSet<JobApplication> JobApplications { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {

        }
    }
}
