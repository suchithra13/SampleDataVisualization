using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SampleDataVisualization.Helpers.EF.Models;
using SampleDataVisualization.Models;
using SampleDataVisualization.Models.AccountViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SampleDataVisualization.Helpers
{
    public class UserHelper
    {
        private DbContextOptions<HealthDbContext> _dbContextOptions;
        public UserHelper(DbContextOptions<HealthDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }
        public async Task SaveUserDetails(RegisterViewModel registerViewModel)
        {
            if (registerViewModel.Id == Guid.Empty)
            {
                var Id = Guid.NewGuid();
                RegisterDetails userDetails = new RegisterDetails()
                {
                    Id = Id,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    Password = registerViewModel.Password,
                };
                using (var context = new HealthDbContext(_dbContextOptions))
                {
                    context.RegisterDetails.Add(userDetails);
                    await context.SaveChangesAsync();
                }
            }
            else
            {
                using (var context = new HealthDbContext(_dbContextOptions))
                {
                    RegisterDetails userDetails = await context.RegisterDetails.FindAsync(registerViewModel.Id);
                    userDetails.FirstName = registerViewModel.FirstName;
                    userDetails.LastName = registerViewModel.LastName;
                    userDetails.Email = registerViewModel.Email;
                    userDetails.Password = registerViewModel.Password;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<RegisterDetails> GetUserByEmail(string email)
        {
            RegisterDetails registerDetails;

            using (var context = new HealthDbContext(_dbContextOptions))
            {
                registerDetails = await context.RegisterDetails.Where(x => x.Email == email).FirstOrDefaultAsync();
            }
            return registerDetails;
        }
    }
}

