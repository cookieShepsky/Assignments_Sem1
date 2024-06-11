namespace Gardener
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            cbxGardenRemove = new ComboBox();
            btnRemove = new Button();
            btnAdd = new Button();
            tbGardenName = new TextBox();
            groupBox2 = new GroupBox();
            lblPeakBloom = new Label();
            btnShowAll = new Button();
            btnSelectPrunable = new Button();
            cbxSelectMonth = new ComboBox();
            btnPlantAdd = new Button();
            cbPlantEvergreen = new CheckBox();
            cbxPlantType = new ComboBox();
            label5 = new Label();
            tbPlantColor = new TextBox();
            tbPlantName = new TextBox();
            label1 = new Label();
            btnPlantsInfo = new Button();
            btnPlantsRemove = new Button();
            lbxPlants = new ListBox();
            lblSelectedGarden = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxGardenRemove);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbGardenName);
            groupBox1.Location = new Point(11, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Gardens";
            // 
            // cbxGardenRemove
            // 
            cbxGardenRemove.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGardenRemove.FormattingEnabled = true;
            cbxGardenRemove.Location = new Point(6, 51);
            cbxGardenRemove.Name = "cbxGardenRemove";
            cbxGardenRemove.Size = new Size(249, 23);
            cbxGardenRemove.TabIndex = 2;
            cbxGardenRemove.SelectedIndexChanged += cbxGardenRemove_IndexChange;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(6, 80);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(249, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(180, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbGardenName
            // 
            tbGardenName.Location = new Point(6, 22);
            tbGardenName.Name = "tbGardenName";
            tbGardenName.PlaceholderText = "Garden Name";
            tbGardenName.Size = new Size(168, 23);
            tbGardenName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPeakBloom);
            groupBox2.Controls.Add(btnShowAll);
            groupBox2.Controls.Add(btnSelectPrunable);
            groupBox2.Controls.Add(cbxSelectMonth);
            groupBox2.Controls.Add(btnPlantAdd);
            groupBox2.Controls.Add(cbPlantEvergreen);
            groupBox2.Controls.Add(cbxPlantType);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbPlantColor);
            groupBox2.Controls.Add(tbPlantName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnPlantsInfo);
            groupBox2.Controls.Add(btnPlantsRemove);
            groupBox2.Controls.Add(lbxPlants);
            groupBox2.Controls.Add(lblSelectedGarden);
            groupBox2.Location = new Point(11, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 505);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage Plants";
            // 
            // lblPeakBloom
            // 
            lblPeakBloom.Location = new Point(7, 42);
            lblPeakBloom.Name = "lblPeakBloom";
            lblPeakBloom.Size = new Size(249, 23);
            lblPeakBloom.TabIndex = 2;
            lblPeakBloom.Text = "lblPeakBloom";
            lblPeakBloom.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(7, 310);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(248, 23);
            btnShowAll.TabIndex = 12;
            btnShowAll.Text = "Show All Plants";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSelectPrunable
            // 
            btnSelectPrunable.Location = new Point(6, 281);
            btnSelectPrunable.Name = "btnSelectPrunable";
            btnSelectPrunable.Size = new Size(249, 23);
            btnSelectPrunable.TabIndex = 11;
            btnSelectPrunable.Text = "Show Prunable Plants";
            btnSelectPrunable.UseVisualStyleBackColor = true;
            btnSelectPrunable.Click += btnSelectPrunable_Click;
            // 
            // cbxSelectMonth
            // 
            cbxSelectMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSelectMonth.FormattingEnabled = true;
            cbxSelectMonth.Location = new Point(7, 252);
            cbxSelectMonth.Name = "cbxSelectMonth";
            cbxSelectMonth.Size = new Size(249, 23);
            cbxSelectMonth.TabIndex = 10;
            // 
            // btnPlantAdd
            // 
            btnPlantAdd.Location = new Point(137, 455);
            btnPlantAdd.Name = "btnPlantAdd";
            btnPlantAdd.Size = new Size(117, 23);
            btnPlantAdd.TabIndex = 9;
            btnPlantAdd.Text = "Add";
            btnPlantAdd.UseVisualStyleBackColor = true;
            btnPlantAdd.Click += btnPlantAdd_Click;
            // 
            // cbPlantEvergreen
            // 
            cbPlantEvergreen.AutoSize = true;
            cbPlantEvergreen.Location = new Point(6, 458);
            cbPlantEvergreen.Name = "cbPlantEvergreen";
            cbPlantEvergreen.Size = new Size(78, 19);
            cbPlantEvergreen.TabIndex = 8;
            cbPlantEvergreen.Text = "Evergreen";
            cbPlantEvergreen.UseVisualStyleBackColor = true;
            // 
            // cbxPlantType
            // 
            cbxPlantType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPlantType.FormattingEnabled = true;
            cbxPlantType.Location = new Point(46, 429);
            cbxPlantType.Name = "cbxPlantType";
            cbxPlantType.Size = new Size(208, 23);
            cbxPlantType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 432);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "Type:";
            // 
            // tbPlantColor
            // 
            tbPlantColor.Location = new Point(5, 400);
            tbPlantColor.Name = "tbPlantColor";
            tbPlantColor.PlaceholderText = "Color";
            tbPlantColor.Size = new Size(249, 23);
            tbPlantColor.TabIndex = 5;
            // 
            // tbPlantName
            // 
            tbPlantName.Location = new Point(6, 371);
            tbPlantName.Name = "tbPlantName";
            tbPlantName.PlaceholderText = "Name";
            tbPlantName.Size = new Size(249, 23);
            tbPlantName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 353);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "New plant:";
            // 
            // btnPlantsInfo
            // 
            btnPlantsInfo.Location = new Point(138, 223);
            btnPlantsInfo.Name = "btnPlantsInfo";
            btnPlantsInfo.Size = new Size(117, 23);
            btnPlantsInfo.TabIndex = 3;
            btnPlantsInfo.Text = "Info";
            btnPlantsInfo.UseVisualStyleBackColor = true;
            btnPlantsInfo.Click += btnPlantsInfo_Click;
            // 
            // btnPlantsRemove
            // 
            btnPlantsRemove.Location = new Point(7, 223);
            btnPlantsRemove.Name = "btnPlantsRemove";
            btnPlantsRemove.Size = new Size(116, 23);
            btnPlantsRemove.TabIndex = 2;
            btnPlantsRemove.Text = "Remove";
            btnPlantsRemove.UseVisualStyleBackColor = true;
            btnPlantsRemove.Click += btnPlantsRemove_Click;
            // 
            // lbxPlants
            // 
            lbxPlants.FormattingEnabled = true;
            lbxPlants.ItemHeight = 15;
            lbxPlants.Location = new Point(7, 78);
            lbxPlants.Name = "lbxPlants";
            lbxPlants.Size = new Size(249, 139);
            lbxPlants.TabIndex = 1;
            // 
            // lblSelectedGarden
            // 
            lblSelectedGarden.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSelectedGarden.Location = new Point(6, 19);
            lblSelectedGarden.Name = "lblSelectedGarden";
            lblSelectedGarden.Size = new Size(249, 23);
            lblSelectedGarden.TabIndex = 0;
            lblSelectedGarden.Text = "lblSelectedGarden";
            lblSelectedGarden.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(285, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 671);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Gardens";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox tbGardenName;
        private Button btnRemove;
        internal ComboBox cbxGardenRemove;
        private GroupBox groupBox2;
        private Label lblSelectedGarden;
        private ListBox lbxPlants;
        private Button btnPlantsInfo;
        private Button btnPlantsRemove;
        private Label label1;
        private ComboBox cbxPlantType;
        private Label label5;
        private TextBox tbPlantColor;
        private TextBox tbPlantName;
        private Button btnPlantAdd;
        private CheckBox cbPlantEvergreen;
        private Button btnSelectPrunable;
        private ComboBox cbxSelectMonth;
        private Button btnShowAll;
        private Label lblPeakBloom;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
