namespace GSBCR.UI
{
    partial class FrmRegion
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rAPMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPCONFIANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPBILANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMotifVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lePraticienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPMATRICULEDataGridViewTextBoxColumn,
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATEDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPCONFIANCEDataGridViewTextBoxColumn,
            this.rAPBILANDataGridViewTextBoxColumn,
            this.rAPMOTIFDataGridViewTextBoxColumn,
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn,
            this.leMedicament1DataGridViewTextBoxColumn,
            this.leMedicament2DataGridViewTextBoxColumn,
            this.leMotifVisiteDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lePraticienDataGridViewTextBoxColumn,
            this.leVisiteurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 219);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitter";
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            // 
            // leMedicament1DataGridViewTextBoxColumn
            // 
            this.leMedicament1DataGridViewTextBoxColumn.DataPropertyName = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.HeaderText = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.Name = "leMedicament1DataGridViewTextBoxColumn";
            // 
            // leMedicament2DataGridViewTextBoxColumn
            // 
            this.leMedicament2DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.HeaderText = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.Name = "leMedicament2DataGridViewTextBoxColumn";
            // 
            // leMotifVisiteDataGridViewTextBoxColumn
            // 
            this.leMotifVisiteDataGridViewTextBoxColumn.DataPropertyName = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.HeaderText = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.Name = "leMotifVisiteDataGridViewTextBoxColumn";
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            // 
            // lePraticienDataGridViewTextBoxColumn
            // 
            this.lePraticienDataGridViewTextBoxColumn.DataPropertyName = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.HeaderText = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.Name = "lePraticienDataGridViewTextBoxColumn";
            // 
            // leVisiteurDataGridViewTextBoxColumn
            // 
            this.leVisiteurDataGridViewTextBoxColumn.DataPropertyName = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.HeaderText = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.Name = "leVisiteurDataGridViewTextBoxColumn";
            // 
            // FrmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmRegion";
            this.Text = "FrmRegion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rAPPORTVISITEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGNOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leSecteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesVisiteursAffectesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rEGIONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMotifVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lePraticienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}