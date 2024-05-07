using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Disponibilite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDispd { get; set; }
        public Etat Etat {  get; set; }
        public DateTime DateDebutDispo {  get; set; }
        public DateTime DateFinDispo { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Chambre Chambre { get; set; }

        public Disponibilite(Etat etat, DateTime dateDebutDispo, DateTime dateFinDispo)
        {
            Etat = etat;
            DateDebutDispo = dateDebutDispo;
            DateFinDispo = dateFinDispo;
        }
    }
}
