using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class chatwindow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["chat"] == null)
            {
                Application["chat"] = new Panel();
            }
            holder.Controls.Add((Panel)Application["chat"]);
        }
    }
}