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

using System.Windows.Threading;

namespace RocketMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int left = 0;
        int speed = 5;


        public MainWindow()
        {
            InitializeComponent();

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();
            timer.Tick += _timer_Tick;

        }

        void _timer_Tick(object sender, EventArgs e)
        {
            left += speed;
            BlueCircle.Margin = new Thickness(left, 0, 0, 90);

            if(left > 443)
            {
                speed = -5;
            }
            if (left < 2)
            {
                speed = 5;
            }

        }
    }
}
