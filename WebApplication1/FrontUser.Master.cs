using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FrontUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            admin.Visible = false;
            login.Visible = false;
            signUp.Visible = false;
            home.Visible = false;
            if (Session["Login"] != null)
            {
                string s = Session["Login"].ToString() ?? "";
                if (Convert.ToBoolean(s))
                {
                    login.Visible = false;
                    signUp.Visible = false;
                    home.Visible = true;
                }
                else
                {
                    home.Visible = false;
                    login.Visible = true;
                    signUp.Visible = true;
                }
                string a = Session["admin"].ToString() ?? "";
                if (Convert.ToBoolean(a))
                {
                    admin.Visible = true;
                }
                else
                {
                    admin.Visible = false;
                }
            }
            else
            {
                home.Visible = false;
                login.Visible = true;
                signUp.Visible = true;
            }
        }
    }
}
