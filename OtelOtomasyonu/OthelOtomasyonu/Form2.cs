using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OthelOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-AQE46M4;Initial Catalog=bilgi;Integrated Security=True");

        public void verileriTemizle()
        {
            listView1.Items.Clear();
        }

        public void alanlariTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
        }

        public void verileriGoster()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From musteri", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["gTarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["hesap"].ToString());
                ekle.SubItems.Add(oku["cTarihi"].ToString());
 
                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriTemizle();
            verileriGoster();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button4.Left = pictureBox20.Left;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Insert Into musteri (id, ad, soyad, odaNo, gTarih, telefon, hesap, cTarihi) values ('" + textBox8.Text.ToString() + "','" +
                textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" +
                textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "')",baglantı);

            komut.ExecuteNonQuery();
            baglantı.Close();

            verileriTemizle();
            verileriGoster();

            alanlariTemizle();
        }

        int id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("Delete From musteri where id= (" + id + ")", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

            verileriTemizle();
            verileriGoster();

            alanlariTemizle();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;        
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;

            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }
        
        Form1 f1 = new Form1();

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            f1.home();
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
