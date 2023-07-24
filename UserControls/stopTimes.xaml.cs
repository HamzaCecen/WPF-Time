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

namespace DispactherTimePlan.UserControls
{
    /// <summary>
    /// Interaction logic for stopTimes.xaml
    /// </summary>
    public partial class stopTimes : UserControl
    {
        public stopTimes()
        {
            InitializeComponent();

            Stops.ItemsSource = TourSources.GetAllTourStops();
        }
    }
}
