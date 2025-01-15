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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FlappyBird_TermProject_WPF
{
    /// <summary>
    /// Interaction logic for Gameplay.xaml
    /// </summary>
    public partial class Gameplay : Page
    {
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private DispatcherTimer countdownTimer = new DispatcherTimer();
        BackgroundEffect backgroundEffect = new BackgroundEffect();
        private GameEngine gameEngine;
        private int countdownValue = 3;
        private bool isCountdownActive = false;

        public Gameplay()
        {
            InitializeComponent();
            myCanvas.Focus();

            gameEngine = new GameEngine(flappyBird, obstacleTop, obstacleBot, obstacleTop2, obstacleBot2, boostScore, background, background2, myCanvas, scoreText, lostText);

            gameTimer.Tick += GameLoop;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            countdownTimer.Tick += CountdownLoop;
            countdownTimer.Interval = TimeSpan.FromSeconds(1);
            backgroundEffect.PlaySound("Countdown");
            gameEngine.gameeOver = false;

            StartCountdown();
        }

        private void StartCountdown()
        {
            gameEngine.backgroundEffect.StopBackgroundMusic();
            gameEngine.StartPosistion();

            isCountdownActive = true;
            countdownValue = 3;
            countdownTimer.Start();
            CountdownText.Text = countdownValue.ToString();
            CountdownText.Visibility = Visibility.Visible;

            scoreText.Text = string.Empty;
            lostText.Text = string.Empty;
            help.Opacity = 1;

        }

        private void CountdownLoop(object sender, EventArgs e)
        {
            
            gameEngine.StartGame(); // play animation while counting down
            if (countdownValue >= 0)
            {
                CountdownText.Text = countdownValue.ToString();
                countdownValue--;
                if (countdownValue < 0)
                {
                    CountdownText.Text = "Go!";
                    help.Opacity = 0;
                }
            }
            else
            {
                countdownTimer.Stop();
                CountdownText.Visibility = Visibility.Collapsed;
                isCountdownActive = false;
                backgroundEffect.PlaySound("bgMusic2");

                gameTimer.Start();
                gameEngine.StartGame();
            }

        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (!isCountdownActive)
            {
                gameEngine.MoveGameObjects();
                gameEngine.CheckCollisions();
                gameEngine.ApplyGravity();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space && !gameEngine.IsGameOver && !isCountdownActive)
            {
                
                gameEngine.Jump();
            }
            if (e.Key == Key.Enter && gameEngine.IsGameOver)
            {
                backgroundEffect.PlaySound("Countdown");

                backgroundEffect.StopBackgroundMusic();
                StartCountdown();
            }
            if(gameEngine.IsGameOver)
            {
                backgroundEffect.StopBackgroundMusic();
            }
            if (e.Key == Key.Escape && gameEngine.IsGameOver)
            {
                backgroundEffect.StopBackgroundMusic();
                NavigationService.Navigate(new Menu());
            }
            if (e.Key == Key.M)
            {
                backgroundEffect.ToggleMute();
            }
        }
    }
}
