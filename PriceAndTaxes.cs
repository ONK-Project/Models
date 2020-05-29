using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Serializable]
    public class PriceAndTaxes
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public string UnitOfMeassure { get; set; }
        public double Tax { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
