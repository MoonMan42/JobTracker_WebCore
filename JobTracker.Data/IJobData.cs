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
        JobApplication Update(JobApplication job);
    }
}