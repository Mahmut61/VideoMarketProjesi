using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitmfilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTurleri frm = new frmFilmTurleri();
            //frm.MdiParent = this;
            //frm.ShowDialog();
            FormAcikMi(frm);
        }

        private void FormAcikMi(Form AcilacakForm)//Peş Peşe form açmaması için yazdık.
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else { AcilacakForm.Dispose(); }
        }

        private void mitmfilmTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmler frm = new frmFilmler();
            FormAcikMi(frm);
        }

        private void mitmfilmSorgulama_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            FormAcikMi(frm);
        }

        private void mitmmusteriTanimlama_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            FormAcikMi(frm);
        }

        private void mitmmusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            FormAcikMi(frm);
        }

        private void mitmfilmSatıs_Click(object sender, EventArgs e)
        {
            frmFilmSatis frm = new frmFilmSatis();
            FormAcikMi(frm);
        }

        private void mitmsatısSorgulama_Click(object sender, EventArgs e)
        {
            frmSatisSorgulama frm = new frmSatisSorgulama();
            FormAcikMi(frm);
        }

        private void mitmdetayliSatısSorgulama_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
            FormAcikMi(frm);
        }
    }
}
