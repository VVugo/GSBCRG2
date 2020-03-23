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
    public partial class UcPraticien : UserControl
    {
        private PRATICIEN lePraticien = null;

        public PRATICIEN LePraticien
        {
            get { return lePraticien; }
            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPraticien_actualiser();
                }
            }
        }
        public UcPraticien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcPraticien_Load(object sender, EventArgs e)
        {

        }
        private void ucPraticien_actualiser()
        {
            txtNumero.Text = lePraticien.PRA_NUM.ToString();
            txtNom.Text = lePraticien.PRA_NOM;
            txtPrenom.Text = lePraticien.PRA_PRENOM;
            txtAdresse.Text = lePraticien.PRA_ADRESSE;
            txtCp.Text = lePraticien.PRA_CP;
            txtVille.Text = lePraticien.PRA_VILLE;
            txtCoefNot.Text = lePraticien.PRA_COEFNOTORIETE.ToString();
            txtType.Text = lePraticien.TYP_CODE;

        }
    }
}
