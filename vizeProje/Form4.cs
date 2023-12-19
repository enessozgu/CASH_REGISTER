using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int anaYemek = 100;
        int tatli = 50;
        int icicek = 20;

        public int masa3Tutar = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ana Yemek =>" + anaYemek);
            masa3Tutar += 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("İçicek =>" + icicek);
            masa3Tutar += 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Tatlı =>" + tatli);
            masa3Tutar += 50;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\n\nToplam Tutar =>" + masa3Tutar);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\nToplam Tutar=>" + masa3Tutar);
        }
    }
}
