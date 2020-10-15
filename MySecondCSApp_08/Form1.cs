using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_08
{
    public partial class Form1 : Form
    {
        string[] Alumns = { "Fran", "Marta", "Miguel", "Albert", "Justo", "Joan", "Pere", "Joana" };

        List<String> Classroom1 = new List<String>();
        List<String> Classroom2 = new List<String>();

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(Alumns);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Alumn = listBox1.SelectedItem.ToString();
            Classroom1.Add(Alumn);
            textBox1.Text = String.Join(", ", Classroom1) + ".";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String Alumn = listBox1.SelectedItem.ToString();
            Classroom2.Add(Alumn);
            textBox1.Text = String.Join(", ", Classroom2) + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classroom1.Clear();
            Classroom2.Clear();
            textBox1.Text = "";
        }
    }
}
