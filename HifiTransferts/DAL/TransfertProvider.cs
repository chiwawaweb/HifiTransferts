using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HifiTransferts.DTO;
using System.Data.Entity;

namespace HifiTransferts.DAL
{
    public class TransfertProvider
    {
        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Transferts.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<string> GetVendeurs()
        {
            using (Context context = new Context())
            {
                try
                {
                    var result = context.Transferts.Select(v => v.Vendeur).Distinct();

                    var vendeurs = from b in context.Transferts
                                   orderby b.Vendeur ascending
                                   
                                   select b
                                   ;
                    return result.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Transfert> Search(string keywords, DateTime dateDebut, DateTime dateFin)
        {
            using (Context context = new Context())
            {
                try
                {
                    var transferts = from b in context.Transferts
                                 orderby b.Id descending
                                 
                                 where (((b.Client.Contains(keywords)
                                    || (b.Articles.Contains(keywords))
                                    || (b.Agence.Contains(keywords))
                                    || (b.Contact.Contains(keywords))
                                    || (b.NoteInterne.Contains(keywords))
                                    || (b.Vendeur.Contains(keywords))
                                    )
                                 && (b.Date >= dateDebut)
                                 && (b.Date <= dateFin))
                                 )
                                 
                                 select b;
                    return transferts.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int? Create(Transfert Transfert)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Transferts.Add(Transfert);
                    context.SaveChanges();
                    int? id = Transfert.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Delete(Transfert Transfert)
        {
            using (Context context = new Context())
            {

                try
                {
                    context.Transferts.Attach(Transfert);
                    context.Transferts.Remove(Transfert);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Transfert GetTransfertById(int ID)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Transferts.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

        public int? Update(Transfert Transfert)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Transferts.Attach(Transfert);
                    // Très important, signifier le fait que l'entité a été modifiée.
                    context.Entry(Transfert).State = EntityState.Modified;
                    context.SaveChanges();
                    int? id = Transfert.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
