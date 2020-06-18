namespace BLT
{
    partial class BLTMain
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
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.addBillButton = new System.Windows.Forms.Button();
            this.viewBillsButton = new System.Windows.Forms.Button();
            this.viewAccountsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Location = new System.Drawing.Point(12, 12);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(126, 48);
            this.manageUsersButton.TabIndex = 1;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // addBillButton
            // 
            this.addBillButton.Location = new System.Drawing.Point(12, 63);
            this.addBillButton.Name = "addBillButton";
            this.addBillButton.Size = new System.Drawing.Size(126, 48);
            this.addBillButton.TabIndex = 2;
            this.addBillButton.Text = "Add Bill";
            this.addBillButton.UseVisualStyleBackColor = true;
            this.addBillButton.Click += new System.EventHandler(this.addBillButton_Click);
            // 
            // viewBillsButton
            // 
            this.viewBillsButton.Location = new System.Drawing.Point(12, 114);
            this.viewBillsButton.Name = "viewBillsButton";
            this.viewBillsButton.Size = new System.Drawing.Size(126, 48);
            this.viewBillsButton.TabIndex = 3;
            this.viewBillsButton.Text = "View Bills";
            this.viewBillsButton.UseVisualStyleBackColor = true;
            this.viewBillsButton.Click += new System.EventHandler(this.viewBillsButton_Click);
            // 
            // viewAccountsButton
            // 
            this.viewAccountsButton.Location = new System.Drawing.Point(12, 165);
            this.viewAccountsButton.Name = "viewAccountsButton";
            this.viewAccountsButton.Size = new System.Drawing.Size(126, 48);
            this.viewAccountsButton.TabIndex = 4;
            this.viewAccountsButton.Text = "View Accounts";
            this.viewAccountsButton.UseVisualStyleBackColor = true;
            this.viewAccountsButton.Click += new System.EventHandler(this.viewAccountsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BLT.Properties.Resources.Logo1;
            this.pictureBox1.InitialImage = global::BLT.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BLTMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 255);
            this.Controls.Add(this.viewAccountsButton);
            this.Controls.Add(this.viewBillsButton);
            this.Controls.Add(this.addBillButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BLTMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button addBillButton;
        private System.Windows.Forms.Button viewBillsButton;
        private System.Windows.Forms.Button viewAccountsButton;
    }
}

