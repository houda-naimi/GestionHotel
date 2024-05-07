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
    public partial class FormFacture : Form
    {
        private readonly FatureService factureService;
        public FormFacture(FatureService factureService)
        {
            InitializeComponent();
            this.factureService = factureService;
            RefreshFactureList();
        }

        private void facturesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionHotelDataSet);

        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dB_GestionHotelDataSet2.Factures'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.facturesTableAdapter1.Fill(this.dB_GestionHotelDataSet2.Factures);
            // TODO: cette ligne de code charge les données dans la table 'gestionHotelDataSet.Factures'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.facturesTableAdapter.Fill(this.gestionHotelDataSet.Factures);

        }

        private void RefreshFactureList()
        {
            List<Facture> listcl = factureService.GetListFacture();
            facturesDataGridView.DataSource = factureService.GetListFacture();
        }
        private void facturesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Facture> listF = factureService.GetListFacture();
            facturesDataGridView.DataSource = listF;
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

        private void btnRoom_Click(object sender, EventArgs e)
        {
            var context = new HotelContext();
            var chService = new ChambreService(context);
            FormmChambre formChambre = new FormmChambre(chService);
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
    }
}
