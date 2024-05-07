using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Promotion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPromotion { get; set; }
        public TypePromo TypePromotion { get; set; }
        public float Remise { get; set; }

        public Promotion(TypePromo typePromotion, float remise)
        {
           
            TypePromotion = typePromotion;
            Remise = remise;
        }

        public Promotion()
        {
        }
    }
}
