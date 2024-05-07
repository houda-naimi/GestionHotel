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
    public partial class ChambreControl : UserControl
    {

        private readonly ChambreService chService ;
        private readonly HotelContext ctx;
        public ChambreControl(ChambreService chService)
        {
            InitializeComponent();
            this.chService = new ChambreService(ctx);
            comboBoxType.DataSource = Enum.GetValues(typeof(TypeChambre));
        }


        public void ModifierVisibiliteTabControl(bool visible)
        {
            tabControlChambre.Visible = visible;
            
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

        private void ChambreControl_Load(object sender, EventArgs e)
        {

        }
    }
}
