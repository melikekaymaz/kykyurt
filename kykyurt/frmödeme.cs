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
    public partial class frmödeme : Form
    {
        public frmödeme()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void frmödeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kykyurtDataSet5.ödeme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ödemeTableAdapter.Fill(this.kykyurtDataSet5.ödeme);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = kalan;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan çıkarma
            
            int ödenen, kalan, yeniborc;
            ödenen = Convert.ToInt16(textBox3.Text);
            kalan = Convert.ToInt16(textBox2.Text);
            yeniborc = kalan - ödenen;
            textBox2.Text = yeniborc.ToString();

            //yeni tutarı veri tabannına ekleme
            SqlCommand komut = new SqlCommand("update ödeme set ogrkalanborcu=@p1 where ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BORCUNUZ ÖDENDİ,KAYIT ALINDI");
            this.ödemeTableAdapter.Fill(this.kykyurtDataSet5.ödeme);

            //KASAYA EKLEME

            SqlCommand komut2 = new SqlCommand("insert into kasa (odemeay,odemetutar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", textBox4.Text);
            komut2.Parameters.AddWithValue("@k2", textBox3.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
