using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmMenu : Form
    {
        private VAFFECTATION leProfil;
        private VISITEUR leVisiteur;

        public FrmMenu(VISITEUR v)
        {
            string matricule = v.VIS_MATRICULE;
            string mdp = v.vis_mdp;
            InitializeComponent();
            // chargement du visiteur connecté et de son profil
            try
            {
                //Charge l'utilisateur
                leVisiteur = VisiteurManager.ChargerVisiteur(matricule, mdp);
                leProfil = VisiteurManager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
               
                if (leProfil.TRA_ROLE == "Délégué")
                {
                    maRégionToolStripMenuItem.Visible = true;
                }
                else if (leProfil.TRA_ROLE == "Responsable")
                {
                    monSecteurToolStripMenuItem.Visible = true;
                    mesRapportsEnCoursToolStripMenuItem.Visible = false;
                    mesRapportsValidésToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            try
            {
                lesRapports = VisiteurManager.ChargerRapportVisiteurEncours(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (lesRapports != null && lesRapports.Count != 0)
            {
                FrmRapportEnCours f = new FrmRapportEnCours(leVisiteur, lesRapports);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun rapport en cours", "Gestion Rapports de visite", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modifierConsulterToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrmInfoPerso f = new FrmInfoPerso(leVisiteur);
            f.ShowDialog();
        }

        private void changerMonMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangerMdp f = new FrmChangerMdp(leVisiteur);
            f.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConnexion f = new FrmConnexion();
            f.ShowDialog();

        }

        private void lesPraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterPracticien f = new FrmConsulterPracticien(leVisiteur.VIS_MATRICULE);
            f.Show();
        }

        private void mesRapportsValidésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapportValide f = new FrmRapportValide(leVisiteur);
            f.Show();

        }

        private void lesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterMedoc f = new FrmConsulterMedoc(leVisiteur.VIS_MATRICULE);
            f.Show();
        }

        private void nouveauVisiteurDéléguéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResponsableCreation f = new FrmResponsableCreation();
            f.Show();
        }
    }
}
