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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int anaYemek = 100;
        int tatli = 50;
        int icicek = 20;

        public int masa4Tutar = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ana Yemek =>" + anaYemek);
            masa4Tutar += 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("İçicek =>" + icicek);
            masa4Tutar += 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Tatlı =>" + tatli);
            masa4Tutar += 50;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\n\nToplam Tutar =>" + masa4Tutar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\nToplam Tutar=>" + masa4Tutar);
        }
    }
}
