using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HifiTransferts.DTO;
using HifiTransferts.DAL;

namespace HifiTransferts.Forms
{
    public partial class MainForm : Form
    {
        TransfertProvider transfertProvider = new TransfertProvider();

        public MainForm()
        {
            InitializeComponent();
            TransfertsListForm frm = new TransfertsListForm();
            frm.MdiParent = this;
            frm.Show();

            transfertProvider.CountAll();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NewTransfert();
        }

        private void NewTransfert()
        {
            TransfertNewForm frm = new TransfertNewForm();
            frm.ShowDialog();
        }
    }
}
