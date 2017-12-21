using System;
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
    }
}
