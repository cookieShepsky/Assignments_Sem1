namespace _1._2_Extending_Student_Group
{
    partial class ChangeGroupNameForm
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
            tbNewName = new TextBox();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // tbNewName
            // 
            tbNewName.Location = new Point(12, 12);
            tbNewName.Name = "tbNewName";
            tbNewName.PlaceholderText = "New group name";
            tbNewName.Size = new Size(261, 23);
            tbNewName.TabIndex = 0;
            tbNewName.Text = "NewGroup";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(12, 41);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(261, 23);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // ChangeGroupNameForm
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 76);
            Controls.Add(btnAccept);
            Controls.Add(tbNewName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChangeGroupNameForm";
            Text = "ChangeGroupNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNewName;
        private Button btnAccept;
    }
}