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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kykyurtDataSet4.ogrencibilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencibilgiTableAdapter3.Fill(this.kykyurtDataSet4.ogrencibilgi);
            // TODO: Bu kod satırı 'kykyurtDataSet3.ogrencibilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencibilgiTableAdapter2.Fill(this.kykyurtDataSet3.ogrencibilgi);
            // TODO: Bu kod satırı 'kykyurtDataSet2.ogrencibilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencibilgiTableAdapter1.Fill(this.kykyurtDataSet2.ogrencibilgi);
            // TODO: Bu kod satırı 'kykyurtDataSet1.ogrencibilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencibilgiTableAdapter.Fill(this.kykyurtDataSet1.ogrencibilgi);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hESAPMAKİNESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void fM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://trkvz-radyolar.ercdn.net/ahaberradyo/playlist.m3u8";
        }

        private void fM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtturku.live.trt.com.tr/master.m3u8";
        }

        private void öĞRENCİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmogrencibilgikyt fr = new Frmogrencibilgikyt();
            fr.Show();
        }

        private void öĞRENCİLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrlistesi fr = new ogrlistesi();
            fr.Show();
        }

        private void öĞRENCİDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrduzenle fr = new ogrduzenle();
            fr.Show();
        }

        private void öDEMEALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmödeme fr = new frmödeme();
            fr.Show();
        }

        private void gelirİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geliriststk fr = new geliriststk();
            fr.Show();
        }

        private void nOTEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notekle fr = new notekle();
            fr.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖZEL ÖĞRENCİ YURT OTOMASYONU ","PROJE ÖDEVİ" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
