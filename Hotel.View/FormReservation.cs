using Hotel.Data;
using Hotel.Domain.Entities;
using Hotel.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View
{
    public partial class FormReservation : Form
    {
        private readonly ReservationService rs;
        private readonly ClientService clt;
        private readonly ChambreService chambreService;
        private readonly PromotionService promoService;

        private HotelContext hotelContext;
        public FormReservation(ReservationService rs, ClientService clt, ChambreService chambreService, PromotionService promoService)
        {
            InitializeComponent();
            this.rs = rs;
            this.clt = clt;
            this.chambreService = chambreService;
            this.promoService = promoService;
            this.hotelContext = new HotelContext();
            this.getListClient1();
            this.getListPromotion();
            this.getListReservation();


        }

        public void getListClient1()
        {
            List<Client> listClient = clt.getListClient();
            //  MessageBox.Show(listClient.Count + "");
            // Créer une liste de noms complets (nom + prénom) pour affichage dans la ComboBox
            List<string> nomsComplets = new List<string>();
            foreach (Client client in listClient)
            {
                string nomComplet = client.Nom + " " + client.Prenom;
                nomsComplets.Add(nomComplet);
            }
            comboBoxClient.DataSource = nomsComplets;
            //comboBoxClient.DisplayMember = "Nom" + "Prenom";
        }

        public void getListReservation()
        {

            List<Reservation> listReservation = rs.getListReservation();    
            reservationsDataGridView.DataSource = listReservation;
        }

        public void getListPromotion()
        {
            List<Promotion> listPromotion = promoService.GetListPromo();
            //  MessageBox.Show(listClient.Count + "");
            // Créer une liste de noms complets (nom + prénom) pour affichage dans la ComboBox
          
            comboBoxPromo.DataSource = listPromotion;
            comboBoxPromo.DisplayMember = "TypePromotion";
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dB_GestionHotelDataSet2.Reservations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationsTableAdapter.Fill(this.dB_GestionHotelDataSet2.Reservations);

            // TODO: cette ligne de code charge les données dans la table 'gestionHotelDataSet.Chambres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambresTableAdapter.Fill(this.gestionHotelDataSet.Chambres);

        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          //  comboBoxClient.DisplayMember = "Nom";

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            var cltService = new ClientService(context);
            Dashboard2 ds = new Dashboard2(cltService, chService);
            ds.Show();
            this.Hide();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {

            var context = new HotelContext();

            var promoService = new PromotionService(context);
            FormPromotion formChambre = new FormPromotion(promoService);
            formChambre.Show();
            this.Hide();
        }

        private void btnFcature_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();

            var factureService = new FatureService(context);
            FormFacture formChambre = new FormFacture(factureService);
            formChambre.Show();
            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            FormmChambre formChambre = new FormmChambre(chService);
            formChambre.Show();
            this.Hide();
        }

        private void chambresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionHotelDataSet);

        }
       

        private void btnChercher_Click(object sender, EventArgs e)
        {
            String dateDebut = dateTimePickerDebut.Value.ToString("yyyy-MM-dd"); ;
            String dateFin = dateTimePickerFin.Value.ToString("yyyy-MM-dd");
            List<Chambre> chambresDispo =  chambreService.GetListChambre();

            List<Reservation> reservations = rs.getListReservation();

            // Parcourir chaque chambre
            foreach (Chambre chambre in chambresDispo.ToList())
            {
                // Vérifier si la chambre est réservée pour la période spécifiée
                foreach (Reservation reservation in reservations)
                {
                    if (dateDebut == reservation.DateDebutRes.ToString("yyyy-MM-dd") && dateDebut == reservation.DateFinRes.ToString("yyyy-MM-dd")) 
                       // ||(dateFin >= reservation.DateDebutRes && dateFin <= reservation.DateFinRes) ||
                        //(dateDebut <= reservation.DateDebutRes && dateFin >= reservation.DateFinRes))
                    {
                      
                            // Si la chambre est réservée, la retirer de la liste des chambres disponibles
                            chambresDispo.Remove(chambre);
                       
                        // Si la chambre est réservée, la retirer de la liste des chambres disponibles
                        // chambresDispo.RemoveAt(chambre.IdCh);
                        break; // Pas besoin de vérifier les autres réservations pour cette chambre
                    }
                }
            }

            // Afficher les chambres disponibles dans le DataGridView
            chambresDataGridView.DataSource = chambresDispo;


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

     /*   private void btnAjouter_Click(object sender, EventArgs e)
        {
            /* if (comboBoxClient.SelectedIndex != -1)
             {

                 // Création de la nouvelle réservation
                 Reservation newReservation = new Reservation
                 (
                     DateTime.Now,
                     dateTimePickerDebut.Value,
                     dateTimePickerFin.Value,
                     int.Parse(txtNbAdult.Text),
                     int.Parse(txtNbEnfant.Text)
                 );

                 // Récupération du client sélectionné dans la combobox
                 Client selectedClient = clt.getListClient()[comboBoxClient.SelectedIndex];
                 newReservation.Client = selectedClient;

                 // Récupération de la promotion sélectionnée dans la combobox
                 Promotion selectedPromo = promoService.GetListPromo()[comboBoxPromo.SelectedIndex];
                 newReservation.Promotion = selectedPromo;

                 // Ajout de la chambre sélectionnée dans la DataGridView
                 if (chambresDataGridView.SelectedRows.Count > 0)
                 {
                     DataGridViewRow selectedRow = chambresDataGridView.SelectedRows[0];
                     DataGridViewCell cell = selectedRow.Cells[0]; // Remplacez "idChDataGridViewTextBoxColumn" par le nom de la colonne contenant l'ID de la chambre
                     if (cell != null && cell.Value != null)
                     {
                         int chambreId = (int)cell.Value;
                         Chambre selectedChambre = chambreService.GetChambre(chambreId); // Supposant que vous avez une méthode pour récupérer une chambre par ID
                        List<Chambre> addedChambre = new List<Chambre>();
                         addedChambre.Add(selectedChambre);
                         newReservation.Chambres = addedChambre;
                     }
                     else
                     {
                         MessageBox.Show("Impossible de récupérer les détails de la chambre sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return;
                     }
                 }
                 else
                 {
                     MessageBox.Show("Veuillez sélectionner une chambre.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return; // Sortie de la méthode si aucune chambre n'est sélectionnée
                 }
                 rs.AjoutReservation(newReservation);

                 MessageBox.Show("Réservation ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 //actualiser();
             }
             else
             {
                 MessageBox.Show("Veuillez sélectionner un type de promotion.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

             this.getListReservation();*/

        /*
            if (comboBoxClient.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxPromo.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une promotion.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimePickerDebut.Value >= dateTimePickerFin.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chambresDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une chambre.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Création de la nouvelle réservation
            Reservation newReservation = new Reservation
            (
                DateTime.Now,
                dateTimePickerDebut.Value,
                dateTimePickerFin.Value,
                int.Parse(txtNbAdult.Text),
                int.Parse(txtNbEnfant.Text)
            );

            // Récupération du client sélectionné dans la combobox
            int selectedClientId = (int)comboBoxClient.SelectedValue;
            Client selectedClient = clt.GetClient(selectedClientId);
            newReservation.Client = selectedClient;

            // Récupération de la promotion sélectionnée dans la combobox
            int selectedPromoId = (int)comboBoxPromo.SelectedValue;
            Promotion selectedPromo = promoService.GetPromotion(selectedPromoId);
            newReservation.Promotion = selectedPromo;

            // Ajout des chambres sélectionnées dans la DataGridView à la réservation
           /* foreach (DataGridViewRow row in chambresDataGridView.SelectedRows)
            {
                int chambreId = (int)row.Cells["IdCh"].Value; // Assurez-vous que le nom de la colonne est correct
                newReservation.Chambres.Add(IdCh);
            }*/

            // Ajout de la réservation
          /*  rs.AjoutReservation(newReservation);

            MessageBox.Show("Réservation ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //actualiser();
            this.getListReservation();



        } 
*/
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxPromo.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une promotion.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimePickerDebut.Value >= dateTimePickerFin.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chambresDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une chambre.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Récupération de l'ID du client sélectionné dans la ComboBox
            int selectedClientId = Convert.ToInt32(comboBoxClient.SelectedValue);

            // Récupération de l'ID de la promotion sélectionnée dans la ComboBox
            int selectedPromoId = Convert.ToInt32(comboBoxPromo.SelectedValue);

            // Création de la nouvelle réservation avec les ID récupérés
            Reservation newReservation = new Reservation
            {
                DateRes = DateTime.Now,
                DateDebutRes = dateTimePickerDebut.Value,
                DateFinRes = dateTimePickerFin.Value,
                NbAdulte = int.Parse(txtNbAdult.Text),
                NbEnfant = int.Parse(txtNbEnfant.Text),
                Client_IdClt = selectedClientId, // Utilisation de la clé étrangère du client
                Promotion_idPromotion = selectedPromoId, // Utilisation de la clé étrangère de la promotion
                                               // Les autres propriétés peuvent être initialisées ici si nécessaire
            };

            // Ajout de la réservation à la base de données
            rs.AjoutReservation(newReservation);

            MessageBox.Show("Réservation ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.getListReservation();
        }

    }
}
