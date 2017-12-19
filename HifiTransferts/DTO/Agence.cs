using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HifiTransferts.DTO
{
    public class Agence
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
        [Column("NUMERO")]
        public int Numero { get; set; }
        [Column("NOM")]
        public string Nom { get; set; }
        [Column("ACTIF")]
        public bool Actif { get; set; }
    }
}
