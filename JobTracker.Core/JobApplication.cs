using System;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Core
{
    public class JobApplication
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime DateApplied { get; set; }
    }
}
