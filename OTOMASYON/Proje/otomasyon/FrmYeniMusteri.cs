using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace otomasyon
{
    public partial class FrmYeniMusteri : Form
    {

        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERKANGENC\\SQLEXPRESS;Initial Catalog=ŞimşekMcqPansiyon;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";

        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnOda110_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "110";
        }

        private void BtnOda111_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "111";
        }

        private void BtnOda112_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "112";
        }

        private void BtnOdaDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void BtnOdaBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpCıkısTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;

            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCıkısTarihi.Text);

            TimeSpan Sonuc = BuyukTarih - KucukTarih;

            Sayac.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(Sayac.Text) * 500;

            TxtUcret.Text = Ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,SoyAdi,Cinsiyet) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + CmbCinsiyet.Text + "')", baglanti);


            baglanti.Close();
            MessageBox.Show("Müsteri kayıt yapıldı.");



        }


    }
}
