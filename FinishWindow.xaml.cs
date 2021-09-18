using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace RocketMan
{
    /// <summary>
    /// Interaction logic for FinishWindow.xaml
    /// </summary>
    public partial class FinishWindow : Window
    {
        
        public FinishWindow()
        {
            InitializeComponent();

            myCanvas.Focus();

            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string text = System.IO.File.ReadAllText(projectPath + "/resources/scores.txt");
            int highestScore = Int32.Parse(text);

            Score.Content = "Highest Score : " + highestScore;
        }

        private void Restart(object sender, RoutedEventArgs e)
        {           
            
            this.Close();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                Restart(sender, e);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
    }
}
