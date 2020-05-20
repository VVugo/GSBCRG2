namespace GSBCR.UI
{
    partial class FrmConsulterMedoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedicament = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.bsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulter un médicament";
            // 
            // cbxMedicament
            // 
            this.cbxMedicament.FormattingEnabled = true;
            this.cbxMedicament.Location = new System.Drawing.Point(220, 21);
            this.cbxMedicament.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMedicament.Name = "cbxMedicament";
            this.cbxMedicament.Size = new System.Drawing.Size(160, 24);
            this.cbxMedicament.TabIndex = 2;
            this.cbxMedicament.SelectedIndexChanged += new System.EventHandler(this.cbxMedicament_SelectedIndexChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(321, 482);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(121, 57);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(34, 54);
            this.ucMedicament1.Margin = new System.Windows.Forms.Padding(5);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(477, 448);
            this.ucMedicament1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consulter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmConsulterMedoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cbxMedicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMedicament1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsulterMedoc";
            this.Text = "FrmConsulterMedoc";
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsMedicament;
        private System.Windows.Forms.ComboBox cbxMedicament;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button button1;
    }
}