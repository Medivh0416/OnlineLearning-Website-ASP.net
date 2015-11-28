using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (userName == null || password == null || verifyCode == null)
            {
                string javaScript = @" <script  language=javascript> layer.alert('登陆出错了，请重新登陆！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
            string name = userName.Text;
            if (string.IsNullOrEmpty(name))
            {
                string javaScript = @" <script  language=javascript> layer.alert('请输入用户名！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
            string pwd = password.Text;
            if (string.IsNullOrEmpty(pwd))
            {
                string javaScript = @" <script  language=javascript> layer.alert('请输入密码！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
            string vCode = verifyCode.Text;
            if (string.IsNullOrEmpty(vCode))
            {
                string javaScript = @" <script  language=javascript> layer.alert('请输入验证码！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }

            //if (vCode != Session["ValidNums"].ToString().ToLower())
            //{
            //    string javaScript = @" <script  language=javascript> layer.alert('您输入的验证码错误！', 8);</script> ";
            //    ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
            //    return;
            //}

            string sql = "select count(*) from users where name=?name and password=?password";
            MySqlParameter[] _params = new MySqlParameter[]
            {
                new MySqlParameter("?name",MySqlDbType.VarChar,100),
                new MySqlParameter("?password",MySqlDbType.VarChar,100)
            };
            _params[0].Value = name;
            _params[1].Value = pwd;

            try
            {
                //int uid=DBUtility.DbHelperMySQL.ExecuteSqlScalar(sql, _params);
                object result = MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql, _params);
                if (result == null)
                {
                    string javaScript = @" <script  language=javascript>  layer.alert('您输入的用户名或密码错误！', 8);</script> ";
                    ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                    return;
                }
                int count = Convert.ToInt32(result);
                if (count == 0)
                {
                    string javaScript = @" <script  language=javascript> layer.alert('您输入的用户名或密码错误！', 8);</script> ";
                    ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                    return;
                }
            }
            catch (Exception)
            {
                string javaScript = @" <script  language=javascript> layer.alert('您输入的用户名或密码错误！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }

            sql = "select * from users where name=?name";
            MySqlParameter[] _param = new MySqlParameter[]
            {
                new MySqlParameter("?name",MySqlDbType.VarChar,100)
            };
            _param[0].Value = name;
            string userID = "";
            string tag = "";
            try
            {
                MySqlDataReader dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, _param);
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    userID = dataReader.GetInt32("id").ToString();
                    tag = dataReader.GetInt32("tag").ToString();
                }
                dataReader.Close();

            }
            catch (Exception)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('出错了！')</script>");
                return;
            }

            Session["userID"] = Convert.ToInt32(userID);
            Session["Login"] = true;
            Session["userName"] = userName.Text;
            if (tag == "0")
            {
                Session["admin"] = false;
                Response.Write("<script language=javascript>parent.location='MyHome.aspx'</script>"); 
            }
            if (tag == "1")
            {
                Session["admin"] = true;
                Response.Write("<script language=JavaScript>parent.location='admin.aspx';</script>");   //在新页面打开
            }
        }
        protected void test()
        {

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            Response.Write("<script language=JavaScript>window.open('signUp.aspx');</script>");   //在新页面打开
            //Context.Response.Redirect("signUp.aspx"); 
        }
    }
}