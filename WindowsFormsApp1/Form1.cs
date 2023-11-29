using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)|| e.KeyChar =='.'||(sender as TextBox).Text.IndexOf(',')>-1)
            {
                e.Handled = true;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            sınıf.sa=textBox1.Text;
            label1.Text=sınıf.sa;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == '.' || (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sınıf.A = Convert.ToInt32(textBox2.Text);
                label1.Text = sınıf.A.ToString();
            }
            catch
            {

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int a= Convert.ToInt32( textBox2.Text );    
            textBox2.Text = a.ToString("#,###.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sınıf.Büyükyaz=textBox3.Text;
            label1.Text=sınıf.Büyükyaz.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sınıf.F = textBox3.Text;
            label1.Text=sınıf.F.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}