using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDataVisualization.Models
{
    public class UserDetails : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProviderDisplayName { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
    }
}