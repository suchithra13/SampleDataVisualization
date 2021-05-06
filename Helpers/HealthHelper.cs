using Microsoft.EntityFrameworkCore;
using SampleDataVisualization.Helpers.EF.Models;
using SampleDataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDataVisualization.Helpers
{
    public class HealthHelper
    {
        private DbContextOptions<HealthDbContext> _dbContextOptions;
        public HealthHelper(DbContextOptions<HealthDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        public async Task SaveRecords(HealthViewModel healthViewModel)
        {
            if (healthViewModel.Id == Guid.Empty)
            {
                var Id = Guid.NewGuid();
                HealthDetails healthDetails = new HealthDetails()
                {
                    Id = Id,
                    FullName = healthViewModel.FullName,
                    Age = healthViewModel.Age,
                    Diabetic = healthViewModel.Diabetic,
                };
                using (var context = new HealthDbContext(_dbContextOptions))
                {
                    context.HealthDetails.Add(healthDetails);
                    await context.SaveChangesAsync();
                }
            }
            else
            {
                using (var context = new HealthDbContext(_dbContextOptions))
                {
                    HealthDetails healthDetails = await context.HealthDetails.FindAsync(healthViewModel.Id);
                    healthDetails.FullName = healthViewModel.FullName;
                    healthDetails.Age = healthViewModel.Age;
                    healthDetails.Diabetic = healthViewModel.Diabetic;
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<List<HealthDetails>> GetAll()
        {
            List<HealthDetails> healthDetails;

            using (var context = new HealthDbContext(_dbContextOptions))
            {
                healthDetails = await context.HealthDetails.ToListAsync();
            }
            return healthDetails;
        }

    }
}

