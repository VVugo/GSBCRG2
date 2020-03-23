namespace GSBCR.UC
{
    partial class UcMedicament
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomFam = new System.Windows.Forms.TextBox();
            this.txtCodeFam = new System.Windows.Forms.TextBox();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtComposition = new System.Windows.Forms.TextBox();
            this.txtEffet = new System.Windows.Forms.TextBox();
            this.txtContreInd = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dépot légal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom commercial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Famille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Composition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Effets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contre-indications";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prix échantillon";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNomFam);
            this.panel1.Controls.Add(this.txtCodeFam);
            this.panel1.Location = new System.Drawing.Point(129, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 8;
            // 
            // txtNomFam
            // 
            this.txtNomFam.Location = new System.Drawing.Point(84, 12);
            this.txtNomFam.Name = "txtNomFam";
            this.txtNomFam.Size = new System.Drawing.Size(100, 20);
            this.txtNomFam.TabIndex = 1;
            // 
            // txtCodeFam
            // 
            this.txtCodeFam.Location = new System.Drawing.Point(10, 12);
            this.txtCodeFam.Name = "txtCodeFam";
            this.txtCodeFam.Size = new System.Drawing.Size(55, 20);
            this.txtCodeFam.TabIndex = 0;
            // 
            // txtDepot
            // 
            this.txtDepot.Location = new System.Drawing.Point(139, 32);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(100, 20);
            this.txtDepot.TabIndex = 9;
            this.txtDepot.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(139, 69);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 11;
            this.txtNom.TabStop = false;
            // 
            // txtComposition
            // 
            this.txtComposition.Location = new System.Drawing.Point(129, 168);
            this.txtComposition.Name = "txtComposition";
            this.txtComposition.Size = new System.Drawing.Size(100, 20);
            this.txtComposition.TabIndex = 12;
            this.txtComposition.TabStop = false;
            // 
            // txtEffet
            // 
            this.txtEffet.Location = new System.Drawing.Point(129, 213);
            this.txtEffet.Name = "txtEffet";
            this.txtEffet.Size = new System.Drawing.Size(100, 20);
            this.txtEffet.TabIndex = 13;
            this.txtEffet.TabStop = false;
            // 
            // txtContreInd
            // 
            this.txtContreInd.Location = new System.Drawing.Point(129, 255);
            this.txtContreInd.Name = "txtContreInd";
            this.txtContreInd.Size = new System.Drawing.Size(100, 20);
            this.txtContreInd.TabIndex = 14;
            this.txtContreInd.TabStop = false;
            this.txtContreInd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(129, 289);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 15;
            this.txtPrix.TabStop = false;
            // 
            // UcMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtContreInd);
            this.Controls.Add(this.txtEffet);
            this.Controls.Add(this.txtComposition);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtDepot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcMedicament";
            this.Size = new System.Drawing.Size(380, 364);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomFam;
        private System.Windows.Forms.TextBox txtCodeFam;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.TextBox txtEffet;
        private System.Windows.Forms.TextBox txtContreInd;
        private System.Windows.Forms.TextBox txtPrix;
    }
}
