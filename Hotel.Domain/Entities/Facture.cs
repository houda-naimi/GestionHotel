using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Facture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFacture { get; set; }
        public float Prix { get; set; }
        public DateTime DateFacture { get; set; }
        [ForeignKey("Reservation")]
        public int? ReservationId { get; set; } // Clé étrangère

        public virtual Reservation Reservation { get; set; }

        public Facture(float prix, DateTime dateFacture)
        {
            Prix = prix;
            DateFacture = dateFacture;
        }

        public Facture()
        {
        }
    }
}
