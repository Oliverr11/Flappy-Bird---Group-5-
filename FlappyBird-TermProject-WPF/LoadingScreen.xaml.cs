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
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Page
    {
        private DispatcherTimer loadingTimer;
        private int progress = 0;
        private int TotalCells = 10;
        private ImageBrush flappyBirdImageBrush = new ImageBrush();
        public LoadingScreen()
        {
            InitializeComponent();

            flappyBirdImageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/Star.png"));
            flappyBirdImageBrush.Stretch = Stretch.Fill;

            loadingTimer = new DispatcherTimer();
            loadingTimer.Interval = TimeSpan.FromMilliseconds(50);
            loadingTimer.Tick += LoadingTimer_Tick;
            loadingTimer.Start();
        }
        private void LoadingTimer_Tick(object sender, System.EventArgs e)
        {
            if (progress < TotalCells)
            {
                ((Rectangle)ProgressGrid.Children[progress]).Fill = flappyBirdImageBrush;
                progress++;

            }
            else
            {
                loadingTimer.Stop();
            }
        }
    }
}
