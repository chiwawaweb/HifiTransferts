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
        }

        private void RefreshData()
        {
            List<Transfert> list;
            /*
            CreateTable(list, idRetour);
            */
        }
    }
}
