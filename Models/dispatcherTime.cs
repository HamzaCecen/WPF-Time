using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DispactherTimePlan.Models
{
    class dispatcherTime
    {
        //private DispatcherTimer dispatcher;
        //private Timer timer;
        private string DisplayTime = "00:00:00";

        public string dateTime
        {
            get { return dateTime;  }
            set { DisplayTime = dateTime; }
        }

        /*
        public dispatcherTime()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick = new EventHandler(UpdateTime_Tick);

            dt.Interval = new TimeSpan(0, 0, 1); //DateTime gibi struct(yapı) olarak tasarlanmış bir süre temsil eden değişkendir
            dt.Start();
        }
        */




    }
    
}

    


