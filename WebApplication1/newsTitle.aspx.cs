using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.Services; //引入命名空间

namespace WebApplication1
{
    public partial class newsTitle : System.Web.UI.Page
    {
        protected string getIdLength()
        {
            string maxId = "select count(*) from news where 1";
            MySqlDataReader maxReader = null;
            maxReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, maxId);
            while (maxReader.Read())
            {
                return maxReader["count(*)"].ToString();
            }
            return "error";
        }

        protected string getId()
        {
            return Request.QueryString["id"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}