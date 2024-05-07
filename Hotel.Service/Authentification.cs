using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
        public class Authentification
        {
            private readonly HotelContext _context;

            public Authentification(HotelContext context)
            {
                _context = context;
            }

            public bool Authenticate(string userName, string password)
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == userName && u.Password == password);
                return user != null;
            }
        }
    
}
