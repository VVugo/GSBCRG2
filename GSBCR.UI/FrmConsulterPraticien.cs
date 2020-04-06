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
using GSBCR.UC;

namespace GSBCR.UI
{
    public partial class FrmConsulterPraticien : Form
    {
        public FrmConsulterPraticien()
        {
            InitializeComponent();
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPraticien.DataSource = bsPracticien;
            cbxPraticien.DisplayMember = "PRA_NOM";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxPracticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPraticien.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPraticien.SelectedItem;
                ucPraticien1.LePraticien = p;
                ucPraticien1.Visible = true;
            }
        }

        private void FrmConsulterPraticien_Load(object sender, EventArgs e)
        {
            ucPraticien1.Visible = false;
            cbxPraticien.SelectedIndex = -1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
