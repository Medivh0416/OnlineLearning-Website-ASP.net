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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["userID"] = 3;
            //Session["userName"] = "wang";
            //Session["Login"] = true;
            Boolean Login=Convert.ToBoolean(Session["Login"]);
            if (Login)
            {
                iframe.Visible = false;
                int id = Convert.ToInt32(Session["userID"].ToString());
                string sql = "select * from users where id=@id";
                DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
                DataTable dt = ds.Tables[0];
                int cityId = Convert.ToInt32(dt.Rows[0]["cityId"].ToString());
                int gradeId = Convert.ToInt32(dt.Rows[0]["gradeId"].ToString());
                int levelId = Convert.ToInt32(dt.Rows[0]["level"].ToString());
                string sql1 = "select * from city where id=@cityId";
                DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@cityId", cityId));
                DataTable dt1 = ds1.Tables[0];
                string sql2 = "select * from grade where id=@gradeId";
                DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, new MySqlParameter("@gradeId", gradeId));
                DataTable dt2 = ds2.Tables[0];
                string sql3 = "select * from levels where id=@levelId";
                DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, new MySqlParameter("@levelId", levelId));
                DataTable dt3 = ds3.Tables[0];
                l_name.Text = dt.Rows[0]["aliasName"].ToString();
                l_gender.Text = dt.Rows[0]["gender"].ToString();
                l_level.Text = dt.Rows[0]["level"].ToString();
                l_score.Text = dt.Rows[0]["score"].ToString();
                logo.ImageUrl = dt.Rows[0]["logo"].ToString();
                l_city.Text = dt1.Rows[0]["city"].ToString();
                l_grade.Text = dt2.Rows[0]["grade"].ToString();
                l_identity.Text = dt3.Rows[0]["levelName"].ToString();
                

            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请先登录哦！')</script>");
                Response.Redirect("homev3.aspx");
            }
        }

        protected void bltMenu_Click(object sender, BulletedListEventArgs e)
        {
            home.Visible = false;
            string menu = bltMenu.Items[e.Index].Value;
            iframe.Visible = true;
            iframe.Src = menu ;
        }

        //protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    Session["menu"] = TreeView1.SelectedNode.Value;
        //    iframe.Src = Session["menu"].ToString();
        //}
    }
}