namespace BLT
{
    partial class UserManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.userListGroupBox = new System.Windows.Forms.GroupBox();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersListbox = new System.Windows.Forms.ListBox();
            this.personManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.displayNameValue = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.resetChangesButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.idValue = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.userManagerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personManagerBindingSource)).BeginInit();
            this.userDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // userListGroupBox
            // 
            this.userListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userListGroupBox.Controls.Add(this.removeUserButton);
            this.userListGroupBox.Controls.Add(this.addUserButton);
            this.userListGroupBox.Controls.Add(this.usersListbox);
            this.userListGroupBox.Location = new System.Drawing.Point(12, 32);
            this.userListGroupBox.Name = "userListGroupBox";
            this.userListGroupBox.Size = new System.Drawing.Size(404, 161);
            this.userListGroupBox.TabIndex = 1;
            this.userListGroupBox.TabStop = false;
            this.userListGroupBox.Text = "Current Users";
            // 
            // removeUserButton
            // 
            this.removeUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeUserButton.Location = new System.Drawing.Point(310, 48);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(88, 23);
            this.removeUserButton.TabIndex = 2;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.Location = new System.Drawing.Point(310, 19);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(88, 23);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersListbox
            // 
            this.usersListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usersListbox.FormattingEnabled = true;
            this.usersListbox.Location = new System.Drawing.Point(6, 19);
            this.usersListbox.Name = "usersListbox";
            this.usersListbox.Size = new System.Drawing.Size(298, 134);
            this.usersListbox.TabIndex = 0;
            this.usersListbox.SelectedIndexChanged += new System.EventHandler(this.usersListbox_SelectedIndexChanged);
            // 
            // personManagerBindingSource
            // 
            this.personManagerBindingSource.AllowNew = true;
            this.personManagerBindingSource.DataMember = "AllPeople";
            // 
            // userDetailsGroupBox
            // 
            this.userDetailsGroupBox.AccessibleName = "";
            this.userDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.userDetailsGroupBox.Controls.Add(this.displayNameValue);
            this.userDetailsGroupBox.Controls.Add(this.lastNameTextBox);
            this.userDetailsGroupBox.Controls.Add(this.firstNameTextBox);
            this.userDetailsGroupBox.Controls.Add(this.resetChangesButton);
            this.userDetailsGroupBox.Controls.Add(this.saveChangesButton);
            this.userDetailsGroupBox.Controls.Add(this.idValue);
            this.userDetailsGroupBox.Controls.Add(this.idLabel);
            this.userDetailsGroupBox.Controls.Add(this.displayNameLabel);
            this.userDetailsGroupBox.Controls.Add(this.lastNameLabel);
            this.userDetailsGroupBox.Controls.Add(this.firstNameLabel);
            this.userDetailsGroupBox.Location = new System.Drawing.Point(12, 199);
            this.userDetailsGroupBox.Name = "userDetailsGroupBox";
            this.userDetailsGroupBox.Size = new System.Drawing.Size(398, 97);
            this.userDetailsGroupBox.TabIndex = 2;
            this.userDetailsGroupBox.TabStop = false;
            this.userDetailsGroupBox.Text = "User Details";
            // 
            // displayNameValue
            // 
            this.displayNameValue.AutoSize = true;
            this.displayNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNameValue.Location = new System.Drawing.Point(277, 22);
            this.displayNameValue.Name = "displayNameValue";
            this.displayNameValue.Size = new System.Drawing.Size(78, 13);
            this.displayNameValue.TabIndex = 15;
            this.displayNameValue.Text = "displayName";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AcceptsReturn = true;
            this.lastNameTextBox.Location = new System.Drawing.Point(73, 45);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.lastNameTextBox.TabIndex = 14;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.detailTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(73, 19);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.firstNameTextBox.TabIndex = 12;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.detailTextBox_TextChanged);
            // 
            // resetChangesButton
            // 
            this.resetChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetChangesButton.Location = new System.Drawing.Point(317, 68);
            this.resetChangesButton.Name = "resetChangesButton";
            this.resetChangesButton.Size = new System.Drawing.Size(75, 23);
            this.resetChangesButton.TabIndex = 11;
            this.resetChangesButton.Text = "Reset";
            this.resetChangesButton.UseVisualStyleBackColor = true;
            this.resetChangesButton.Click += new System.EventHandler(this.resetChangesButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.Location = new System.Drawing.Point(236, 68);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 10;
            this.saveChangesButton.Text = "Save";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // idValue
            // 
            this.idValue.AutoSize = true;
            this.idValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idValue.Location = new System.Drawing.Point(277, 48);
            this.idValue.Name = "idValue";
            this.idValue.Size = new System.Drawing.Size(49, 13);
            this.idValue.TabIndex = 9;
            this.idValue.Text = "idValue";
            this.idValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(250, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(196, 22);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(75, 13);
            this.displayNameLabel.TabIndex = 4;
            this.displayNameLabel.Text = "Display Name:";
            this.displayNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 48);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // userManagerErrorProvider
            // 
            this.userManagerErrorProvider.ContainerControl = this;
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 308);
            this.Controls.Add(this.userDetailsGroupBox);
            this.Controls.Add(this.userListGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "UserManagerForm";
            this.Text = "UserManager";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.UserManagerForm_Closing);
            this.userListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personManagerBindingSource)).EndInit();
            this.userDetailsGroupBox.ResumeLayout(false);
            this.userDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox userListGroupBox;
        private System.Windows.Forms.GroupBox userDetailsGroupBox;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox usersListbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.Label idValue;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button resetChangesButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.BindingSource personManagerBindingSource;
        private System.Windows.Forms.Label displayNameValue;
        private System.Windows.Forms.ErrorProvider userManagerErrorProvider;
    }
}