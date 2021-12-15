using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Song
    {
        /// <summary>
        /// Length of song in seconds.
        /// </summary>
        public float Length => length;

        public string Title => title;
        public string Artist => artist;
        public bool IsCompleted => isCompleted;
        public int HighScore => highScore;
        public int LongestStreak => longestStreak;
        public int DifficultyRating => difficultyRating;
        public AudioClip AudioClip => audioClip;
        public Queue<Note> Notes => notes;

        private readonly string title;
        private readonly string artist;
        private readonly bool isCompleted;
        private readonly int highScore;
        private readonly int longestStreak;
        private readonly float length;
        private readonly AudioClip audioClip;
        private readonly Queue<Note> notes;
        private readonly int difficultyRating;

        private const float lengthPadding = 2;
        public Song() { notes = new Queue<Note>(); }
        public Song(string title, string artist, AudioClip audioClip, Queue<Note> notes)
        {
            this.title = title;
            this.artist = artist;
            this.audioClip = audioClip;
            this.notes = notes;
            length = Notes.Last().TimeStamp + lengthPadding;
            difficultyRating = (int)(Notes.Count / (length - lengthPadding));
        }
        public Song(string title, string artist, AudioClip audioClip)
        {
            this.title = title;
            this.artist = artist;
            this.audioClip = audioClip;
            this.notes = new Queue<Note>();
        }

        public void OnWin()
        {
            User.UpdateScores(new SongData(Title, IsCompleted, HighScore, LongestStreak));
        }
    }
}
