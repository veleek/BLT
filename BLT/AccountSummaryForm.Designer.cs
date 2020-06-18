namespace BLT
{
    partial class AccountSummaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userComboBox1 = new BLT.Components.UserComboBox();
            this.accountViewControl1 = new BLT.Components.AccountViewControl();
            this.refreshGridButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // userComboBox1
            // 
            this.userComboBox1.FormattingEnabled = true;
            this.userComboBox1.Location = new System.Drawing.Point(50, 6);
            this.userComboBox1.Name = "userComboBox1";
            this.userComboBox1.Size = new System.Drawing.Size(121, 21);
            this.userComboBox1.TabIndex = 1;
            this.userComboBox1.SelectedIndexChanged += new System.EventHandler(this.userComboBox1_SelectedIndexChanged);
            // 
            // accountViewControl1
            // 
            this.accountViewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountViewControl1.Location = new System.Drawing.Point(12, 25);
            this.accountViewControl1.Name = "accountViewControl1";
            this.accountViewControl1.Size = new System.Drawing.Size(466, 272);
            this.accountViewControl1.TabIndex = 2;
            this.accountViewControl1.User = null;
            // 
            // refreshGridButton
            // 
            this.refreshGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshGridButton.Location = new System.Drawing.Point(391, 4);
            this.refreshGridButton.Name = "refreshGridButton";
            this.refreshGridButton.Size = new System.Drawing.Size(82, 23);
            this.refreshGridButton.TabIndex = 3;
            this.refreshGridButton.Text = "Refresh Table";
            this.refreshGridButton.UseVisualStyleBackColor = true;
            // 
            // AccountSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 309);
            this.Controls.Add(this.refreshGridButton);
            this.Controls.Add(this.accountViewControl1);
            this.Controls.Add(this.userComboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AccountSummaryForm";
            this.Text = "AccountSummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BLT.Components.UserComboBox userComboBox1;
        private BLT.Components.AccountViewControl accountViewControl1;
        private System.Windows.Forms.Button refreshGridButton;
    }
}