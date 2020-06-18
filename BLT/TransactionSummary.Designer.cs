namespace BLT
{
    partial class TransactionSummary
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
            this.transactionTable = new System.Windows.Forms.DataGridView();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionTable
            // 
            this.transactionTable.AllowUserToAddRows = false;
            this.transactionTable.AllowUserToDeleteRows = false;
            this.transactionTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionID,
            this.description,
            this.amount,
            this.date});
            this.transactionTable.Location = new System.Drawing.Point(12, 12);
            this.transactionTable.Name = "transactionTable";
            this.transactionTable.ReadOnly = true;
            this.transactionTable.Size = new System.Drawing.Size(371, 233);
            this.transactionTable.TabIndex = 0;
            // 
            // transactionID
            // 
            this.transactionID.FillWeight = 4.09936F;
            this.transactionID.HeaderText = "ID";
            this.transactionID.MinimumWidth = 20;
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            this.transactionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // description
            // 
            this.description.FillWeight = 343.1984F;
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 100;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.FillWeight = 40.60913F;
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 50;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 12.09311F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 100;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailsButton.Location = new System.Drawing.Point(12, 251);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(308, 251);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TransactionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 286);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.transactionTable);
            this.Name = "TransactionSummary";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.transactionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionTable;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;


    }
}