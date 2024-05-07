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
    public partial class FormmChambre : Form
    {

        private Chambre selectedChambre;
        private readonly ChambreService ChService;
        public FormmChambre(ChambreService ChService)
        {
            InitializeComponent();
            this.ChService = ChService;
            RefreshChambreList();
            typeChambreComboBox.DataSource = Enum.GetValues(typeof(TypeChambre));
            chambresDataGridView.SelectionChanged += chambresDataGridView_SelectionChanged;
        }
        private void chambresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Chambre> listCh = ChService.GetListChambre();

            chambresDataGridView.DataSource = listCh;

        }
        private void RefreshChambreList()
        {
            List<Chambre> listCH = ChService.GetListChambre();
            chambresDataGridView.DataSource = ChService.GetListChambre();
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

        private void btnFacture_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();

            var factureService = new FatureService(context);
            FormFacture formChambre = new FormFacture(factureService);
            formChambre.Show();
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

        private void btnCltt_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var cltService = new ClientService(context);
            var rsService = new ReservationService(context);
            FormListClient formListeClient = new FormListClient(cltService, rsService);
            formListeClient.Show();
            this.Hide();
        }

        private void chambresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chambresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionHotelDataSet);

        }

        private void FormmChambre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionHotelDataSet.Chambres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambresTableAdapter.Fill(this.gestionHotelDataSet.Chambres);

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (typeChambreComboBox.SelectedIndex != -1)
            {
                Chambre newChambre = new Chambre
                {
                    TypeChambre = (TypeChambre)typeChambreComboBox.SelectedIndex,
                    PrixParJour = float.Parse(prixParJourTextBox.Text)
                };
                ChService.AjoutChambre(newChambre);
                RefreshChambreList();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type de promotion.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (selectedChambre != null)
            {
                selectedChambre.TypeChambre = (TypeChambre)typeChambreComboBox.SelectedIndex;
                selectedChambre.PrixParJour = float.Parse(prixParJourTextBox.Text);
                ChService.ModifierChambre(selectedChambre);
                RefreshChambreList();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une chambre à modifier.", "Aucune chambre sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (chambresDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = chambresDataGridView.SelectedRows[0].Index;
                Chambre selectedCh = (Chambre)chambresDataGridView.Rows[rowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette chambre ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ChService.SupprimerChambre(selectedCh.IdCh);
                    RefreshChambreList();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une promotion à supprimer.", "Aucune promotion sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void chambresDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (chambresDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = chambresDataGridView.SelectedRows[0].Index;
                selectedChambre = (Chambre)chambresDataGridView.Rows[rowIndex].DataBoundItem;

                // Afficher les détails de la chambre sélectionnée dans les champs
                typeChambreComboBox.SelectedIndex = (int)selectedChambre.TypeChambre;
                prixParJourTextBox.Text = selectedChambre.PrixParJour.ToString();
            }
            else
            {
                // Réinitialiser les champs si aucune ligne n'est sélectionnée
                selectedChambre = null;
                typeChambreComboBox.SelectedIndex = -1;
                prixParJourTextBox.Text = string.Empty;
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            FormmChambre formChambre = new FormmChambre(chService);
            formChambre.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
