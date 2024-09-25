using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, result;
            a=int.Parse(TextBox1.Text);
            b=int.Parse(TextBox2.Text);
            c=int.Parse(TextBox3.Text);
            d=int.Parse(TextBox4.Text);
            result = a * b * c * d;
            TextBox5.Text = result.ToString();

        }
    }
}