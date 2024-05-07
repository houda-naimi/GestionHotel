using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Chambre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCh {  get; set; }
        public TypeChambre TypeChambre { get; set; }
        public float PrixParJour { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public Chambre()
        {
        }

        public Chambre(TypeChambre typeChambre, float prixParJour)
        {
            TypeChambre = typeChambre;
            PrixParJour = prixParJour;
        }
    }
}
