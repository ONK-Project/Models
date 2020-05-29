using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class SubmissionPrice
    {
        public double TotalCost { get; set; }
        public string Currency { get; set; }
    }
}
