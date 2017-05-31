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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient encrypt = new EncryptService.ServiceClient();
            try
            {
                lblEncrypt.Text = encrypt.Encrypt(txtEncrypt.Text);                
            }
            catch (Exception ec)
            {
                lblEncrypt.Text = ec.Message.ToString();
            }
            try
            {
                lblDecrypt.Text = encrypt.Decrypt(lblEncrypt.Text);
            }
            catch(Exception dc)
            {
                lblDecrypt.Text = dc.Message.ToString();
            }
        }

        private void stkButton_Click(object sender, EventArgs e)
        {
            stockService.ServiceClient quote = new stockService.ServiceClient();
            try
            {
                String info = quote.getStockquote(stkInput.Text);
                lblPrice.Text = info;
            }
            catch (Exception sc)
            {
                Console.WriteLine(sc.Message.ToString());
            }
        }
    }
}
