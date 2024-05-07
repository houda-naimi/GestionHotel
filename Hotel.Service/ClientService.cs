using Hotel.Data;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class ClientService
    {
        private readonly HotelContext ctx;
        List<Client> clients = new List<Client>();
        public ClientService(HotelContext context)
        {
            ctx = context;
        }

        public List<Client> getListClient()
        {
            //var ListClient = ctx.Clients.ToList();
            // clients.AddRange(ctx.Clients);
            //return clients;
            return ctx.Clients.ToList();
        }
        public void AjoutClient(Client c)
        {
            ctx.Clients.Add(c);
            ctx.SaveChanges();
        }
        public void ModifierClient(Client client)
        {
            // Récupérer le client existant depuis la base de données
            Client existingClient = ctx.Clients.FirstOrDefault(c => c.IdClt == client.IdClt);

            if (existingClient != null)
            {
                // Mettre à jour les propriétés du client existant avec les nouvelles valeurs
                existingClient.Nom = client.Nom;
                existingClient.Prenom = client.Prenom;
                existingClient.NumTel = client.NumTel;
                existingClient.Email = client.Email;
                existingClient.Adresse = client.Adresse;

                // Sauvegarder les modifications dans la base de données
                ctx.SaveChanges();
            }
        }
        public void SupprimerClient(int clientId)
        {
            // Récupérer le client à supprimer
            Client clientToDelete = ctx.Clients.FirstOrDefault(c => c.IdClt == clientId);

            if (clientToDelete != null)
            {
                // Supprimer le client de la base de données
                ctx.Clients.Remove(clientToDelete);
                ctx.SaveChanges();
            }
        }
        public Client GetClient(int clientId)
        {
            return ctx.Clients.FirstOrDefault(c => c.IdClt == clientId);
        }
    }
}
