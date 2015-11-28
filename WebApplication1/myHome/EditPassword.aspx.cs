using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class EditPassword : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.id = Convert.ToInt32(Session["userID"].ToString());
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string oldPwd;
            string sql = "select * from users where id=@id";
            //DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql);
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            DataTable dt = ds.Tables[0];
            //DataRowCollection rows = dt.Rows;
            oldPwd = dt.Rows[0]["password"].ToString();
            Response.Write("<script language=JavaScript>layer.alert('pwd');</script>"); 
            if (oldPwd != oldPsw.Text)
            {
                string javaScript = @" <script  language=javascript> layer.alert('请输入正确的原密码！', 8); </script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }

        }


    }
}