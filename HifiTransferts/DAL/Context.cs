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
                new Agence { Numero=33, Nom="BETTEMBOURG", Email="hifi33@hifi.lu",Actif=true}


            };

            foreach (Agence agence in agences)
            {
                context.Agences.Add(agence);
            }
        }
    }
}
