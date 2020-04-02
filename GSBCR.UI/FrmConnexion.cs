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
    public partial class FrmConnexion : Form
    {
        public VISITEUR leVisiteur;
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            leVisiteur = VisiteurManager.ChargerVisiteur(txtbIdentifiant.Text, txtbMotDePasse.Text);
            if( leVisiteur != null)
            {
                FrmMenuVisiteur f = new FrmMenuVisiteur(leVisiteur);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
