namespace GSBCR.UI
{
    partial class FrmRapportValide
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblRapNum = new System.Windows.Forms.Label();
            this.lblPraNum = new System.Windows.Forms.Label();
            this.lblMotifVis = new System.Windows.Forms.Label();
            this.lblDateVis = new System.Windows.Forms.Label();
            this.lblRapEtat = new System.Windows.Forms.Label();
            this.lblCodeMed = new System.Windows.Forms.Label();
            this.cbxRapNum = new System.Windows.Forms.ComboBox();
            this.txtNumPra = new System.Windows.Forms.TextBox();
            this.txtDateVis = new System.Windows.Forms.TextBox();
            this.txtMotifVis = new System.Windows.Forms.TextBox();
            this.txtRapEtat = new System.Windows.Forms.TextBox();
            this.txtCodeMed = new System.Windows.Forms.TextBox();
            this.BtnDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRapNum
            // 
            this.lblRapNum.AutoSize = true;
            this.lblRapNum.Location = new System.Drawing.Point(224, 49);
            this.lblRapNum.Name = "lblRapNum";
            this.lblRapNum.Size = new System.Drawing.Size(111, 17);
            this.lblRapNum.TabIndex = 3;
            this.lblRapNum.Text = "Rapport numéro";
            this.lblRapNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPraNum
            // 
            this.lblPraNum.AutoSize = true;
            this.lblPraNum.Location = new System.Drawing.Point(213, 102);
            this.lblPraNum.Name = "lblPraNum";
            this.lblPraNum.Size = new System.Drawing.Size(122, 17);
            this.lblPraNum.TabIndex = 4;
            this.lblPraNum.Text = "Practicien numero";
            this.lblPraNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMotifVis
            // 
            this.lblMotifVis.AutoSize = true;
            this.lblMotifVis.Location = new System.Drawing.Point(261, 208);
            this.lblMotifVis.Name = "lblMotifVis";
            this.lblMotifVis.Size = new System.Drawing.Size(74, 17);
            this.lblMotifVis.TabIndex = 5;
            this.lblMotifVis.Text = "Motif visite";
            this.lblMotifVis.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDateVis
            // 
            this.lblDateVis.AutoSize = true;
            this.lblDateVis.Location = new System.Drawing.Point(261, 155);
            this.lblDateVis.Name = "lblDateVis";
            this.lblDateVis.Size = new System.Drawing.Size(74, 17);
            this.lblDateVis.TabIndex = 6;
            this.lblDateVis.Text = "Date visite";
            this.lblDateVis.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRapEtat
            // 
            this.lblRapEtat.AutoSize = true;
            this.lblRapEtat.Location = new System.Drawing.Point(248, 257);
            this.lblRapEtat.Name = "lblRapEtat";
            this.lblRapEtat.Size = new System.Drawing.Size(87, 17);
            this.lblRapEtat.TabIndex = 7;
            this.lblRapEtat.Text = "Rapport etat";
            this.lblRapEtat.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCodeMed
            // 
            this.lblCodeMed.AutoSize = true;
            this.lblCodeMed.Location = new System.Drawing.Point(214, 311);
            this.lblCodeMed.Name = "lblCodeMed";
            this.lblCodeMed.Size = new System.Drawing.Size(121, 17);
            this.lblCodeMed.TabIndex = 8;
            this.lblCodeMed.Text = "Code medicament";
            this.lblCodeMed.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxRapNum
            // 
            this.cbxRapNum.FormattingEnabled = true;
            this.cbxRapNum.Location = new System.Drawing.Point(368, 49);
            this.cbxRapNum.Name = "cbxRapNum";
            this.cbxRapNum.Size = new System.Drawing.Size(137, 24);
            this.cbxRapNum.TabIndex = 9;
            // 
            // txtNumPra
            // 
            this.txtNumPra.Location = new System.Drawing.Point(368, 102);
            this.txtNumPra.Name = "txtNumPra";
            this.txtNumPra.Size = new System.Drawing.Size(137, 22);
            this.txtNumPra.TabIndex = 10;
            this.txtNumPra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDateVis
            // 
            this.txtDateVis.Location = new System.Drawing.Point(368, 150);
            this.txtDateVis.Name = "txtDateVis";
            this.txtDateVis.Size = new System.Drawing.Size(137, 22);
            this.txtDateVis.TabIndex = 11;
            this.txtDateVis.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMotifVis
            // 
            this.txtMotifVis.Location = new System.Drawing.Point(368, 203);
            this.txtMotifVis.Name = "txtMotifVis";
            this.txtMotifVis.Size = new System.Drawing.Size(137, 22);
            this.txtMotifVis.TabIndex = 12;
            this.txtMotifVis.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRapEtat
            // 
            this.txtRapEtat.Location = new System.Drawing.Point(368, 254);
            this.txtRapEtat.Name = "txtRapEtat";
            this.txtRapEtat.Size = new System.Drawing.Size(137, 22);
            this.txtRapEtat.TabIndex = 13;
            this.txtRapEtat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCodeMed
            // 
            this.txtCodeMed.Location = new System.Drawing.Point(368, 306);
            this.txtCodeMed.Name = "txtCodeMed";
            this.txtCodeMed.Size = new System.Drawing.Size(137, 22);
            this.txtCodeMed.TabIndex = 14;
            this.txtCodeMed.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // BtnDetail
            // 
            this.BtnDetail.Location = new System.Drawing.Point(566, 49);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(86, 23);
            this.BtnDetail.TabIndex = 15;
            this.BtnDetail.Text = "Details";
            this.BtnDetail.UseVisualStyleBackColor = true;
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // FrmRapportValide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDetail);
            this.Controls.Add(this.txtCodeMed);
            this.Controls.Add(this.txtRapEtat);
            this.Controls.Add(this.txtMotifVis);
            this.Controls.Add(this.txtDateVis);
            this.Controls.Add(this.txtNumPra);
            this.Controls.Add(this.cbxRapNum);
            this.Controls.Add(this.lblCodeMed);
            this.Controls.Add(this.lblRapEtat);
            this.Controls.Add(this.lblDateVis);
            this.Controls.Add(this.lblMotifVis);
            this.Controls.Add(this.lblPraNum);
            this.Controls.Add(this.lblRapNum);
            this.Controls.Add(this.button1);
            this.Name = "FrmRapportValide";
            this.Text = "FrmRapportValide";
            this.Load += new System.EventHandler(this.FrmRapportValide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRapNum;
        private System.Windows.Forms.Label lblPraNum;
        private System.Windows.Forms.Label lblMotifVis;
        private System.Windows.Forms.Label lblDateVis;
        private System.Windows.Forms.Label lblRapEtat;
        private System.Windows.Forms.Label lblCodeMed;
        private System.Windows.Forms.ComboBox cbxRapNum;
        private System.Windows.Forms.TextBox txtNumPra;
        private System.Windows.Forms.TextBox txtDateVis;
        private System.Windows.Forms.TextBox txtMotifVis;
        private System.Windows.Forms.TextBox txtRapEtat;
        private System.Windows.Forms.TextBox txtCodeMed;
        private System.Windows.Forms.Button BtnDetail;
    }
}