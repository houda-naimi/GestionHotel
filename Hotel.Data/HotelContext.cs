using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext()
           : base("Name=DefaultConnection")
        { 
            Database.SetInitializer<HotelContext>(new HotelContextInitializer()); 

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
       // public DbSet<Disponibilite> Disponibilites { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOptional(r => r.Facture) // Une réservation peut avoir une facture associée (optionnelle)
                .WithRequired(f => f.Reservation); // Une facture doit avoir une réservation associée

            base.OnModelCreating(modelBuilder);
        }
    }

    public class HotelContextInitializer :
   DropCreateDatabaseIfModelChanges<HotelContext>
    {
        protected override void Seed(HotelContext context)
        {

        }

    }
}
