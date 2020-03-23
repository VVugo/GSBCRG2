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
using GSBCR.UCTEST;

namespace GSBCR.UCTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bsMedoc.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedoc.DataSource = bsMedoc;
            cbxMedoc.DisplayMember = "MED_NOMCOMMERCIAL";

            bsPraticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPraticien.DataSource = bsPraticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedoc.SelectedIndex = -1;

            ucPraticien1.Visible = false;
            cbxPraticien.SelectedIndex = -1;
            

        }

        private void ucMedicament1_Load(object sender, EventArgs e)
        {

        }

        private void cbxMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMedoc.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedoc.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxPraticien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPraticien.SelectedItem;
                ucPraticien1.LePraticien = p;
                ucPraticien1.Visible = true;
            }
        }
    }
}
