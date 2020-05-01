namespace GSBCR.UI
{
    partial class FrmInfoPerso
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
            this.btnModification = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.txtbVille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(12, 292);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(95, 49);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modifier";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(149, 292);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(95, 49);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomPrenom.Location = new System.Drawing.Point(21, 21);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(126, 25);
            this.lblNomPrenom.TabIndex = 4;
            this.lblNomPrenom.Text = "Nom Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(72, 69);
            this.txtbAdresse.Multiline = true;
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(177, 39);
            this.txtbAdresse.TabIndex = 6;
            // 
            // txtbVille
            // 
            this.txtbVille.Location = new System.Drawing.Point(72, 131);
            this.txtbVille.Multiline = true;
            this.txtbVille.Name = "txtbVille";
            this.txtbVille.Size = new System.Drawing.Size(177, 39);
            this.txtbVille.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ville";
            // 
            // txtbCp
            // 
            this.txtbCp.Location = new System.Drawing.Point(72, 189);
            this.txtbCp.MaxLength = 5;
            this.txtbCp.Multiline = true;
            this.txtbCp.Name = "txtbCp";
            this.txtbCp.Size = new System.Drawing.Size(85, 29);
            this.txtbCp.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date d\'embauche";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(137, 251);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(91, 13);
            this.lblDateEmbauche.TabIndex = 12;
            this.lblDateEmbauche.Text = "lblDateEmbauche";
            // 
            // FrmInfoPerso
            // 
            this.AcceptButton = this.btnModification;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 351);
            this.Controls.Add(this.lblDateEmbauche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbCp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbVille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModification);
            this.Name = "FrmInfoPerso";
            this.Text = "Informations personnelles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.TextBox txtbVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateEmbauche;
    }
}