using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondCSApp_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hScrollBar1.Minimum = 50;
            hScrollBar1.Maximum = 80;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           textBox1.Text =  hScrollBar1.Value.ToString();
        }
    }
}
