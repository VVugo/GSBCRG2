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
        /// <summary>
        /// Modification des informations du visiteur
        /// <param name="v">Visiteur</param>
        /// </summary>

        private VISITEUR v = null;

        public FrmInfoPerso(VISITEUR v)
        {
            InitializeComponent();
            this.v = v;

            lblNomPrenom.Text = v.VIS_NOM + " " + v.Vis_PRENOM;
            txtbAdresse.Text = v.VIS_ADRESSE;
            txtbVille.Text = v.VIS_VILLE;
            txtbCp.Text = v.VIS_CP;
            lblDateEmbauche.Text = v.VIS_DATEEMBAUCHE.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            string adresse = txtbAdresse.Text;
            string cp = txtbCp.Text;
            string ville = txtbVille.Text;


            if (String.IsNullOrEmpty(adresse))
            {
                MessageBox.Show("Veuillez renseigner votre adresse !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(cp) || txtbCp.TextLength < 5 || cp.Any(char.IsLetter))
                {
                    MessageBox.Show("Veuillez renseigner votre code postal !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (String.IsNullOrEmpty(ville) || ville.All(char.IsNumber))
                    {
                        MessageBox.Show("Veuillez renseigner votre ville !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        v.VIS_ADRESSE = adresse;
                        v.VIS_CP = cp;
                        v.VIS_VILLE = ville;

                        VisiteurManager.MajVisiteur(v);

                        MessageBox.Show("Modification des informations personnelles enregistré", "Mise à Jour des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
