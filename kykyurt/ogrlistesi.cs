using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kykyurt
{
    public partial class ogrlistesi : Form
    {
        public ogrlistesi()
        {
            InitializeComponent();
        }

        private void ogrlistesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kykyurtDataSet6.ogrencibilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencibilgiTableAdapter.Fill(this.kykyurtDataSet6.ogrencibilgi);

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ogrduzenle fr = new ogrduzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            

            fr.Show();

        }
    }
}
