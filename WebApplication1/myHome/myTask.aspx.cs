using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class myTask : System.Web.UI.Page
    {
        static string subjID;
        static string sectID;
        string userID;
        ArrayList al = new ArrayList();
        ArrayList su = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
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
            task();
        }
        /// <summary>
        /// 绑定科目
        /// </summary>
        protected void study_bind()
        {
            try
            {
                string sql = "select id,sName,pic,comment from sections where subjId=@subjId and id in (select sectID from purchase where userID=@userid)";
                DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                    new MySqlParameter("@subjId", subjID),
                    new MySqlParameter("@userid", userID));
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
        /// <summary>
        /// 课程判定
        /// </summary>
        protected void task()
        {
            string sql = "select * from subjects where id in (select subjId from sections where id in (select sectID from purchase where userID=@userid))";
            MySqlDataReader dataReader = null;
            dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@userid", userID));
            while (dataReader.Read())
            {
                su.Add(dataReader["id"].ToString());
            }
            if (su.Contains("1"))
            {
                chuWu.Visible = true;
            }
            if (su.Contains("2"))
            {
                gaoWU.Visible = true;
            }
            if (su.Contains("3"))
            {
                chuShu.Visible = true;
            }
            if (su.Contains("4"))
            {
                gaoShu.Visible = true; ;
            }
        }
        /// <summary>
        /// 点击选择课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbt_buy_Click(object sender, CommandEventArgs e)
        {
            sectID = e.CommandArgument.ToString();
            string sql3 = "select * from questions where sectionID=@qId";
            DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, new MySqlParameter("@qId", sectID));
            DataTable dt3 = ds3.Tables[0];
            BLquestions.DataSource = dt3;
            BLquestions.DataBind();
        }

        /// <summary>
        /// 转入对应做题页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bltQu_Click(object sender, BulletedListEventArgs e)
        {
            string quesId = BLquestions.Items[e.Index].Value.ToString();
            Session["quesId"] = quesId;
            //Response.Write(" <script> parent.window.location.href= 'study1.aspx?ques=" + quesId + "' </script> ");
            Response.Write(" <script> parent.window.location.href= '../study1.aspx' </script> ");
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