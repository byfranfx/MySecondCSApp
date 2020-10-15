using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_09
{
    public partial class Form1 : Form
    {
        String[] odd = { "Nº 1", "Nº 3", "Nº 5", "Nº 7", "Nº 9" };
        String[] even = { "Nº 2", "Nº 4", "Nº 6", "Nº 8", "Nº 10" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains("Nº 2"))
            {
                textBox1.Text = "";
            } else
            {
                comboBox1.Items.AddRange(even);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains("Nº 1"))
            {
                textBox1.Text = "";
            }
            else
            {
                comboBox1.Items.AddRange(odd);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
