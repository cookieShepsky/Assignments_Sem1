
namespace Bakery
{
    partial class AddForm
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
            label1 = new System.Windows.Forms.Label();
            cbbBreadFilter = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tbxName = new System.Windows.Forms.TextBox();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            nudBasePrice = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudBasePrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            label1.Location = new System.Drawing.Point(12, 36);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Bread:";
            // 
            // cbbBreadFilter
            // 
            cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbBreadFilter.FormattingEnabled = true;
            cbbBreadFilter.Location = new System.Drawing.Point(87, 33);
            cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            cbbBreadFilter.Name = "cbbBreadFilter";
            cbbBreadFilter.Size = new System.Drawing.Size(332, 23);
            cbbBreadFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            label2.Location = new System.Drawing.Point(11, 89);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingredients:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 502);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(408, 22);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Sandwich";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            label3.Location = new System.Drawing.Point(11, 10);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new System.Drawing.Point(87, 9);
            tbxName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            tbxName.Name = "tbxName";
            tbxName.Size = new System.Drawing.Size(332, 23);
            tbxName.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new System.Drawing.Point(87, 89);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(332, 400);
            checkedListBox1.TabIndex = 13;
            // 
            // nudBasePrice
            // 
            nudBasePrice.DecimalPlaces = 2;
            nudBasePrice.Location = new System.Drawing.Point(87, 60);
            nudBasePrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudBasePrice.Name = "nudBasePrice";
            nudBasePrice.Size = new System.Drawing.Size(332, 23);
            nudBasePrice.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            label4.Location = new System.Drawing.Point(12, 62);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Base price:";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(431, 534);
            Controls.Add(nudBasePrice);
            Controls.Add(checkedListBox1);
            Controls.Add(tbxName);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cbbBreadFilter);
            Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Name = "AddForm";
            Text = "Add New Sandwich";
            ((System.ComponentModel.ISupportInitialize)nudBasePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.NumericUpDown nudBasePrice;
        private System.Windows.Forms.Label label4;
    }
}

