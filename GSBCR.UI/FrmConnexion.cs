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
                this.Hide();
                FrmMenu f = new FrmMenu(leVisiteur);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
