using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UcInfoPerso : UserControl
    {
        private VISITEUR leVisiteur = null;

        public VISITEUR LeVisiteur
        {
            get { return leVisiteur; }
            set
            {
                leVisiteur = value;
                if (leVisiteur != null)
                {
                    ucInfoPerso_actualiser();
                }
            }
        }

        public UcInfoPerso()
        {
            InitializeComponent();
        }

        private void ucInfoPerso_actualiser()
        {
            lblNomPrenom.Text = leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            txtbAdresse.Text = leVisiteur.VIS_ADRESSE;
            txtbVille.Text = leVisiteur.VIS_VILLE;
            txtbCodePostal.Text = leVisiteur.VIS_CP;
            lblDateEmbauche.Text = leVisiteur.VIS_DATEEMBAUCHE.ToString();
        }

    }
}


