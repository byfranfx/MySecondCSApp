using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String checkOne = "Mouse";
            String checkTwo = "Cat";
            String checkTree = "Dog";
            String CheckChoose = "Choosen animals: ";
            String CheckResult = "";

            if (checkBox1.Checked)
            {
                CheckResult = CheckResult + " " + checkOne;
            }
            if (checkBox2.Checked)
            {
                CheckResult = CheckResult + " " + checkTwo;
            }
            if (checkBox3.Checked)
            {
                CheckResult = CheckResult + " " + checkTree;
            }

            if (CheckResult == "")
            {
                textBox1.Text = CheckChoose + "any";
            } else
            {
                textBox1.Text = CheckChoose + CheckResult;
            }

        }
    }
}
