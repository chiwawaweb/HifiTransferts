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
            this.TapSystem = new System.Windows.Forms.TabPage();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumAgence = new System.Windows.Forms.TextBox();
            this.TxtNomAgence = new System.Windows.Forms.TextBox();
            this.TxtAdr1Agence = new System.Windows.Forms.TextBox();
            this.TxtAdr2Agence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCpAgence = new System.Windows.Forms.TextBox();
            this.TxtVilleAgence = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelAgence = new System.Windows.Forms.TextBox();
            this.TxtFaxAgence = new System.Windows.Forms.TextBox();
            this.TxtEmailAgence = new System.Windows.Forms.TextBox();
            this.TxtDbPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmailSmtp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEmailPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEmailUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtEmailPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.TapAgence.SuspendLayout();
            this.TapSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TapAgence);
            this.TabControl.Controls.Add(this.TapSystem);
            this.TabControl.Location = new System.Drawing.Point(20, 16);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(300, 294);
            this.TabControl.TabIndex = 0;
            // 
            // TapAgence
            // 
            this.TapAgence.Controls.Add(this.TxtEmailAgence);
            this.TapAgence.Controls.Add(this.TxtFaxAgence);
            this.TapAgence.Controls.Add(this.TxtTelAgence);
            this.TapAgence.Controls.Add(this.label8);
            this.TapAgence.Controls.Add(this.label7);
            this.TapAgence.Controls.Add(this.label6);
            this.TapAgence.Controls.Add(this.TxtVilleAgence);
            this.TapAgence.Controls.Add(this.TxtCpAgence);
            this.TapAgence.Controls.Add(this.label5);
            this.TapAgence.Controls.Add(this.TxtAdr2Agence);
            this.TapAgence.Controls.Add(this.TxtAdr1Agence);
            this.TapAgence.Controls.Add(this.TxtNomAgence);
            this.TapAgence.Controls.Add(this.TxtNumAgence);
            this.TapAgence.Controls.Add(this.label4);
            this.TapAgence.Controls.Add(this.label3);
            this.TapAgence.Controls.Add(this.label2);
            this.TapAgence.Controls.Add(this.label1);
            this.TapAgence.Location = new System.Drawing.Point(4, 22);
            this.TapAgence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TapAgence.Name = "TapAgence";
            this.TapAgence.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TapAgence.Size = new System.Drawing.Size(292, 268);
            this.TapAgence.TabIndex = 0;
            this.TapAgence.Text = "Agence";
            this.TapAgence.UseVisualStyleBackColor = true;
            // 
            // TapSystem
            // 
            this.TapSystem.Controls.Add(this.textBox6);
            this.TapSystem.Controls.Add(this.TxtEmailPassword);
            this.TapSystem.Controls.Add(this.label14);
            this.TapSystem.Controls.Add(this.TxtEmailUser);
            this.TapSystem.Controls.Add(this.label13);
            this.TapSystem.Controls.Add(this.TxtEmailPort);
            this.TapSystem.Controls.Add(this.label12);
            this.TapSystem.Controls.Add(this.TxtEmailSmtp);
            this.TapSystem.Controls.Add(this.label11);
            this.TapSystem.Controls.Add(this.TxtDbPath);
            this.TapSystem.Controls.Add(this.label9);
            this.TapSystem.Controls.Add(this.label10);
            this.TapSystem.Location = new System.Drawing.Point(4, 22);
            this.TapSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TapSystem.Name = "TapSystem";
            this.TapSystem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TapSystem.Size = new System.Drawing.Size(292, 268);
            this.TapSystem.TabIndex = 1;
            this.TapSystem.Text = "Système";
            this.TapSystem.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(217, 314);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 26);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(99, 314);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 26);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations agence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse :";
            // 
            // TxtNumAgence
            // 
            this.TxtNumAgence.Location = new System.Drawing.Point(105, 28);
            this.TxtNumAgence.MaxLength = 3;
            this.TxtNumAgence.Name = "TxtNumAgence";
            this.TxtNumAgence.Size = new System.Drawing.Size(33, 20);
            this.TxtNumAgence.TabIndex = 4;
            // 
            // TxtNomAgence
            // 
            this.TxtNomAgence.Enabled = false;
            this.TxtNomAgence.Location = new System.Drawing.Point(105, 58);
            this.TxtNomAgence.Name = "TxtNomAgence";
            this.TxtNomAgence.Size = new System.Drawing.Size(161, 20);
            this.TxtNomAgence.TabIndex = 5;
            // 
            // TxtAdr1Agence
            // 
            this.TxtAdr1Agence.Location = new System.Drawing.Point(105, 88);
            this.TxtAdr1Agence.Name = "TxtAdr1Agence";
            this.TxtAdr1Agence.Size = new System.Drawing.Size(161, 20);
            this.TxtAdr1Agence.TabIndex = 6;
            // 
            // TxtAdr2Agence
            // 
            this.TxtAdr2Agence.Location = new System.Drawing.Point(105, 113);
            this.TxtAdr2Agence.Name = "TxtAdr2Agence";
            this.TxtAdr2Agence.Size = new System.Drawing.Size(161, 20);
            this.TxtAdr2Agence.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CP / Ville :";
            // 
            // TxtCpAgence
            // 
            this.TxtCpAgence.Location = new System.Drawing.Point(105, 143);
            this.TxtCpAgence.Name = "TxtCpAgence";
            this.TxtCpAgence.Size = new System.Drawing.Size(43, 20);
            this.TxtCpAgence.TabIndex = 9;
            // 
            // TxtVilleAgence
            // 
            this.TxtVilleAgence.Location = new System.Drawing.Point(152, 143);
            this.TxtVilleAgence.Name = "TxtVilleAgence";
            this.TxtVilleAgence.Size = new System.Drawing.Size(112, 20);
            this.TxtVilleAgence.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Téléphone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fax :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "E-mail :";
            // 
            // TxtTelAgence
            // 
            this.TxtTelAgence.Location = new System.Drawing.Point(105, 173);
            this.TxtTelAgence.Name = "TxtTelAgence";
            this.TxtTelAgence.Size = new System.Drawing.Size(161, 20);
            this.TxtTelAgence.TabIndex = 14;
            // 
            // TxtFaxAgence
            // 
            this.TxtFaxAgence.Location = new System.Drawing.Point(105, 203);
            this.TxtFaxAgence.Name = "TxtFaxAgence";
            this.TxtFaxAgence.Size = new System.Drawing.Size(161, 20);
            this.TxtFaxAgence.TabIndex = 15;
            // 
            // TxtEmailAgence
            // 
            this.TxtEmailAgence.Location = new System.Drawing.Point(105, 233);
            this.TxtEmailAgence.Name = "TxtEmailAgence";
            this.TxtEmailAgence.Size = new System.Drawing.Size(161, 20);
            this.TxtEmailAgence.TabIndex = 16;
            // 
            // TxtDbPath
            // 
            this.TxtDbPath.Location = new System.Drawing.Point(105, 28);
            this.TxtDbPath.Name = "TxtDbPath";
            this.TxtDbPath.Size = new System.Drawing.Size(161, 20);
            this.TxtDbPath.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chemin BD :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Configuration système :";
            // 
            // TxtEmailSmtp
            // 
            this.TxtEmailSmtp.Location = new System.Drawing.Point(105, 58);
            this.TxtEmailSmtp.Name = "TxtEmailSmtp";
            this.TxtEmailSmtp.Size = new System.Drawing.Size(161, 20);
            this.TxtEmailSmtp.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "SMTP :";
            // 
            // TxtEmailPort
            // 
            this.TxtEmailPort.Location = new System.Drawing.Point(105, 88);
            this.TxtEmailPort.MaxLength = 5;
            this.TxtEmailPort.Name = "TxtEmailPort";
            this.TxtEmailPort.Size = new System.Drawing.Size(37, 20);
            this.TxtEmailPort.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Port :";
            // 
            // TxtEmailUser
            // 
            this.TxtEmailUser.Location = new System.Drawing.Point(105, 118);
            this.TxtEmailUser.Name = "TxtEmailUser";
            this.TxtEmailUser.Size = new System.Drawing.Size(161, 20);
            this.TxtEmailUser.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "User :";
            // 
            // TxtEmailPassword
            // 
            this.TxtEmailPassword.Location = new System.Drawing.Point(105, 148);
            this.TxtEmailPassword.Name = "TxtEmailPassword";
            this.TxtEmailPassword.Size = new System.Drawing.Size(161, 20);
            this.TxtEmailPassword.TabIndex = 16;
            this.TxtEmailPassword.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Password :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Red;
            this.textBox6.Location = new System.Drawing.Point(26, 193);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(240, 48);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Attention ! Toute modification sur cette page peut entraîner de graves dysfonctio" +
    "nnements de l\'application !!!";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.TabControl.ResumeLayout(false);
            this.TapAgence.ResumeLayout(false);
            this.TapAgence.PerformLayout();
            this.TapSystem.ResumeLayout(false);
            this.TapSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TapAgence;
        private System.Windows.Forms.TabPage TapSystem;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtNumAgence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmailAgence;
        private System.Windows.Forms.TextBox TxtFaxAgence;
        private System.Windows.Forms.TextBox TxtTelAgence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtVilleAgence;
        private System.Windows.Forms.TextBox TxtCpAgence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAdr2Agence;
        private System.Windows.Forms.TextBox TxtAdr1Agence;
        private System.Windows.Forms.TextBox TxtNomAgence;
        private System.Windows.Forms.TextBox TxtEmailPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtEmailUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtEmailPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtEmailSmtp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDbPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
    }
}