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
            btnPlantsInfo = new Button();
            btnPlantsRemove = new Button();
            lbxPlants = new ListBox();
            lblSelectedGarden = new Label();
            label1 = new Label();
            tbPlantName = new TextBox();
            tbPlantColor = new TextBox();
            label5 = new Label();
            cbxPlantType = new ComboBox();
            cbPlantEvergreen = new CheckBox();
            btnPlantAdd = new Button();
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
            btnGardenSelect.Size = new Size(118, 23);
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
            groupBox2.Location = new Point(12, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 464);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage Plants";
            // 
            // btnPlantsInfo
            // 
            btnPlantsInfo.Location = new Point(138, 190);
            btnPlantsInfo.Name = "btnPlantsInfo";
            btnPlantsInfo.Size = new Size(117, 23);
            btnPlantsInfo.TabIndex = 3;
            btnPlantsInfo.Text = "Info";
            btnPlantsInfo.UseVisualStyleBackColor = true;
            btnPlantsInfo.Click += btnPlantsInfo_Click;
            // 
            // btnPlantsRemove
            // 
            btnPlantsRemove.Location = new Point(7, 190);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 230);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "New plant:";
            // 
            // tbPlantName
            // 
            tbPlantName.Location = new Point(7, 248);
            tbPlantName.Name = "tbPlantName";
            tbPlantName.PlaceholderText = "Name";
            tbPlantName.Size = new Size(249, 23);
            tbPlantName.TabIndex = 5;
            // 
            // tbPlantColor
            // 
            tbPlantColor.Location = new Point(6, 277);
            tbPlantColor.Name = "tbPlantColor";
            tbPlantColor.PlaceholderText = "Color";
            tbPlantColor.Size = new Size(249, 23);
            tbPlantColor.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 309);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 6;
            label5.Text = "Type:";
            // 
            // cbxPlantType
            // 
            cbxPlantType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPlantType.FormattingEnabled = true;
            cbxPlantType.Location = new Point(47, 306);
            cbxPlantType.Name = "cbxPlantType";
            cbxPlantType.Size = new Size(208, 23);
            cbxPlantType.TabIndex = 7;
            // 
            // cbPlantEvergreen
            // 
            cbPlantEvergreen.AutoSize = true;
            cbPlantEvergreen.Location = new Point(7, 335);
            cbPlantEvergreen.Name = "cbPlantEvergreen";
            cbPlantEvergreen.Size = new Size(78, 19);
            cbPlantEvergreen.TabIndex = 8;
            cbPlantEvergreen.Text = "Evergreen";
            cbPlantEvergreen.UseVisualStyleBackColor = true;
            // 
            // btnPlantAdd
            // 
            btnPlantAdd.Location = new Point(138, 332);
            btnPlantAdd.Name = "btnPlantAdd";
            btnPlantAdd.Size = new Size(117, 23);
            btnPlantAdd.TabIndex = 9;
            btnPlantAdd.Text = "Add";
            btnPlantAdd.UseVisualStyleBackColor = true;
            btnPlantAdd.Click += btnPlantAdd_Click;
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
            groupBox2.PerformLayout();
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
        private Label label1;
        private ComboBox cbxPlantType;
        private Label label5;
        private TextBox tbPlantColor;
        private TextBox tbPlantName;
        private Button btnPlantAdd;
        private CheckBox cbPlantEvergreen;
    }
}
