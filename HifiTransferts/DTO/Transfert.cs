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
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Column("CONTACT")]
        public string Contact { get; set; }
        [Column("REMARQUE")]
        public string Remarque { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }

        // les articles du transfert
        public ICollection<Article> articles { get; set; }
    }
}
