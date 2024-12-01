using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        int toplam1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int zar1 = rnd.Next(1, 7);
            int zar2 = rnd.Next(1, 7);

            label1.Text = zar1.ToString();

            label2.Text = zar2.ToString();

            toplam1 += zar1 + zar2;

            label5.Text = "Puan= " + toplam1;

            button1.Enabled = false;
            button2.Enabled = true;
        }

        int toplam2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int zar1 = rnd.Next(1, 7);
            int zar2 = rnd.Next(1, 7);

            label4.Text = zar1.ToString();

            label3.Text = zar2.ToString();

            toplam2 += zar1 + zar2;

            label6.Text="Puan= " + toplam2;

            button2.Enabled = false;
            button1.Enabled = true;

            if (toplam1>=50)
            {
                label7.Text = "Kazanan: Oyuncu 1";
                MessageBox.Show("Bitti");
            }
            else if (toplam2>=50)
            {
                label7.Text = "Kazanan: Oyuncu 2";
                MessageBox.Show("Bitti");
            }
        }
    }
}
