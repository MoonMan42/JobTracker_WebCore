using JobTracker.Core;
using System.Collections.Generic;

namespace JobTracker.Data
{
    public interface IJobData
    {
        JobApplication Add(JobApplication job);
        int Commit();
        JobApplication Delete(int id);
        JobApplication GetJobById(int id);
        IEnumerable<JobApplication> GetJobByName(string Name);
        IEnumerable<JobApplication> GetOpenJobByName(string Name);
        int GetOpenJobsTotal();
        int GetActiveJobsTotal();
        int GetCallBackTotal();
        JobApplication Update(JobApplication job);
    }
}