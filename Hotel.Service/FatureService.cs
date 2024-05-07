using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class FatureService
    {
        private readonly HotelContext ctx;

        public FatureService(HotelContext context)
        {
            ctx = context;
        }

        public List<Facture> GetListFacture()
        {
            return ctx.Factures.ToList();
        }

        public void AjoutFacture(Facture c)
        {
            ctx.Factures.Add(c);
            ctx.SaveChanges();
        }

        public void ModifierFacture(Facture ch)
        {
            // Récupérer la chambre existante depuis la base de données
            Facture existingCh = ctx.Factures.FirstOrDefault(c => c.IdFacture == ch.IdFacture);

            if (existingCh != null)
            {
                existingCh.DateFacture = ch.DateFacture;
                existingCh.Prix = ch.Prix;

                ctx.SaveChanges();
            }
        }

        public void SupprimerFacture(int chId)
        {
            Chambre FactureToDelete = ctx.Chambres.FirstOrDefault(c => c.IdCh == chId);
            if (FactureToDelete != null)
            {
                ctx.Chambres.Remove(FactureToDelete);
                ctx.SaveChanges();
            }
        }

        public Facture GetFacture(int id)
        {
            return ctx.Factures.FirstOrDefault(c => c.IdFacture == id);
        }
    }
}
