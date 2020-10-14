using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            textBox3.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res;
            textBox3.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int calculate;
            
               
            if (textBox3.Text == "+")
            {
                calculate = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox4.Text = calculate.ToString();
            } else
            {
                if(textBox3.Text == "-")
                {
                    calculate = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                    textBox4.Text = calculate.ToString();
                } else
                {
                    textBox4.Text = "error";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            if (curItem == "suma")
            {
                textBox3.Text = "+";
            } else
            {
                if (curItem == "resta")
                {
                    textBox3.Text = "-";
                } else
                {
                    textBox3.Text = "error";
                }
            }
        }
    }
}
