namespace wfVideoMarketProjesi
{
    partial class frmSatisSorgulama
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnYazici = new System.Windows.Forms.Button();
            this.VideoMarketDataSet1 = new wfVideoMarketProjesi.VideoMarketDataSet1();
            this.vwDetayliSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDetayliSatisTableAdapter = new wfVideoMarketProjesi.VideoMarketDataSet1TableAdapters.vwDetayliSatisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetayliSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(102, 29);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(143, 20);
            this.dtpTarih1.TabIndex = 0;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(341, 29);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(143, 20);
            this.dtpTarih2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Tarih";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(34, 84);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatislar.Size = new System.Drawing.Size(549, 296);
            this.dgvSatislar.TabIndex = 4;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(228, 55);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(131, 23);
            this.btnGetir.TabIndex = 5;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Toplam:";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(531, 386);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(52, 20);
            this.txtToplamTutar.TabIndex = 14;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(470, 386);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(52, 20);
            this.txtToplamAdet.TabIndex = 15;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwDetayliSatisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "wfVideoMarketProjesi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(34, 414);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(549, 133);
            this.reportViewer1.TabIndex = 17;
            this.reportViewer1.Visible = false;
            // 
            // btnYazici
            // 
            this.btnYazici.Location = new System.Drawing.Point(34, 383);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(118, 23);
            this.btnYazici.TabIndex = 18;
            this.btnYazici.Text = "Yazıcıya Gonder";
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // VideoMarketDataSet1
            // 
            this.VideoMarketDataSet1.DataSetName = "VideoMarketDataSet1";
            this.VideoMarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDetayliSatisBindingSource
            // 
            this.vwDetayliSatisBindingSource.DataMember = "vwDetayliSatis";
            this.vwDetayliSatisBindingSource.DataSource = this.VideoMarketDataSet1;
            // 
            // vwDetayliSatisTableAdapter
            // 
            this.vwDetayliSatisTableAdapter.ClearBeforeFill = true;
            // 
            // frmSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(608, 559);
            this.Controls.Add(this.btnYazici);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Name = "frmSatisSorgulama";
            this.Text = "Detaylı Satış Sorgulama";
            this.Load += new System.EventHandler(this.frmSatisSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoMarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetayliSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnYazici;
        private System.Windows.Forms.BindingSource vwDetayliSatisBindingSource;
        private VideoMarketDataSet1 VideoMarketDataSet1;
        private VideoMarketDataSet1TableAdapters.vwDetayliSatisTableAdapter vwDetayliSatisTableAdapter;
    }
}