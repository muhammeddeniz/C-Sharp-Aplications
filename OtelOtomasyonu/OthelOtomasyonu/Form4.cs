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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button3.Left = pictureBox16.Left;
            label9.Visible = false;
            textBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox2.Text!="" && textBox3.Text != "" && textBox5.Text != "" && 
                textBox6.Text!= "" )
            {
                label9.Visible = true;
                label9.Text = "KAYDINIZ BAŞARIYLA TAMAMLANDI \n " + textBox1.Text.ToUpper() + "  BEY";
            }
            else
            {
                MessageBox.Show("BOŞ ALAN BIRAKMAYINIZ!!!");
            }
            
       }

        private void oda8_Click(object sender, EventArgs e)
        {
            Button buton = new Button();

            buton = (Button)sender;     
            string isim = buton.Name;
            textBox3.Text = isim.Substring(3).ToString();

            panel2.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();                      
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

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            f1.odaServisi();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
