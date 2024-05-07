using Hotel.Data;
using Hotel.Domain.Entities;
using Hotel.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View
{
    public partial class FormPromotion : Form
    {
        private readonly PromotionService promoService;
        public FormPromotion(PromotionService promoService )
        {
            InitializeComponent();
            this.promoService = promoService;
            comboBoxTypePromo.DataSource = Enum.GetValues(typeof(TypePromo));
            RefreshPromoList();
        }

        private void FormPromotion_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionHotelDataSet.Promotions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.promotionsTableAdapter.Fill(this.gestionHotelDataSet.Promotions);

        }

        private void promotionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.promotionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionHotelDataSet);

        }
        private void promotionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Promotion> listpromo = promoService.GetListPromo();

            promotionsDataGridView.DataSource = listpromo;
        }


        private void RefreshPromoList()
        {
            List<Promotion> listpromo = promoService.GetListPromo();
            promotionsDataGridView.DataSource = promoService.GetListPromo();
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            if (comboBoxTypePromo.SelectedIndex != -1)
            {
                
                Promotion newPromotion = new Promotion
                (
                    (TypePromo)comboBoxTypePromo.SelectedIndex,
                   float.Parse(txtRemise.Text)
                );
                promoService.AjoutPromotion(newPromotion);
                actualiser();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un type de promotion.", "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void getListPromot()
        {
            List<Promotion> listpromo = promoService.GetListPromo();
            promotionsDataGridView.DataSource = listpromo;
        }

        public void actualiser()
        {
            txtRemise.Clear();


            getListPromot();

        }
      
       

        /*private void promotionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
           /* DataGridViewRow row = promotionsDataGridView.Rows[e.RowIndex];

            // Récupérer les valeurs des cellules de la ligne sélectionnée
            //   int clientId = (int)row.Cells["IdClt"].Value;
            //TypePromo type = row.Cells[1].Value.ToString();
            String remise = row.Cells[2].Value.ToString();
            

            // Afficher les valeurs dans les TextBox correspondants
            // txtClientId.Text = clientId.ToString();
            txtRemise.Text = remise;

            if (e.RowIndex >= 0 && e.RowIndex < promotionsDataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = promotionsDataGridView.Rows[e.RowIndex];

                // Récupérer les valeurs des cellules de la ligne sélectionnée
                TypePromo typePromotion = (TypePromo)selectedRow.Cells[0].Value; // Assurez-vous d'ajuster l'index de la colonne selon votre structure de données
                string remise = selectedRow.Cells[1].Value.ToString(); // Supposant que la remise est stockée dans la deuxième colonne

                // Afficher les valeurs dans les TextBox correspondants
                comboBoxTypePromo.SelectedIndex = (int)typePromotion;
                txtRemise.Text = remise;
            }
        }*/

        private void btnModifier_Click(object sender, EventArgs e)
        {


            if (promotionsDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = promotionsDataGridView.SelectedRows[0].Index;
                Promotion selectedPromotion = (Promotion)promotionsDataGridView.Rows[rowIndex].DataBoundItem;

                comboBoxTypePromo.SelectedIndex = (int)selectedPromotion.TypePromotion;
                txtRemise.Text = selectedPromotion.Remise.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une promotion à modifier.", "Aucune promotion sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (promotionsDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = promotionsDataGridView.SelectedRows[0].Index;
                Promotion selectedPromotion = (Promotion)promotionsDataGridView.Rows[rowIndex].DataBoundItem;
                selectedPromotion.TypePromotion = (TypePromo)comboBoxTypePromo.SelectedIndex;
                selectedPromotion.Remise = float.Parse(txtRemise.Text);
                promoService.ModifierPromo(selectedPromotion);
                RefreshPromoList();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une promotion à modifier.", "Aucune promotion sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (promotionsDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = promotionsDataGridView.SelectedRows[0].Index;
                Promotion selectedPromotion = (Promotion)promotionsDataGridView.Rows[rowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette promotion ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    promoService.SupprimerPromotion(selectedPromotion.idPromotion);
                    RefreshPromoList();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une promotion à supprimer.", "Aucune promotion sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFacture_Click(object sender, EventArgs e)
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

        private void promotionsBindingNavigator_RefreshItems(object sender, EventArgs e)
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
    }
}
