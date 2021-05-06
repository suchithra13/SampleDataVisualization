using System;

namespace SampleDataVisualization.Models
{
    public class HealthDetails
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool Diabetic { get; set; }
    }
}