using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        int manti = 100;
        int pilav = 50;
        int makarna = 20;
        int ayran = 10;
        int limonata = 15;
        int su = 5;
        int sufle = 50;
        int tiramisu = 40;
        int revani = 30;


        public int masa1Tutar = 0;


        public void button5_Click(object sender, EventArgs e)
        {


            Form1 fr2 = new Form1();
            fr2.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        public void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("manti =>" + manti);
            masa1Tutar += 100;


        }

        public void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Makarna =>" + makarna);
            masa1Tutar += 20;


        }

        public void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Pilav =>" + pilav);
            masa1Tutar += 50;


        }

        public void button4_Click(object sender, EventArgs e)
        {


            Form7 fr1 = new Form7();

            fr1.label1.Text = masa1Tutar.ToString();
            fr1.Show();
            this.Hide();



        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("\nToplam Tutar=>" + masa1Tutar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Ayran =>" + ayran);
            masa1Tutar += 10;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Limonata =>" + limonata);
            masa1Tutar += 15;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Sufle =>" + sufle);
            masa1Tutar += 50;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Tiramisu =>" + tiramisu);
            masa1Tutar += 40;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Revani =>" + revani);
            masa1Tutar += 30;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Su =>" + revani);
            masa1Tutar += 5;
        }
    }
}
