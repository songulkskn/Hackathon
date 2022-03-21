using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Models
{
    public class RecordedData
    { 
        public int RegisterationNumber { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status{ get; set; }
        public string Reason { get; set; }
        public String TotalTime
        {
            get
            {

                TimeSpan differences = EndDate - StartingDate;
                var minutes = differences.TotalMinutes;

                var hour = (int)minutes / 60;
                var minute = (int)minutes % 60;
                if (hour < 1)

                {
                    return minute.ToString() + " mn";
                }
                else if (minute == 0)
                {
                    return hour.ToString() + " hr";
                }
                else
                {
                    return hour.ToString() + "hr" +  minute.ToString() + " mn";
                }
            }
        }

        public RecordedData(int registrationNumber, DateTime startingDate, DateTime endDate, string status,List<BreakTime> breaktimes)
        {
            RegisterationNumber = registrationNumber;
            StartingDate = startingDate;
            EndDate = endDate;
            Status = status;
            Reason = setReason(breaktimes);
        }

        private string setReason(List<BreakTime> breaktimes)
        {
          
            if (this.Status == "URETIM")
            {                
               return " ";
            }
            foreach(var item in breaktimes)
            {
                if (item.StartingTime == this.StartingDate.ToString("HH:mm") && item.EndTime == this.EndDate.ToString("HH:mm"))
                {
                   return item.ReasonOfStance;

                }
            }
            return "ARIZA";
        }









    }
}
