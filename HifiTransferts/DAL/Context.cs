using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HifiTransferts.DTO;
using System.Data.Entity;

namespace HifiTransferts.DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Transfert> Transferts { get; set; }
        public DbSet<Agence> Agences { get; set; }
    }

    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);

            Agence[] agences =
            {
                
                new Agence { Numero=15, Nom="BELLE ETOILE", Email="hifi15@hifi.lu", Actif=true},
                new Agence { Numero=19, Nom="POMMERLOCH", Email="hifi19@hifi.lu",Actif=true},
                new Agence { Numero=26, Nom="CITY CONCORDE", Email="hifi26@hifi.lu",Actif=true},
                new Agence { Numero=30, Nom="HOWALD", Email="hifi30@hifi.lu",Actif=true}
                new Agence { Numero=33, Nom="BETTEMBOURG", Email="hifi33@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE EM", Email="hifi34em@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE AV", Email="hifi34AV@hifi.lu",Actif=true},
                new Agence { Numero=34, Nom="BERTRANGE MM", Email="hifi34mm@hifi.lu",Actif=true},
                new Agence { Numero=36, Nom="GARE", Email="hifi36@hifi.lu",Actif=true},
                new Agence { Numero=37, Nom="BERELDANGE", Email="hifi37@hifi.lu",Actif=true},
                new Agence { Numero=38, Nom="MERSCH", Email="hifi38@hifi.lu",Actif=true},
                new Agence { Numero=39, Nom="MASSEN", Email="hifi39@hifi.lu",Actif=true},
                new Agence { Numero=40, Nom="FOETZ", Email="hifi40@hifi.lu",Actif=true},
                new Agence { Numero=41, Nom="INGELDORF", Email="hifi41@hifi.lu",Actif=true}
            };

            foreach (Agence agence in agences)
            {
                context.Agences.Add(agence);
            }
        }
    }
}
