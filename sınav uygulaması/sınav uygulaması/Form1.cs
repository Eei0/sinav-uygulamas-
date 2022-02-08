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

namespace sınav_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void saveToTxt()
        {
            string ad = textBox1.Text;
            int snf = Convert.ToInt32(textBox2.Text);
            string cins = comboBox1.Text;

            FileStream fw;
            StreamWriter sw;
            fw = new FileStream(path: @"C:/Users/eeisc/Desktop/c#\uygulamalar\bilgiler.txt", mode: FileMode.Append, access: FileAccess.Write);
            sw = new StreamWriter(fw);
            sw.WriteLine(ad);
            sw.WriteLine(snf.ToString());
            sw.WriteLine(cins);
            sw.Close();
            fw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveToTxt();
            MessageBox.Show("KAYDOLMA BAŞARILI");
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 for1m = new Form1();
            Form2 form = new Form2();
            form.Show();
            for1m.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider provider = new ErrorProvider();
            if (Convert.ToInt32(textBox2.Text) >12)
            {
                provider.SetError(textBox2, "sınıf 12 den büyük olamaz");
            }
            else
            {
                provider.Clear();
            }
        }
    }
}
