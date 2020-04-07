using System;

namespace Models
{
    public class Submission
    {
        public MeteringUnit MeteringUnit { get; set; }
        public SubmissionPrice SubmissionPrice { get; set; }
        public DateTime DateTime { get; set; }
        public double RessourceUsage { get; set; }
        public string UnitOfMeassure { get; set; }
    }
}
