﻿namespace HifiTransferts.Forms
{
    partial class TransfertEditForm
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtClient = new System.Windows.Forms.TextBox();
            this.ChkStock = new System.Windows.Forms.CheckBox();
            this.CbxVendeur = new System.Windows.Forms.ComboBox();
            this.TxtArticles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNoteInterne = new System.Windows.Forms.TextBox();
            this.LblEnvoye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxAgence
            // 
            this.CbxAgence.BackColor = System.Drawing.SystemColors.Window;
            this.CbxAgence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxAgence.FormattingEnabled = true;
            this.CbxAgence.Location = new System.Drawing.Point(159, 24);
            this.CbxAgence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxAgence.Name = "CbxAgence";
            this.CbxAgence.Size = new System.Drawing.Size(138, 21);
            this.CbxAgence.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(335, 402);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(105, 25);
            this.BtnSend.TabIndex = 8;
            this.BtnSend.TabStop = false;
            this.BtnSend.Text = "Envoyer";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(249, 402);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 25);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.AcceptsReturn = true;
            this.TxtMessage.Location = new System.Drawing.Point(15, 274);
            this.TxtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(425, 42);
            this.TxtMessage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Agence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vendeur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vu avec";
            // 
            // TxtContact
            // 
            this.TxtContact.Location = new System.Drawing.Point(301, 24);
            this.TxtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(140, 20);
            this.TxtContact.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnSave.Location = new System.Drawing.Point(17, 402);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(113, 25);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Client";
            // 
            // TxtClient
            // 
            this.TxtClient.Location = new System.Drawing.Point(15, 61);
            this.TxtClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.Size = new System.Drawing.Size(140, 20);
            this.TxtClient.TabIndex = 3;
            // 
            // ChkStock
            // 
            this.ChkStock.AutoSize = true;
            this.ChkStock.Location = new System.Drawing.Point(159, 64);
            this.ChkStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkStock.Name = "ChkStock";
            this.ChkStock.Size = new System.Drawing.Size(77, 17);
            this.ChkStock.TabIndex = 4;
            this.ChkStock.Text = "Pour stock";
            this.ChkStock.UseVisualStyleBackColor = true;
            this.ChkStock.CheckedChanged += new System.EventHandler(this.ChkStock_CheckedChanged);
            // 
            // CbxVendeur
            // 
            this.CbxVendeur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbxVendeur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxVendeur.FormattingEnabled = true;
            this.CbxVendeur.Location = new System.Drawing.Point(15, 23);
            this.CbxVendeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxVendeur.Name = "CbxVendeur";
            this.CbxVendeur.Size = new System.Drawing.Size(138, 21);
            this.CbxVendeur.TabIndex = 0;
            // 
            // TxtArticles
            // 
            this.TxtArticles.AcceptsReturn = true;
            this.TxtArticles.Location = new System.Drawing.Point(15, 113);
            this.TxtArticles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtArticles.Multiline = true;
            this.TxtArticles.Name = "TxtArticles";
            this.TxtArticles.Size = new System.Drawing.Size(425, 135);
            this.TxtArticles.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Articles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Note interne ";
            // 
            // TxtNoteInterne
            // 
            this.TxtNoteInterne.AcceptsReturn = true;
            this.TxtNoteInterne.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNoteInterne.Location = new System.Drawing.Point(15, 333);
            this.TxtNoteInterne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNoteInterne.Multiline = true;
            this.TxtNoteInterne.Name = "TxtNoteInterne";
            this.TxtNoteInterne.Size = new System.Drawing.Size(425, 42);
            this.TxtNoteInterne.TabIndex = 23;
            // 
            // LblEnvoye
            // 
            this.LblEnvoye.AutoSize = true;
            this.LblEnvoye.BackColor = System.Drawing.Color.Yellow;
            this.LblEnvoye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEnvoye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnvoye.Location = new System.Drawing.Point(292, 60);
            this.LblEnvoye.Name = "LblEnvoye";
            this.LblEnvoye.Padding = new System.Windows.Forms.Padding(3);
            this.LblEnvoye.Size = new System.Drawing.Size(148, 21);
            this.LblEnvoye.TabIndex = 25;
            this.LblEnvoye.Text = "Demande déjà envoyée";
            this.LblEnvoye.Visible = false;
            // 
            // TransfertEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 434);
            this.Controls.Add(this.LblEnvoye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNoteInterne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtArticles);
            this.Controls.Add(this.CbxVendeur);
            this.Controls.Add(this.ChkStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtClient);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.CbxAgence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfertEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Demande de transfert";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransfertEditForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxAgence;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtClient;
        private System.Windows.Forms.CheckBox ChkStock;
        private System.Windows.Forms.ComboBox CbxVendeur;
        private System.Windows.Forms.TextBox TxtArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNoteInterne;
        private System.Windows.Forms.Label LblEnvoye;
    }
}