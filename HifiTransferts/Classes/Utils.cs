using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Mail;

namespace HifiTransferts.Classes
{
    public class Utils
    {
        public List<Agence> AllAgencies()
        {
            List<Agence> agences = new List<Agence>()
            {
                new Agence { Numero=15, Nom="BELLE ETOILE", Email="hifi15@hifi.lu", Actif=true},
                new Agence { Numero=19, Nom="POMMERLOCH", Email="hifi19@hifi.lu",Actif=true},
                new Agence { Numero=26, Nom="CITY CONCORDE", Email="hifi26@hifi.lu",Actif=true},
                new Agence { Numero=30, Nom="HOWALD", Email="hifi30@hifi.lu",Actif=true},
                new Agence { Numero=33, Nom="BETTEMBOURG", Email="hifi33@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE EM", Email="hifi34em@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE AV", Email="hifi34av@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE MM", Email="hifi34mm@hifi.lu",Actif=true},
                new Agence { Numero=36, Nom="GARE", Email="hifi36@hifi.lu",Actif=true},
                new Agence { Numero=37, Nom="BERELDANGE", Email="hifi37@hifi.lu",Actif=true},
                new Agence { Numero=38, Nom="MERSCH", Email="hifi38@hifi.lu",Actif=true},
                new Agence { Numero=39, Nom="MASSEN", Email="hifi39@hifi.lu",Actif=true},
                new Agence { Numero=40, Nom="FOETZ", Email="hifi40@hifi.lu",Actif=true},
                new Agence { Numero=41, Nom="INGELDORF", Email="hifi41@hifi.lu",Actif=true}
            };

            return agences;
        }

        public string RemoveDiacritics(String s)
        {
            String normalizedString = s.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                Char c = normalizedString[i];
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            return stringBuilder.ToString();
        }

        public string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "";
            }
        }

        /// <summary>
        /// Vérifie la validité d'une adresse email.
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                if (emailaddress != "")
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
