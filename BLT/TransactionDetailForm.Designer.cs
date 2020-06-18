namespace BLT
{
    partial class TransactionDetailForm
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
            this.transactionDetailView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionValue = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionDetailView
            // 
            this.transactionDetailView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDetailView.Location = new System.Drawing.Point(12, 52);
            this.transactionDetailView.Name = "transactionDetailView";
            this.transactionDetailView.Size = new System.Drawing.Size(389, 257);
            this.transactionDetailView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(326, 315);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(12, 28);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(62, 13);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Detail Filter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // descriptionValue
            // 
            this.descriptionValue.AutoSize = true;
            this.descriptionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionValue.Location = new System.Drawing.Point(77, 9);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(101, 13);
            this.descriptionValue.TabIndex = 5;
            this.descriptionValue.Text = "descriptionValue";
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateValue.Location = new System.Drawing.Point(274, 9);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(64, 13);
            this.dateValue.TabIndex = 7;
            this.dateValue.Text = "dateValue";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(235, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date:";
            // 
            // TransactionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 350);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.transactionDetailView);
            this.Name = "TransactionDetailForm";
            this.Text = "BillDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionDetailView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionValue;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label dateLabel;
    }
}