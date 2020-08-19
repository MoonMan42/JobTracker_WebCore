using JobTracker.Core;
using JobTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace JobTracker.Web2.Pages.JobApplications
{
    public class IndexModel : PageModel
    {
        private readonly IJobData jobData;

        public IEnumerable<JobApplication> jobs { get; set; }

        [BindProperty(SupportsGet = true)]
        public string searchTerm { get; set; }

        [TempData]
        public string Message { get; set; }

        public IndexModel(IJobData jobData)
        {
            this.jobData = jobData;
        }

        public void OnGet()
        {
            jobs = jobData.GetOpenJobByName(searchTerm);
        }
    }
}
