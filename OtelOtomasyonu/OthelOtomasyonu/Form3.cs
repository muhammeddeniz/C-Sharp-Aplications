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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Left = pictureBox21.Left;      
        }

        Form1 f1 = new Form1();

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
