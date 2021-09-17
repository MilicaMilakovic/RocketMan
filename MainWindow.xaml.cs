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

        bool goLeft, goRight, gameOver;

        ImageBrush playerImage = new ImageBrush();
        ImageBrush starImage = new ImageBrush();

        double speed = 10;
        int playerSpeed = 8;
        double starSpeed = 5;

        int starFrequency = 50;
        int starCount = 0;

        int speedUp = 200;
        double duration = 0;
        Rect playerHitBox;

        List<Rectangle> ToRemove = new List<Rectangle>();

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

            duration += 0.05;

            --starFrequency;
            --speedUp;

            if (speedUp<0)
            {
                speed += 1;
                starSpeed += 0.9;
                speedUp = random.Next(200, 600);
            }

            StarCount.Content = starCount.ToString();
            playerHitBox = new Rect(Canvas.GetLeft(Player), Canvas.GetTop(Player), Player.ActualWidth, Player.ActualHeight);

            
            // pomjeranje rakete

            if (goLeft == true && Canvas.GetLeft(Player) > 5)
            {
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) - playerSpeed);
            }
            if(goRight == true && Canvas.GetLeft(Player) + 80 < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(Player, Canvas.GetLeft(Player) + playerSpeed);
            }

            // postavljanje nove zvijezde
            if (starFrequency < 1)
            {
                MakeStar();
                starFrequency = random.Next(50, 100);
            }

            // provjera kolizije sa drugim planetama i sakupljanje zvjezdica
            foreach (var x in myCanvas.Children.OfType<Rectangle>())
            {
               
                if ((string)x.Tag == "Planet")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + speed);

                    if (Canvas.GetTop(x) > 500)
                    {
                        ChangePlanets(x);
                    }

                    Rect planetHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width-25 , x.Height-25);

                    if (playerHitBox.IntersectsWith(planetHitBox))
                    {
                        //Canvas.SetLeft(x, Canvas.GetLeft(Player));
                        //Canvas.SetTop(x, Canvas.GetTop(Player));
                        gameOver = true;
                        gameTimer.Stop();

                        

                    }

                }
                if ((string)x.Tag == "Star")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + starSpeed);
                    Rect starHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (playerHitBox.IntersectsWith(starHitBox))
                    {
                        ++starCount;
                        ToRemove.Add(x);
                    }

                    if(Canvas.GetTop(x) > 500)
                    {
                        ToRemove.Add(x);
                    }

                   
                }
            }


           foreach(Rectangle rectangle in ToRemove)
            {
                myCanvas.Children.Remove(rectangle);
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
            if (e.Key == Key.Space && gameOver == true)
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            speed = 5;
            playerSpeed = 12;
            starSpeed = 4;
            starCount = 0;
            

            goLeft = false;
            goRight = false;
            gameOver = false;

            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/player2.png"));
            starImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/1.png"));
           

            starImage.Stretch = Stretch.UniformToFill;
            playerImage.Stretch = Stretch.UniformToFill;
            

            Player.Fill = playerImage;

            // postavljanje prepreka
            foreach (var x in myCanvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "Planet")
                {

                    ChangePlanets(x);
                    //Canvas.SetTop(x, Canvas.GetTop(x) + speed);

                    //if (Canvas.GetTop(x) > 500)
                    //{
                    //    Canvas.SetTop(x, random.Next(100, 400) * -1);
                    //    Canvas.SetLeft(x, random.Next(0, 430));

                    //    ChangePlanets(x);
                    //}
                }

                if((string)x.Tag == "Star")
                {
                    ToRemove.Add(x);
                }
               
            }

            ToRemove.Clear();
            gameTimer.Start();

        }

        private void ChangePlanets(Rectangle planet)
        {
            int planetNumber = random.Next(1, 10);
            ImageBrush planetImage = new ImageBrush();

            planetImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/planet" + planetNumber + ".png"));
            planetImage.Stretch = Stretch.Uniform;
            planet.Fill = planetImage;


            Canvas.SetTop(planet, random.Next(100, 400) * -1);
            Canvas.SetLeft(planet, random.Next(0, 430));
        }

     

        private void MakeStar()
        {
            Rectangle newStar = new Rectangle
            {
                Height = 30,
                Width = 30,
                Tag = "Star",
                Fill = starImage
            };

            Canvas.SetTop(newStar, random.Next(100, 400) * -1);
            Canvas.SetLeft(newStar, random.Next(0, 430));

            myCanvas.Children.Add(newStar);     
        }
    }
}
