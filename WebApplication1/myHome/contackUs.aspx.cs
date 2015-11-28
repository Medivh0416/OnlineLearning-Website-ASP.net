using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.myHome
{
    public partial class contackUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string userID = Session["userID"].ToString();
            string name = tb_name.Text.Trim();
            string tel = tb_tel.Text.Trim();
            string text = tb_word.Text.Trim();
            try
            {
                string sql = "insert into contack(userId,conName,tel,text,date) values(@userId,@name,@tel,@text,@date)";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                        new MySqlParameter("@userId", userID), new MySqlParameter("@name", name),
                        new MySqlParameter("@tel", tel), new MySqlParameter("@text", text),
                        new MySqlParameter("@date", System.DateTime.Now));
                mv_form.SetActiveView(v_success);
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('出错了！')</script>");
            }
        }
    }
}