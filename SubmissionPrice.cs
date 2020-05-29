using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class SubmissionPrice
    {
        public string id { get; set; }
        public double TotalCost { get; set; }
        public string Currency { get; set; }
    }
}
