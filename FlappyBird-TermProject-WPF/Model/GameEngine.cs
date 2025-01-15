using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace FlappyBird_TermProject_WPF.Model
{
    public class GameEngine
    {
        private const double gravity = 1.5;
        private const int minGapPosition = 0;
        private const int maxGapPosition = 350;

        private Rectangle flappyBird;
        private Rectangle obstacleTop, obstacleBot, obstacleTop2, obstacleBot2, boostScore;
        private Rectangle background, background2;
        private Canvas myCanvas;
        private TextBlock scoreText;
        private TextBlock lostText;

        private ImageBrush backgroundSprite = new ImageBrush();
        private ImageBrush obstacleSprite = new ImageBrush();
        private ImageBrush boostScoreImage = new ImageBrush();

        private DispatcherTimer animationTimer = new DispatcherTimer();
        private AnimationManager animationManager = new AnimationManager();
        public BackgroundEffect backgroundEffect = new BackgroundEffect();

        private double speed;
        private Random random = new Random();
        public bool gameeOver;
        private int score = -1;

        public bool IsGameOver => gameeOver;


        public GameEngine(Rectangle flappyBird, Rectangle obstacleTop, Rectangle obstacleBot, Rectangle obstacleTop2, Rectangle obstacleBot2, Rectangle boostScore, Rectangle background, Rectangle background2, Canvas myCanvas, TextBlock scoreText, TextBlock lostText)
        {
            this.flappyBird = flappyBird;
            this.obstacleTop = obstacleTop;
            this.obstacleBot = obstacleBot;
            this.obstacleTop2 = obstacleTop2;
            this.obstacleBot2 = obstacleBot2;
            this.boostScore = boostScore;
            this.background = background;
            this.background2 = background2;
            this.myCanvas = myCanvas;
            this.scoreText = scoreText;
            this.lostText = lostText;
            animationManager = new AnimationManager(flappyBird);

            DisplayObstacleAndBackground();
            FlyAnimation();

        }
        public void FlyAnimation()
        {
            animationTimer.Interval = TimeSpan.FromMilliseconds(100); 
            animationTimer.Tick += FlyAnimationLoop; 
            animationTimer.Start();
        }
        private void FlyAnimationLoop(object sender, EventArgs e)
        {
            if (!gameeOver)
            {
                animationManager.FlyAnimationLoop();
            }
        }
        public void DisplayObstacleAndBackground()
        {
            backgroundSprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/BgFlappyBird.png"));
            background.Fill = background2.Fill = backgroundSprite;
            obstacleSprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/PipeStyle.png"));
            obstacleTop.Fill = obstacleBot2.Fill = obstacleTop2.Fill = obstacleBot.Fill = obstacleSprite;
            boostScoreImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/Star.png"));
            boostScore.Fill = boostScoreImage;
        }
        public void ApplyGravity()
        {
            Canvas.SetTop(flappyBird, Canvas.GetTop(flappyBird) + speed);
            speed += gravity;
            if (speed >= 0)  animationManager.Rotate(20);
        }
        public void Jump()
        {
            if (!gameeOver) { 
                speed = -14;
                backgroundEffect.PlaySound("Fly");
                animationManager.Rotate(-15); 
            }
        }
        public void MoveGameObjects()
        {
            MoveObstacle(obstacleBot);
            MoveObstacle(obstacleTop);
            MoveObstacle(obstacleBot2);
            MoveObstacle(obstacleTop2);
            MoveObstacle(boostScore);
            MoveBackground(background);
            MoveBackground(background2);
        }
        private void MoveObstacle(Rectangle obstacle)
        {
            Canvas.SetLeft(obstacle, Canvas.GetLeft(obstacle) - 6); 
        }
        private void MoveBackground(Rectangle bg)
        {
            Canvas.SetLeft(bg, Canvas.GetLeft(bg) - 3);
            if (Canvas.GetLeft(bg) < -bg.Width)  Canvas.SetLeft(bg, Canvas.GetLeft(bg) + bg.Width * 2);
        }

        public void CheckCollisions()
        {
            //Rectangle (it's a ui element) in xaml use for design only it's can't caluclate the position
            //Rect in this code it's use to detect the position
            Rect playerHitBox = new Rect(Canvas.GetLeft(flappyBird), Canvas.GetTop(flappyBird), flappyBird.Width, flappyBird.Height);
            Rect obstacleHitBoxBot = new Rect(Canvas.GetLeft(obstacleBot), Canvas.GetTop(obstacleBot), obstacleBot.Width, obstacleBot.Height);
            Rect obstacleHitBoxTop = new Rect(Canvas.GetLeft(obstacleTop), Canvas.GetTop(obstacleTop), obstacleTop.Width, obstacleTop.Height);
            Rect obstacleHitBoxBot2 = new Rect(Canvas.GetLeft(obstacleBot2), Canvas.GetTop(obstacleBot2), obstacleBot2.Width, obstacleBot2.Height);
            Rect obstacleHitBoxTop2 = new Rect(Canvas.GetLeft(obstacleTop2), Canvas.GetTop(obstacleTop2), obstacleTop2.Width, obstacleTop2.Height);
            Rect boostHitBox = new Rect(Canvas.GetLeft(boostScore), Canvas.GetTop(boostScore), boostScore.Width, boostScore.Height);
            //flappyBird.Stroke = obstacleTop.Stroke = obstacleTop2.Stroke = obstacleBot2.Stroke = obstacleBot.Stroke = Brushes.Red;
            if (CheckCollision(playerHitBox, obstacleHitBoxBot, obstacleHitBoxTop, obstacleHitBoxBot2, obstacleHitBoxTop2))
            {
                if(gameeOver!=true) // prevent duplicate lost sound
                EndGame();
                return;
            }
            CheckAndResetBoostScore(playerHitBox, boostHitBox);
            CheckAndResetObstacle(obstacleTop, obstacleBot);
            CheckAndResetObstacle(obstacleTop2, obstacleBot2);
        }

        private bool CheckCollision(Rect playerHitBox, params Rect[] obstacles)
        {
            foreach (var obstacle in obstacles)
            {
                //IntersectsWith : built in function of rect , check if it overlap or intersect or not
                if (playerHitBox.IntersectsWith(obstacle)) return true;
            }
            return Canvas.GetTop(flappyBird) < 0 || Canvas.GetTop(flappyBird) > 560;
        }
        private void EndGame()
        {
            gameeOver = true;
            backgroundEffect.PlaySound("lost");
            flappyBird.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/images/ghost.png")));
            flappyBird.Width = 100;
            flappyBird.Height = 100;
            lostText.Text = "Press Enter to Retry,\n Ecs to back to Menu.";
        }
        private void CheckAndResetBoostScore(Rect playerHitBox, Rect boostHitBox)
        {
            int randomOffset = random.Next(1000, 2000);

            if (Canvas.GetLeft(boostScore) < -randomOffset)
            {
                SetBoostScorePosition(randomOffset);
            }
            if (playerHitBox.IntersectsWith(boostHitBox))
            {
                backgroundEffect.PlaySound("BoostScore");
                score += 2; 
                UpdateScore();
                SetBoostScorePosition(randomOffset);
            }
        }

        private void CheckAndResetObstacle(Rectangle topObstacle, Rectangle bottomObstacle)
        {
            if (Canvas.GetLeft(bottomObstacle) < -80) 
            {
                SetObstaclePosition(topObstacle, bottomObstacle);
                backgroundEffect.PlaySound("score2");
                score++; 
                UpdateScore();
            }
        }
        private void UpdateScore()
        {
            scoreText.Text = score.ToString(); 
        }
        private void SetObstaclePosition(Rectangle topObstacle, Rectangle bottomObstacle)
        {
            Canvas.SetLeft(topObstacle, 440);
            Canvas.SetLeft(bottomObstacle, 440);
            int gapSize = 200;
            int gapStart = random.Next(minGapPosition, maxGapPosition);
            Canvas.SetTop(topObstacle, gapStart - topObstacle.Height);
            Canvas.SetTop(bottomObstacle, gapStart + gapSize);
        }
        private void SetBoostScorePosition(int randomPosition)
        {
            int gapStart = random.Next(minGapPosition, maxGapPosition);
            Canvas.SetTop(boostScore, gapStart + 100); 
            Canvas.SetLeft(boostScore, randomPosition);
        }
        public void StartGame()
        {
            animationManager.Rotate(0);
            gameeOver = false;
            score = 0;
            speed = -20;
            lostText.Text = string.Empty;
            UpdateScore();
            StartPosistion();
        }
        public void StartPosistion()
        {
            flappyBird.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/images/orangeBird1.png")));
            flappyBird.Width = 50; flappyBird.Height = 40;

            Canvas.SetLeft(flappyBird, 100);
            Canvas.SetTop(flappyBird, 250);

            Canvas.SetLeft(obstacleBot, 240);
            Canvas.SetTop(obstacleBot, 650);
            Canvas.SetLeft(obstacleTop, 240);
            Canvas.SetTop(obstacleTop, -650);

            Canvas.SetLeft(obstacleBot2, 480);
            Canvas.SetTop(obstacleBot2, 350);
            Canvas.SetLeft(obstacleTop2, 480);
            Canvas.SetTop(obstacleTop2, -230);

            Canvas.SetLeft(background, 0);
            Canvas.SetLeft(background2, 480);
        }
    }
}