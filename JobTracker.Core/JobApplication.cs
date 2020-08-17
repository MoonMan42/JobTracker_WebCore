﻿using System;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Core
{
    public class JobApplication
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [StringLength(500, ErrorMessage = "Limit to 500 words.")]
        public string Description { get; set; }

        [StringLength(500, ErrorMessage = "Limit to 500 words.")]
        public string JobRequirement { get; set; }

        [Required]
        [Display(Name = "Date Applied")]
        [DataType(DataType.Date)]
        public DateTime DateApplied { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string AppliedSite { get; set; }

        [Display(Name = "Did they call back?")]
        public bool CallBack { get; set; } = false;

        [Display(Name = "What was the last update.")]
        public string LastUpdate { get; set; }

        [Display(Name = "When did they call Back?")]
        [DataType(DataType.Date)]
        public DateTime? CallBackDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Is the job still active?")]
        public bool IsJobStillActive { get; set; } = true;

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string CompanyWebsite { get; set; }
    }
}
