using GSBCR.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmDetailPracticien : Form
    {
        public PRATICIEN selectedPra;
        public List<RAPPORT_VISITE> RapportPra;
        public FrmDetailPracticien()
        {
            InitializeComponent();
        }

        public FrmDetailPracticien(PRATICIEN selectedPra)
        {
            InitializeComponent();
            this.selectedPra = selectedPra;
            RapportPra = VisiteurManager.GetRapportValideByPratricien(selectedPra.PRA_NUM.ToString());
            bsRapportPra.DataSource = RapportPra;
            dgvRapportPra.DataSource = bsRapportPra;
            txtBoxRapportPra.Text = selectedPra.PRA_NOM;
            
        }


        private void dgvRapportPra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxRapportPra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
