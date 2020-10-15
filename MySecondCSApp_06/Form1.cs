using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String res = "Choosen colour: ";

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = res + "red.";

            }else
            {
                if (radioButton2.Checked)
                {
                    textBox1.Text = res + "blue.";
                } else
                {
                    if (radioButton3.Checked)
                    {
                        textBox1.Text = res + "white.";
                    }
                    else
                    {
                        textBox1.Text = "Any colour selected.";
                    }
                }
            }
        }
    }
}
