using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HifiTransferts.DTO
{
    public class AgenceTransfert
    {
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
        [Column("ID_TRANSFERT")]
        public int IdTransfert { get; set; }
        [Column("ID_AGENCE")]
        public int IdAgence { get; set; }
    }
}
