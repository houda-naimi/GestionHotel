using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Reservation
    {
        /*public Reservation( DateTime dateRes, DateTime dateDebutRes, DateTime dateFinRes, int nbAdulte, int nbEnfant)
        {
           
            DateRes = dateRes;
            DateDebutRes = dateDebutRes;
            DateFinRes = dateFinRes;
            NbAdulte = nbAdulte;
            NbEnfant = nbEnfant;
        }
        */
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRes { get; set; }
        public DateTime DateRes { get; set;}
        public DateTime DateDebutRes { get; set; }
        public DateTime DateFinRes { get; set; }
        public int NbAdulte { get; set; }
        public int NbEnfant { get; set; }
       // public virtual List<Chambre> Chalbres { get; set;}
        public virtual Chambre Chambre { get; set;}
        public virtual Promotion Promotion { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("Facture")]
        public int? FactureId { get; set; } // Clé étrangère

        public virtual Facture Facture { get; set; }
        public int Client_IdClt { get; set; }
        public int Promotion_idPromotion { get; set; }

        public Reservation()
        {
        }
    }
}
