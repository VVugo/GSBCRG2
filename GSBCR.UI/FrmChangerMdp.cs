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
    public partial class FrmChangerMdp : Form
    {
        /// <summary>
        /// Modification du mot de passe d'un visiteur
        /// <param name="v">Visiteur</param>
        /// </summary>

        private VISITEUR v = null;

        public FrmChangerMdp(VISITEUR v)
        {
            InitializeComponent();
            this.v = v;


        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbMdpActuel.Text))
            {
                MessageBox.Show("Veuillez renseigner votre mot de passe actuel !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtbNouveauMdp.Text))
            {
                MessageBox.Show("Veuillez renseigner votre nouveau mot de passe actuel !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtbConfNouveauMdp.Text))
            {
                MessageBox.Show("Veuillez renseigner la confirmation de votre nouveau mot de passe actuel !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtbMdpActuel.Text == v.vis_mdp)
            {
                if (txtbNouveauMdp.Text != v.vis_mdp)
                {
                    if (txtbNouveauMdp.TextLength <= 8)
                    {
                        if (txtbNouveauMdp.Text.Any(char.IsUpper) && txtbNouveauMdp.Text.Any(char.IsLower) && txtbNouveauMdp.Text.Any(char.IsDigit))
                        {

                            if (txtbNouveauMdp.Text == txtbConfNouveauMdp.Text)
                            {
                                v.vis_mdp = txtbNouveauMdp.Text.ToString();
                                VisiteurManager.MajVisiteur(v);
                                MessageBox.Show("Votre mot de passe à bien été modifié !", "Confirmation de modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("La confirmation du mot de passe et votre nouveau mot de passe ne sont pas identitque !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Votre nouveau mot de passe doit être fort : il doit contenir au moins une lettre majuscule, une lettre minuscule et un chiffre !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Votre nouveau mot de passe est supérieur à 8 caractères", "Erreur de modificaiton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Votre nouveau mot de passe doit être différent", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Votre mot de passe actuel n'est pas correct !", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
