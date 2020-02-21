using InstantFest_2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstantFest_2.Models
{
    public class JoinerModel : BaseModel
    {
        public User User { get; internal set; }
    }
}
