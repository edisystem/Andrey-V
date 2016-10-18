using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double a, b, c;
 a = Convert.ToDouble(textBox1.Text); 
 b = Convert.ToDouble(textBox2.Text);
 c = a + b;
 textBox3.Text = c.ToString(); 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox6.Text);
            b = Convert.ToDouble(textBox5.Text);
            textBox4.Text = (a + b).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
        
       
            textBox7.Text = (Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox8.Text)).ToString();



        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a;
     a = Convert.ToDouble(textBox12.Text); 

     textBox10.Text = (Convert.ToDouble(textBox12.Text) +Convert.ToDouble(textBox11.Text)).ToString(); 

        }
    }
}
