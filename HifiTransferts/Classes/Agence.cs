using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HifiTransferts.Classes
{
    public class Agence
    {
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public bool Actif { get; set; }

        public string FullName => $"{Numero} {Nom}";
        
    }

    
}
