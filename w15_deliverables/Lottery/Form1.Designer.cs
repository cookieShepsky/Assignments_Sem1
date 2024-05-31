namespace _1._3_Lottery
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
            btnCreate = new Button();
            numWanted = new NumericUpDown();
            numMax = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            btnNext = new Button();
            btnAll = new Button();
            listBox = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWanted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(numWanted);
            groupBox1.Controls.Add(numMax);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery settings";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(6, 89);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(261, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create lottery object";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // numWanted
            // 
            numWanted.Location = new Point(147, 60);
            numWanted.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numWanted.Name = "numWanted";
            numWanted.Size = new Size(120, 23);
            numWanted.TabIndex = 1;
            numWanted.ThousandsSeparator = true;
            // 
            // numMax
            // 
            numMax.Location = new Point(147, 30);
            numMax.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMax.Name = "numMax";
            numMax.Size = new Size(120, 23);
            numMax.TabIndex = 1;
            numMax.ThousandsSeparator = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 0;
            label3.Text = "No. of wanted numbers:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Max. value:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.Location = new Point(18, 137);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(261, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Draw next number";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAll
            // 
            btnAll.Enabled = false;
            btnAll.Location = new Point(18, 166);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(261, 23);
            btnAll.TabIndex = 2;
            btnAll.Text = "Draw all numbers";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(292, 20);
            listBox.Name = "listBox";
            listBox.Size = new Size(120, 169);
            listBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 200);
            Controls.Add(listBox);
            Controls.Add(btnAll);
            Controls.Add(btnNext);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Lottery";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWanted).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnCreate;
        private NumericUpDown numWanted;
        private NumericUpDown numMax;
        private Label label3;
        private Button btnNext;
        private Button btnAll;
        private ListBox listBox;
    }
}
