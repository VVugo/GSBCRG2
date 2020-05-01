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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmRapportValide_Load(object sender, EventArgs e)
        {
            lblCodeMed.Show();
            txtCodeMed.Show();
            lblDateVis.Show();
            txtDateVis.Show();
            lblMotifVis.Show();
            txtMotifVis.Show();
            lblPraNum.Show();
            txtNumPra.Show();
            lblRapEtat.Show();
            txtRapEtat.Show();
            lblCodeMed2.Show();
            txtCodeMed2.Show();
            bsRapportValide.DataSource = VisiteurManager.ChargerRapportVisiteurFinis(actuVisiteur.VIS_MATRICULE);
            cbxRapNum.DataSource = bsRapportValide;
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {

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
            //actuRapport.

        }
    }
    }
