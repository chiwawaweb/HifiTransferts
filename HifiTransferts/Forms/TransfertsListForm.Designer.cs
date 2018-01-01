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
            this.dgvTransferts.AllowUserToResizeRows = false;
            this.dgvTransferts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferts.Location = new System.Drawing.Point(0, 54);
            this.dgvTransferts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTransferts.Name = "dgvTransferts";
            this.dgvTransferts.ReadOnly = true;
            this.dgvTransferts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferts.Size = new System.Drawing.Size(1220, 711);
            this.dgvTransferts.TabIndex = 0;
            // 
            // TransfertsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 765);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTransferts);
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