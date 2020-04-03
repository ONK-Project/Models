using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public long AccountId { get; set; }
        public List<MeteringUnit> MeteringUnits { get; set; }
    }
}
