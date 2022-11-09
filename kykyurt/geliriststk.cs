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
    public partial class geliriststk : Form
    {
        public geliriststk()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void geliriststk_Load(object sender, EventArgs e)
        {

            // kasadaki miktar
            SqlCommand komut = new SqlCommand("select sum(odemetutar) from kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                label2.Text = oku[0].ToString() + "TL";

            }
            bgl.baglanti().Close();

            //ayları tekrarsız distinc ile getirme

            SqlCommand komut2 = new SqlCommand("select distinct(odemeay) from kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox1.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            //GRAFİĞE VERİ TABANINDAN VERİ ÇEKME

            SqlCommand komut3 = new SqlCommand("select odemeay,sum(odemetutar)from kasa group by odemeay", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["AYLIK"].Points.AddXY(oku3[0],oku3[1]);
            }

            bgl.baglanti().Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(odemetutar) from kasa where odemeay=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label4.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
