using JobTracker.Core;
using JobTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobTracker.Pages.JobApplications
{
    public class EditModel : PageModel
    {
        private readonly IJobData jobData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public JobApplication job { get; set; }


        public EditModel(IJobData jobData, IHtmlHelper helper)
        {
            this.jobData = jobData;
            this.htmlHelper = helper;
        }

        public void OnGet(int? jobId)
        {
            if (jobId.HasValue)
            {
                job = jobData.GetJobById(jobId.Value);
            }
            else
            {
                job = new JobApplication();
            }
        }

        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (job.Id > 0)
            {
                jobData.Update(job);
                TempData["Message"] = "Update position";
            }
            else
            {
                jobData.Add(job);
                TempData["Message"] = "Job Saved";
            }

            jobData.Commit();

            return RedirectToPage("./Index", new { jobId = job.Id });
        }

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            jobData.Delete(job.Id);
            jobData.Commit();

            TempData["Message"] = "Job removed!";

            return RedirectToPage("./Index");
        }
    }
}
