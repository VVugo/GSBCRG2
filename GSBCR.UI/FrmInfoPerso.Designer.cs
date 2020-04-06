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
            this.components = new System.ComponentModel.Container();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bsInfoPerso = new System.Windows.Forms.BindingSource(this.components);
            this.ucInfoPerso1 = new GSBCR.UC.UcInfoPerso();
            ((System.ComponentModel.ISupportInitialize)(this.bsInfoPerso)).BeginInit();
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
            // ucInfoPerso1
            // 
            this.ucInfoPerso1.LeVisiteur = null;
            this.ucInfoPerso1.Location = new System.Drawing.Point(-2, 12);
            this.ucInfoPerso1.Name = "ucInfoPerso1";
            this.ucInfoPerso1.Size = new System.Drawing.Size(246, 274);
            this.ucInfoPerso1.TabIndex = 3;
            // 
            // FrmInfoPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 352);
            this.Controls.Add(this.ucInfoPerso1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModification);
            this.Name = "FrmInfoPerso";
            this.Text = "FrmModifInfos";
            this.Load += new System.EventHandler(this.FrmInfoPerso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInfoPerso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsInfoPerso;
        private UC.UcInfoPerso ucInfoPerso1;
    }
}