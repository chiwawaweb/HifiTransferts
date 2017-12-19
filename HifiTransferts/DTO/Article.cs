using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HifiTransferts.DTO
{
    public class Article
    {
        // data
        [Key]
        [Column("ID")]
        public int? Id { get; set; }
        [Column("REFERENCE")]
        public string Reference { get; set; }
        [Column("QTE")]
        public int Qte { get; set; }
        [Column("REMARQUE")]
        public string Remarque { get; set; }
        [Required]
        [Column("AGENCE_ID")]
        public int AgenceId { get; set; }
        [Required]
        [Column("TRANSFERT_ID")]
        public int TransfertId { get; set; }
        [Required]
        [ForeignKey("TransfertId")]
        public virtual Transfert Transferts { get; set; }
        [Required]
        [ForeignKey("TransfertId")]
        public virtual Agence Agences { get; set; }
    }
}
