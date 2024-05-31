using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        StreamingMusicService service;
        bool isFavorites;
        public Form1()
        {
            InitializeComponent();
            service = new("Areaify");
            // Add all genres to the cbx
            foreach (Genre g in Enum.GetValues(typeof(Genre)))
                cbxAddGenre.Items.Add(g);
            // Default songs for testing
            service.DefaultSongs();
            UpdateSongTab();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string newArtist = tbAddArtist.Text;
            string newTitle = tbAddTitle.Text;
            int newDuration = (int)nudAddDuration.Value;

            // Check for emtpy cbx
            if (!(cbxAddGenre.SelectedIndex > -1))
            {
                MessageBox.Show("Please define a Genre.");
                return;
            }
            Genre newGenre = (Genre)cbxAddGenre.SelectedIndex;

            // Check for empty/invalid input
            if (!service.AddSong(newArtist, newTitle, newDuration, newGenre))
            {
                MessageBox.Show("Please define an Artist, Title, and Duration.");
                return;
            }

            // if successful
            UpdateSongTab();
        }

        private void UpdateSongTab()
        {
            lbxSongs.Items.Clear();
            foreach (Song s in service.GetSongs())
                lbxSongs.Items.Add(s);
            tbAddArtist.Text = tbAddTitle.Text = "";
            nudAddDuration.Value = 0;
            cbxAddGenre.SelectedIndex = -1;
            this.Text = $"{service.Name} | Current User: {service.SelectedUser} | Songs: {service.GetSongs().Length}";
            isFavorites = false;
            lblCurrentUser.Text = $"Current User: {service.SelectedUser}";
        }

        private void UpdateUserTab()
        {
            lbxUsers.Items.Clear();
            foreach (User s in service.Users)
                lbxUsers.Items.Add(s);
            tbAddUsername.Text = "";
            this.Text = $"{service.Name} | Current User: {service.SelectedUser} | Songs: {service.GetSongs().Length}";
            lblCurrentUser.Text = $"Current User: {service.SelectedUser}";
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {

            if (service.AddUser(tbAddUsername.Text))
            {
                service.SelectedUser = service.Users.Last();
                UpdateUserTab();
                return;
            }
            MessageBox.Show("That user already exists!");
        }

        private void btnUserSelect_Click(object sender, EventArgs e)
        {
            if (lbxUsers.SelectedIndex > -1) service.SelectedUser = service.Users[lbxUsers.SelectedIndex];
            UpdateUserTab();
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            if (service.SelectedUser == null)
            {
                MessageBox.Show("No user selected!");
                return;
            }

            if (lbxSongs.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a song to add.");
                return;
            }

            if (service.SelectedUser.AddSongToFavorites(service.GetSongs()[lbxSongs.SelectedIndex]))
                MessageBox.Show($"{service.GetSongs()[lbxSongs.SelectedIndex]} was added to favorites!");
        }

        private void btnRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            if (service.SelectedUser == null)
            {
                MessageBox.Show("No user selected!");
                return;
            }

            if (!(service.SelectedUser.FavoriteSongs.Count() > 0))
            {
                MessageBox.Show("No songs in Favorites.");
                return;
            }

            if (lbxSongs.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a song to remove.");
                return;
            }

            if (isFavorites)
            {
                if (service.SelectedUser.RemoveSongFromFavorites((Song)lbxSongs.SelectedItem))
                {
                    MessageBox.Show($"{(Song)lbxSongs.SelectedItem} was removed from favorites!");
                    btnShowFavorites_Click(sender, e);
                    return;
                }
            }

            if (service.SelectedUser.RemoveSongFromFavorites(service.GetSongs()[lbxSongs.SelectedIndex]))
            {
                MessageBox.Show($"{(Song)lbxSongs.SelectedItem} was removed from favorites!");
                btnShowFavorites_Click(sender, e);
                return;
            }

            MessageBox.Show("That song is not in your favorites!");
        }

        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            if (service.SelectedUser == null)
            {
                MessageBox.Show("No user selected!");
                return;
            }
            if ((service.SelectedUser.FavoriteSongs.Count()) < 0)
            {
                MessageBox.Show("No favorites to show!");
                return;
            }
            lbxSongs.Items.Clear();
            foreach (Song s in service.SelectedUser.FavoriteSongs)
                lbxSongs.Items.Add(s);
            isFavorites = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateSongTab();
        }

        private void tbSearchArtist_TextChanged(object sender, EventArgs e)
        {
            lbxSongs.Items.Clear();
            if (string.IsNullOrEmpty(tbSearchArtist.Text))
            {
                UpdateSongTab();
                return;
            }
            Song[] sorted = service.GetSongs(search: tbSearchArtist.Text, partialSearch:true);
            foreach (Song s in sorted) { lbxSongs.Items.Add(s); }
        }
    }
}
