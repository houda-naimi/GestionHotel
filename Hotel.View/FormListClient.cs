using Hotel.Data;
using Hotel.Domain.Entities;
using Hotel.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View
{
    public partial class FormListClient : Form
    {
        private readonly ClientService cltService;
        private readonly ReservationService rsService;
        public FormListClient(ClientService cltService, ReservationService rsService)
        {

            InitializeComponent();
            this.cltService = cltService;
            this.rsService = rsService;
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionHotelDataSet);

        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dB_GestionHotelDataSet2.Reservations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationsTableAdapter.Fill(this.dB_GestionHotelDataSet2.Reservations);
            // TODO: cette ligne de code charge les données dans la table 'gestionHotelDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.gestionHotelDataSet.Clients);

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Client> listcl = cltService.getListClient();

            clientsDataGridView.DataSource = listcl;

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            var clService = new ClientService(context);
            var promoService = new PromotionService(context);

            var rsService = new ReservationService(context);
            FormReservation formChambre = new FormReservation(rsService, clService, chService, promoService);
            formChambre.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            var cltService = new ClientService(context);
            Dashboard2 ds = new Dashboard2(cltService, chService);
            ds.Show();
            this.Hide();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            List<Client> listcl = cltService.getListClient();
            Client client = listcl.Find(c => c.Email == txtEmail.Text);
            if (client != null)
            {
                // Le client a été trouvé
                MessageBox.Show("Un client avec cet email existe déjà. Veuillez utiliser un autre email.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Créer un nouveau client à partir des données saisies dans le formulaire
                Client newClient = new Client
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    NumTel = Convert.ToInt32(txtTel.Text),
                    Email = txtEmail.Text,
                    Adresse = txtAdresse.Text
                };

                // Ajouter le client à la base de données
                cltService.AjoutClient(newClient);


                actualiser();
            }

        }

        public void getListClient()
        {
            List<Client> listcl = cltService.getListClient();

            clientsDataGridView.DataSource = listcl;
        }

        int a;
        /*private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;

            DataGridViewRow row = clientsDataGridView.Rows[a];

            // Récupérer les valeurs des cellules de la ligne sélectionnée
            //   int clientId = (int)row.Cells["IdClt"].Value;
            string nom = row.Cells[1].Value.ToString();
            string prenom = row.Cells[2].Value.ToString();
            int numTel = (int)row.Cells[3].Value;
            string email = row.Cells[4].Value.ToString();
            string adresse = row.Cells[5].Value.ToString();

            // Afficher les valeurs dans les TextBox correspondants
            // txtClientId.Text = clientId.ToString();
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtTel.Text = numTel.ToString();
            txtEmail.Text = email;
            txtAdresse.Text = adresse;

        }
        */
          private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;

            DataGridViewRow row = clientsDataGridView.Rows[a];

            // Récupérer les valeurs des cellules de la ligne sélectionnée
            //   int clientId = (int)row.Cells["IdClt"].Value;
            //
            int clientId = (int)row.Cells["IdClt"].Value;
            //
            string nom = row.Cells[1].Value.ToString();
            string prenom = row.Cells[2].Value.ToString();
            int numTel = (int)row.Cells[3].Value;
            string email = row.Cells[4].Value.ToString();
            string adresse = row.Cells[5].Value.ToString();

            // Afficher les valeurs dans les TextBox correspondants
            // txtClientId.Text = clientId.ToString();
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtTel.Text = numTel.ToString();
            txtEmail.Text = email;
            txtAdresse.Text = adresse;

            // Afficher les réservations pour le client sélectionné
            var reservations = rsService.GetReservationsForClient(clientId);
            reservationsDataGridView.DataSource = reservations;

        }


        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            List<Client> listcl = cltService.getListClient();
            Client client = listcl.Find(c => c.Email == txtEmail.Text);

            // Créer un nouveau client à partir des données saisies dans le formulaire
            Client newClient = new Client
            {
                IdClt = client.IdClt,
                Nom = txtNom.Text,
                Prenom = txtPrenom.Text,
                NumTel = Convert.ToInt32(txtTel.Text),
                Email = txtEmail.Text,
                Adresse = txtAdresse.Text
            };

            // Ajouter le client à la base de données
            cltService.ModifierClient(newClient);

            actualiser();



        }

        public void actualiser()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtAdresse.Clear();


            getListClient();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            List<Client> listcl = cltService.getListClient();
            Client client = listcl.Find(c => c.Email == txtEmail.Text);
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   

                    // Appelez la méthode de service pour supprimer le client
                    cltService.SupprimerClient(client.IdClt);

                    // Actualisez l'affichage des clients dans le DataGridView
                    actualiser();
                }
            }

        private void btnPromotion_Click(object sender, EventArgs e)
        {

            var context = new HotelContext();

            var promoService = new PromotionService(context);
            FormPromotion formChambre = new FormPromotion(promoService);
            formChambre.Show();
            this.Hide();
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();

            var factureService = new FatureService(context);
            FormFacture formChambre = new FormFacture(factureService);
            formChambre.Show();
            this.Hide();
        }

        private void btnCltt_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var cltService = new ClientService(context);
            var rsService = new ReservationService(context);
            FormListClient formListeClient = new FormListClient(cltService, rsService);
            formListeClient.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();

            var chambreService = new ChambreService(context);
            FormmChambre formChambre = new FormmChambre(chambreService);
            formChambre.Show();
            this.Hide();

        }

        
        
private void reservationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
   if (e.RowIndex >= 0) // Vérifier si une ligne valide est cliquée
   {
       DataGridViewRow row = clientsDataGridView.Rows[e.RowIndex];

       // Récupérer l'ID du client sélectionné
       int clientId = (int)row.Cells["IdClt"].Value;

       // Afficher les réservations pour le client sélectionné
       var reservations = rsService.GetReservationsForClient(clientId);
       reservationsDataGridView.DataSource = reservations;
   }
}
    }
}
