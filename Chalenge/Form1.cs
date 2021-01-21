using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chalenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string[] angka1 = new string[99];
        public int a = 0;
        private void button24_Click(object sender, EventArgs e)
        {
            angka1[a] = "1";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            angka1[a] = "2";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            angka1[a] = "3";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            angka1[a] = "4";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            angka1[a] = "5";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            angka1[a] = "6";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka1[a] = "7";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            angka1[a] = "8";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            angka1[a] = "9";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textAngka.Text = "";
            a = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textAngka.Text = "";
            a = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textAngka.Text = "";
            for (int i = 0; i <a - 1; i++)
            {
                textAngka.Text = textAngka.Text + angka1[i];
            }
            a--;
        }
        

        private void button28_Click(object sender, EventArgs e)
        {
            angka1[a] = ".";
            textAngka.Text = textAngka.Text + angka1[a];
            a++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textAngka.Text);
            if (x > 0)
            {
                x = x * -1;
                textAngka.Text = Convert.ToString(x);
            }
            else if (x < 0)
            {
                x = x * -1;
                textAngka.Text = Convert.ToString(x);
            }
        }
    }
}
