using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.myHome
{
    public partial class buy : System.Web.UI.Page
    {
        string userID;
        static string subjID;
        ArrayList al = new ArrayList();
        ArrayList su = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.userID = Session["userID"].ToString();
                string sql = "select * from purchase where userID=@userid";
                MySqlDataReader dataReader = null;
                dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@userid", userID));
                while (dataReader.Read())
                {
                    al.Add(dataReader["sectID"].ToString());//将该用户已购买科目的ID加入到ArrayList中，后面点击的时候判断
                }
                dataReader.Close();
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('服务器出错了！')</script>");
            }
        }
        protected void study_bind()
        {
            try
            {
                string sql = "select id,sName,pic,comment from sections where subjId=@subjId ";
                DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@subjId", subjID));
                PagedDataSource pds = new PagedDataSource();
                pds.AllowPaging = true;
                //pds.PageSize = 20;
                pds.DataSource = ds.Tables[0].DefaultView;
                this.lv_study.DataSource = pds;
                this.lv_study.DataBind();
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('服务器出错了！')</script>");
            }

        }

        protected void lbt_buy_Click(object sender, CommandEventArgs e)
        {
            string sectId = e.CommandArgument.ToString();
            if (al.Contains(sectId))
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您已购买该课程！');</script>");
                return;
            }
            else
            {
                try
                {
                    int coin;
                    string sql1 = "select coin from users where id=@id";
                    DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@id", userID));
                    DataTable dt = ds.Tables[0];
                    coin = Convert.ToInt32(dt.Rows[0]["coin"].ToString());
                    if (coin - 5 >= 0)
                    {
                        coin = coin - 5;
                        string sql = "insert into purchase(sectId,userId,buyTime) values(@sectId,@userId,@buyTime)";
                        MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                                new MySqlParameter("@sectId", sectId), new MySqlParameter("@userId", userID),
                                new MySqlParameter("@buyTime", System.DateTime.Now));
                        string sql2 = "update users set coin=@coin where id=@ID";
                        MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql2,
                            new MySqlParameter("@ID", userID), new MySqlParameter("@coin", coin));
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('购买成功！')</script>");
                    }
                    else 
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('学币不足！')</script>");
                    }
                }
                catch
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('服务器出错了！')</script>");
                }
            }
        }
        protected void chuShu_Click(object sender, ImageClickEventArgs e)
        {
            subjID = "3";
            study_bind();
        }

        protected void gaoShu_Click(object sender, ImageClickEventArgs e)
        {
            subjID = "4";
            study_bind();
        }

        protected void chuWu_Click(object sender, ImageClickEventArgs e)
        {
            subjID = "1";
            study_bind();
        }

        protected void gaoWU_Click(object sender, ImageClickEventArgs e)
        {
            subjID = "2";
            study_bind();
        }
    }
}