using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kykyurt
{
    public partial class notekle : Form
    {
        public notekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt yeri seçin";
            saveFileDialog1.Filter = "Metin dosyası  | *.txt";
            saveFileDialog1.InitialDirectory = "C:\\notlar";

            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("kayıt yapıldı");
        }
    }
}
