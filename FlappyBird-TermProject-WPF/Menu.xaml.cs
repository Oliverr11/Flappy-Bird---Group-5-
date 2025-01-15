using FlappyBird_TermProject_WPF.Model;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FlappyBird_TermProject_WPF
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        private BackgroundEffect backgroundEffect = new BackgroundEffect();
        private DispatcherTimer flyAnimationTimer;
        private DispatcherTimer backgroundAnimationTimer;
        private int currentFlyIndex = 1;
        private const int MaxFlyFrames = 3;
        private const double BackgroundSpeed = 2;

        public Menu()
        {
            InitializeComponent();
            backgroundEffect.PlaySound("bgMusic2");

            flyAnimationTimer = new DispatcherTimer();
            flyAnimationTimer.Interval = TimeSpan.FromMilliseconds(100);
            flyAnimationTimer.Tick += FlyAnimationTimer_Tick;
            flyAnimationTimer.Start();

            backgroundAnimationTimer = new DispatcherTimer();
            backgroundAnimationTimer.Interval = TimeSpan.FromMilliseconds(15);
            backgroundAnimationTimer.Tick += BackgroundAnimationTimer_Tick;
            backgroundAnimationTimer.Start();
        }

        private void FlyAnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFlyIndex = (currentFlyIndex % MaxFlyFrames) + 1;
            FlappyBirdAnimation.Source = new BitmapImage(new Uri($"pack://application:,,,/images/orangeBird{currentFlyIndex}.png"));
        }

        private void BackgroundAnimationTimer_Tick(object sender, EventArgs e)
        {
            double newMargin1 = Background1.Margin.Left - BackgroundSpeed;
            double newMargin2 = Background2.Margin.Left - BackgroundSpeed;

            if (newMargin1 <= -450)
            {
                newMargin1 = 450;
            }
            if (newMargin2 <= -450)
            {
                newMargin2 = 450;
            }

            //left top right bot
            Background1.Margin = new Thickness(newMargin1, 0, 0, 0);
            Background2.Margin = new Thickness(newMargin2, 0, 0, 0);
        }

        private void NavigateToPage2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Gameplay());
            backgroundEffect.StopBackgroundMusic();
            Page2Button.Visibility = Visibility.Collapsed;
            FlappyBirdLogo.Visibility = Visibility.Collapsed;
            MuteButton.Visibility = Visibility.Collapsed;
            CloseButton.Visibility = Visibility.Collapsed;
            FlappyBirdAnimation.Visibility = Visibility.Collapsed;

            flyAnimationTimer.Stop();
            backgroundAnimationTimer.Stop();
        }

        private void ToggleMute(object sender, RoutedEventArgs e)
        {
            backgroundEffect.ToggleMute();
            ((Image)MuteButton.Content).Source = new BitmapImage(new Uri(MusicState.IsMuted ? "pack://application:,,,/images/Mute.png" : "pack://application:,,,/images/Unmute.png"));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
