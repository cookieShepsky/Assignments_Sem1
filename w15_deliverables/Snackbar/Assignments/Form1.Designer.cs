namespace Assignments
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
            btnAdd = new Button();
            combxSnacks = new ComboBox();
            numAmount = new NumericUpDown();
            lbxCart = new ListBox();
            label2 = new Label();
            btnCheckout = new Button();
            btnCancel = new Button();
            btnRevenue = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            cbNew = new CheckBox();
            tbPrice = new TextBox();
            tbStock = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnAddStock = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(combxSnacks);
            groupBox1.Controls.Add(numAmount);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(282, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add to Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // combxSnacks
            // 
            combxSnacks.FormattingEnabled = true;
            combxSnacks.Location = new Point(6, 22);
            combxSnacks.Name = "combxSnacks";
            combxSnacks.Size = new Size(204, 23);
            combxSnacks.TabIndex = 1;
            combxSnacks.SelectedIndexChanged += combxSnacks_SelectedIndexChanged;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(216, 22);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(46, 23);
            numAmount.TabIndex = 2;
            // 
            // lbxCart
            // 
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 15;
            lbxCart.Location = new Point(6, 108);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(413, 229);
            lbxCart.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "Cart";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(346, 343);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(73, 23);
            btnCheckout.TabIndex = 6;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(248, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.Location = new Point(248, 372);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Size = new Size(171, 23);
            btnRevenue.TabIndex = 7;
            btnRevenue.Text = "Revenue";
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(442, 432);
            tabControl1.TabIndex = 9;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRevenue);
            tabPage1.Controls.Add(btnCancel);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnCheckout);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(lbxCart);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(434, 404);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Order";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(434, 404);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stock";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbNew);
            groupBox2.Controls.Add(tbPrice);
            groupBox2.Controls.Add(tbStock);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnAddStock);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 193);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Stock";
            // 
            // cbNew
            // 
            cbNew.AutoSize = true;
            cbNew.Location = new Point(17, 163);
            cbNew.Name = "cbNew";
            cbNew.Size = new Size(95, 19);
            cbNew.TabIndex = 12;
            cbNew.Text = "New Product";
            cbNew.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(310, 85);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "e.g. \"1.80\"";
            tbPrice.Size = new Size(100, 23);
            tbPrice.TabIndex = 10;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(310, 46);
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "e.g. \"20\"";
            tbStock.Size = new Size(100, 23);
            tbStock.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(310, 15);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "e.g. \"Frikandel\"";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 8;
            // 
            // label6
            // 
            label6.Location = new Point(17, 79);
            label6.Name = "label6";
            label6.Size = new Size(287, 61);
            label6.TabIndex = 5;
            label6.Text = "Price in euro\r\n(leave empty if you do not want to change the price):";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 49);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 5;
            label4.Text = "Stock to add:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 18);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 5;
            label1.Text = "Product name:";
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(310, 159);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(100, 23);
            btnAddStock.TabIndex = 11;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 427);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Snackbar";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private ListBox lbxCart;
        private Label label2;
        private Button btnCheckout;
        private Button btnCancel;
        private Button btnRevenue;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button btnAddStock;
        private ComboBox combxSnacks;
        private NumericUpDown numAmount;
        private Label label1;
        private Label label6;
        private Label label4;
        private TextBox tbPrice;
        private TextBox tbStock;
        private TextBox tbName;
        private CheckBox cbNew;
    }
}
