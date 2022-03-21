using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class BreakTime
    {
        public BreakTime(String startingTime, String endTime, string reasonOfStance)
        {
            StartingTime = startingTime;
            EndTime = endTime;
            ReasonOfStance = reasonOfStance;
        }

        public String StartingTime { get; set; }
        public String EndTime { get; set; }
        public string  ReasonOfStance{ get; set; }
    }

}
