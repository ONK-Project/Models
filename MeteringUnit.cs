using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    [Serializable]
    public class MeteringUnit
    {
        public long MeteringUnitId { get; set; }
        public string Location { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public Account Account { get; set; }
        public long AccountId { get; set; }
    }
}
