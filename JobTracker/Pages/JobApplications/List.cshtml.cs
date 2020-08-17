using JobTracker.Core;
using JobTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace JobTracker.Pages.JobApplications
{
    public class ListModel : PageModel
    {
        private readonly IJobData jobData;

        public IEnumerable<JobApplication> jobs { get; set; }

        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }


        public ListModel(IJobData db)
        {
            jobData = db;
        }
        public void OnGet()
        {
            jobs = jobData.GetJobByName(searchTerm);
        }
    }
}
