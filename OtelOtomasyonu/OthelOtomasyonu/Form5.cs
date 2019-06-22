using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OthelOtomasyonu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Oda " + textBox1.Text + "\n";

            if (radioButton1.Checked == true)
            {
                label3.Text += radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                label3.Text += radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                label3.Text += radioButton3.Text;
            }
            if (checkBox1.Checked == true)
            {
                label3.Text += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                label3.Text += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                label3.Text += checkBox3.Text;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Left = pictureBox17.Left;
        }

        Form1 f1 = new Form1();

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            f1.home();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            f1.mLogin();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            f1.aboutUs();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            f1.customer();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
