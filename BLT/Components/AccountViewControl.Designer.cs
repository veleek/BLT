namespace BLT.Components
{
    partial class AccountViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.accountInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.transactionIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountGroupBox.Controls.Add(this.amountLabel);
            this.accountGroupBox.Controls.Add(this.label1);
            this.accountGroupBox.Controls.Add(this.accountInfoDataGrid);
            this.accountGroupBox.Location = new System.Drawing.Point(3, 3);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(469, 253);
            this.accountGroupBox.TabIndex = 0;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "groupBox1";
            // 
            // accountInfoDataGrid
            // 
            this.accountInfoDataGrid.AllowUserToAddRows = false;
            this.accountInfoDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.accountInfoDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accountInfoDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.accountInfoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountInfoDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.accountInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDColumn,
            this.transactionDescriptionColumn,
            this.transactionDateColumn,
            this.paymentAmountColumn});
            this.accountInfoDataGrid.Location = new System.Drawing.Point(6, 19);
            this.accountInfoDataGrid.Name = "accountInfoDataGrid";
            this.accountInfoDataGrid.ReadOnly = true;
            this.accountInfoDataGrid.RowTemplate.ReadOnly = true;
            this.accountInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountInfoDataGrid.Size = new System.Drawing.Size(457, 203);
            this.accountInfoDataGrid.TabIndex = 0;
            // 
            // transactionIDColumn
            // 
            this.transactionIDColumn.HeaderText = "Transaction ID";
            this.transactionIDColumn.Name = "transactionIDColumn";
            this.transactionIDColumn.ReadOnly = true;
            // 
            // transactionDescriptionColumn
            // 
            this.transactionDescriptionColumn.HeaderText = "Description";
            this.transactionDescriptionColumn.Name = "transactionDescriptionColumn";
            this.transactionDescriptionColumn.ReadOnly = true;
            // 
            // transactionDateColumn
            // 
            this.transactionDateColumn.HeaderText = "Date";
            this.transactionDateColumn.Name = "transactionDateColumn";
            this.transactionDateColumn.ReadOnly = true;
            // 
            // paymentAmountColumn
            // 
            this.paymentAmountColumn.HeaderText = "Amount";
            this.paymentAmountColumn.Name = "paymentAmountColumn";
            this.paymentAmountColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Amount:";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Enabled = false;
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amountLabel.Location = new System.Drawing.Point(361, 229);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(13, 13);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "0";
            // 
            // AccountViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountGroupBox);
            this.Name = "AccountViewControl";
            this.Size = new System.Drawing.Size(477, 259);
            this.accountGroupBox.ResumeLayout(false);
            this.accountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountInfoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.DataGridView accountInfoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountColumn;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label1;
    }
}
