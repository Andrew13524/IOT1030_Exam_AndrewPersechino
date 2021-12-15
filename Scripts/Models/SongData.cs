using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    public struct SongData
    {
        public string Name;
        public bool IsCompleted;
        public int HighScore;
        public int LongestStreak;

        public SongData(string name, bool isCompleted, int highScore, int longestStreak)
        {
            Name = name;
            IsCompleted = isCompleted;
            HighScore = highScore;
            LongestStreak = longestStreak;
        }
    }
}
