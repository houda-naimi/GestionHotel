using Hotel.Data;
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
    public partial class Dashboard2 : Form
    {
        private readonly ClientService clt;
        private readonly ChambreService chambreService;

        public Dashboard2(ClientService clt, ChambreService chambreService)
        {
            InitializeComponent();  
            this.clt = clt;
            this.chambreService = chambreService;

            // Récupérer le nombre de clients
            int nbClient = clt.getListClient().Count();

            // Mettre à jour le contenu de la Label
            label2.Text = nbClient.ToString();

            // Mettre à jour le contenu de la Label
            label4.Text = chambreService.GetListChambre().Count().ToString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

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
            var chService = new ChambreService(context);
            FormmChambre formChambre = new FormmChambre(chService);
            formChambre.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            var clService = new ClientService(context);
            var promoSer = new PromotionService(context);

            var rsService = new ReservationService(context);
            FormReservation formChambre = new FormReservation(rsService  , clService ,chService, promoSer);
            formChambre.Show();
            this.Hide();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {
            int nbClient = clt.getListClient().Count();
            this.Text= nbClient.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();

            var authenS = new Authentification(context);
            FormLogin form = new FormLogin(authenS , context);
            form.Show();
            this.Hide();
        }
    }
}
