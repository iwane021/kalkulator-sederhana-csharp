using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorIwan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hasil = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);

            calculateAngka(hasil);
            textBox_Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double hasil = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);

            calculateAngka(hasil);
            textBox_Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double hasil = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);

            calculateAngka(hasil);
            textBox_Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double hasil = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);

            calculateAngka(hasil);
            textBox_Clear();
        }

        private void calculateAngka(double hasil)
        {
            textBox3.Text = Convert.ToString(hasil);
        }

        private void textBox_Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int h = 58; h <= 127; h++)
            {
                if (e.KeyChar == h)
                {
                    e.Handled = true;
                }
            }
            for (int k = 32; k <= 47; k++)
            {
                if (e.KeyChar == k)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int h = 58; h <= 127; h++)
            {
                if (e.KeyChar == h)
                {
                    e.Handled = true;
                }
            }
            for (int k = 32; k <= 47; k++)
            {
                if (e.KeyChar == k)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
