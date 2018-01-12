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

        public SetupForm(MainForm owner)
        {
            _owner = owner;
            FormClosed += new FormClosedEventHandler(SetupForm_FormClosed);
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

        /// <summary>
        /// Enregistre la configuration.
        /// </summary>
        private void SaveSetup()
        {
            /* Récupération des paramètres */
            string nomAgence = TxtNomAgence.Text.ToUpper().Trim();
            int numAgence = int.Parse(TxtNumAgence.Text.Trim());
            string adresse1Agence = TxtAdr1Agence.Text.ToUpper().Trim();
            string adresse2Agence = TxtAdr2Agence.Text.ToUpper().Trim();
            string cpAgence = TxtCpAgence.Text.ToUpper().Trim();
            string villeAgence = TxtVilleAgence.Text.ToUpper().Trim();
            string telAgence = TxtTelAgence.Text.ToUpper().Trim();
            string faxAgence = TxtFaxAgence.Text.ToUpper().Trim();
            string emailAgence = TxtEmailAgence.Text.ToLower().Trim();
            string dbPath = TxtDbPath.Text.ToLower().Trim();
            string emailSmtp = TxtEmailSmtp.Text.ToLower().Trim();
            string emailPort = TxtEmailPort.Text.ToLower().Trim();
            string emailUser = TxtEmailUser.Text.Trim();
            string emailPassword = TxtEmailPassword.Text.Trim();

            /* Enregistrement des paramètres */
            AddUpdateAppSettings("nomAgence", nomAgence);
            AddUpdateAppSettings("numAgence", numAgence.ToString("000"));
            AddUpdateAppSettings("adresse1Agence", adresse1Agence);
            AddUpdateAppSettings("adresse2Agence", adresse2Agence);
            AddUpdateAppSettings("cpAgence", cpAgence);
            AddUpdateAppSettings("villeAgence", villeAgence);
            AddUpdateAppSettings("telAgence", telAgence);
            AddUpdateAppSettings("faxAgence", faxAgence);
            AddUpdateAppSettings("emailAgence", emailAgence);
            AddUpdateAppSettings("dbPath", dbPath);
            AddUpdateAppSettings("emailSmtp", emailSmtp);
            AddUpdateAppSettings("emailPort", emailPort);
            AddUpdateAppSettings("emailUser", emailUser);
            AddUpdateAppSettings("emailPassword", emailPassword);
            AddUpdateConnString("DefaultConnection", dbPath);
            Close();
        }

        /// <summary>
        /// Modification ou ajout d'un paramètre de configuration.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        /// <summary>
        /// Modification ou ajout d'un paramètre de configuration.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        static void AddUpdateConnString(string name, string dataSource)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.ConnectionStrings.ConnectionStrings;

                settings[name].Name = name;
                settings[name].ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSetup();
        }

        private void TxtNumAgence_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtEmailPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void SetupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshForm();
        }
    }
}
