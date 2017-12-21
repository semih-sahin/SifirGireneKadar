using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifirGirdigindeKapananProg
{
    public partial class Form1 : Form
    {
        int sayi, ptop = 0, padet = 0, ntop = 0, nadet = 0, sayac=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac == 1)
                {
                    textBox1.Text = "Bitti";
                }
                sayi = Convert.ToInt32(textBox1.Text);
                if (sayi == 0)
                {
                    textBox2.Text = Convert.ToString(padet);
                    textBox3.Text = Convert.ToString(ptop);
                    textBox4.Text = Convert.ToString(nadet);
                    textBox5.Text = Convert.ToString(ntop);
                    sayac = 1;
                }
                if (sayi > 0)
                {
                    padet++;
                    ptop += sayi;
                    textBox1.Text = "";
                }
                if (sayi < 0)
                {
                    nadet++;
                    ntop += sayi;
                    textBox1.Text = "";
                }
                if (sayac == 1)
                {
                    textBox1.Text = "Bitti";
                }
            }
            catch (Exception)
            {
                textBox1.Text = "Bitti!";
            }
        }
    }
}
