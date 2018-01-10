using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using HifiTransferts.Classes;
using HifiTransferts;
using HifiTransferts.DAL;
using HifiTransferts.DTO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;

namespace HifiTransferts.Forms
{
    public partial class TransfertEditForm : Form
    {
        Utils utils = new Utils();

        string vendeur, agence, contact, client, articles, remarque, noteInterne, agenceName, emailAgence;
        string formTitle, ligContact, ligBonneJournee, ligRemarque, ligClient;
        bool stock, transfertUpdateMode, envoye;
        int _id, agenceNumber;

        DateTime date;

        TransfertsListForm _owner;
        Transfert transfert;
        TransfertProvider transfertProvider = new TransfertProvider();

        public TransfertEditForm(TransfertsListForm owner, bool update, int id = 0)
        {
            _owner = owner;
            _id = id;
            transfertUpdateMode = update;
            FormClosed += new FormClosedEventHandler(TransfertEditForm_FormClosed);
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

            /* Combobox Vendeur */
            var dataSourceVendeur = new List<string>();
            dataSourceVendeur.Add("");
            foreach (string transfert in transfertProvider.GetVendeurs())
            {
                dataSourceVendeur.Add(transfert);
            }
            CbxVendeur.DataSource = dataSourceVendeur;
            CbxVendeur.DisplayMember = "Vendeur";
            //CbxVendeur.ValueMember = "Vendeur";

            switch (transfertUpdateMode)
            {
                /* Mode création */
                case false:
                    NewTransfert();
                    break;

                /* Mode mise à jour */
                case true:
                    LoadTransfert();
                    break;
            }

            /* Titre du formulaire */
            this.Text = formTitle;

            

        }

        private void NewTransfert()
        {
            formTitle = "Nouvelle demande de transfert";



        }

        private void LoadTransfert()
        {
            formTitle = "Modification d'une demande de transfert";

            /* Récupération des données */
            vendeur = transfertProvider.GetTransfertById(_id).Vendeur;
            agence = transfertProvider.GetTransfertById(_id).Agence;
            contact = transfertProvider.GetTransfertById(_id).Contact;
            client = transfertProvider.GetTransfertById(_id).Client;
            stock = transfertProvider.GetTransfertById(_id).Stock;
            articles = transfertProvider.GetTransfertById(_id).Articles;
            remarque = transfertProvider.GetTransfertById(_id).Remarque;
            noteInterne = transfertProvider.GetTransfertById(_id).NoteInterne;
            envoye = transfertProvider.GetTransfertById(_id).Envoye;

            /* Affichage des données */
            CbxVendeur.Text = vendeur;
            CbxAgence.Text = agence;
            TxtContact.Text = contact;
            TxtClient.Text = client;
            ChkStock.Checked = stock;
            TxtArticles.Text = articles;
            TxtMessage.Text = remarque;
            TxtNoteInterne.Text = noteInterne;

            /* Vérifie si déjà envoyé par mail */
            if (envoye == true)
            {
                TssSended.Visible = true;
                BtnSend.Text = "Réenvoyer";
            }
            else
            {
                TssSended.Visible = true;
                TssSended.Text = "Cette demande est en attente d'envoi...";
            }

        }

