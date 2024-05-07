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
    public partial class FormChambreControl : Form
    {
        private readonly ChambreService chService;
        public FormChambreControl(ChambreService chService)
        {
            InitializeComponent();
            this.chService = chService;
           // comboBoxType.DataSource = Enum.GetValues(typeof(TypeChambre));
        }

        private void btnAjouterChambre_Click(object sender, EventArgs e)
        {
            /*int indexSelectionne = comboBoxType.SelectedIndex;
             TypeChambre typeChambre = (TypeChambre)indexSelectionne;

                // Utiliser la valeur de typeChambre comme nécessaire
           
            //TypeChambre typeChambre = (TypeChambre)comboBoxType.SelectedItem;
            float prixParJour;
            if (!float.TryParse(txtPrixAjouté.Text, out prixParJour))
            {
                MessageBox.Show("Veuillez entrer un prix valide.");
                return;
            }
            // Chambre nouvelleChambre = new Chambre(typeChambre, prixParJour);
            chService.addChambre(typeChambre, prixParJour);
            if (chService.addChambre(typeChambre, prixParJour))
            {
                MessageBox.Show("added");
            }*/
        }

        private void tabPageAjouterChambre_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            var cltService = new ClientService(context);
            Dashboard2 ds = new Dashboard2(cltService, chService);
            ds.Show();
            this.Hide();
        }

        private void FormChambreControl_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
