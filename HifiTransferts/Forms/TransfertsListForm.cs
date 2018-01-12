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
            DtpDebut.Value = DateTime.Now.AddMonths(-1);
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
            idColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 85;
            dateColumn.MinimumWidth = 85;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn agenceColumn = new DataGridViewTextBoxColumn();
            agenceColumn.Name = "Agence";
            agenceColumn.HeaderText = "AGENCE";
            agenceColumn.Width = 150;
            agenceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn vendeurColumn = new DataGridViewTextBoxColumn();
            vendeurColumn.Name = "Vendeur";
            vendeurColumn.HeaderText = "VENDEUR";
            vendeurColumn.Width = 150;
            vendeurColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn clientColumn = new DataGridViewTextBoxColumn();
            clientColumn.Name = "Client";
            clientColumn.HeaderText = "CLIENT";
            clientColumn.Width = 200;
            clientColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn articlesColumn = new DataGridViewTextBoxColumn();
            articlesColumn.Name = "Articles";
            articlesColumn.HeaderText = "ARTICLES";
            articlesColumn.Width = 300;
            articlesColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn contactColumn = new DataGridViewTextBoxColumn();
            contactColumn.Name = "Contact";
            contactColumn.HeaderText = "CONTACT";
            contactColumn.Width = 160;
            contactColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn messageColumn = new DataGridViewTextBoxColumn();
            messageColumn.Name = "Message";
            messageColumn.HeaderText = "MESSAGE";
            messageColumn.Width = 250;
            messageColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCheckBoxColumn envoyeColumn = new DataGridViewCheckBoxColumn();
            envoyeColumn.Name = "Envoye";
            envoyeColumn.HeaderText = "ENVOYE";
            envoyeColumn.Width = 70;
            envoyeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            /* Création des colonnes */
            dgvTransferts.Columns.Add(idColumn);
            dgvTransferts.Columns.Add(dateColumn);
            dgvTransferts.Columns.Add(vendeurColumn);
            dgvTransferts.Columns.Add(agenceColumn);
            dgvTransferts.Columns.Add(clientColumn);
            dgvTransferts.Columns.Add(contactColumn);
            dgvTransferts.Columns.Add(articlesColumn);
            dgvTransferts.Columns.Add(messageColumn);
            dgvTransferts.Columns.Add(envoyeColumn);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = dgvTransferts.Rows.Add();

                string id = list[i].Id.ToString("000000");
                DateTime date = list[i].Date;
                string agence = list[i].Agence;
                string client = list[i].Client;
                string contact = list[i].Contact;
                string vendeur = list[i].Vendeur;
                string articles = list[i].Articles;
                string remarque = list[i].Remarque;
                bool envoye = list[i].Envoye;

                dgvTransferts.Rows[number].Cells[0].Value = id;
                dgvTransferts.Rows[number].Cells[1].Value = date.ToString("dd/MM/yyyy");
                dgvTransferts.Rows[number].Cells[2].Value = vendeur;
                dgvTransferts.Rows[number].Cells[3].Value = agence;
                dgvTransferts.Rows[number].Cells[4].Value = client;
                dgvTransferts.Rows[number].Cells[5].Value = contact;
                dgvTransferts.Rows[number].Cells[6].Value = articles;
                dgvTransferts.Rows[number].Cells[7].Value = remarque;
                dgvTransferts.Rows[number].Cells[8].Value = envoye;

                // pointe sur l'enregistrement courant
                if (list[i].Id == idRetour)
                {
                    dgvTransferts.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        public void RefreshData()
        {
            List<Transfert> list;
            list = transfertProvider.Search(TxtSearch.Text, DtpDebut.Value, DtpFin.Value); // à completer avec mots cles / dates

            CreateTable(list, idRetour);


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NewTransfert();
        }

        private void NewTransfert()
        {
            TransfertEditForm frm = new TransfertEditForm(this, false);
            frm.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditTransfert();
        }

        private void EditTransfert()
        {
            if (dgvTransferts.RowCount > 0)
            {
                int ID = int.Parse(dgvTransferts.CurrentRow.Cells[0].Value.ToString());
                idRetour = ID;
                TransfertEditForm frm = new TransfertEditForm(this, true, ID);
                frm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SupprimerTransfert();
        }

        private void SupprimerTransfert()
        {
            if (dgvTransferts.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Etes-vous certain de vouloir supprimer cette demande de transfert ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int ID = int.Parse(dgvTransferts.CurrentRow.Cells[0].Value.ToString());
                    transfertProvider.Delete(new Transfert { Id = ID });
                    RefreshData();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchTransferts();
        }

        private void SearchTransferts()
        {
            List<Transfert> list;
            DateTime dateDebut = Convert.ToDateTime(DtpDebut.Value.ToShortDateString());
            DateTime dateFin = Convert.ToDateTime(DtpFin.Value.ToShortDateString());

            list = transfertProvider.Search(TxtSearch.Text, dateDebut, dateFin);

            CreateTable(list, idRetour);
        }

        private void SearchFieldsReset()
        {
            TxtSearch.Text = "";
            DtpDebut.Value = DateTime.Now.AddMonths(-1);
            DtpFin.Value = DateTime.Now;
            SearchTransferts();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            SearchFieldsReset();
        }

        private void dgvTransferts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditTransfert();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (dgvTransferts.RowCount > 0)
            {
                /* Test si déjà envoyé */
                bool sended = Convert.ToBoolean(dgvTransferts.CurrentRow.Cells[8].Value);
                string warningMsg;
                MessageBoxIcon msgboxicon;

                if (sended == true)
                {
                    /* Demande déjà envoyée */
                    warningMsg = "La demande a déjà été envoyée. Voulez-vous vraiment la renvoyer ?";
                    msgboxicon = MessageBoxIcon.Warning;
                }
                else
                {
                    /* Demande non envoyée */
                    warningMsg = "Voulez-vous envoyer cette demande maintenant ?";
                    msgboxicon = MessageBoxIcon.Question;
                }

                DialogResult result = MessageBox.Show(warningMsg, "Confirmation d'envoi", MessageBoxButtons.YesNo, msgboxicon);
                if (result == DialogResult.Yes)
                {
                    int ID = int.Parse(dgvTransferts.CurrentRow.Cells[0].Value.ToString());
                    //transfertProvider.Delete(new Transfert { Id = ID });
                    //RefreshData();
                }
            }

            
        }
    }
}
