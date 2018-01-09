﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HifiTransferts.Classes;
using HifiTransferts;
using HifiTransferts.DAL;
using HifiTransferts.DTO;

namespace HifiTransferts.Forms
{
    public partial class TransfertEditForm : Form
    {
        Utils utils = new Utils();

        string vendeur, agence, contact, client, articles, remarque, noteInterne;
        string formTitle;
        bool stock, transfertUpdateMode, envoye;
        int _id;

        DateTime date;

        TransfertsListForm _owner;

        TransfertProvider transfertProvider = new TransfertProvider();

        public TransfertEditForm(TransfertsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            transfertUpdateMode = update;
            FormClosed += new FormClosedEventHandler(TransfertEditForm_FormClosed);
            InitializeComponent();

            /* Combobox Agence */
            var dataSource = new List<Agence>();
            foreach (Agence agence in utils.AllAgencies())
            {
                if (agence.Actif == true)
                {
                    dataSource.Add(agence);
                }
            }
            CbxAgence.DataSource = dataSource;
            CbxAgence.DisplayMember = "FullName";
            CbxAgence.ValueMember = "FullName";

            /* Combobox Vendeur */
            var dataSourceVendeur = new List<string>();
            dataSourceVendeur.Add("");
            foreach (string transfert in transfertProvider.GetVendeurs())
            {
                dataSourceVendeur.Add(transfert);
            }
            CbxVendeur.DataSource = dataSourceVendeur;
            CbxVendeur.DisplayMember = "Vendeur";
            //CbxVendeur.ValueMember = "Vendeur";

            switch (transfertUpdateMode)
            {
                /* Mode création */
                case false:
                    NewTransfert();
                    break;

                /* Mode mise à jour */
                case true:
                    LoadTransfert();
                    break;
            }

            /* Titre du formulaire */
            this.Text = formTitle;

            

        }

        private void NewTransfert()
        {
            formTitle = "Nouvelle demande de transfert";



        }

        private void LoadTransfert()
        {
            formTitle = "Modification d'une demande de transfert";

            /* Récupération des données */
            vendeur = transfertProvider.GetTransfertById(_id).Vendeur;
            agence = transfertProvider.GetTransfertById(_id).Agence;
            contact = transfertProvider.GetTransfertById(_id).Contact;
            client = transfertProvider.GetTransfertById(_id).Client;
            stock = transfertProvider.GetTransfertById(_id).Stock;
            articles = transfertProvider.GetTransfertById(_id).Articles;
            remarque = transfertProvider.GetTransfertById(_id).Remarque;
            noteInterne = transfertProvider.GetTransfertById(_id).NoteInterne;
            envoye = transfertProvider.GetTransfertById(_id).Envoye;

            /* Affichage des données */
            CbxVendeur.Text = vendeur;
            CbxAgence.Text = agence;
            TxtContact.Text = contact;
            TxtClient.Text = client;
            ChkStock.Checked = stock;
            TxtArticles.Text = articles;
            TxtMessage.Text = remarque;
            TxtNoteInterne.Text = noteInterne;

            /* Vérifie si déjà envoyé par mail */
            if (envoye == true)
            {
                LblEnvoye.Visible = true;
                BtnSend.Text = "Réenvoyer";
            }

        }

        private void ChkStock_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkStock.Checked==true)
            {
                TxtClient.Enabled = false;
                TxtClient.Text = "";
            }
            else
            {
                TxtClient.Enabled = true;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SaveTransfert(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveTransfert(false);
        }

        private void SaveTransfert(bool send)
        {
            /* Recuperation des donnees */
            date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            vendeur = utils.RemoveDiacritics(CbxVendeur.Text.ToUpper().Trim());
            client = utils.RemoveDiacritics(TxtClient.Text.ToUpper().Trim());
            stock = ChkStock.Checked;
            agence = utils.RemoveDiacritics(CbxAgence.Text.ToUpper().Trim());
            int agenceNumber = int.Parse(agence.Substring(0, 3));
            string agenceName = agence.Substring(6);
            contact = utils.RemoveDiacritics(TxtContact.Text.ToUpper().Trim());
            articles = utils.RemoveDiacritics(TxtArticles.Text.ToUpper().Trim());
            remarque = utils.RemoveDiacritics(TxtMessage.Text.ToUpper().Trim());
            noteInterne = utils.RemoveDiacritics(TxtNoteInterne.Text.ToUpper().Trim());

            

            /* Vérification des donnees */
            bool errors = false;
            bool errVendeur, errArticles = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (vendeur.Length<2)
            {
                errors = true;
                errMsg = "- Vendeur non spécifié\n";
            }

            if (articles.Length<2)
            {
                errors = true;
                errMsg += "- Article(s) manquant(s)\n";
            }

            if (errors == true)
            {
                /* Erreurs dans la saisie */
                MessageBox.Show("" + errMsg,"Erreur(s) dans la saisie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    Transfert transfert = new Transfert();
                    transfert.Date = date;
                    transfert.Vendeur = vendeur;
                    if (stock == true)
                    {
                        client = "STOCK MAGASIN";
                    }

                    transfert.Client = client;
                    transfert.Stock = stock;
                    transfert.Agence = agence;
                    transfert.Contact = contact;
                    transfert.Articles = articles;
                    transfert.Remarque = remarque;
                    transfert.NoteInterne = noteInterne;

                    foreach (Agence agence in utils.AllAgencies())
                    {
                        if (agence.Numero == agenceNumber && agence.Nom == agenceName)
                        {
                            transfert.Email = agence.Email;
                        }
                    }
                    transfert.Envoye = send;

                    transfert.CreatedAt = DateTime.Now;

                    transfertProvider.Create(transfert);

                    /*context.Transferts.Add(transfert);
                    context.SaveChanges();*/

                    if (send == true)
                    {
                        // Envoi du transfert par email

                    }

                    Close();
                }

            }
        }

        private void TransfertEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }
    }
}
