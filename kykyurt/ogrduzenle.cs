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
namespace kykyurt
{
    public partial class ogrduzenle : Form
    {
        public ogrduzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,tc,telefon,dogum,bolum;

        private void cmbodano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void butngncl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update ogrencibilgi set ograd=@p2,ogrsoyad=@p3,ogrtc=@p4,ogrtelefon=@p5,ogrdogum=@p6,ogrbolum=@p7,ogrmail=@p8,ogrodano=@p9,ogryakınıtel=@p10,adres=@p11 where ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", txtograd.Text);
                komut.Parameters.AddWithValue("@p3", textogrsoyad.Text);
                komut.Parameters.AddWithValue("@p4", msktc.Text);
                komut.Parameters.AddWithValue("@p5", msktel.Text);
                komut.Parameters.AddWithValue("@p6", mskdgm.Text);
                komut.Parameters.AddWithValue("@p7", cmbbolum.Text);
                komut.Parameters.AddWithValue("@p8", ogrmail.Text);
                komut.Parameters.AddWithValue("@p9", cmbodano.Text);
                komut.Parameters.AddWithValue("@p10", mskykn.Text);
                komut.Parameters.AddWithValue("@p11", textBox4.Text);


                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT GÜNCELLENDİ");
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }


        }

        public string mail, odano,  velitel, adres;
        private void ogrduzenle_Load(object sender, EventArgs e)
        {
            textBox1.Text = id;
            txtograd.Text = ad;
            textogrsoyad.Text = soyad;
            msktc.Text = tc;
            msktel.Text = telefon;
            mskdgm.Text = dogum;
            mskykn.Text = velitel;
            textBox4.Text = adres;
            cmbodano.Text = odano;
            cmbbolum.Text = bolum;
            ogrmail.Text = mail;


            SqlCommand komut2 = new SqlCommand("Select odano from odalar where odakapasite !=odaaktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbodano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }
    }
}
