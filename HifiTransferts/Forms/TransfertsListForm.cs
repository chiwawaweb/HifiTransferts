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
            idColumn.Visible = true;

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.HeaderText = "DATE";
            dateColumn.Width = 90;
            dateColumn.MinimumWidth = 90;
            dateColumn.FillWeight = 1;
            dateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            /* Création des colonnes */
            dgvTransferts.Columns.Add(idColumn);
            dgvTransferts.Columns.Add(dateColumn);
            
        }

        private void RefreshData()
        {
            List<Transfert> list;
            list = transfertProvider.Search(""); // à completer avec mots cles / dates

            CreateTable(list, idRetour);
        }
    }
}
