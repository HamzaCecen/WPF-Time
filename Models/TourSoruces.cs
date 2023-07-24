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
                Latitude = "11111",
                Longitude = "-222222",
                ImageUri = "/DispactherTimePlan;component/Images/kadıköy.jpg"

            });

            _tourStops.Add(new TourStop
            {
                StopNumber = 2,
                Name = "Bostancı",
                Latitude = "33333333",
                Longitude = "-444444444444",
                ImageUri = "/DispactherTimePlan;component/Images/bostancı.jpg"
            });


        }

        public static List<TourStop> GetAllTourStops()
        {
            var result = _tourStops.ToList<TourStop>();
            return result;
        }
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
    }
}
