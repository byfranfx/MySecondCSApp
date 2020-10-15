using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("red");
            comboBox1.Items.Add("purple");
            comboBox1.Items.Add("blue");
            comboBox1.Items.Add("yellow");
            comboBox1.Items.Add("cyan");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                String res = "The choosen color is: ";
                textBox1.Text = res + comboBox1.SelectedItem.ToString();
            }
        }
    }
}
