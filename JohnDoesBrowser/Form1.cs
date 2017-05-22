using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnDoesBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient encrypt = new EncryptService.ServiceClient();
            try
            {
                label1.Text = encrypt.Encrypt(txtEncrypt.Text);
                txtDecrypt.Text= encrypt.Encrypt(txtEncrypt.Text);
            }
            catch(Exception ec)
            {
                label1.Text = ec.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient decrypt = new EncryptService.ServiceClient();
            try
            {
                label2.Text = decrypt.Decrypt(txtDecrypt.Text);
            }
            catch (Exception ec)
            {
                label2.Text = ec.Message.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockService.ServiceClient quote = new stockService.ServiceClient();
            try
            {
                String info = quote.getStockquote(textBox1.Text);
                Console.WriteLine(info);
            }catch(Exception sc)
            {
                Console.WriteLine(sc.Message.ToString());
            }
        }
    }
}
