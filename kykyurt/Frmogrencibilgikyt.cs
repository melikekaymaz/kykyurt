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
    public partial class Frmogrencibilgikyt : Form
    {
        public Frmogrencibilgikyt()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmogrencibilgikyt_Load(object sender, EventArgs e)
        {
                
                SqlCommand komut = new SqlCommand("Select bolumad from bolumler", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbbolum.Items.Add(oku[0].ToString());
                }
                bgl.baglanti().Close();

            
            SqlCommand komut2 = new SqlCommand("Select odano from odalar where odakapasite !=odaaktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbodano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //öğrenci bilgilerini kayıt etme
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into ogrencibilgi(ograd,ogrsoyad,ogrtc,ogrtelefon,ogrdogum,ogrbolum,ogrmail,ogrodano,ogryakınıtel,adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());

                komutkaydet.Parameters.AddWithValue("@p1", txtograd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", textogrsoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", msktc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", msktel.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskdgm.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbbolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", ogrmail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbodano.Text);
                komutkaydet.Parameters.AddWithValue("@p9", mskykn.Text);
                komutkaydet.Parameters.AddWithValue("@p10", textBox4.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR.");

                //öğrenci id yi labele çekelim
                SqlCommand komut = new SqlCommand("select ogrid from ogrencibilgi", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label9.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();




                //öğrenci ödemesi alanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into ödeme(ogrid,ograd,ogrsoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1",label9.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtograd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", textogrsoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
                
            }





        }

        private void cmbodano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

//Data Source = LAPTOP - //LH9FG425\SQLEXPRESS; Initial Catalog = kykyurt; Integrated Security = True