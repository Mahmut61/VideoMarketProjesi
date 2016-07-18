using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(cGenel.connStr);
        private void btnGetir_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            dt=fs.SatislariGetirByTarihlerArasi(dtpTarih1.Value,dtpTarih2.Value);
            dgvSatislar.DataSource = dt;
            dgvSatislar.Columns[0].Visible = false;
            dgvSatislar.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSatislar.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSatislar.Columns["Adet"].Width = 70;
            int TAdet = 0;
            double TTutar = 0;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    TAdet += Convert.ToInt32(dr["Adet"]);
            //    TTutar += Convert.ToDouble(dr["Tutar"]);
            //}
            for (int i = 0; i < dgvSatislar.Rows.Count; i++)
			{
                TAdet += Convert.ToInt32(dgvSatislar.Rows[i].Cells["Adet"].Value);
                TTutar += Convert.ToDouble(dgvSatislar.Rows[i].Cells["Tutar"].Value);
			}
            
            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();

            this.reportViewer1.Visible = false;
        }

        private void frmSatisSorgulama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VideoMarketDataSet1.vwDetayliSatis' table. You can move, or remove it, as needed.
            this.vwDetayliSatisTableAdapter.Fill(this.VideoMarketDataSet1.vwDetayliSatis);

            this.reportViewer1.RefreshReport();
        }

        private void btnYazici_Click(object sender, EventArgs e)
        {
            this.VideoMarketDataSet1.vwDetayliSatis.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select Convert(varchar(20),Tarih,104) as IslemTarihi, MusteriAd + ' ' + MusteriSoyad as Musteri,FilmAd,BirimFiyat,Adet,Adet*BirimFiyat as Tutar from FilmSatis fs inner join Musteriler m on fs.MusteriNo=m.MusteriNo inner join Filmler f on f.FilmNo=fs.FilmNo where fs.Silindi=0 and Convert(Date,Tarih,104) Between Convert(Date,@Tarih1,104) and Convert(Date,@Tarih2,104) order by SatisNo desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = dtpTarih1.Value;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = dtpTarih2.Value;
            try
            {
                da.Fill(this.VideoMarketDataSet1.vwDetayliSatis);
                this.reportViewer1.Visible = true;
                this.reportViewer1.Top = 90;
                this.reportViewer1.Left = 30;
                this.reportViewer1.Height = 400;
                this.reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }

              //this.vwDetayliSatisTableAdapter.Fill(this.VideoMarketDataSet1.vwDetayliSatis);
              
        }
    }
}
