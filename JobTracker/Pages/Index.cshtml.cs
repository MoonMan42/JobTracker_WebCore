using JobTracker.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IJobData jobData;

        public int totalJobApplications;
        public int totalActiveJobs;
        public int totalCallBack;

        public IndexModel(IJobData db)
        {
            jobData = db;
        }

        public void OnGet()
        {
            totalJobApplications = jobData.GetOpenJobsTotal();
            totalActiveJobs = jobData.GetActiveJobsTotal();
            totalCallBack = jobData.GetCallBackTotal();
        }
    }
}
