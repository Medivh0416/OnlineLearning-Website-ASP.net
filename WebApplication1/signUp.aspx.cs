using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class signUp : System.Web.UI.Page
    {
        string gender;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DDLbind();
            }
        }
        /// <summary>
        /// 绑定 省 年纪 学校的方法
        /// </summary>
        protected void DDLbind()
        {
            string sql1 = "select * from province";
            DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1);
            DataTable dt1 = ds1.Tables[0];
            DDLprovince.DataSource = dt1;
            DDLprovince.DataBind();

            string sql2 = "select * from school";
            DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql2);
            DataTable dt2 = ds2.Tables[0];
            DDLschool.DataSource = dt2;
            DDLschool.DataBind();

            string sql3 = "select * from grade";
            DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3);
            DataTable dt3 = ds3.Tables[0];
            DDLgrade.DataSource = dt3;
            DDLgrade.DataBind();
        }
        /// <summary>
        /// 改变省，确定所选择的市
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DDLprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int id = Convert.ToInt32(DDLprovince.SelectedValue);
                string sql = "select * from city where provinceId=@id";
                DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
                DataTable dt = ds.Tables[0];
                DDLcity.DataSource = dt;
                DDLcity.DataBind();
            }
        }
        /// <summary>
        /// 判断用户名是否 重复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void name_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "select name from users where name=@name";
            DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@name", name.Text));
            DataTable dt1 = ds1.Tables[0];
            if (dt1.Rows.Count >= 1)
            {
                Label9.Visible = true;
                submit.Enabled = false;
            }
            else
            {
                Label9.Visible = false;
                submit.Enabled = true;
            }

        }


        protected void submit_Click(object sender, EventArgs e)
        {
            string pwd = password.Text;
            if (RDMale.Checked)
            {
                this.gender = "男";
            }
            else
            {
                this.gender = "女";
            }
            if (!string.IsNullOrEmpty(name.Text) || !string.IsNullOrEmpty(password.Text) || !string.IsNullOrEmpty(email.Text) || !string.IsNullOrEmpty(aliasName.Text))
            {
                try
                {
                    string sql = "insert into users(name,password,email,schoolId,aliasName,gradeId,gender,cityId,regTime,logo,level) values(@name,@password,@email,@schoolId,@ailasName,@gradeId,@gender,@cityId,@regTime,@logo,@level)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                        new MySqlParameter("@name", name.Text),
                        new MySqlParameter("@password", pwd),
                        new MySqlParameter("@email", email.Text),
                        new MySqlParameter("@schoolId", DDLschool.SelectedValue),
                        new MySqlParameter("@ailasName", aliasName.Text),
                        new MySqlParameter("@gradeId", DDLgrade.SelectedValue),
                        new MySqlParameter("@gender", gender),
                        new MySqlParameter("@cityId", DDLcity.SelectedValue),
                        new MySqlParameter("@regTime", DateTime.Now),
                        new MySqlParameter("@logo", "/logo/logoDef.png"),
                        new MySqlParameter("@level", "1"));
                    //string javaScript = @" <script  language=javascript> layer.alert('注册成功！', 6);</script> ";
                    //ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                    Response.Write("<script> window.alert('注册成功！'); </script>");
                    string userID = "";
                    try
                    {
                        string sql1 = "select id from users where name=@name";
                        MySqlDataReader dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql1,
                            new MySqlParameter("@name", name.Text));
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            userID = dataReader.GetInt32("id").ToString();
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
                    Session["userName"] = name.Text;
                    Response.Write("<script>window.location.href='MyHome.aspx';</script>");
                }
                catch
                {
                    Response.Write("<script> window.alert('注册失败！'); </script>");
                    return;
                }
            }
            else
            {
                Response.Write("<script> window.alert('请补全所有信息！'); </script>");
                return;
            }

        }
    }

}