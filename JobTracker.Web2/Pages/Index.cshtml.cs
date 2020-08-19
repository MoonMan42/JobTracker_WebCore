using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobTracker.Web2.Pages
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
