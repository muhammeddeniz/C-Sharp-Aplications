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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        public void odaServisi()
        {
            this.Hide();
            Form5 odaServisi = new Form5();
            odaServisi.Show();
        }
        public void home()
        {
            this.Hide();
            Form3 home = new Form3();
            home.Show();
        }
        public void mLogin()
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
        public void customer()
        {
            this.Hide();
            Form4 customer = new Form4();
            customer.Show();
        }
        public void aboutUs()
        {
            this.Hide();
            Form6 about = new Form6();
            about.Show();
        }
        
        string name, sifre;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı Adı = 'admin' \nŞifre = '123'");
            name = "admin";
            sifre = "123";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
         
            Form2 kayıtSayfassı = new Form2();

            if (textBox1.Text == name && textBox2.Text == sifre)
            {
                kayıtSayfassı.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE VEYA KULLANICI ADI!");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=tr"); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gmail.com");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            sifre = textBox2.Text;

            MessageBox.Show("KAYIT BAŞARILI!");

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
