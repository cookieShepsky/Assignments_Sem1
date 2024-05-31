using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private List<Song> songs;
        private User selectedUser;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.Name = name;
            this.songs = new List<Song>();
            this.Users = new List<User>();
        }

        public string Name { get; private set; }
        public List<User> Users { get; private set; }

        public User SelectedUser
        {
            get { return this.selectedUser; }
            set { if (Users.Contains(value)) this.selectedUser = value; }
        }

        /// <summary>
        /// Add a song to the streaming service.
        /// </summary>
        /// <returns>
        /// True if adding was successful <br/>
        /// False if invalid values were passed -> if adding failed
        /// </returns>
        public bool AddSong(string artist, string title, int durationInSeconds, Genre genre)
        {
            if (!string.IsNullOrEmpty(artist) && !string.IsNullOrEmpty(title) && durationInSeconds > 0)
            {
                this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, genre));
                this.songIdSeeder++;
                return true;
            }
            return false;
        }

        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.Id)
                { return s; }
            }
            return null;
        }

        public Song[] GetSongs()
        {
            return this.songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new();
            foreach (Song s in this.songs)
            {
                if(artist == s.Artist)
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }

        public Song[] GetSongs(string search, bool partialSearch)
        {
            if (partialSearch)
            {
                List<Song> foundSongs = new();
                foreach (Song s in this.songs)
                {
                    if(s.Artist.ToLower().Contains(search.ToLower())) foundSongs.Add(s);
                }
                return foundSongs.ToArray();
            }
            return null;
        }

        /// <summary>
        /// Add a user to Users
        /// </summary>
        /// <returns>
        /// <c>true</c> if adding was successfull <br/>
        /// <c>false</c> if adding was unsuccessfull
        /// </returns>
        public bool AddUser(string username)
        {
            try
            {
                // Check if username is taken
                if (Users.Count > 0)
                {
                    foreach (User u in Users)
                    {
                        if (u.Username == username)
                            return false;
                    }
                }
                    User newUser = new(username);
                    Users.Add(newUser);
                    return true;
            }
            catch(Exception) { return false; }
        }

        /// <summary>
        /// Returns the user object at a specified index, if that index exists.
        /// </summary>\
        /// <returns>
        /// <c>User</c> if index is valid <br/>
        /// <c>null</c> if index is out of range
        /// </returns>
        public User GetUserAt(int index)
        {
            try
            {
                return Users[index];
            }
            catch (IndexOutOfRangeException) {  return null; }
        }

        public void DefaultSongs()
        {
            this.AddSong("Jacob Collier", "Time alone with you", 200, Genre.RnB);
            this.AddSong("Fox Stevenson", "Okay", 220, Genre.DnB);
            this.AddSong("Jacob Collier", "In my room", 198, Genre.Jazz);
            this.AddSong("Jacob Collier", "Moon river", 320, Genre.Ambient);
            this.AddSong("Dr. Peacock", "Trip to Ireland", 250, Genre.Frenchcore);
        }

        public override string ToString()
        {
            return $"Streaming Music service: {this.Name} ({this.songs.Count} songs & {this.Users.Count} users)";
        }
    }
}
