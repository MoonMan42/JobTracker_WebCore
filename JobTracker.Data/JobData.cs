using JobTracker.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JobTracker.Data
{
    public class JobData : IJobData
    {

        private JobDbContext _context;

        public JobData(JobDbContext db)
        {
            _context = db;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public JobApplication Add(JobApplication job)
        {
            _context.Add(job);
            return job;
        }

        public JobApplication Delete(int id)
        {
            var job = GetJobById(id);

            if (job != null)
            {
                _context.JobApplications.Remove(job);
            }

            return job;
        }

        public JobApplication Update(JobApplication job)
        {
            var jobToUpdate = _context.JobApplications.Attach(job);
            jobToUpdate.State = EntityState.Modified;
            return job;
        }

        public JobApplication GetJobById(int id)
        {
            return _context.JobApplications.Find(id);
        }
        public IEnumerable<JobApplication> GetJobByName(string name)
        {
            var query = from j in _context.JobApplications
                        where (string.IsNullOrEmpty(name) || j.JobTitle.ToLower().StartsWith(name.ToLower()))
                                && j.IsJobStillActive == true

                        orderby j.DateApplied descending
                        select j;

            return query;
        }

    }
}
