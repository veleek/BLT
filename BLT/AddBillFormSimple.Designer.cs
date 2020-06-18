namespace BLT
{
    partial class AddBillFormSimple
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
            this.transactionDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.payerComboBox = new BLT.Components.UserComboBox();
            this.payerLabel = new System.Windows.Forms.Label();
            this.debitsGroupBox = new System.Windows.Forms.GroupBox();
            this.debtorComboBox = new BLT.Components.UserComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.debtorsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitBillButton = new System.Windows.Forms.Button();
            this.amountTextBox = new BLT.Components.DecimalTextBox();
            this.transactionDetailGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.debitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionDetailGroupBox
            // 
            this.transactionDetailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDetailGroupBox.Controls.Add(this.amountTextBox);
            this.transactionDetailGroupBox.Controls.Add(this.descriptionTextbox);
            this.transactionDetailGroupBox.Controls.Add(this.label3);
            this.transactionDetailGroupBox.Controls.Add(this.transactionDatePicker);
            this.transactionDetailGroupBox.Controls.Add(this.label2);
            this.transactionDetailGroupBox.Controls.Add(this.label1);
            this.transactionDetailGroupBox.Location = new System.Drawing.Point(12, 12);
            this.transactionDetailGroupBox.Name = "transactionDetailGroupBox";
            this.transactionDetailGroupBox.Size = new System.Drawing.Size(473, 73);
            this.transactionDetailGroupBox.TabIndex = 6;
            this.transactionDetailGroupBox.TabStop = false;
            this.transactionDetailGroupBox.Text = "Transaction Details";
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextbox.Location = new System.Drawing.Point(72, 45);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(395, 20);
            this.descriptionTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Amount ($):";
            // 
            // transactionDatePicker
            // 
            this.transactionDatePicker.Location = new System.Drawing.Point(45, 19);
            this.transactionDatePicker.Name = "transactionDatePicker";
            this.transactionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.transactionDatePicker.TabIndex = 3;
            this.transactionDatePicker.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentGroupBox.Controls.Add(this.payerComboBox);
            this.paymentGroupBox.Controls.Add(this.payerLabel);
            this.paymentGroupBox.Location = new System.Drawing.Point(12, 91);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(473, 45);
            this.paymentGroupBox.TabIndex = 7;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payments";
            // 
            // payerComboBox
            // 
            this.payerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.payerComboBox.FormattingEnabled = true;
            this.payerComboBox.Location = new System.Drawing.Point(45, 19);
            this.payerComboBox.Name = "payerComboBox";
            this.payerComboBox.Size = new System.Drawing.Size(422, 21);
            this.payerComboBox.TabIndex = 1;
            // 
            // payerLabel
            // 
            this.payerLabel.AutoSize = true;
            this.payerLabel.Location = new System.Drawing.Point(6, 22);
            this.payerLabel.Name = "payerLabel";
            this.payerLabel.Size = new System.Drawing.Size(37, 13);
            this.payerLabel.TabIndex = 0;
            this.payerLabel.Text = "Payer:";
            // 
            // debitsGroupBox
            // 
            this.debitsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debitsGroupBox.Controls.Add(this.debtorComboBox);
            this.debitsGroupBox.Controls.Add(this.removeButton);
            this.debitsGroupBox.Controls.Add(this.addButton);
            this.debitsGroupBox.Controls.Add(this.debtorsListBox);
            this.debitsGroupBox.Controls.Add(this.label5);
            this.debitsGroupBox.Location = new System.Drawing.Point(12, 142);
            this.debitsGroupBox.Name = "debitsGroupBox";
            this.debitsGroupBox.Size = new System.Drawing.Size(473, 204);
            this.debitsGroupBox.TabIndex = 8;
            this.debitsGroupBox.TabStop = false;
            this.debitsGroupBox.Text = "Debits";
            // 
            // debtorComboBox
            // 
            this.debtorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorComboBox.FormattingEnabled = true;
            this.debtorComboBox.Location = new System.Drawing.Point(57, 19);
            this.debtorComboBox.Name = "debtorComboBox";
            this.debtorComboBox.Size = new System.Drawing.Size(410, 21);
            this.debtorComboBox.TabIndex = 7;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(392, 45);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(311, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // debtorsListBox
            // 
            this.debtorsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorsListBox.FormattingEnabled = true;
            this.debtorsListBox.Location = new System.Drawing.Point(6, 74);
            this.debtorsListBox.Name = "debtorsListBox";
            this.debtorsListBox.Size = new System.Drawing.Size(461, 121);
            this.debtorsListBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Debtor:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(410, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(329, 352);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitBillButton
            // 
            this.submitBillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBillButton.Location = new System.Drawing.Point(248, 352);
            this.submitBillButton.Name = "submitBillButton";
            this.submitBillButton.Size = new System.Drawing.Size(75, 23);
            this.submitBillButton.TabIndex = 9;
            this.submitBillButton.Text = "Submit";
            this.submitBillButton.UseVisualStyleBackColor = true;
            this.submitBillButton.Click += new System.EventHandler(this.submitBillButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Location = new System.Drawing.Point(345, 19);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(122, 20);
            this.amountTextBox.TabIndex = 6;
            // 
            // AddBillFormSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 387);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitBillButton);
            this.Controls.Add(this.debitsGroupBox);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.transactionDetailGroupBox);
            this.Name = "AddBillFormSimple";
            this.Text = "AddBillFormSimple";
            this.Load += new System.EventHandler(this.AddBillFormSimple_Load);
            this.transactionDetailGroupBox.ResumeLayout(false);
            this.transactionDetailGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.debitsGroupBox.ResumeLayout(false);
            this.debitsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transactionDetailGroupBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker transactionDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.GroupBox debitsGroupBox;
        private System.Windows.Forms.Label payerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox debtorsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private BLT.Components.UserComboBox payerComboBox;
        private BLT.Components.UserComboBox debtorComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitBillButton;
        private BLT.Components.DecimalTextBox amountTextBox;

    }
}