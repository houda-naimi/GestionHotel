using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Entities
{
    public class Client
    {
        public Client(string nom, string prenom, int numTel, string email, string adresse)
        {
            
            Nom = nom;
            Prenom = prenom;
            NumTel = numTel;
            Email = email;
            Adresse = adresse;
        }
        public Client()
        {
           
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClt { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NumTel { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public virtual List<Reservation> Reservations {  get; set; }
    }
}
