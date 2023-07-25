using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DispactherTimePlan.Models;
using System.Diagnostics;
using System.Windows.Threading;
using System.Timers;

namespace DispactherTimePlan.UserControls
{
    /// <summary>
    /// Interaction logic for stopWatchView.xaml
    /// </summary>
    public partial class stopWatchView : UserControl
    {
        private DispatcherTimer dt;
        //private const string displaytime = "00:00:00";
        private Stopwatch stopwatch;
        private Timer timer;

        public stopWatchView()
        {
            InitializeComponent();

            //displayDate foo = new displayDate();
            forStopWatch foo1 = new forStopWatch();
            //string value = foo1.foo;
            foo1.foo = "00:00:00";


            //display as 00:00
            DisplayTime.Text = foo1.foo; //displaytime;

            //create new objects
            stopwatch = new Stopwatch();
            dt = new DispatcherTimer();
            timer = new Timer(interval: 1000);

            
            timer.Elapsed += timer_tick;
            





        }

        private void timer_tick(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() => DisplayTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss"));
        }
        

    
        

        private void Start_Click_1(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            timer.Start();
            //Clear buttonu görünmez yap
            Clear.IsEnabled = false;
        }

        private void Stop_Click_1(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            timer.Stop();
            //start buttonundan sonra clear buttonu görünür yap
            Clear.IsEnabled = true;
        }

        private void Clear_Click_1(object sender, RoutedEventArgs e)
        {
            forStopWatch foo1 = new forStopWatch();
            //string value = foo1.foo;
            foo1.foo = "00:00:00";

            //Display(text) sıfırla
            stopwatch.Reset();
            DisplayTime.Text = foo1.foo; //displaytime;
        }
    }
    
}
