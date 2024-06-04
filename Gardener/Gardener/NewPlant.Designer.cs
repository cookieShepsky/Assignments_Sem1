namespace Gardener
{
    partial class NewPlant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblColor = new Label();
            lblType = new Label();
            lblEvergreen = new Label();
            groupBox1 = new GroupBox();
            btnBloomAdd = new Button();
            lbxBloom = new ListBox();
            label2 = new Label();
            label1 = new Label();
            cbxBloomEnd = new ComboBox();
            cbxBloomStart = new ComboBox();
            groupBox2 = new GroupBox();
            btnPruneAdd = new Button();
            lbxPrune = new ListBox();
            label3 = new Label();
            label4 = new Label();
            cbxPruneEnd = new ComboBox();
            cbxPruneStart = new ComboBox();
            btnFinish = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 0;
            lblName.Text = "lblName";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(12, 24);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(49, 15);
            lblColor.TabIndex = 0;
            lblColor.Text = "lblColor";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 39);
            lblType.Name = "lblType";
            lblType.Size = new Size(44, 15);
            lblType.TabIndex = 0;
            lblType.Text = "lblType";
            // 
            // lblEvergreen
            // 
            lblEvergreen.AutoSize = true;
            lblEvergreen.Location = new Point(12, 54);
            lblEvergreen.Name = "lblEvergreen";
            lblEvergreen.Size = new Size(72, 15);
            lblEvergreen.TabIndex = 0;
            lblEvergreen.Text = "lblEvergreen";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBloomAdd);
            groupBox1.Controls.Add(lbxBloom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxBloomEnd);
            groupBox1.Controls.Add(cbxBloomStart);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bloom Periods";
            // 
            // btnBloomAdd
            // 
            btnBloomAdd.Location = new Point(12, 72);
            btnBloomAdd.Name = "btnBloomAdd";
            btnBloomAdd.Size = new Size(247, 23);
            btnBloomAdd.TabIndex = 4;
            btnBloomAdd.Text = "Add";
            btnBloomAdd.UseVisualStyleBackColor = true;
            btnBloomAdd.Click += btnBloomAdd_Click;
            // 
            // lbxBloom
            // 
            lbxBloom.FormattingEnabled = true;
            lbxBloom.ItemHeight = 15;
            lbxBloom.Location = new Point(12, 101);
            lbxBloom.Name = "lbxBloom";
            lbxBloom.Size = new Size(247, 64);
            lbxBloom.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 25);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "End";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Start";
            // 
            // cbxBloomEnd
            // 
            cbxBloomEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBloomEnd.FormattingEnabled = true;
            cbxBloomEnd.Location = new Point(139, 43);
            cbxBloomEnd.Name = "cbxBloomEnd";
            cbxBloomEnd.Size = new Size(121, 23);
            cbxBloomEnd.TabIndex = 0;
            // 
            // cbxBloomStart
            // 
            cbxBloomStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBloomStart.FormattingEnabled = true;
            cbxBloomStart.Location = new Point(12, 43);
            cbxBloomStart.Name = "cbxBloomStart";
            cbxBloomStart.Size = new Size(121, 23);
            cbxBloomStart.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPruneAdd);
            groupBox2.Controls.Add(lbxPrune);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbxPruneEnd);
            groupBox2.Controls.Add(cbxPruneStart);
            groupBox2.Location = new Point(12, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 178);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pruning Periods";
            // 
            // btnPruneAdd
            // 
            btnPruneAdd.Location = new Point(12, 72);
            btnPruneAdd.Name = "btnPruneAdd";
            btnPruneAdd.Size = new Size(247, 23);
            btnPruneAdd.TabIndex = 4;
            btnPruneAdd.Text = "Add";
            btnPruneAdd.UseVisualStyleBackColor = true;
            btnPruneAdd.Click += btnPruneAdd_Click;
            // 
            // lbxPrune
            // 
            lbxPrune.FormattingEnabled = true;
            lbxPrune.ItemHeight = 15;
            lbxPrune.Location = new Point(12, 101);
            lbxPrune.Name = "lbxPrune";
            lbxPrune.Size = new Size(247, 64);
            lbxPrune.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 25);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 25);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "Start";
            // 
            // cbxPruneEnd
            // 
            cbxPruneEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPruneEnd.FormattingEnabled = true;
            cbxPruneEnd.Location = new Point(139, 43);
            cbxPruneEnd.Name = "cbxPruneEnd";
            cbxPruneEnd.Size = new Size(121, 23);
            cbxPruneEnd.TabIndex = 0;
            // 
            // cbxPruneStart
            // 
            cbxPruneStart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPruneStart.FormattingEnabled = true;
            cbxPruneStart.Location = new Point(12, 43);
            cbxPruneStart.Name = "cbxPruneStart";
            cbxPruneStart.Size = new Size(121, 23);
            cbxPruneStart.TabIndex = 0;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(12, 454);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(274, 23);
            btnFinish.TabIndex = 2;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // NewPlant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 484);
            Controls.Add(btnFinish);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblEvergreen);
            Controls.Add(lblType);
            Controls.Add(lblColor);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewPlant";
            Text = "NewPlant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblColor;
        private Label lblType;
        private Label lblEvergreen;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbxBloomEnd;
        private ComboBox cbxBloomStart;
        private Button btnBloomAdd;
        private ListBox lbxBloom;
        private GroupBox groupBox2;
        private Button btnPruneAdd;
        private ListBox lbxPrune;
        private Label label3;
        private Label label4;
        private ComboBox cbxPruneEnd;
        private ComboBox cbxPruneStart;
        private Button btnFinish;
    }
}