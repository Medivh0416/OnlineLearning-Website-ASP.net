using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class CMS1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                //通过给数据库news表的title列设置唯一索引，用于排除重复上传的问题
                MySqlConnection conn = new MySqlConnection(MySqlHelper.Conn);
                string valueOfTitle = title.Value;
                string valueOfContent = elm1.Value;
                string valueOfDate = DateTime.Now.ToString();
                string valueOflibrary = part.Value;
                string ins = "insert into " + valueOflibrary + "(title,content,praise,date)values('" + valueOfTitle + "','" + valueOfContent + "','0','" + valueOfDate + "')";
                MySqlCommand inscom = new MySqlCommand(ins, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                conn.Open();
                da.InsertCommand = inscom;
                da.InsertCommand.ExecuteNonQuery();
                string javaScript1 = @" <script  language=javascript> alert('上传成功');</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript1);
            }
            catch
            {
                string javaScript = @" <script  language=javascript> alert('上传失败，请勿重复上传。');</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
        }
    }
}