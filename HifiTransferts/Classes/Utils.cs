using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HifiTransferts.Classes
{
    public class Utils
    {
        public List<Agence> AllAgencies()
        {
            List<Agence> agences = new List<Agence>()
            {
                new Agence {Numero=15, Nom="Bele etoile", Actif=true},
                new Agence {Numero=19, Nom="pommerloch", Actif=true}

            };

            return agences;

        }

        


    }
}
