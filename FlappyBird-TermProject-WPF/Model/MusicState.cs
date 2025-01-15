using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird_TermProject_WPF.Model
{
    public static class MusicState
    {
        public static bool IsMuted { get; set; } = false; 
        public static double Volume { get; set; } = 0.5; 
    }
}
