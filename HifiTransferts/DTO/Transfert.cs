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
        public int Id { get; set; }
        [Column("DATE")]
        public DateTime Date { get; set; }
        [Required]
        [Column("VENDEUR")]
        public string Vendeur { get; set; }
        [Required]
        [Column("CLIENT")]
        public string Client { get; set; }
        [Column("STOCK")]
        public bool Stock { get; set; }
        [Required]
        [Column("AGENCE")]
        public string Agence { get; set; }
        [Required]
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("ARTICLES")]
        public string Articles { get; set; }
        [Column("CONTACT")]
        public string Contact { get; set; }
        [Column("REMARQUE")]
        public string Remarque { get; set; }
        [Column("ENVOYE")]
        public bool Envoye { get; set; }
        [Column("NOTE_INTERNE")]
        public string NoteInterne { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        [Column("UPDATED_AT")]
        public DateTime UpdatedAt { get; set; }
    }
}
