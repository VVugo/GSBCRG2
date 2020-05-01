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

    public partial class FrmConsulterPracticien : Form
    {
        public FrmConsulterPracticien()
        {
            InitializeComponent();
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPracticien.DataSource = bsPracticien;
            cbxPracticien.DisplayMember = "PRA_NOM" + " " + "PRA_PRENOM";
        }

        private void cbxPracticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRATICIEN selectedPraticien = (PRATICIEN) cbxPracticien.SelectedItem;
            ucPraticien1.LePraticien = selectedPraticien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
