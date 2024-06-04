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
            btnGardenSelect = new Button();
            groupBox1.SuspendLayout();
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 909);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Gardens";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox tbGardenName;
        private Button btnRemove;
        internal ComboBox cbxGardenRemove;
        private Button btnGardenSelect;
    }
}
