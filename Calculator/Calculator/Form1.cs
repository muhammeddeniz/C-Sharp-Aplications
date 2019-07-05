using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        { Application.Exit(); }

        float firstValue = 0, secondValue = 0;
        string process;
        float upper = 1;
        float sonuc, kare, yüzde;

        #region numbers
        private void button4_Click(object sender, EventArgs e)
        { textBox1.Text = "1"; }

        private void button5_Click(object sender, EventArgs e)
        { textBox1.Text += "2"; }

        private void button6_Click(object sender, EventArgs e)
        { textBox1.Text += "3"; }

        private void button12_Click(object sender, EventArgs e)
        { textBox1.Text += "4"; }

        private void button11_Click(object sender, EventArgs e)
        { textBox1.Text += "5"; }

        private void button10_Click(object sender, EventArgs e)
        { textBox1.Text += "6"; }

        private void button9_Click(object sender, EventArgs e)
        { textBox1.Text += "7"; }

        private void button8_Click(object sender, EventArgs e)
        { textBox1.Text += "8"; }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button20_Click(object sender, EventArgs e)
        { textBox1.Text += "0"; }

        private void button19_Click(object sender, EventArgs e)
        { textBox1.Text += "."; }
        #endregion

        #region operations
        private void button3_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "plus";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "multiply";
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "minus";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "equals";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "upper";
        }
      
        private void button13_Click(object sender, EventArgs e)
        {
            firstValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            process = "remaining";
        }
        #endregion
        private void button17_Click(object sender, EventArgs e)
        {
            secondValue = float.Parse(textBox1.Text);
            textBox1.Clear();
            if (process == "plus")
            {
                secondValue += firstValue;
            }
            else if (process == "multiply")
            {
                secondValue *= firstValue;
            }
            else if (process == "minus")
            {
                secondValue = firstValue - secondValue;
            }
            else if (process == "equals")
            {
                secondValue /= firstValue;
            }
            else if (process == "upper")
            {
                for (int i = 1; i <= secondValue ; i++)
                {
                    upper *= firstValue;
                }
                secondValue = upper;
            }
            else if (process == "remaining")
            {
                secondValue = firstValue % secondValue;
            }
            
            textBox1.Text = secondValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        
       



    }
}
