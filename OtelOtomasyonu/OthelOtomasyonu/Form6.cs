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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

      

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Left = pictureBox19.Left;
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
