namespace BLT
{
    partial class AddBillForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.payeeRemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.payeeListBox = new System.Windows.Forms.ListBox();
            this.payeeAddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.debtorRemoveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.debtorListBox = new System.Windows.Forms.ListBox();
            this.debtorAddButton = new System.Windows.Forms.Button();
            this.submitBillButton = new System.Windows.Forms.Button();
            this.clearBillButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.billDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionAmountTextBox = new BLT.Components.DecimalTextBox();
            this.debtorComboBox = new BLT.Components.UserComboBox();
            this.debtorAmountTextbox = new BLT.Components.DecimalTextBox();
            this.payeeComboBox = new BLT.Components.UserComboBox();
            this.payeeAmountTextbox = new BLT.Components.DecimalTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.payeeComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.payeeRemoveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.payeeAmountTextbox);
            this.groupBox1.Controls.Add(this.payeeListBox);
            this.groupBox1.Controls.Add(this.payeeAddButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payee:";
            // 
            // payeeRemoveButton
            // 
            this.payeeRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeRemoveButton.Location = new System.Drawing.Point(201, 71);
            this.payeeRemoveButton.Name = "payeeRemoveButton";
            this.payeeRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.payeeRemoveButton.TabIndex = 8;
            this.payeeRemoveButton.Text = "Remove";
            this.payeeRemoveButton.UseVisualStyleBackColor = true;
            this.payeeRemoveButton.Click += new System.EventHandler(this.payeeRemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount ($):";
            // 
            // payeeListBox
            // 
            this.payeeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeListBox.FormattingEnabled = true;
            this.payeeListBox.Location = new System.Drawing.Point(6, 100);
            this.payeeListBox.Name = "payeeListBox";
            this.payeeListBox.Size = new System.Drawing.Size(270, 121);
            this.payeeListBox.TabIndex = 2;
            // 
            // payeeAddButton
            // 
            this.payeeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeAddButton.Location = new System.Drawing.Point(120, 71);
            this.payeeAddButton.Name = "payeeAddButton";
            this.payeeAddButton.Size = new System.Drawing.Size(75, 23);
            this.payeeAddButton.TabIndex = 1;
            this.payeeAddButton.Text = "Add";
            this.payeeAddButton.UseVisualStyleBackColor = true;
            this.payeeAddButton.Click += new System.EventHandler(this.payeeAddButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.15873F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 237);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.debtorComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.debtorRemoveButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.debtorAmountTextbox);
            this.groupBox2.Controls.Add(this.debtorListBox);
            this.groupBox2.Controls.Add(this.debtorAddButton);
            this.groupBox2.Location = new System.Drawing.Point(291, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Debtor:";
            // 
            // debtorRemoveButton
            // 
            this.debtorRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorRemoveButton.Location = new System.Drawing.Point(201, 71);
            this.debtorRemoveButton.Name = "debtorRemoveButton";
            this.debtorRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.debtorRemoveButton.TabIndex = 7;
            this.debtorRemoveButton.Text = "Remove";
            this.debtorRemoveButton.UseVisualStyleBackColor = true;
            this.debtorRemoveButton.Click += new System.EventHandler(this.debtorRemoveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount ($):";
            // 
            // debtorListBox
            // 
            this.debtorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorListBox.FormattingEnabled = true;
            this.debtorListBox.Location = new System.Drawing.Point(6, 100);
            this.debtorListBox.Name = "debtorListBox";
            this.debtorListBox.Size = new System.Drawing.Size(270, 121);
            this.debtorListBox.TabIndex = 3;
            // 
            // debtorAddButton
            // 
            this.debtorAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorAddButton.Location = new System.Drawing.Point(120, 71);
            this.debtorAddButton.Name = "debtorAddButton";
            this.debtorAddButton.Size = new System.Drawing.Size(75, 23);
            this.debtorAddButton.TabIndex = 2;
            this.debtorAddButton.Text = "Add";
            this.debtorAddButton.UseVisualStyleBackColor = true;
            this.debtorAddButton.Click += new System.EventHandler(this.debtorAddButton_Click);
            // 
            // submitBillButton
            // 
            this.submitBillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBillButton.Location = new System.Drawing.Point(351, 334);
            this.submitBillButton.Name = "submitBillButton";
            this.submitBillButton.Size = new System.Drawing.Size(75, 23);
            this.submitBillButton.TabIndex = 2;
            this.submitBillButton.Text = "Submit";
            this.submitBillButton.UseVisualStyleBackColor = true;
            this.submitBillButton.Click += new System.EventHandler(this.submitBillButton_Click);
            // 
            // clearBillButton
            // 
            this.clearBillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBillButton.Location = new System.Drawing.Point(432, 334);
            this.clearBillButton.Name = "clearBillButton";
            this.clearBillButton.Size = new System.Drawing.Size(75, 23);
            this.clearBillButton.TabIndex = 3;
            this.clearBillButton.Text = "Clear";
            this.clearBillButton.UseVisualStyleBackColor = true;
            this.clearBillButton.Click += new System.EventHandler(this.clearBillButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(513, 334);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.billDescriptionTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.billDateTimePicker);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.transactionAmountTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Details";
            // 
            // billDescriptionTextBox
            // 
            this.billDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.billDescriptionTextBox.Location = new System.Drawing.Point(72, 45);
            this.billDescriptionTextBox.Name = "billDescriptionTextBox";
            this.billDescriptionTextBox.Size = new System.Drawing.Size(495, 20);
            this.billDescriptionTextBox.TabIndex = 5;
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
            // billDateTimePicker
            // 
            this.billDateTimePicker.Location = new System.Drawing.Point(45, 19);
            this.billDateTimePicker.Name = "billDateTimePicker";
            this.billDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.billDateTimePicker.TabIndex = 3;
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
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAmountTextBox.Location = new System.Drawing.Point(345, 19);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(222, 20);
            this.transactionAmountTextBox.TabIndex = 1;
            this.transactionAmountTextBox.Text = "0";
            // 
            // debtorComboBox
            // 
            this.debtorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.debtorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.debtorComboBox.Location = new System.Drawing.Point(73, 19);
            this.debtorComboBox.Name = "debtorComboBox";
            this.debtorComboBox.Size = new System.Drawing.Size(203, 21);
            this.debtorComboBox.Sorted = true;
            this.debtorComboBox.TabIndex = 12;
            // 
            // debtorAmountTextbox
            // 
            this.debtorAmountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debtorAmountTextbox.Location = new System.Drawing.Point(73, 45);
            this.debtorAmountTextbox.Name = "debtorAmountTextbox";
            this.debtorAmountTextbox.Size = new System.Drawing.Size(203, 20);
            this.debtorAmountTextbox.TabIndex = 5;
            this.debtorAmountTextbox.Text = "0";
            // 
            // payeeComboBox
            // 
            this.payeeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.payeeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.payeeComboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.payeeComboBox.Location = new System.Drawing.Point(73, 19);
            this.payeeComboBox.Name = "payeeComboBox";
            this.payeeComboBox.Size = new System.Drawing.Size(203, 21);
            this.payeeComboBox.Sorted = true;
            this.payeeComboBox.TabIndex = 10;
            // 
            // payeeAmountTextbox
            // 
            this.payeeAmountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeAmountTextbox.Location = new System.Drawing.Point(73, 45);
            this.payeeAmountTextbox.Name = "payeeAmountTextbox";
            this.payeeAmountTextbox.Size = new System.Drawing.Size(203, 20);
            this.payeeAmountTextbox.TabIndex = 5;
            this.payeeAmountTextbox.Text = "0";
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearBillButton);
            this.Controls.Add(this.submitBillButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddBillForm";
            this.Text = "AddBillForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submitBillButton;
        private System.Windows.Forms.Button clearBillButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox payeeListBox;
        private System.Windows.Forms.Button payeeAddButton;
        private System.Windows.Forms.ListBox debtorListBox;
        private System.Windows.Forms.Button debtorAddButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker billDateTimePicker;
        private System.Windows.Forms.Label label2;
        private Components.DecimalTextBox transactionAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billDescriptionTextBox;
        private System.Windows.Forms.Button payeeRemoveButton;
        private System.Windows.Forms.Label label4;
        private Components.DecimalTextBox payeeAmountTextbox;
        private System.Windows.Forms.Button debtorRemoveButton;
        private System.Windows.Forms.Label label5;
        private Components.DecimalTextBox debtorAmountTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Components.UserComboBox payeeComboBox;
        private Components.UserComboBox debtorComboBox;
    }
}