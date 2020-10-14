using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }

    //https://es.stackoverflow.com/questions/65498/c%C3%B3mo-puedo-sumar-los-valores-de-dos-textbox-y-mostrarlos-en-un-tercero
}
