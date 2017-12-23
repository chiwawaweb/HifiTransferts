﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HifiTransferts.DTO;

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

        public List<Transfert> Search(string keywords)
        {
            using (Context context = new Context())
            {
                try
                {
                    var transferts = from b in context.Transferts
                                 orderby b.Id descending
                                 /*
                                 where (((b.InfoClient1.Contains(keywords)
                                    || (b.InfoClient2.Contains(keywords))
                                    || (b.InfoClient3.Contains(keywords))
                                    || (b.InfoClient4.Contains(keywords)))
                                 && (b.Date >= dateDebut)
                                 && (b.Date <= dateFin))
                                 || b.Numero.Equals(keywords))
                                 */
                                 select b;
                    return transferts.ToList();
                }
                catch
                {
                    throw;
                }
            }

        }
    }
}
