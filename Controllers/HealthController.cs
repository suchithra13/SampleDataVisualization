using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleDataVisualization.Helpers;
using SampleDataVisualization.Helpers.EF.Models;
using SampleDataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDataVisualization.Controllers
{
    public class HealthController : Controller
    {
        private DbContextOptions<HealthDbContext> _dbContextOptions;
        public HealthController(DbContextOptions<HealthDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }
        public IActionResult Health()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveRecords(HealthViewModel healthViewModel)
        {
            if (ModelState.IsValid)
            {
                HealthHelper healthHelper = new HealthHelper(_dbContextOptions);
                await healthHelper.SaveRecords(healthViewModel);
                ViewBag.msg = "Health details saved";
                return LocalRedirect("/Health/Health");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            HealthHelper healthHelper = new HealthHelper(_dbContextOptions);
            var list = await healthHelper.GetAll();
            var sortedList = list.OrderBy(x => x.Age).ToList();
            List<int> commonAge = new List<int>();
            var ages = sortedList.Select(x => x.Age).Distinct();
            var totalCount = new Dictionary<int, int>();
            foreach (var age in ages)
            {
                commonAge.Add(sortedList.Count(x => x.Age == age));
            }
            var commonagelist = commonAge;
            var diabetic = new Dictionary<int, int>();
            int i = 0, j = 0, k = 0;
            int set1 = 0, set2 = 0, set3 = 0;
            foreach (var healthList in sortedList)
            {
                if (healthList.Age < 31)
                {
                    if (healthList.Diabetic == true)
                    {
                        i += 1;
                    }
                    set1 += 1;
                }
                else if (healthList.Age < 61)
                {
                    if (healthList.Diabetic == true)
                    {
                        j += 1;
                    }
                    set2 += 1;
                }
                else
                {
                    if (healthList.Diabetic == true)
                    {
                        k += 1;
                    }
                    set3 += 1;
                }
            }
            totalCount.Add(1, set1);
            totalCount.Add(2, set2);
            totalCount.Add(3, set3);
            diabetic.Add(1, i);
            diabetic.Add(2, j);
            diabetic.Add(3, k);

            var percentage = new List<int>();
            foreach (var index in Enumerable.Range(1, 3))
            {
                percentage.Add((diabetic.GetValueOrDefault(index) * 100) / totalCount.GetValueOrDefault(index));
            }
            ViewBag.AGES = ages;
            ViewBag.COMMONAGELIST = commonagelist;
            ViewBag.PERCENTAGE = percentage;
            return View();
        }

    }
}

