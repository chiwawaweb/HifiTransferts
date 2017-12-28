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

        string vendeur, agence, contact, client, articles, message;
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
            vendeur = CbxVendeur.Text;
            client = TxtClient.Text;
            agence = CbxAgence.Text;
            contact = TxtContact.Text;

            using (Context context = new Context())
            {
                Transfert transfert = new Transfert();
                transfert.Date = date;
                transfert.Vendeur = vendeur;
                transfert.Client = client;
                transfert.Agence = agence;
                transfert.Contact = contact;

                transfert.CreatedAt = DateTime.Now;

                context.Transferts.Add(transfert);
                context.SaveChanges();
            }

        }
    }
}
