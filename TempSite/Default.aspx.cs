using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TempSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TempConverter.Service1Client convert = new TempConverter.Service1Client();
            int f = Convert.ToInt32(TextBox2.Text);
            int c = convert.f2c(f);
            Label3.Text = c.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TempConverter.Service1Client convert = new TempConverter.Service1Client();
            int c = Convert.ToInt32(TextBox1.Text);
            int f = convert.c2f(c);
            Label2.Text = f.ToString();
        }
    }
}