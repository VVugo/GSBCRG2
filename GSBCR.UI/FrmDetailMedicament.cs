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
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmDetailMedicament : Form
    {
        public MEDICAMENT Medoc;
        public List<RAPPORT_VISITE> listeRapport = new List<RAPPORT_VISITE>();

        public FrmDetailMedicament()
        {
            InitializeComponent();
        }

        public FrmDetailMedicament(MEDICAMENT Medoc)
        {
            InitializeComponent();
            this.Medoc = Medoc;
            bsRapportMed.DataSource = VisiteurManager.GetRapportValideByMedoc(Medoc.MED_DEPOTLEGAL);
            dgvRapportMed.DataSource = bsRapportMed;
            txtBoxMed.Text = Medoc.MED_NOMCOMMERCIAL;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
