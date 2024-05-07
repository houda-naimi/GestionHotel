using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class ReservationService
    {
        private readonly HotelContext _context;
        public ReservationService(HotelContext context)
        {
            _context = context;
        }
        public List<Reservation> getListReservation()
        {
            //var ListClient = ctx.Clients.ToList();
            // clients.AddRange(ctx.Clients);
            //return clients;
            return _context.Reservations.ToList();
        }
        public void AjoutReservation(Reservation R)
        {
            _context.Reservations.Add(R);
            _context.SaveChanges(); 
        }

        public List<Reservation> GetReservationsForClient(int clientId)
        {
            return _context.Reservations.Where(r => r.Client.IdClt == clientId).ToList();
        }

    }
}
