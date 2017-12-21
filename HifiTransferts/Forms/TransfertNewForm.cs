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

namespace HifiTransferts.Forms
{
    public partial class TransfertNewForm : Form
    {
        Utils utils = new Utils();

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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AfficheAgences()
        {
            
        }

        private void TransfertNewForm_Load(object sender, EventArgs e)
        {
            

            

            

        }
    }
}
