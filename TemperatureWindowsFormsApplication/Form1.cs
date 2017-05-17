using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureWindowsFormsApplication.ServiceReference1;

namespace TemperatureWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client hw = new Service1Client();
            int c = Convert.ToInt32(textBox1.Text);
            int f = hw.c2f(c);
            label3.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client hr = new Service1Client();
            int f = Convert.ToInt32(textBox2.Text);
            int c = hr.f2c(f);
            label6.Text = c.ToString();
        }
    }
}
