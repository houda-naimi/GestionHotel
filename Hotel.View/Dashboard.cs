using Hotel.Data;
using Hotel.Domain.Entities;
using Hotel.Service;
using Hotel.View.ClientControl;
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
    public partial class Dashboard : Form
    {
        private readonly ChambreService chService;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var cltService = new ClientService(context);
            var rsService = new ReservationService(context);
            FormListClient formListeClient = new FormListClient(cltService, rsService);
            formListeClient.Show();
            this.Hide();
        }

        private void btnChambre_Click(object sender, EventArgs e)
        {

            var context = new HotelContext();
            var chService = new ChambreService(context);
            FormChambreControl formChambre = new  FormChambreControl(chService);
            formChambre.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //ChambreControl chambre = new ChambreControl(chService);
            // chambre.Show();
            //chambre.Visible = false;
            // chambreControl.Show();
           // clientControl2.Hide();
            // chambreControl.Show();
            ChambreControl chambreControl = new ChambreControl(chService);
            chambreControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
           // chambreControl.Dock = DockStyle.Fill; // Assurez-vous que le contrôle remplit toute la zone client du formulaire
            this.Controls.Add(chambreControl); // Ajoutez le contrôle au formulaire principal

        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var authService = new Authentification(context);
            DialogResult result = MessageBox.Show("Est ce que vous etes sure ?","Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                this.Close();
                FormLogin login = new FormLogin(authService, context);
                login.Show();

            }

        }

        private void btnCltt_Click(object sender, EventArgs e)
        {
            // ClientControl x = new ClientControl();
            // ChambreControl chambre = new ChambreControl();
            
            // chambre.Visible = false;
            // chambre.Show();
            // ChambreControl x = new ChambreControl();
            // x.ModifierVisibiliteTabControl(false);
            //chambreControl.Hide();
           // clientControl2.Show();

           

        }

        private void clientControl2_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {

        }
    }
}
