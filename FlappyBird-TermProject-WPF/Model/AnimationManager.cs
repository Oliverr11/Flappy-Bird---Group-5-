using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using System.Windows;

namespace FlappyBird_TermProject_WPF.Model
{
    public class AnimationManager
    {
        private int currentFlyIndex = 1;
        private Rectangle flappyBird;
        private ImageBrush flappyBirdFly = new ImageBrush();
        private RotateTransform rotateTransform = new RotateTransform(); 

        public AnimationManager() { }
        public AnimationManager(Rectangle flappyBird)
        {
            this.flappyBird = flappyBird;
            this.flappyBird.RenderTransform = rotateTransform;
            this.flappyBird.RenderTransformOrigin = new Point(0.5, 0.5);
        }

        public void FlyingAnimation(double i)
        {
            switch (i)
            {
                case 1: flappyBirdFly.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orangeBird1.png")); break;
                case 2: flappyBirdFly.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orangeBird2.png")); break;
                case 3: flappyBirdFly.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orangeBird3.png")); break;
                case 4: flappyBirdFly.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orangeBird4.png")); break;
            }
            flappyBird.Fill = flappyBirdFly;
        }

        public void FlyAnimationLoop()
        {
            currentFlyIndex = (currentFlyIndex % 4) + 1;
            FlyingAnimation(currentFlyIndex);
        }
        public  void Rotate(int angle)
        {
            rotateTransform.Angle = angle; // Set rotation angle
        }
    }
}