        private void ChkStock_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkStock.Checked==true)
            {
                TxtClient.Enabled = false;
                TxtClient.Text = "";
            }
            else
            {
                TxtClient.Enabled = true;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SaveTransfert(true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveTransfert(false);
        }

        private void SaveTransfert(bool send)
        {
            /* Recuperation des donnees */
            date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            vendeur = utils.RemoveDiacritics(CbxVendeur.Text.ToUpper().Trim());
            client = utils.RemoveDiacritics(TxtClient.Text.ToUpper().Trim());
            stock = ChkStock.Checked;
            agence = utils.RemoveDiacritics(CbxAgence.Text.ToUpper().Trim());
            agenceNumber = int.Parse(agence.Substring(0, 3));
            agenceName = agence.Substring(6);
            contact = utils.RemoveDiacritics(TxtContact.Text.ToUpper().Trim());
            articles = utils.RemoveDiacritics(TxtArticles.Text.ToUpper().Trim());
            remarque = utils.RemoveDiacritics(TxtMessage.Text.ToUpper().Trim());
            noteInterne = utils.RemoveDiacritics(TxtNoteInterne.Text.ToUpper().Trim());

            /* Vérification des donnees */
            bool errors = false;
            bool errVendeur, errArticles = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (vendeur.Length<2)
            {
                errors = true;
                errMsg = "- Vendeur non spécifié\n";
            }

            if (articles.Length<2)
            {
                errors = true;
                errMsg += "- Article(s) manquant(s)\n";
            }

            if (errors == true)
            {
                /* Erreurs dans la saisie */
                MessageBox.Show("" + errMsg,"Erreur(s) dans la saisie",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (transfertUpdateMode==true)
                    {
                        UpdateDatabase(send);
                    }
                    else
                    {
                        AddDatabase(send);
                    }
                    
                    if (send == true)
                    {
                        // Envoi du transfert par email
                        SendEmail();
                    }

                    Close();
                }

            }
        }

        private void AddDatabase(bool send)
        {
            Transfert transfert = new Transfert();

            transfert.Date = date;
            transfert.Vendeur = vendeur;
            if (stock == true)
            {
                client = "STOCK MAGASIN";
            }

            transfert.Client = client;
            transfert.Stock = stock;
            transfert.Agence = agence;
            transfert.Contact = contact;
            transfert.Articles = articles;
            transfert.Remarque = remarque;
            transfert.NoteInterne = noteInterne;

            foreach (Agence agence in utils.AllAgencies())
            {
                if (agence.Numero == agenceNumber && agence.Nom == agenceName)
                {
                    emailAgence = agence.Email;
                }
            }

            transfert.Email = emailAgence;
            transfert.Envoye = send;

            transfert.CreatedAt = DateTime.Now;

            transfertProvider.Create(transfert);
        }

        private void UpdateDatabase(bool send)
        {
            Transfert transfert = transfertProvider.GetTransfertById(_id);

            //transfert.Date = date;
            transfert.Vendeur = vendeur;
            if (stock == true)
            {
                client = "STOCK MAGASIN";
            }

            transfert.Client = client;
            transfert.Stock = stock;
            transfert.Agence = agence;
            transfert.Contact = contact;
            transfert.Articles = articles;
            transfert.Remarque = remarque;
            transfert.NoteInterne = noteInterne;

            foreach (Agence agence in utils.AllAgencies())
            {
                if (agence.Numero == agenceNumber && agence.Nom == agenceName)
                {
                    emailAgence = agence.Email;
                }
            }

            transfert.Email = emailAgence;

            /* Si transfert déjà envoyé, le statut ne change pas */
            if (envoye ==  true)
            {
                send = true;
            }
            transfert.Envoye = send;

            transfert.UpdatedAt = DateTime.Now;


            transfertProvider.Update(transfert);
        }

        private void TransfertEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void SendEmail()
        {
            
            /* Vérifie si email valide et non vide */
            string emailToSend = utils.RemoveDiacritics(emailAgence.ToLower().Trim());

            if (utils.IsEmailValid(emailToSend) == true && emailToSend.Length > 3)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient();

                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                    /* Vérifie si "vu avec " */
                    if (contact.Trim().Length>0)
                    {
                        
                        ligContact = "Vu avec " + ti.ToTitleCase(contact.ToLower()) + "\n\n";
                    }

                    /* Message */
                    if (remarque.Length>0)
                    {
                        ligRemarque = "Remarque : \n" + remarque + "\n\n";
                    }
                        

                    /* Vérifie si client ou stock */
                    if (stock == true)
                    {
                        ligClient = "Pour stock magasin \n\n";
                    }
                    else
                    {
                        ligClient = "Client : " + client + "\n\n";
                    }

                    /* Bonne journée/aprem/soirée */
                    if (DateTime.Now.Hour > 4 && DateTime.Now.Hour <= 17)
                    {
                        ligBonneJournee = "Bonne journée.";
                    }

                    if (DateTime.Now.Hour > 17 && DateTime.Now.Hour <= 22)
                    {
                        ligBonneJournee = "Bonne soirée.";
                    }

                    if (DateTime.Now.Hour > 22 && DateTime.Now.Hour <= 4)
                    {
                        ligBonneJournee = "Bonne nuit.";
                    }


                    mail.From = new MailAddress(utils.ReadSetting("emailAgence"), "Hifi International");
                    //mail.To.Add(emailToSend);
                    mail.To.Add("fredandroid76@gmail.com");
                    //mail.CC.Add(utils.ReadSetting("emailAgence")); // Copie à l'agence
                    mail.Subject = "Demande de transfert";
                    string bodyEmail = "Bonjour,\n\n" +
                        "Merci de tranférer le ou les articles suivants : \n\n" +

                        "-----------------------\n\n" +
                        articles + "\n\n" +
                        "-----------------------\n\n" +

                        ligRemarque + 

                        ligContact +

                        ligClient +

                        "Merci !\n" +
                        ligBonneJournee + "\n\n" +

                        ti.ToTitleCase(vendeur.ToLower()) + "\n\n" +

                        utils.ReadSetting("nomAgence") + "\n" +
                        utils.ReadSetting("adresse1Agence") + "\n" +
                        utils.ReadSetting("adresse2Agence") + "\n" +
                        utils.ReadSetting("cpAgence") + " " + utils.ReadSetting("villeAgence") + "\n" +
                        "Tél. : " + utils.ReadSetting("telAgence") + "\n" +
                        "Fax. : " + utils.ReadSetting("faxAgence") + "\n" +
                        "Email : " + utils.ReadSetting("emailAgence") + "\n";

                    mail.Body = bodyEmail;

                    SmtpServer.Port = int.Parse(utils.ReadSetting("emailPort"));
                    SmtpServer.Host = utils.ReadSetting("emailSmtp");
                    //SmtpServer.UseDefaultCredentials = true;
                    SmtpServer.Credentials = new NetworkCredential(utils.ReadSetting("emailUser"), utils.ReadSetting("emailPassword"));
                    SmtpServer.EnableSsl = true;

                    /* Envoi du mail dans un thread séparé */
                    Thread T1 = new Thread(delegate ()
                    {
                        SmtpServer.Send(mail);
                        mail.Dispose();
                        SmtpServer.Dispose();
                    });

                    T1.Start();
                    MessageBox.Show("La demande de transfert a été envoyée avec succès par e-mail.", "Demande expédiée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    /*Console.WriteLine(
                         "Exception caught in CreateTestMessage1(): {0}",
                         ex.ToString());*/
                }
            }
            else
            {
                /* Email non valide */
                MessageBox.Show("L'adresse email n'est pas valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
