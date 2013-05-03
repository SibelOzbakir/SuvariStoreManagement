namespace SuvariStoreManagement
{
    partial class turkiyeSorgu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suvariData = new SuvariStoreManagement.SuvariData();
            this.suvariDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazaTanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazaTanimTableAdapter = new SuvariStoreManagement.SuvariDataTableAdapters.MagazaTanimTableAdapter();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolgeKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaKisaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaLokasyonTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaAlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaIliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılBolgesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaSabitHatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaGSMNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suvariData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suvariDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaTanimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.bolgeKoduDataGridViewTextBoxColumn,
            this.magazaKoduDataGridViewTextBoxColumn,
            this.magazaKisaKoduDataGridViewTextBoxColumn,
            this.magazaAdiDataGridViewTextBoxColumn,
            this.magazaTipiDataGridViewTextBoxColumn,
            this.magazaLokasyonTipiDataGridViewTextBoxColumn,
            this.magazaAlanDataGridViewTextBoxColumn,
            this.magazaIliDataGridViewTextBoxColumn,
            this.ılBolgesiDataGridViewTextBoxColumn,
            this.magazaAdresDataGridViewTextBoxColumn,
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn,
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn,
            this.magazaSabitHatNoDataGridViewTextBoxColumn,
            this.magazaGSMNoDataGridViewTextBoxColumn,
            this.magazaMailDataGridViewTextBoxColumn,
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazaTanimBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // suvariData
            // 
            this.suvariData.DataSetName = "SuvariData";
            this.suvariData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suvariDataBindingSource
            // 
            this.suvariDataBindingSource.DataSource = this.suvariData;
            this.suvariDataBindingSource.Position = 0;
            // 
            // magazaTanimBindingSource
            // 
            this.magazaTanimBindingSource.DataMember = "MagazaTanim";
            this.magazaTanimBindingSource.DataSource = this.suvariDataBindingSource;
            // 
            // magazaTanimTableAdapter
            // 
            this.magazaTanimTableAdapter.ClearBeforeFill = true;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "RecordId";
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolgeKoduDataGridViewTextBoxColumn
            // 
            this.bolgeKoduDataGridViewTextBoxColumn.DataPropertyName = "BolgeKodu";
            this.bolgeKoduDataGridViewTextBoxColumn.HeaderText = "BolgeKodu";
            this.bolgeKoduDataGridViewTextBoxColumn.Name = "bolgeKoduDataGridViewTextBoxColumn";
            this.bolgeKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaKoduDataGridViewTextBoxColumn
            // 
            this.magazaKoduDataGridViewTextBoxColumn.DataPropertyName = "MagazaKodu";
            this.magazaKoduDataGridViewTextBoxColumn.HeaderText = "MagazaKodu";
            this.magazaKoduDataGridViewTextBoxColumn.Name = "magazaKoduDataGridViewTextBoxColumn";
            this.magazaKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaKisaKoduDataGridViewTextBoxColumn
            // 
            this.magazaKisaKoduDataGridViewTextBoxColumn.DataPropertyName = "MagazaKisaKodu";
            this.magazaKisaKoduDataGridViewTextBoxColumn.HeaderText = "MagazaKisaKodu";
            this.magazaKisaKoduDataGridViewTextBoxColumn.Name = "magazaKisaKoduDataGridViewTextBoxColumn";
            this.magazaKisaKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaAdiDataGridViewTextBoxColumn
            // 
            this.magazaAdiDataGridViewTextBoxColumn.DataPropertyName = "MagazaAdi";
            this.magazaAdiDataGridViewTextBoxColumn.HeaderText = "MagazaAdi";
            this.magazaAdiDataGridViewTextBoxColumn.Name = "magazaAdiDataGridViewTextBoxColumn";
            this.magazaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaTipiDataGridViewTextBoxColumn
            // 
            this.magazaTipiDataGridViewTextBoxColumn.DataPropertyName = "MagazaTipi";
            this.magazaTipiDataGridViewTextBoxColumn.HeaderText = "MagazaTipi";
            this.magazaTipiDataGridViewTextBoxColumn.Name = "magazaTipiDataGridViewTextBoxColumn";
            this.magazaTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaLokasyonTipiDataGridViewTextBoxColumn
            // 
            this.magazaLokasyonTipiDataGridViewTextBoxColumn.DataPropertyName = "MagazaLokasyonTipi";
            this.magazaLokasyonTipiDataGridViewTextBoxColumn.HeaderText = "MagazaLokasyonTipi";
            this.magazaLokasyonTipiDataGridViewTextBoxColumn.Name = "magazaLokasyonTipiDataGridViewTextBoxColumn";
            this.magazaLokasyonTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaAlanDataGridViewTextBoxColumn
            // 
            this.magazaAlanDataGridViewTextBoxColumn.DataPropertyName = "MagazaAlan";
            this.magazaAlanDataGridViewTextBoxColumn.HeaderText = "MagazaAlan";
            this.magazaAlanDataGridViewTextBoxColumn.Name = "magazaAlanDataGridViewTextBoxColumn";
            this.magazaAlanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaIliDataGridViewTextBoxColumn
            // 
            this.magazaIliDataGridViewTextBoxColumn.DataPropertyName = "MagazaIli";
            this.magazaIliDataGridViewTextBoxColumn.HeaderText = "MagazaIli";
            this.magazaIliDataGridViewTextBoxColumn.Name = "magazaIliDataGridViewTextBoxColumn";
            this.magazaIliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ılBolgesiDataGridViewTextBoxColumn
            // 
            this.ılBolgesiDataGridViewTextBoxColumn.DataPropertyName = "IlBolgesi";
            this.ılBolgesiDataGridViewTextBoxColumn.HeaderText = "IlBolgesi";
            this.ılBolgesiDataGridViewTextBoxColumn.Name = "ılBolgesiDataGridViewTextBoxColumn";
            this.ılBolgesiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaAdresDataGridViewTextBoxColumn
            // 
            this.magazaAdresDataGridViewTextBoxColumn.DataPropertyName = "MagazaAdres";
            this.magazaAdresDataGridViewTextBoxColumn.HeaderText = "MagazaAdres";
            this.magazaAdresDataGridViewTextBoxColumn.Name = "magazaAdresDataGridViewTextBoxColumn";
            this.magazaAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaYetkilisiAdiDataGridViewTextBoxColumn
            // 
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn.DataPropertyName = "MagazaYetkilisiAdi";
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn.HeaderText = "MagazaYetkilisiAdi";
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn.Name = "magazaYetkilisiAdiDataGridViewTextBoxColumn";
            this.magazaYetkilisiAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaYetkilisiUnvaniDataGridViewTextBoxColumn
            // 
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn.DataPropertyName = "MagazaYetkilisiUnvani";
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn.HeaderText = "MagazaYetkilisiUnvani";
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn.Name = "magazaYetkilisiUnvaniDataGridViewTextBoxColumn";
            this.magazaYetkilisiUnvaniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaSabitHatNoDataGridViewTextBoxColumn
            // 
            this.magazaSabitHatNoDataGridViewTextBoxColumn.DataPropertyName = "MagazaSabitHatNo";
            this.magazaSabitHatNoDataGridViewTextBoxColumn.HeaderText = "MagazaSabitHatNo";
            this.magazaSabitHatNoDataGridViewTextBoxColumn.Name = "magazaSabitHatNoDataGridViewTextBoxColumn";
            this.magazaSabitHatNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaGSMNoDataGridViewTextBoxColumn
            // 
            this.magazaGSMNoDataGridViewTextBoxColumn.DataPropertyName = "MagazaGSMNo";
            this.magazaGSMNoDataGridViewTextBoxColumn.HeaderText = "MagazaGSMNo";
            this.magazaGSMNoDataGridViewTextBoxColumn.Name = "magazaGSMNoDataGridViewTextBoxColumn";
            this.magazaGSMNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaMailDataGridViewTextBoxColumn
            // 
            this.magazaMailDataGridViewTextBoxColumn.DataPropertyName = "MagazaMail";
            this.magazaMailDataGridViewTextBoxColumn.HeaderText = "MagazaMail";
            this.magazaMailDataGridViewTextBoxColumn.Name = "magazaMailDataGridViewTextBoxColumn";
            this.magazaMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn
            // 
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn.DataPropertyName = "MagazaYetkilisiKisiselGSMNo";
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn.HeaderText = "MagazaYetkilisiKisiselGSMNo";
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn.Name = "magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn";
            this.magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turkiyeSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "turkiyeSorgu";
            this.Text = "turkiyeSorgu";
            this.Load += new System.EventHandler(this.turkiyeSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suvariData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suvariDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazaTanimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource suvariDataBindingSource;
        private SuvariData suvariData;
        private System.Windows.Forms.BindingSource magazaTanimBindingSource;
        private SuvariDataTableAdapters.MagazaTanimTableAdapter magazaTanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaKisaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaLokasyonTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaAlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaIliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılBolgesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaYetkilisiAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaYetkilisiUnvaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaSabitHatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaGSMNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magazaYetkilisiKisiselGSMNoDataGridViewTextBoxColumn;

    }
}