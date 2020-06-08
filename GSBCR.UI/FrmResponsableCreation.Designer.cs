namespace GSBCR.UI
{
    partial class FrmResponsableCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.LblLabo = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxSecteur = new System.Windows.Forms.ComboBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.cbxLabo = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cbxTitre = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMatricule
            // 
            this.txtBoxMatricule.Location = new System.Drawing.Point(209, 71);
            this.txtBoxMatricule.Name = "txtBoxMatricule";
            this.txtBoxMatricule.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMatricule.TabIndex = 0;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(126, 71);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(65, 17);
            this.lblMatricule.TabIndex = 1;
            this.lblMatricule.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(143, 176);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(207, 173);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(143, 232);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom";
            this.lblPrenom.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(207, 229);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrenom.TabIndex = 4;
            this.txtBoxPrenom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(143, 288);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(60, 17);
            this.lblAdresse.TabIndex = 7;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(207, 285);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(270, 22);
            this.txtBoxAdresse.TabIndex = 6;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(118, 337);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(83, 17);
            this.lblCP.TabIndex = 9;
            this.lblCP.Text = "Code postal";
            this.lblCP.Click += new System.EventHandler(this.lblCP_Click);
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(207, 334);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCP.TabIndex = 8;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(143, 386);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(34, 17);
            this.lblVille.TabIndex = 11;
            this.lblVille.Text = "Ville";
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(207, 383);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(229, 22);
            this.txtBoxVille.TabIndex = 10;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(98, 129);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(93, 17);
            this.lblMdp.TabIndex = 13;
            this.lblMdp.Text = "Mot de passe";
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(209, 126);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.PasswordChar = '*';
            this.txtBoxMdp.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMdp.TabIndex = 12;
            this.txtBoxMdp.UseSystemPasswordChar = true;
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(574, 45);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(57, 17);
            this.lblSecteur.TabIndex = 15;
            this.lblSecteur.Text = "Secteur";
            // 
            // LblLabo
            // 
            this.LblLabo.AutoSize = true;
            this.LblLabo.Location = new System.Drawing.Point(566, 101);
            this.LblLabo.Name = "LblLabo";
            this.LblLabo.Size = new System.Drawing.Size(81, 17);
            this.LblLabo.TabIndex = 17;
            this.LblLabo.Text = "Laboratoire";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(638, 254);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date embauche";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbxSecteur
            // 
            this.cbxSecteur.DataSource = this.bsSecteur;
            this.cbxSecteur.DisplayMember = "SEC_LIBELLE";
            this.cbxSecteur.FormattingEnabled = true;
            this.cbxSecteur.Location = new System.Drawing.Point(652, 45);
            this.cbxSecteur.Name = "cbxSecteur";
            this.cbxSecteur.Size = new System.Drawing.Size(121, 24);
            this.cbxSecteur.TabIndex = 24;
            this.cbxSecteur.ValueMember = "SEC_CODE";
            this.cbxSecteur.SelectedIndexChanged += new System.EventHandler(this.cbxSecteur_SelectedIndexChanged);
            // 
            // bsSecteur
            // 
            this.bsSecteur.DataSource = typeof(GSBCR.modele.SECTEUR);
            // 
            // cbxLabo
            // 
            this.cbxLabo.FormattingEnabled = true;
            this.cbxLabo.Items.AddRange(new object[] {
            "SW",
            "GY"});
            this.cbxLabo.Location = new System.Drawing.Point(652, 94);
            this.cbxLabo.Name = "cbxLabo";
            this.cbxLabo.Size = new System.Drawing.Size(121, 24);
            this.cbxLabo.TabIndex = 26;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(612, 356);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 27;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(745, 356);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 28;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cbxTitre
            // 
            this.cbxTitre.FormattingEnabled = true;
            this.cbxTitre.Items.AddRange(new object[] {
            "Visiteur",
            "Délégué"});
            this.cbxTitre.Location = new System.Drawing.Point(652, 198);
            this.cbxTitre.Name = "cbxTitre";
            this.cbxTitre.Size = new System.Drawing.Size(121, 24);
            this.cbxTitre.TabIndex = 30;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(582, 201);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 17);
            this.lblTitre.TabIndex = 29;
            this.lblTitre.Text = "Titre";
            // 
            // cbxRegion
            // 
            this.cbxRegion.DataSource = this.bsRegion;
            this.cbxRegion.DisplayMember = "REG_NOM";
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(652, 143);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 24);
            this.cbxRegion.TabIndex = 32;
            this.cbxRegion.ValueMember = "REG_CODE";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(574, 150);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(53, 17);
            this.lblRegion.TabIndex = 31;
            this.lblRegion.Text = "Region";
            // 
            // bsRegion
            // 
            this.bsRegion.DataSource = typeof(GSBCR.modele.REGION);
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // FrmResponsableCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 566);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cbxTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxLabo);
            this.Controls.Add(this.cbxSecteur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.LblLabo);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtBoxMdp);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtBoxCP);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.txtBoxMatricule);
            this.Name = "FrmResponsableCreation";
            this.Load += new System.EventHandler(this.FrmResponsableCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label LblLabo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSecteur;
        private System.Windows.Forms.ComboBox cbxLabo;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.ComboBox cbxTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.BindingSource bsRegion;
    }
}