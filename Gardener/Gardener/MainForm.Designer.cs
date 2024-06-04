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
            btnGardenSelect = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            tbGardenName = new TextBox();
            groupBox2 = new GroupBox();
            lbxPlants = new ListBox();
            lblSelectedGarden = new Label();
            btnPlantsRemove = new Button();
            btnPlantsInfo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxGardenRemove);
            groupBox1.Controls.Add(btnGardenSelect);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbGardenName);
            groupBox1.Location = new Point(12, 12);
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
            // 
            // btnGardenSelect
            // 
            btnGardenSelect.Location = new Point(138, 80);
            btnGardenSelect.Name = "btnGardenSelect";
            btnGardenSelect.Size = new Size(117, 23);
            btnGardenSelect.TabIndex = 1;
            btnGardenSelect.Text = "Select";
            btnGardenSelect.UseVisualStyleBackColor = true;
            btnGardenSelect.Click += btnGardenSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(6, 80);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(117, 23);
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
            groupBox2.Controls.Add(btnPlantsInfo);
            groupBox2.Controls.Add(btnPlantsRemove);
            groupBox2.Controls.Add(lbxPlants);
            groupBox2.Controls.Add(lblSelectedGarden);
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 464);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mange Plants";
            // 
            // lbxPlants
            // 
            lbxPlants.FormattingEnabled = true;
            lbxPlants.ItemHeight = 15;
            lbxPlants.Location = new Point(7, 45);
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
            // btnPlantsRemove
            // 
            btnPlantsRemove.Location = new Point(7, 190);
            btnPlantsRemove.Name = "btnPlantsRemove";
            btnPlantsRemove.Size = new Size(116, 23);
            btnPlantsRemove.TabIndex = 2;
            btnPlantsRemove.Text = "Remove";
            btnPlantsRemove.UseVisualStyleBackColor = true;
            // 
            // btnPlantsInfo
            // 
            btnPlantsInfo.Location = new Point(138, 190);
            btnPlantsInfo.Name = "btnPlantsInfo";
            btnPlantsInfo.Size = new Size(117, 23);
            btnPlantsInfo.TabIndex = 3;
            btnPlantsInfo.Text = "Info";
            btnPlantsInfo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 909);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Gardens";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox tbGardenName;
        private Button btnRemove;
        internal ComboBox cbxGardenRemove;
        private Button btnGardenSelect;
        private GroupBox groupBox2;
        private Label lblSelectedGarden;
        private ListBox lbxPlants;
        private Button btnPlantsInfo;
        private Button btnPlantsRemove;
    }
}
