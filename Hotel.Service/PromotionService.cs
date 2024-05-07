using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class PromotionService
    {
        private readonly HotelContext ctx;

        public PromotionService(HotelContext context)
        {
            ctx = context;
        }

        public List<Promotion> GetListPromo()
        {
            return ctx.Promotions.ToList();
        }

        public void AjoutPromotion(Promotion p)
        {
            ctx.Promotions.Add(p);
            ctx.SaveChanges();
        }

        public void ModifierPromo(Promotion promotion)
        {
            Promotion existingPromo = ctx.Promotions.FirstOrDefault(c => c.idPromotion == promotion.idPromotion);

            if (existingPromo != null)
            {
                existingPromo.TypePromotion = promotion.TypePromotion;
                existingPromo.Remise = promotion.Remise;

                ctx.SaveChanges();
            }
        }

        public void SupprimerPromotion(int promoId)
        {
            Promotion promotionToDelete = ctx.Promotions.FirstOrDefault(c => c.idPromotion == promoId);
            if (promotionToDelete != null)
            {
                ctx.Promotions.Remove(promotionToDelete);
                ctx.SaveChanges();
            }
        }

        public Promotion GetPromotion(int promoId)
        {
            return ctx.Promotions.FirstOrDefault(c => c.idPromotion == promoId);
        }
    }
}
