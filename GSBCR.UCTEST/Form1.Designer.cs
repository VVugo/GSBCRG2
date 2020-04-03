namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedoc = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultation Medicament";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxMedoc
            // 
            this.cbxMedoc.FormattingEnabled = true;
            this.cbxMedoc.Location = new System.Drawing.Point(279, 31);
            this.cbxMedoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMedoc.Name = "cbxMedoc";
            this.cbxMedoc.Size = new System.Drawing.Size(160, 24);
            this.cbxMedoc.TabIndex = 2;
            this.cbxMedoc.SelectedIndexChanged += new System.EventHandler(this.cbxMedoc_SelectedIndexChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(951, 511);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consultation Praticien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(783, 31);
            this.cbxPraticien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(160, 24);
            this.cbxPraticien.TabIndex = 5;
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxPraticien_SelectedIndexChanged);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(56, 64);
            this.ucMedicament1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(507, 448);
            this.ucMedicament1.TabIndex = 0;
            this.ucMedicament1.Load += new System.EventHandler(this.ucMedicament1_Load);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(633, 87);
            this.ucPraticien1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(417, 416);
            this.ucPraticien1.TabIndex = 6;
            this.ucPraticien1.Load += new System.EventHandler(this.ucPraticien1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cbxMedoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMedicament1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMedoc;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsMedoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.BindingSource bsPraticien;
        private UC.UcPraticien ucPraticien1;
    }
}

