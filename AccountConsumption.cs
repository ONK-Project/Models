using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AccountConsumption
    {
        public Account Account { get; set; }
        public string UnitOfMeassure { get; set; }
        public string Type { get; set; }
        public double RessourceUsage { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public SubmissionPrice Price { get; set; }
    }
}
