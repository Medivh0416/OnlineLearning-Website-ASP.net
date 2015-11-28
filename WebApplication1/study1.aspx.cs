using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class study1t : System.Web.UI.Page
    {
        string quesId;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.quesId = Session["quesId"].ToString();
                //Response.Redirect("study2.aspx");
            }
            catch { }
            if (string.IsNullOrEmpty(quesId))
            {
                quesId = "3";
            }
            string sql = "select questionTitle from questions where id=@id";
            MySqlDataReader dataReader = null;
            try
            {
                dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", quesId));
                while (dataReader.Read())
                {
                    menu.InnerHtml += dataReader["questionTitle"].ToString();

                }
                dataReader.Close();
            }
            catch (Exception)
            {
                string javaScript = @" <script  language=javascript> layer.alert('加载题目信息时出错了，请重试！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
        }
       
        
        }
      
    }
