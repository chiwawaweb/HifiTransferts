using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HifiTransferts.DAL;
using HifiTransferts.DTO;

namespace HifiTransferts.Forms
{
    public partial class TransfertsListForm : Form
    {
        private static int idRetour;

        TransfertProvider transfertProvider = new TransfertProvider();

        public TransfertsListForm()
        {
            InitializeComponent();
        }

        private void TransfertsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            WindowState = FormWindowState.Maximized;
        }

        private void CreateTable(List<Transfert> list, int _idRetour)
        {
            idRetour = _idRetour;
            /* Initialisation du Datagridview */
            dgvTransferts.Rows.Clear();
            dgvTransferts.Columns.Clear();

            /* Mise en forme Datagridview */
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "#";
            idColumn.Width = 50;
            idColumn.Visible = true;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 90;
            dateColumn.MinimumWidth = 90;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn agenceColumn = new DataGridViewTextBoxColumn();
            agenceColumn.Name = "Agence";
            agenceColumn.HeaderText = "AGENCE";
            agenceColumn.Width = 150;

            DataGridViewTextBoxColumn vendeurColumn = new DataGridViewTextBoxColumn();
            agenceColumn.Name = "Vendeur";
            agenceColumn.HeaderText = "VENDEUR";
            agenceColumn.Width = 150;

            DataGridViewTextBoxColumn clientColumn = new DataGridViewTextBoxColumn();
            clientColumn.Name = "Client";
            clientColumn.HeaderText = "CLIENT";
            clientColumn.Width = 200;

            DataGridViewTextBoxColumn articlesColumn = new DataGridViewTextBoxColumn();
            articlesColumn.Name = "Articles";
            articlesColumn.HeaderText = "ARTICLES";
            articlesColumn.Width = 300;

            DataGridViewTextBoxColumn contactColumn = new DataGridViewTextBoxColumn();
            contactColumn.Name = "Contact";
            contactColumn.HeaderText = "CONTACT";
            contactColumn.Width = 160;


            /* Création des colonnes */
            dgvTransferts.Columns.Add(idColumn);
            dgvTransferts.Columns.Add(dateColumn);
            dgvTransferts.Columns.Add(vendeurColumn);
            dgvTransferts.Columns.Add(agenceColumn);
            dgvTransferts.Columns.Add(clientColumn);
            dgvTransferts.Columns.Add(contactColumn);
            dgvTransferts.Columns.Add(articlesColumn);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvTransferts.Rows.Add();

                int? id = list[i].Id;
                DateTime date = list[i].Date;
                string agence = list[i].Agence;
                string client = list[i].Client;
                string contact = list[i].Contact;
                string vendeur = list[i].Vendeur;
                string articles = list[i].Articles;

                dgvTransferts.Rows[number].Cells[0].Value = id;
                dgvTransferts.Rows[number].Cells[1].Value = date.ToString("dd/MM/yyyy");
                dgvTransferts.Rows[number].Cells[2].Value = vendeur;
                dgvTransferts.Rows[number].Cells[3].Value = agence;
                dgvTransferts.Rows[number].Cells[4].Value = client;
                dgvTransferts.Rows[number].Cells[5].Value = contact;

                // pointe sur l'enregistrement courant
                if (list[i].Id == idRetour)
                {
                    dgvTransferts.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        private void RefreshData()
        {
            List<Transfert> list;
            list = transfertProvider.Search(""); // à completer avec mots cles / dates

            CreateTable(list, idRetour);


        }
    }
}
