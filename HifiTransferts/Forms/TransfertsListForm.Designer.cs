namespace HifiTransferts.Forms
{
    partial class TransfertsListForm
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
            this.dgvTransferts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferts
            // 
            this.dgvTransferts.AllowUserToAddRows = false;
            this.dgvTransferts.AllowUserToDeleteRows = false;
            this.dgvTransferts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferts.Location = new System.Drawing.Point(0, 35);
            this.dgvTransferts.Name = "dgvTransferts";
            this.dgvTransferts.ReadOnly = true;
            this.dgvTransferts.Size = new System.Drawing.Size(813, 462);
            this.dgvTransferts.TabIndex = 0;
            // 
            // TransfertsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 497);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTransferts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfertsListForm";
            this.Text = "TransfertsListForm";
            this.Load += new System.EventHandler(this.TransfertsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransferts;
    }
}