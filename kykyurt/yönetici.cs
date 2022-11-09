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
    public partial class yönetici : Form
    {
        public yönetici()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from yönetici where yoneticiad=@p1 and yoneticisifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                anaform fr = new anaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı ya da şifre!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            bgl.baglanti().Close();

        }
    }
}
