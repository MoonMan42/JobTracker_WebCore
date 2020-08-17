using System;
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

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Applied")]
        [DataType(DataType.Date)]
        public DateTime DateApplied { get; set; } = DateTime.UtcNow;
    }
}
