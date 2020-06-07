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

        PRATICIEN selectedPraticien;
        string mat;
        public FrmConsulterPracticien()
        {
            InitializeComponent();
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPracticien.DataSource = bsPracticien;
            cbxPracticien.DisplayMember = "PRA_NOM";
            selectedPraticien = (PRATICIEN)cbxPracticien.SelectedItem;
            ucPraticien1.LePraticien = selectedPraticien;
        }

        public FrmConsulterPracticien(string mat)
        {
            InitializeComponent();
            this.mat = mat;
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPracticien.DataSource = bsPracticien;
            cbxPracticien.DisplayMember = "PRA_NOM";
            selectedPraticien = (PRATICIEN)cbxPracticien.SelectedItem;
            ucPraticien1.LePraticien = selectedPraticien;
        }
        public FrmConsulterPracticien(string mat, PRATICIEN pra)
        {
            InitializeComponent();
            this.mat = mat;
            bsPracticien.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPracticien.DataSource = bsPracticien;
            cbxPracticien.DisplayMember = "PRA_NOM";
            cbxPracticien.SelectedIndex = cbxPracticien.Items.IndexOf(pra);
            bsPracticien.Position = bsPracticien.IndexOf(bsPracticien.List.OfType<PRATICIEN>().ToList().Find(findPra => findPra.PRA_NUM == pra.PRA_NUM));
            //selectedPraticien = pra;
            //ucPraticien1.LePraticien = selectedPraticien;

        }

        private void cbxPracticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPraticien = (PRATICIEN)cbxPracticien.SelectedItem;
            ucPraticien1.LePraticien = selectedPraticien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            FrmDetailPracticien f = new FrmDetailPracticien(selectedPraticien, mat);
            f.Show();
        }
    }
}
