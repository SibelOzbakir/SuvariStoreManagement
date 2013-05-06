namespace SuvariStoreManagement
{
    partial class magazaSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magazaSorgu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMagazaKisaKodu = new System.Windows.Forms.ComboBox();
            this.cmbMagazaAdi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.suvariData1 = new SuvariStoreManagement.SuvariData();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.magazaTanimTableAdapter = new SuvariStoreManagement.SuvariDataTableAdapters.MagazaTanimTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suvariData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magaza Kısa Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Magaza Adı";
            // 
            // cmbMagazaKisaKodu
            // 
            this.cmbMagazaKisaKodu.FormattingEnabled = true;
            this.cmbMagazaKisaKodu.Items.AddRange(new object[] {
            "ADC",
            "ADM",
            "AKE",
            "ATA",
            "AYO",
            "BSC",
            "ADY",
            "AMK",
            "AEA",
            "AAN",
            "ABC",
            "AIM",
            "ANF",
            "ANV",
            "OPT",
            "ALN",
            "ANT",
            "ANN",
            "AYF",
            "SSR",
            "BMB",
            "BMH",
            "BIA",
            "BNC",
            "BRA",
            "BRS",
            "DNT",
            "DNZ",
            "DSP",
            "DNP",
            "DOF",
            "DYB",
            "ELZ",
            "EZI",
            "EZU",
            "GMA",
            "GMG",
            "GSP",
            "GRS",
            "APA",
            "HTY",
            "ISK",
            "212",
            "GMM",
            "IAA",
            "IAP",
            "IBF",
            "IET",
            "ILM",
            "IMF",
            "ISA",
            "IUC",
            "IYS",
            "KLE",
            "OLV",
            "UMR",
            "VIA",
            "IGO",
            "IKC",
            "MRS",
            "KYF",
            "KYP",
            "GBZ",
            "KNK",
            "KNM",
            "MLT",
            "MMM",
            "MKM",
            "MRF",
            "MRH",
            "MTT",
            "ORD",
            "OPA",
            "AAC",
            "HN1",
            "SML",
            "URF",
            "TKR",
            "TRF",
            "VMK"});
            this.cmbMagazaKisaKodu.Location = new System.Drawing.Point(160, 56);
            this.cmbMagazaKisaKodu.Name = "cmbMagazaKisaKodu";
            this.cmbMagazaKisaKodu.Size = new System.Drawing.Size(121, 21);
            this.cmbMagazaKisaKodu.TabIndex = 2;
            this.cmbMagazaKisaKodu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbMagazaAdi
            // 
            this.cmbMagazaAdi.FormattingEnabled = true;
            this.cmbMagazaAdi.Items.AddRange(new object[] {
            "Adana Carrefour AVM",
            "Adana M1 AVM",
            "Adana Kenan Evren Cad.",
            "Adana Atatürk Cad.",
            "Adana Optımum AVM",
            "Adana Beşocak Kuruköprü Mah. Cad.",
            "Adıyaman Ulucami Mah. Cad",
            "Afyon Kurtuluş Cad.",
            "Aksaray Efor AVM",
            "Ankara Antares AVM",
            "Ankara Batıkent Carrefour AVM",
            "Ankara Ankamall AVM",
            "Ankara Forum AVM",
            "Ankara Nata Vega AVM",
            "Ankara Optimum AVM",
            " Antalya / Alanya Ş.Tokuş Cad.",
            "Antalya Özdilek AVM",
            "Aydın Nazilli Cad.",
            "Aydın Forum AVM",
            "Balıkesir Susurluk Ulusoy Outletpark AVM",
            "Batman Batmanpark AVM",
            "Bolu Hıghway AVM",
            "Bursa İnegöl AVM",
            "Bursa Nilüfer Carrefour",
            "Bursa Anatolıum AVM",
            "Bursa Kentmeydanı AVM",
            "Denizli Teraspark AVM",
            "Denizli Forum AVM",
            "Denizli Sümerpark AVM",
            "Diyarbakır Ninova park AVM",
            "Diyarbakır Ofis Cad.",
            "Diyarbakır Mega Center AVM",
            "Elazığ Akgün AVM",
            "Erzincan Ermerkez AVM",
            "Erzurum Redevco AVM",
            " Gaziantep Mütercim Asım Cad.",
            " Gaziantep Gazimuhtarpaşa Bulvarı Cad.",
            " Gaziantep Sankopark AVM",
            "Giresun G-City AVM",
            "Antakya Prime Mall AVM",
            "Antakya Hatay Atatürk Cad.",
            "İskenderun Prime Mall AVM",
            "212 Power Outlet AVM",
            "İstanbul Genel Müd. ",
            "İstanbul Airport AVM",
            "İstanbul Avcılar Pelikan Mall AVM",
            "İstanbul Bayramapaşa Forum AVM",
            "İstanbul Torıum AVM",
            "İstanbul Levent Metrocity AVM",
            "İstanbul Marmara Forum AVM",
            "İstanbul Sefaköy Armonipark Outlet CenterAVM",
            "İstanbul Ümraniye Carrefour AVM",
            "İstanbul Starcity Outlat Center AVM",
            "İstanbul Kale Center AVM",
            " İstanbul Olivium AVM",
            "İstanbul Ümraniye Alemdağ Cad.",
            "İstanbul Viaport AVM",
            "İzmir Gaziemir Optimum AVM",
            "İzmir Karşıyaka Carrefour AVM",
            "Kahramanmaraş Azerbaycan Bulv. Cad.",
            "Kayseri Forum AVM",
            "Kayseri Park AVM",
            "Gebze Doğuş AVM",
            "Konya Kulesite AVM",
            "Konya M1 AVM",
            "Malatya Park AVM",
            "Manisa Magnesia AVM",
            "Mardin Kızıltepe Movapark AVM",
            "Mersin Forum AVM",
            "Mersin Hastane Cad.",
            "Mersin Tarsus Tarsu AVM",
            "Ordu Migros AVM",
            "Osmaniye Park 328 AVM",
            "Adapazarı Adacenter AVM",
            "Hendek 1 Parkshop AVM",
            "Samsun Lovelet AVM",
            "Şanlıurfa Şair Şevket Mah Cad.",
            "Tekirdağ Tekira AVM",
            "Trabzon Forum AVM",
            "Van Kazım Karabkir Cad."});
            this.cmbMagazaAdi.Location = new System.Drawing.Point(160, 109);
            this.cmbMagazaAdi.Name = "cmbMagazaAdi";
            this.cmbMagazaAdi.Size = new System.Drawing.Size(121, 21);
            this.cmbMagazaAdi.TabIndex = 3;
            this.cmbMagazaAdi.SelectedIndexChanged += new System.EventHandler(this.cmbMagazaAdi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rapor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 280);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 255);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(378, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton1.Text = "Geri";
            this.toolStripButton1.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // suvariData1
            // 
            this.suvariData1.DataSetName = "SuvariData";
            this.suvariData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "MagazaTanim";
            this.bindingSource1.DataSource = this.suvariData1;
            // 
            // magazaTanimTableAdapter
            // 
            this.magazaTanimTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // magazaSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 280);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbMagazaAdi);
            this.Controls.Add(this.cmbMagazaKisaKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "magazaSorgu";
            this.Text = "magazaSorgu";
            this.Load += new System.EventHandler(this.magazaSorgu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suvariData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMagazaKisaKodu;
        private System.Windows.Forms.ComboBox cmbMagazaAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private SuvariData suvariData1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SuvariDataTableAdapters.MagazaTanimTableAdapter magazaTanimTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}