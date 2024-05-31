using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private string artist;
        private string title;

        public Song(int id, string artist, string title, int durationInSeconds, Genre genre)
        {
            this.Id = id;
            this.Artist = artist;
            this.Title = title;
            this.DurationInSeconds = durationInSeconds;
            this.Genre = genre;

        }

        public int Id { get; private set; }

        public string Artist
        {
            get { return this.artist; }
            set
            {
                if (!string.IsNullOrEmpty(value)) this.artist = value;
                else throw new Exception("Artist name should not be empty.");
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (!string.IsNullOrEmpty(value)) this.title = value;
                else throw new Exception("Title should not be empty.");
            }
        }

        public int DurationInSeconds { get; set; }

        public Genre Genre { get; set; }

        public override string ToString()
        {
            return $"ID {this.Id:00}: {this.Artist} - {this.Title} ({this.DurationInSeconds} seconds)";
        }
    }
}
