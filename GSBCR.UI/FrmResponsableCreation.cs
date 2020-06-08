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
    public partial class FrmResponsableCreation : Form
    {
        private VISITEUR newVisiteur = new VISITEUR();
        private TRAVAILLER newTravail = new TRAVAILLER();

        public FrmResponsableCreation()
        {
            InitializeComponent();
            bsSecteur.DataSource = VisiteurManager.GetSecteur();
            bsRegion.DataSource = VisiteurManager.GetRegion();
            cbxLabo.SelectedIndex = 0;
            cbxTitre.SelectedIndex = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmResponsableCreation_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblCP_Click(object sender, EventArgs e)
        {

        }

        private void cbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(txtBoxNom.Text != ""  && txtBoxPrenom.Text != "" && txtBoxMatricule.Text != "" && txtBoxMdp.Text != "" && txtBoxCP.Text != "" && txtBoxAdresse.Text != "" && txtBoxVille.Text != "")
            {
                try
                {
                    newVisiteur.VIS_NOM = txtBoxNom.Text;
                    newVisiteur.Vis_PRENOM = txtBoxPrenom.Text;
                    newVisiteur.vis_mdp = txtBoxMdp.Text;
                    newVisiteur.VIS_MATRICULE = txtBoxMatricule.Text;
                    newVisiteur.VIS_ADRESSE = txtBoxAdresse.Text;
                    newVisiteur.VIS_CP = txtBoxCP.Text;
                    newVisiteur.VIS_VILLE = txtBoxVille.Text;
                    newVisiteur.VIS_DATEEMBAUCHE = dtpDate.Value;
                    newVisiteur.SEC_CODE = cbxSecteur.SelectedValue.ToString();
                    newVisiteur.LAB_CODE = cbxLabo.SelectedItem.ToString();
                    newVisiteur.LesRapports = new List<RAPPORT_VISITE>();
                    newVisiteur.LesAffectations = new List<TRAVAILLER>();

                    newTravail.VIS_MATRICULE = txtBoxMatricule.Text;
                    newTravail.JJMMAA = dtpDate.Value;
                    newTravail.REG_CODE = cbxRegion.SelectedValue.ToString();
                    newTravail.TRA_ROLE = cbxTitre.SelectedItem.ToString();

                    
                    VisiteurManager.CreateVisiteur(newVisiteur);
                    VisiteurManager.CreateTravailler(newTravail);
                    MessageBox.Show("Visiteur crée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
               
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de valider");
            }

           



        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
