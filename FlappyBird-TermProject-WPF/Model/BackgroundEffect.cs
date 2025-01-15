using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FlappyBird_TermProject_WPF.Model
{
    public class BackgroundEffect
    {
        public MediaPlayer bgMusic = new MediaPlayer();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private MediaPlayer Fly = new MediaPlayer();
        private MediaPlayer Countdown = new MediaPlayer();
        private MediaPlayer BoostScore = new MediaPlayer();

        public void PlaySound(string nameSound)
        {
            string soundFilePath = "sounds/" + nameSound + ".mp3";
            string fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, soundFilePath);
            if(nameSound == "BoostScore")
            {
                BoostScore.Open(new Uri(fullPath, UriKind.Absolute));
                BoostScore.Volume = 0.5;
                BoostScore.Play();
                return;
            }
            if(nameSound == "Boost")
            {
                Countdown.Open(new Uri(fullPath, UriKind.Absolute));
                Countdown.Volume = 0.5;
                Countdown.Play();
                return;
            } 
            if(nameSound == "Fly" )
            {
                Fly.Open(new Uri(fullPath, UriKind.Absolute));
                Fly.Volume = 0.5;
                Fly.Play();
                return;
            }
            if (nameSound != "bgMusic2" && nameSound != "Fly" )
            {
                mediaPlayer.Open(new Uri(fullPath, UriKind.Absolute));
                mediaPlayer.Volume = 0.5;
                mediaPlayer.Play();
            }
            if(nameSound == "bgMusic2")
            {
                Console.WriteLine("bg2");
                bgMusic.Open(new Uri(fullPath, UriKind.Absolute));
                bgMusic.MediaEnded += (sender, e) => { bgMusic.Position = TimeSpan.Zero; bgMusic.Play(); };
                bgMusic.Volume = 0.5;
                bgMusic.Play();
            }
            
        }
        public void ToggleMute()
        {

            MusicState.IsMuted = !MusicState.IsMuted; 
            MusicState.Volume = MusicState.IsMuted ? 0 : 0.5; 
            bgMusic.Volume = MusicState.Volume;

        }
        public void StopBackgroundMusic()
        {
            mediaPlayer.Stop();
            bgMusic.Stop();
        }
    }
}
