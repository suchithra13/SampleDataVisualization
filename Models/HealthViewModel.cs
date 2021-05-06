using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDataVisualization.Models
{
    public class HealthViewModel
    {
        [Key]
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Diabetic")]
        public bool Diabetic { get; set; }
    }
}

