using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HifiTransferts.DTO
{
    public class Transfert
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
    }
}
