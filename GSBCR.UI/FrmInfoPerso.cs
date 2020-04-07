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
    public partial class FrmInfoPerso : Form
    {
        private VISITEUR leVisiteur;
        public FrmInfoPerso(VISITEUR v)
        {
            InitializeComponent();
            leVisiteur = v;
            string matricule = leVisiteur.VIS_MATRICULE;
            string mdp = leVisiteur.vis_mdp;
            bsInfoPerso.DataSource = VisiteurManager.ChargerVisiteur(matricule,mdp);
        }

        private void FrmInfoPerso_Load(object sender, EventArgs e)
        {
            ucInfoPerso1.LeVisiteur = leVisiteur;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModification_Click(object sender, EventArgs e)
        {

        }
    }
}
