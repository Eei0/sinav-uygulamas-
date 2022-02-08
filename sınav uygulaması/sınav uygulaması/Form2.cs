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
    public partial class Form2 : Form
        
    {
        public void puanlama()
        {
            int puan = 0;
            if (radioButton2.Checked == true) puan = puan+25;
            if (radioButton7.Checked == true) puan = puan+25;
            if (radioButton11.Checked == true) puan = puan+25;
            if (radioButton15.Checked == true) puan = puan+25;
            label5.Text = puan.ToString();
            FileStream fw;
            StreamWriter sw;
            fw = new FileStream(path: @"C:/Users/eeisc/Desktop/c#\uygulamalar\bilgiler.txt", mode: FileMode.Append, access: FileAccess.Write);
            sw = new StreamWriter(fw);
            sw.WriteLine("Alınan Puan: "+puan.ToString());
            sw.WriteLine("--------------------");
            label5.Text = "Sayın Öğrencimiz Puanınız: "+puan.ToString();
            fw.Close();
            sw.Close();
        }

        void timer()
        {
            timer1.Interval = 100;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                this.BackColor = Color.Red;
            }
        }

        void visibles()
        {
            button1.Visible = false;
            button3.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
        }
        void visibles2()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            lblDakika.Visible = false;
            lblSaniye.Visible = false;
            textBox1.Visible = false;
        }
        public Form2()
        {
            InitializeComponent();
        }

        int saniye = 60;
        int dakika = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            visibles();
            textBox1.Text = "15";
            timer1.Start();
            dakika = Convert.ToInt32(textBox1.Text);
            this.BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
            timer1.Stop();
            puanlama();
            visibles2();
            
            
            
            
            

            
        }
    }
}
