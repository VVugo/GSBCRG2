namespace GSBCR.UI
{
    partial class FrmConsulterPraticien
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
            this.bsPracticien = new System.Windows.Forms.BindingSource(this.components);
            this.ucPraticien2 = new GSBCR.UC.UcPraticien();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPraticien2
            // 
            this.ucPraticien2.LePraticien = null;
            this.ucPraticien2.Location = new System.Drawing.Point(166, 13);
            this.ucPraticien2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPraticien2.Name = "ucPraticien2";
            this.ucPraticien2.Size = new System.Drawing.Size(417, 416);
            this.ucPraticien2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucPraticien2);
            this.Name = "FrmConsulterPraticien";
            this.Text = "FrmConsulterPraticien";
            this.Load += new System.EventHandler(this.FrmConsulterPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPracticien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPracticien;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.BindingSource bsPraticien;
        private UC.UcPraticien ucPraticien1;
        private UC.UcPraticien ucPraticien2;
        private System.Windows.Forms.Button button1;
    }
}