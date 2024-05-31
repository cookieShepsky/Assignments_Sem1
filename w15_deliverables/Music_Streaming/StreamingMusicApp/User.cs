using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp;

public class User
{
    private string username;
    private const int MAX_SONGS_IN_FAVORITE = 50;

    public string Username
    {
        get { return this.username; }
        set
        {
            if (!string.IsNullOrEmpty(value)) this.username = value;
            else throw new ArgumentException("Username should not be empty.");
        }
    }

    public List<Song> FavoriteSongs { get; private set; }

    public User(string username)
    {
        this.Username = username;
        this.FavoriteSongs = new List<Song>();
    }

    public bool AddSongToFavorites(Song song)
    {
        if (!this.FavoriteSongs.Contains(song) && this.FavoriteSongs.Count <= MAX_SONGS_IN_FAVORITE)
        {
            this.FavoriteSongs.Add(song);
            return true;
        }
        return false;
    }

    public bool RemoveSongFromFavorites(Song song)
    {
        if (this.FavoriteSongs.Contains(song))
        {
            this.FavoriteSongs.Remove(song);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Removes song from favorites by it's ID
    /// </summary>
    public bool RemoveSongFromFavorites(int id)
    {
        foreach (Song s in this.FavoriteSongs)
            if (s.Id == id)
            {
                this.FavoriteSongs.Remove(s);
                return true;
            }
        return false;
    }

    public string GetFavoriteSongs()
    {
        string message;

        if (this.FavoriteSongs.Count == 0) message = $"{this.username} has no favorite songs.\n";
        else
        {
            message = $"Favorite songs of {this.username}\n";
            foreach (Song song in this.FavoriteSongs) message += $"{song}\n";
        }

        return message;
    }

    public override string ToString()
    {
        return username;
    }
}
