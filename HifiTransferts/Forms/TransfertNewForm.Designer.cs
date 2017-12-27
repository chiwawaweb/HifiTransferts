namespace HifiTransferts.Forms
{
    partial class TransfertNewForm
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
            this.CbxAgence = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtClient = new System.Windows.Forms.TextBox();
            this.ChkStock = new System.Windows.Forms.CheckBox();
            this.CbxVendeur = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbxAgence
            // 
            this.CbxAgence.FormattingEnabled = true;
            this.CbxAgence.Location = new System.Drawing.Point(238, 37);
            this.CbxAgence.Name = "CbxAgence";
            this.CbxAgence.Size = new System.Drawing.Size(205, 28);
            this.CbxAgence.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 607);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Envoyer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 607);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.Location = new System.Drawing.Point(22, 525);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(638, 62);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Agence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vendeur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vu avec";
            // 
            // TxtContact
            // 
            this.TxtContact.Location = new System.Drawing.Point(452, 37);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(208, 26);
            this.TxtContact.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Client";
            // 
            // TxtClient
            // 
            this.TxtClient.Location = new System.Drawing.Point(22, 94);
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.Size = new System.Drawing.Size(208, 26);
            this.TxtClient.TabIndex = 19;
            // 
            // ChkStock
            // 
            this.ChkStock.AutoSize = true;
            this.ChkStock.Location = new System.Drawing.Point(238, 98);
            this.ChkStock.Name = "ChkStock";
            this.ChkStock.Size = new System.Drawing.Size(110, 24);
            this.ChkStock.TabIndex = 21;
            this.ChkStock.Text = "Pour stock";
            this.ChkStock.UseVisualStyleBackColor = true;
            // 
            // CbxVendeur
            // 
            this.CbxVendeur.FormattingEnabled = true;
            this.CbxVendeur.Location = new System.Drawing.Point(22, 35);
            this.CbxVendeur.Name = "CbxVendeur";
            this.CbxVendeur.Size = new System.Drawing.Size(205, 28);
            this.CbxVendeur.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 205);
            this.textBox1.TabIndex = 23;
            // 
            // TransfertNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbxVendeur);
            this.Controls.Add(this.ChkStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CbxAgence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfertNewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Demande de transfert";
            this.Load += new System.EventHandler(this.TransfertNewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxAgence;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtClient;
        private System.Windows.Forms.CheckBox ChkStock;
        private System.Windows.Forms.ComboBox CbxVendeur;
        private System.Windows.Forms.TextBox textBox1;
    }
}