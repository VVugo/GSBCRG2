namespace GSBCR.UI
{
    partial class FrmGestionEquipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVisiteur = new System.Windows.Forms.ComboBox();
            this.ucVisiteur1 = new GSBCR.UC.UcVisiteur();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionner un utilisateur";
            // 
            // cbxVisiteur
            // 
            this.cbxVisiteur.FormattingEnabled = true;
            this.cbxVisiteur.Location = new System.Drawing.Point(173, 28);
            this.cbxVisiteur.Name = "cbxVisiteur";
            this.cbxVisiteur.Size = new System.Drawing.Size(121, 21);
            this.cbxVisiteur.TabIndex = 2;
            // 
            // ucVisiteur1
            // 
            this.ucVisiteur1.Location = new System.Drawing.Point(33, 55);
            this.ucVisiteur1.Name = "ucVisiteur1";
            this.ucVisiteur1.Size = new System.Drawing.Size(261, 228);
            this.ucVisiteur1.TabIndex = 3;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 312);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 40);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(225, 312);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(98, 40);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // FrmGestionEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 381);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.ucVisiteur1);
            this.Controls.Add(this.cbxVisiteur);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionEquipe";
            this.Text = "FrmGestionEquipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVisiteur;
        private UC.UcVisiteur ucVisiteur1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
    }
}