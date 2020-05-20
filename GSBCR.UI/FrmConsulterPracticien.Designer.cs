namespace GSBCR.UI
{
    partial class FrmConsulterPracticien
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
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.cbxPracticien = new System.Windows.Forms.ComboBox();
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(92, 78);
            this.ucPraticien1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(417, 416);
            this.ucPraticien1.TabIndex = 0;
            // 
            // cbxPracticien
            // 
            this.cbxPracticien.DataSource = this.bsPracticien;
            this.cbxPracticien.FormattingEnabled = true;
            this.cbxPracticien.Location = new System.Drawing.Point(264, 26);
            this.cbxPracticien.Name = "cbxPracticien";
            this.cbxPracticien.Size = new System.Drawing.Size(175, 24);
            this.cbxPracticien.TabIndex = 1;
            this.cbxPracticien.SelectedIndexChanged += new System.EventHandler(this.cbxPracticien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Practicien :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulter
            // 
            this.btnConsulter.Location = new System.Drawing.Point(483, 25);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(90, 24);
            this.btnConsulter.TabIndex = 4;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.UseVisualStyleBackColor = true;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // FrmConsulterPracticien
            // 
            this.ClientSize = new System.Drawing.Size(654, 492);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPracticien);
            this.Controls.Add(this.ucPraticien1);
            this.Name = "FrmConsulterPracticien";
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.ComboBox cbxPracticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsPracticien;
        private System.Windows.Forms.Button btnConsulter;
    }
}