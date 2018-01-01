using System;
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
    public partial class TransfertNewForm : Form
    {
        Utils utils = new Utils();

        string vendeur, agence, contact, client, articles, remarque;
        bool stock;
        DateTime date;

        public TransfertNewForm()
        {
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

        }



        private void TransfertNewForm_Load(object sender, EventArgs e)
        {
            

            

            

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveTransfert();
            Close();
        }

        private void SaveTransfert()
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
                transfert.Agence = agence;
                transfert.Contact = contact;
                transfert.Articles = articles;
                transfert.Remarque = remarque;

                foreach (Agence agence in utils.AllAgencies())
                {
                    if (agence.Numero == agenceNumber && agence.Nom == agenceName)
                    {
                        MessageBox.Show(agence.Email);
                    }
                }

                transfert.CreatedAt = DateTime.Now;

                context.Transferts.Add(transfert);
                context.SaveChanges();
            }

        }
    }
}
