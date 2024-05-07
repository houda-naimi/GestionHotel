using Hotel.Data;
using Hotel.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View
{
    public partial class FormLogin : Form
    {
        private readonly Authentification authService;
        private readonly HotelContext context;

        public FormLogin(Authentification authService, HotelContext context)
        {
            InitializeComponent();
            this.authService = authService;
            this.context = context;

            // Vérifiez si la base de données existe, sinon, créez-la
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
        }

        private void btnCnx_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPwd.Text;

            // Authentifier l'utilisateur en utilisant le service d'authentification
            if (authService.Authenticate(userName, password))
            {
                // Authentification réussie
                MessageBox.Show("Connexion réussie !");
                // Effectuez les actions nécessaires après l'authentification
                var context = new HotelContext();
                var chService = new ChambreService(context);
                var cltService = new ClientService(context);
                Dashboard2 ds = new Dashboard2(cltService, chService);
                ds.Show();
                this.Hide();
            }
            else
            {
                // Authentification échouée
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }



}

