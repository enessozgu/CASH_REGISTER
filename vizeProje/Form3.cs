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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        public int masa2Tutar = 0;

        int manti = 100;
        int pilav = 50;
        int makarna = 20;
        int ayran = 10;
        int limonata = 15;
        int su = 5;
        int sufle = 50;
        int tiramisu = 40;
        int revani = 30;



        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 fr1 = new Form7();

            fr1.label2.Text = masa2Tutar.ToString();
            fr1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\nToplam Tutar=>" + masa2Tutar);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add("Pilav =>" + pilav);
            masa2Tutar += 50;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add("manti =>" + manti);
            masa2Tutar += 100;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add("Makarna =>" + makarna);
            masa2Tutar += 20;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ayran =>" + ayran);
            masa2Tutar += 10;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Limonata =>" + limonata);
            masa2Tutar += 15;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Su =>" + su);
            masa2Tutar += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Sufle =>" + sufle);
            masa2Tutar += 50;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Tiramisu =>" + tiramisu);
            masa2Tutar += 40;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Revani =>" + revani);
            masa2Tutar += 30;
        }
    }
}
