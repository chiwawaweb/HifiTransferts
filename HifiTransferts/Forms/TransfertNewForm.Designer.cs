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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CbxAgence = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 26);
            this.textBox2.TabIndex = 1;
            // 
            // CbxAgence
            // 
            this.CbxAgence.FormattingEnabled = true;
            this.CbxAgence.Location = new System.Drawing.Point(238, 37);
            this.CbxAgence.Name = "CbxAgence";
            this.CbxAgence.Size = new System.Drawing.Size(205, 28);
            this.CbxAgence.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 26);
            this.textBox3.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(624, 271);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 42);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(686, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 697);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Envoyer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 697);
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
            this.textBox4.Location = new System.Drawing.Point(26, 628);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(688, 62);
            this.textBox4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remarque";
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
            this.label5.Location = new System.Drawing.Point(21, 603);
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
            this.button1.Location = new System.Drawing.Point(462, 697);
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
            // TransfertNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 806);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CbxAgence);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransfertNewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Demande de transfert";
            this.Load += new System.EventHandler(this.TransfertNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox CbxAgence;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
    }
}