namespace GSBCR.UI
{
    partial class FrmChangerMdp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbMdpActuel = new System.Windows.Forms.TextBox();
            this.txtbNouveauMdp = new System.Windows.Forms.TextBox();
            this.txtbConfNouveauMdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification du mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe actuel";
            // 
            // txtbMdpActuel
            // 
            this.txtbMdpActuel.Location = new System.Drawing.Point(151, 69);
            this.txtbMdpActuel.Name = "txtbMdpActuel";
            this.txtbMdpActuel.PasswordChar = '*';
            this.txtbMdpActuel.Size = new System.Drawing.Size(177, 20);
            this.txtbMdpActuel.TabIndex = 3;
            // 
            // txtbNouveauMdp
            // 
            this.txtbNouveauMdp.Location = new System.Drawing.Point(151, 108);
            this.txtbNouveauMdp.Name = "txtbNouveauMdp";
            this.txtbNouveauMdp.PasswordChar = '*';
            this.txtbNouveauMdp.Size = new System.Drawing.Size(177, 20);
            this.txtbNouveauMdp.TabIndex = 4;
            // 
            // txtbConfNouveauMdp
            // 
            this.txtbConfNouveauMdp.Location = new System.Drawing.Point(151, 152);
            this.txtbConfNouveauMdp.Name = "txtbConfNouveauMdp";
            this.txtbConfNouveauMdp.PasswordChar = '*';
            this.txtbConfNouveauMdp.Size = new System.Drawing.Size(177, 20);
            this.txtbConfNouveauMdp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nouveau mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmation";
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(38, 259);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(91, 50);
            this.btnModification.TabIndex = 8;
            this.btnModification.Text = "Modifier";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(213, 259);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(91, 50);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Annuler";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmChangerMdp
            // 
            this.AcceptButton = this.btnModification;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuitter;
            this.ClientSize = new System.Drawing.Size(345, 331);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbConfNouveauMdp);
            this.Controls.Add(this.txtbNouveauMdp);
            this.Controls.Add(this.txtbMdpActuel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChangerMdp";
            this.Text = "FrmChangerMdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbMdpActuel;
        private System.Windows.Forms.TextBox txtbNouveauMdp;
        private System.Windows.Forms.TextBox txtbConfNouveauMdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnQuitter;
    }
}