using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispactherTimePlan.Models
{
    class TourStop
    {
        public int StopNumber { get; set; }
        public string Name { get; set; }
        public string ArriveTime { get; set; }
        public string DepartureTime { get; set; }
        public string ImageUri { get; set; }
        public List<BusyTime> BusyTimes { get; set; }

    }
    public class BusyTime
    {
        public int Hour { get; set; }
        public int Rank { get; set; }

    }
}
