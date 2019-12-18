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
            Double s, spr, sgo, month;
            Double sn = Convert.ToDouble(textBox1.Text);
            Double sr = Convert.ToDouble(textBox2.Text);

            spr = sn / 100 * 8;
            sgo = sn + spr;
            month = sgo / 12;
            s = sn + month * sr;
            string f = Convert.ToString(s);
            label8.Text = f;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Text += trackBar3.Value;
            Double s, s2, spr, spr2, sgo, sgo2, month, month2;
            Double sn = Convert.ToDouble(textBox1.Text);
            Double sr = Convert.ToDouble(textBox2.Text);
            Double se = Convert.ToDouble(textBox3.Text);

            sn = sn + se;

            spr = sn / 100 * 5;
            spr2 = sn / 100 * 6;
            sgo = sn + spr;
            sgo2 = sn + spr2;
            month = sgo / 12;
            month2 = sgo2 / 12;
            s = sn + month * sr;
            s2 = sn + month2 * sr;
            string f = Convert.ToString(s);
            string f2 = Convert.ToString(s2);
            label9.Text = f;
            label10.Text = f2;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Деньги_в_каждый_карман_isip182НСГВ.Form3();
            f3.Show();
            f3.label8.Text = label8.Text;
            f3.label20.Text = label9.Text;
            f3.label26.Text = label10.Text;
            float sum = Convert.ToInt32(textBox1.Text);
            float srokvk = Convert.ToInt32(textBox2.Text);
            float monrefill = Convert.ToInt32(textBox3.Text);
            float prsum1 = (sum / 100 * 8) / 12 * srokvk;
            float prsum2 = ((sum + monrefill) / 100 * 5) / 12 * srokvk;
            float prsum3 = ((sum + monrefill) / 100 * 6) / 12 * srokvk;
            float yearsum1 = sum + prsum1;
            float yearsum2 = sum + prsum2;
            float yearsum3 = sum + prsum3;
            f3.label11.Text = yearsum1.ToString();
            f3.label17.Text = yearsum2.ToString();
            f3.label24.Text = yearsum3.ToString();
            Hide();
        }
    }
}
