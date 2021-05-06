using System;
using System.ComponentModel.DataAnnotations;

namespace SampleDataVisualization.Models.AccountViewModel
{
    public class LoginViewModel
    {
        [Key]
        [Display(Name = "Id")]
        public Guid Id { get; set; }
        public string ReturnUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberMe { get; set; }
    }
}