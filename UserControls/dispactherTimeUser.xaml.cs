using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace DispactherTimePlan.UserControls
{
    /// <summary>
    /// Interaction logic for dispactherTimeUser.xaml
    /// </summary>
    
    public partial class dispactherTimeUser : UserControl
    {
        private string showTime = "00:00:00";

        public dispactherTimeUser()
        {
            InitializeComponent();

            DisplayTime.Text = showTime.ToString();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(UpdateTime_Tick);
            dt.Interval = new TimeSpan(0, 0, 1); //DateTime gibi struct(yapı) olarak tasarlanmış bir süre temsil eden değişkendir
            dt.Start();

        }
        /*
        public dispatherTime()
        {
            
        }
        */
        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            DisplayTime.Text = DateTime.Now.ToString();
        }
    }


}

