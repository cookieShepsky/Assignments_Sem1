
namespace StreamingMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tbSearchArtist = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnShowFavorites = new System.Windows.Forms.Button();
            btnRemoveFromFavorites = new System.Windows.Forms.Button();
            btnAddToFavorites = new System.Windows.Forms.Button();
            lblCurrentUser = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnShowAll = new System.Windows.Forms.Button();
            btnAddSong = new System.Windows.Forms.Button();
            cbxAddGenre = new System.Windows.Forms.ComboBox();
            nudAddDuration = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbAddTitle = new System.Windows.Forms.TextBox();
            tbAddArtist = new System.Windows.Forms.TextBox();
            lbxSongs = new System.Windows.Forms.ListBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            btnUserSelect = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnUserAdd = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            tbAddUsername = new System.Windows.Forms.TextBox();
            lbxUsers = new System.Windows.Forms.ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddDuration).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(799, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbSearchArtist);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(lbxSongs);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(791, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Songs";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbSearchArtist
            // 
            tbSearchArtist.Location = new System.Drawing.Point(310, 391);
            tbSearchArtist.Name = "tbSearchArtist";
            tbSearchArtist.PlaceholderText = "Search by Artist";
            tbSearchArtist.Size = new System.Drawing.Size(474, 23);
            tbSearchArtist.TabIndex = 5;
            tbSearchArtist.TextChanged += tbSearchArtist_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnShowFavorites);
            groupBox3.Controls.Add(btnRemoveFromFavorites);
            groupBox3.Controls.Add(btnAddToFavorites);
            groupBox3.Controls.Add(lblCurrentUser);
            groupBox3.Location = new System.Drawing.Point(6, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(296, 126);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Favorites";
            // 
            // btnShowFavorites
            // 
            btnShowFavorites.Location = new System.Drawing.Point(18, 95);
            btnShowFavorites.Name = "btnShowFavorites";
            btnShowFavorites.Size = new System.Drawing.Size(257, 23);
            btnShowFavorites.TabIndex = 1;
            btnShowFavorites.Text = "Show Favorites";
            btnShowFavorites.UseVisualStyleBackColor = true;
            btnShowFavorites.Click += btnShowFavorites_Click;
            // 
            // btnRemoveFromFavorites
            // 
            btnRemoveFromFavorites.Location = new System.Drawing.Point(18, 66);
            btnRemoveFromFavorites.Name = "btnRemoveFromFavorites";
            btnRemoveFromFavorites.Size = new System.Drawing.Size(257, 23);
            btnRemoveFromFavorites.TabIndex = 1;
            btnRemoveFromFavorites.Text = "Remove selected song from favorites";
            btnRemoveFromFavorites.UseVisualStyleBackColor = true;
            btnRemoveFromFavorites.Click += btnRemoveFromFavorites_Click;
            // 
            // btnAddToFavorites
            // 
            btnAddToFavorites.Location = new System.Drawing.Point(18, 37);
            btnAddToFavorites.Name = "btnAddToFavorites";
            btnAddToFavorites.Size = new System.Drawing.Size(257, 23);
            btnAddToFavorites.TabIndex = 1;
            btnAddToFavorites.Text = "Add selected song to favorites";
            btnAddToFavorites.UseVisualStyleBackColor = true;
            btnAddToFavorites.Click += btnAddToFavorites_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new System.Drawing.Point(18, 19);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new System.Drawing.Size(78, 15);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.Text = "Current user: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowAll);
            groupBox1.Controls.Add(btnAddSong);
            groupBox1.Controls.Add(cbxAddGenre);
            groupBox1.Controls.Add(nudAddDuration);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbAddTitle);
            groupBox1.Controls.Add(tbAddArtist);
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(296, 172);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Song";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new System.Drawing.Point(18, 143);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new System.Drawing.Size(121, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new System.Drawing.Point(169, 143);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new System.Drawing.Size(121, 23);
            btnAddSong.TabIndex = 5;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // cbxAddGenre
            // 
            cbxAddGenre.FormattingEnabled = true;
            cbxAddGenre.Location = new System.Drawing.Point(169, 107);
            cbxAddGenre.Name = "cbxAddGenre";
            cbxAddGenre.Size = new System.Drawing.Size(121, 23);
            cbxAddGenre.TabIndex = 4;
            // 
            // nudAddDuration
            // 
            nudAddDuration.Location = new System.Drawing.Point(169, 75);
            nudAddDuration.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAddDuration.Name = "nudAddDuration";
            nudAddDuration.Size = new System.Drawing.Size(121, 23);
            nudAddDuration.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(18, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 20);
            label1.TabIndex = 2;
            label1.Text = "Song Artist: ";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(18, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(145, 20);
            label4.TabIndex = 2;
            label4.Text = "Song Genre:";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(18, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Song Duration in seconds:";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(18, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Song Title: ";
            // 
            // tbAddTitle
            // 
            tbAddTitle.Location = new System.Drawing.Point(169, 45);
            tbAddTitle.Name = "tbAddTitle";
            tbAddTitle.PlaceholderText = "Title";
            tbAddTitle.Size = new System.Drawing.Size(121, 23);
            tbAddTitle.TabIndex = 1;
            // 
            // tbAddArtist
            // 
            tbAddArtist.Location = new System.Drawing.Point(169, 16);
            tbAddArtist.Name = "tbAddArtist";
            tbAddArtist.PlaceholderText = "Artist";
            tbAddArtist.Size = new System.Drawing.Size(121, 23);
            tbAddArtist.TabIndex = 1;
            // 
            // lbxSongs
            // 
            lbxSongs.FormattingEnabled = true;
            lbxSongs.ItemHeight = 15;
            lbxSongs.Location = new System.Drawing.Point(310, 6);
            lbxSongs.Name = "lbxSongs";
            lbxSongs.Size = new System.Drawing.Size(475, 379);
            lbxSongs.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnUserSelect);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(lbxUsers);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(791, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUserSelect
            // 
            btnUserSelect.Location = new System.Drawing.Point(621, 391);
            btnUserSelect.Name = "btnUserSelect";
            btnUserSelect.Size = new System.Drawing.Size(164, 23);
            btnUserSelect.TabIndex = 5;
            btnUserSelect.Text = "Select User";
            btnUserSelect.UseVisualStyleBackColor = true;
            btnUserSelect.Click += btnUserSelect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUserAdd);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbAddUsername);
            groupBox2.Location = new System.Drawing.Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(298, 87);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add User";
            // 
            // btnUserAdd
            // 
            btnUserAdd.Location = new System.Drawing.Point(169, 54);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new System.Drawing.Size(121, 23);
            btnUserAdd.TabIndex = 5;
            btnUserAdd.Text = "Add User";
            btnUserAdd.UseVisualStyleBackColor = true;
            btnUserAdd.Click += btnUserAdd_Click;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(18, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 20);
            label5.TabIndex = 2;
            label5.Text = "Username: ";
            // 
            // tbAddUsername
            // 
            tbAddUsername.Location = new System.Drawing.Point(169, 16);
            tbAddUsername.Name = "tbAddUsername";
            tbAddUsername.PlaceholderText = "Username";
            tbAddUsername.Size = new System.Drawing.Size(121, 23);
            tbAddUsername.TabIndex = 1;
            // 
            // lbxUsers
            // 
            lbxUsers.FormattingEnabled = true;
            lbxUsers.ItemHeight = 15;
            lbxUsers.Location = new System.Drawing.Point(310, 6);
            lbxUsers.Name = "lbxUsers";
            lbxUsers.Size = new System.Drawing.Size(475, 379);
            lbxUsers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddDuration).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxSongs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddArtist;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.ComboBox cbxAddGenre;
        private System.Windows.Forms.NumericUpDown nudAddDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddUsername;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUserSelect;
        private System.Windows.Forms.Button btnAddToFavorites;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.TextBox tbSearchArtist;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.Button btnRemoveFromFavorites;
        private System.Windows.Forms.Button btnShowAll;
    }
}

