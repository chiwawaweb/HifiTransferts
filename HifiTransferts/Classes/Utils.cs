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
                new Agence {Numero=15, Nom="BELLE ETOILE", Email="hifi15@hifi.lu", Actif=true},
                new Agence {Numero=19, Nom="POMMERLOCH", Email="hifi19@hifi.lu",Actif=true},
                new Agence {Numero=26, Nom="CITY CONCORDE", Email="hifi26@hifi.lu",Actif=true},
                new Agence {Numero=30, Nom="HOWALD", Email="hifi19@hifi.lu",Actif=true},
                new Agence {Numero=33, Nom="BETTEMBOURG", Email="hifi33@hifi.lu",Actif=true},
                new Agence {Numero=34, Nom="BERTRANGE E.M.", Email="hifi34em@hifi.lu",Actif=true},
                new Agence {Numero=30, Nom="BERTRANGE A.V.", Email="hifi34av@hifi.lu",Actif=true}

            };

            return agences;

        }

        


    }
}
