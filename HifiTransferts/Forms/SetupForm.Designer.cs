namespace HifiTransferts.Forms
{
    partial class SetupForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TapAgence = new System.Windows.Forms.TabPage();
            this.TapEmail = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TapAgence);
            this.TabControl.Controls.Add(this.TapEmail);
            this.TabControl.Location = new System.Drawing.Point(24, 23);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(450, 336);
            this.TabControl.TabIndex = 0;
            // 
            // TapAgence
            // 
            this.TapAgence.Location = new System.Drawing.Point(4, 29);
            this.TapAgence.Name = "TapAgence";
            this.TapAgence.Padding = new System.Windows.Forms.Padding(3);
            this.TapAgence.Size = new System.Drawing.Size(442, 303);
            this.TapAgence.TabIndex = 0;
            this.TapAgence.Text = "Agence";
            this.TapAgence.UseVisualStyleBackColor = true;
            // 
            // TapEmail
            // 
            this.TapEmail.Location = new System.Drawing.Point(4, 29);
            this.TapEmail.Name = "TapEmail";
            this.TapEmail.Padding = new System.Windows.Forms.Padding(3);
            this.TapEmail.Size = new System.Drawing.Size(442, 339);
            this.TapEmail.TabIndex = 1;
            this.TapEmail.Text = "Email";
            this.TapEmail.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(385, 366);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(278, 366);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 423);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TabControl);
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TapAgence;
        private System.Windows.Forms.TabPage TapEmail;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}