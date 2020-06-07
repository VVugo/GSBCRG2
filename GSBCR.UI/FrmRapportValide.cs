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
    public partial class FrmRapportValide : Form
    {
        VISITEUR actuVisiteur;
        public FrmRapportValide(VISITEUR leVisiteur)
        {
            InitializeComponent();
            actuVisiteur = leVisiteur;
            bsRapportValide.DataSource = VisiteurManager.ChargerRapportVisiteurFinis(leVisiteur.VIS_MATRICULE);
            cbxRapNum.DataSource = bsRapportValide;
            cbxRapNum.DisplayMember = "RAP_NUM";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void cbxRapNum_SelectedIndexChanged(object sender, EventArgs e)
        {

            RAPPORT_VISITE actuRapport = (RAPPORT_VISITE)cbxRapNum.SelectedItem;
            txtNumPra.Text = actuRapport.RAP_PRANUM.ToString();
            txtDateVis.Text = actuRapport.RAP_DATVISIT.ToString();
            txtMotifVis.Text = actuRapport.RAP_MOTIF;
            txtRapEtat.Text = actuRapport.RAP_ETAT;
            txtCodeMed.Text = actuRapport.RAP_MED1;
            txtCodeMed2.Text = actuRapport.RAP_MED2;
            

        }

        private void btnPraticien_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE selectedRap = (RAPPORT_VISITE)bsRapportValide.Current;
            FrmConsulterPracticien frmConsulterPracticien = new FrmConsulterPracticien(actuVisiteur.VIS_MATRICULE, VisiteurManager.ChargerLePraticien(selectedRap.RAP_PRANUM));
            frmConsulterPracticien.Show();
        }

        private void btnMedicament1_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE selectedRap = (RAPPORT_VISITE)bsRapportValide.Current;
            FrmConsulterMedoc frmConsulterMedicament = new FrmConsulterMedoc(actuVisiteur.VIS_MATRICULE, VisiteurManager.ChargerLeMedicament(selectedRap.RAP_MED1));
            frmConsulterMedicament.Show();
        }

        private void btnMedicament2_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE selectedRap = (RAPPORT_VISITE)bsRapportValide.Current;
            FrmConsulterMedoc frmConsulterMedicament = new FrmConsulterMedoc(actuVisiteur.VIS_MATRICULE, VisiteurManager.ChargerLeMedicament(selectedRap.RAP_MED2));
            frmConsulterMedicament.Show();
        }
    }
    }
