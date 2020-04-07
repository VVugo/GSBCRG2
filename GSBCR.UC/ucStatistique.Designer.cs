namespace GSBCR.UC
{
    partial class UcStatistique
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxChoixRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consulterRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxChoixRegion
            // 
            this.cbxChoixRegion.FormattingEnabled = true;
            this.cbxChoixRegion.Location = new System.Drawing.Point(170, 19);
            this.cbxChoixRegion.Name = "cbxChoixRegion";
            this.cbxChoixRegion.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixRegion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Séléctionner une région";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region,
            this.nbVisiteur,
            this.nbVisite,
            this.consulterRegion});
            this.dataGridView1.Location = new System.Drawing.Point(3, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 260);
            this.dataGridView1.TabIndex = 2;
            // 
            // region
            // 
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            // 
            // nbVisiteur
            // 
            this.nbVisiteur.HeaderText = "Nombre de visite";
            this.nbVisiteur.Name = "nbVisiteur";
            // 
            // nbVisite
            // 
            this.nbVisite.HeaderText = "Nombre de visite";
            this.nbVisite.Name = "nbVisite";
            // 
            // consulterRegion
            // 
            this.consulterRegion.HeaderText = "Plus de détail";
            this.consulterRegion.Name = "consulterRegion";
            // 
            // UcStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxChoixRegion);
            this.Name = "UcStatistique";
            this.Size = new System.Drawing.Size(479, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChoixRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn consulterRegion;
    }
}
