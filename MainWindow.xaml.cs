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

        DispatcherTimer gameTimer = new DispatcherTimer();
        Random random = new Random();

        bool goLeft, goRight;

        ImageBrush playerImage = new ImageBrush();
        ImageBrush starImage = new ImageBrush();

        int speed = 10;
        int playerSpeed = 8;



        public MainWindow()
        {
            InitializeComponent();

            myCanvas.Focus();

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            StartGame();

        }

        private void GameLoop(object sender, EventArgs e)
        {

            // pomjeranje rakete

            if(goLeft == true && Canvas.GetLeft(Player) > 0)
            {
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) - playerSpeed);
            }
            if(goRight == true && Canvas.GetLeft(Player) + 150 < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) + playerSpeed);
            }


            // postavljanje prepreka
            foreach(var x  in myCanvas.Children.OfType<Rectangle>())
            {
                if((string) x.Tag == "Planet")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + speed);

                    if (Canvas.GetTop(x) > 500)
                    {
                        Canvas.SetTop(x, random.Next(100, 400) * -1);
                        Canvas.SetLeft(x, random.Next(0, 430));

                        ChangePlanets(x);
                    }
                }
            }


        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Left)
            {
                goLeft = false;
            }
            if(e.Key == Key.Right)
            {
                goRight = false;
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                goLeft = true;

            }
            if (e.Key == Key.Right)
            {
                goRight = true;
            }
        }

        private void StartGame()
        {
            speed = 8;
            gameTimer.Start();

            goLeft = false;
            goRight = false;

            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/player.png"));
            starImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/star.png"));

            playerImage.Stretch = Stretch.UniformToFill;
            Player.Fill = playerImage;

        }

        private void ChangePlanets(Rectangle planet)
        {
            int planetNumber = random.Next(1, 10);
            ImageBrush planetImage = new ImageBrush();

            planetImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/planet" + planetNumber + ".png"));
            planetImage.Stretch = Stretch.UniformToFill;
            planet.Fill = planetImage;
        }
    }
}
