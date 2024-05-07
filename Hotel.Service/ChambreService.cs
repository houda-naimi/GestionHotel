using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class ChambreService
    {
        List<Client> clients = new List<Client>();
        private readonly HotelContext ctx;

        public ChambreService(HotelContext context)
        {
            ctx = new HotelContext();
        }
        public List<Chambre> GetListChambre()
        {
            return ctx.Chambres.ToList();
        }
        public void AjoutChambre(Chambre c)
        {
            ctx.Chambres.Add(c);
            ctx.SaveChanges();
        }
        public void ModifierChambre(Chambre ch)
        {
            // Récupérer la chambre existante depuis la base de données
            Chambre existingCh = ctx.Chambres.FirstOrDefault(c => c.IdCh == ch.IdCh);

            if (existingCh != null)
            {
                existingCh.TypeChambre = ch.TypeChambre;
                existingCh.PrixParJour = ch.PrixParJour;

                ctx.SaveChanges();
            }
        }

        public void SupprimerChambre(int chId)
        {
            Chambre chambreToDelete = ctx.Chambres.FirstOrDefault(c => c.IdCh == chId);
            if (chambreToDelete != null)
            {
                ctx.Chambres.Remove(chambreToDelete);
                ctx.SaveChanges();
            }
        }

        public Chambre GetChambre(int chId)
        {
            return ctx.Chambres.FirstOrDefault(c => c.IdCh == chId);
        }
    }
}
