using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деньги_в_каждый_карман_isip182НСГВ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         int s
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text += trackBar1.Value;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text += trackBar2.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text += trackBar3.Value;
           
             
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
