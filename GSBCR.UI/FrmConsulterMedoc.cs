using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;
namespace GSBCR.UI
 
{
    public partial class FrmConsulterMedoc : Form
    {
        public FrmConsulterMedoc()
        {
            InitializeComponent();
            bsMedicament.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = bsMedicament;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            MEDICAMENT selectedMedicament = (MEDICAMENT)cbxMedicament.SelectedItem;
            ucMedicament1.LeMedicament = selectedMedicament;
        }
    }
}
