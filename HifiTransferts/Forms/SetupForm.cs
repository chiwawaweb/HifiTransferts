using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using HifiTransferts.Classes;

namespace HifiTransferts.Forms
{
    public partial class SetupForm : Form
    {
        Utils utils = new Utils();
        MainForm _owner;

        public SetupForm()
        {
            InitializeComponent();

            TxtNomAgence.Text = utils.ReadSetting("nomAgence");
            TxtNumAgence.Text = utils.ReadSetting("numAgence");
            TxtAdr1Agence.Text = utils.ReadSetting("adresse1Agence");
            TxtAdr2Agence.Text = utils.ReadSetting("adresse2Agence");
            TxtCpAgence.Text = utils.ReadSetting("cpAgence");
            TxtVilleAgence.Text = utils.ReadSetting("villeAgence");
            TxtTelAgence.Text = utils.ReadSetting("telAgence");
            TxtFaxAgence.Text = utils.ReadSetting("faxAgence");
            TxtEmailAgence.Text = utils.ReadSetting("emailAgence");
            TxtDbPath.Text = utils.ReadSetting("dbPath");
            TxtEmailSmtp.Text = utils.ReadSetting("emailSmtp");
            TxtEmailPort.Text = utils.ReadSetting("emailPort");
            TxtEmailUser.Text = utils.ReadSetting("emailUser");
            TxtEmailPassword.Text = utils.ReadSetting("emailPassword");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
