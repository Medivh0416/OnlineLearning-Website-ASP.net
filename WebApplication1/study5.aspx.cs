using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class study5t : System.Web.UI.Page
    {
        string time;
        string quesId;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.quesId = Session["quesId"].ToString();

            }
            catch
            {

            }
            if (string.IsNullOrEmpty(quesId))
            {
                quesId = "3";
            }
            //时间
            this.time = Request.QueryString["time"];
            if (!IsPostBack)
            {
                temp.Value = time;
                //////////////////////////////////////////
                string sql = "select questionTitle from questions where quesId=@id";
                MySqlDataReader dataReader = null;
                dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql,new MySqlParameter("@id",quesId));
                while (dataReader.Read())
                {
                    get.InnerHtml += dataReader["questionTitle"].ToString();
                }
                dataReader.Close();
                //题目分步
                string sql1 = "select content from stepscore where quesId=@id and OrderId=1";
                MySqlDataReader dataReader1 = null;
                dataReader1 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@id", quesId));
                while (dataReader1.Read())
                {
                    score.InnerHtml += dataReader1["content"].ToString();
                }
                dataReader1.Close();
                //规范表达
                string sql2 = "select biaoda from guifanbiaoda where quesId=@id and OrderId=1";
                MySqlDataReader dataReader2 = null;
                dataReader2 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, new MySqlParameter("@id", quesId));
                while (dataReader2.Read())
                {
                    biaoda.InnerHtml += dataReader2["biaoda"].ToString();
                }
                dataReader2.Close();
            }
        }
        protected void save_Click1(object sender, EventArgs e)
        {
            try
            {
                string userId = Session["userID"].ToString();
                string quesId = Session["quesId"].ToString();
                string sql = "insert into record(userId,workTime,quesId,date) values(@userId,@workTime,@quesId,@date)";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                                new MySqlParameter("@userId", userId), new MySqlParameter("@workTime", time),
                                new MySqlParameter("@quesId", quesId), new MySqlParameter("@date", System.DateTime.Now));
                Response.Write("<script language = javascript>alert('保存成功');</script>");
            }
            catch
            {
                Response.Write("<script language = javascript>alert('出错了');</script>");
            }
        }
    }
}