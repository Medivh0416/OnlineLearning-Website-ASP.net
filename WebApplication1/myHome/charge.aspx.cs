using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void _submit_Click(object sender, EventArgs e)
        {
            Response.Write("<script language=JavaScript>window.open('https://www.alipay.com/');</script>");
        }
    }
}