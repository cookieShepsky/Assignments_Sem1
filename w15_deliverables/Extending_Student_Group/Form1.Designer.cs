namespace _1._2_Extending_Student_Group
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            cbxGroup = new ComboBox();
            btnAdd = new Button();
            tbNumber = new TextBox();
            tbName = new TextBox();
            lb = new ListBox();
            cbxShowGroup = new ComboBox();
            btnShow = new Button();
            btnRemove = new Button();
            btnChangeGroupName = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxGroup);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Member";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 83);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Project Group";
            // 
            // cbxGroup
            // 
            cbxGroup.FormattingEnabled = true;
            cbxGroup.Location = new Point(92, 80);
            cbxGroup.Name = "cbxGroup";
            cbxGroup.Size = new Size(157, 23);
            cbxGroup.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(92, 139);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(6, 51);
            tbNumber.Name = "tbNumber";
            tbNumber.PlaceholderText = "Student No. (Optional)";
            tbNumber.Size = new Size(243, 23);
            tbNumber.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(6, 22);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Student Name";
            tbName.Size = new Size(243, 23);
            tbName.TabIndex = 0;
            // 
            // lb
            // 
            lb.FormattingEnabled = true;
            lb.ItemHeight = 15;
            lb.Location = new Point(273, 21);
            lb.Name = "lb";
            lb.Size = new Size(335, 94);
            lb.TabIndex = 4;
            // 
            // cbxShowGroup
            // 
            cbxShowGroup.FormattingEnabled = true;
            cbxShowGroup.Location = new Point(273, 122);
            cbxShowGroup.Name = "cbxShowGroup";
            cbxShowGroup.Size = new Size(335, 23);
            cbxShowGroup.TabIndex = 5;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(444, 151);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(164, 23);
            btnShow.TabIndex = 7;
            btnShow.Text = "Show Members";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(273, 151);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(164, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove Member";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnChangeGroupName
            // 
            btnChangeGroupName.Location = new Point(273, 180);
            btnChangeGroupName.Name = "btnChangeGroupName";
            btnChangeGroupName.Size = new Size(335, 23);
            btnChangeGroupName.TabIndex = 8;
            btnChangeGroupName.Text = "Change group name";
            btnChangeGroupName.UseVisualStyleBackColor = true;
            btnChangeGroupName.Click += btnChangeGroupName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 213);
            Controls.Add(btnChangeGroupName);
            Controls.Add(btnRemove);
            Controls.Add(btnShow);
            Controls.Add(cbxShowGroup);
            Controls.Add(lb);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Project Groups";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbName;
        private Label label1;
        private ComboBox cbxGroup;
        private Button btnAdd;
        private ListBox lb;
        private ComboBox cbxShowGroup;
        private Button btnShow;
        private TextBox tbNumber;
        private Button btnRemove;
        private Button btnChangeGroupName;
    }
}
