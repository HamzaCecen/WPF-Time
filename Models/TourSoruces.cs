using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispactherTimePlan.Models
{
    class TourSources
    {
        private static List<TourStop> _tourStops;
        static TourSources()
        {
            // stops for our Food and Fun park tour
            _tourStops = new List<TourStop>();
            _tourStops.Add(new TourStop
            {
                StopNumber = 1,
                Name = "Kadıköy",
                ArriveTime = "15:20",
                DepartureTime = "15:23",
                ImageUri = "/DispactherTimePlan;component/Images/kadıköy.jpg"

            });

            _tourStops.Add(new TourStop
            {
                StopNumber = 2,
                Name = "Bostancı",
                ArriveTime = "16:00",
                DepartureTime = "16:01",
                ImageUri = "/DispactherTimePlan;component/Images/bostancı.jpg"
            });


        }

        public static List<TourStop> GetAllTourStops()
        {
            var result = _tourStops.ToList<TourStop>();
            return result;
        }
        /*
        public static List<TourStop> GetTourStops(int count)
        {
            var result = _tourStops.Take(count).ToList<TourStop>();
            return result;
        }
        public static List<TourStop> TourStops
        {
            get
            {
                return _tourStops;
            }
        }
        */
    }
}
