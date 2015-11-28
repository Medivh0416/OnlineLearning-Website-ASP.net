using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.BBS
{
    public partial class forum : System.Web.UI.Page
    {
        string cardId;
        string curPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cardId = Request.QueryString["cardId"].ToString();
            }
            catch
            {
                Response.Redirect("card.aspx");
            }

            if (!IsPostBack)
            {
                this.lblPageCur.Text = "1";//不能放到dataGridBind()后面,不然lblPageCur.Text没有被初始化,出错

                reply_bind();
                sendcard();

            }
        }
        /// <summary>
        /// 楼主发帖的信息
        /// </summary>
        protected void sendcard()
        {
            string sql = "select users.id,aliasName,logo,level,levelName,userId,sendcardId,title,text,date from users inner join sendcard on id=userId inner join levels on levelID=level where sendcardId=@sendcardId";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@sendcardId", cardId));
            DataTable dt = ds.Tables[0];
            logo.ImageUrl = dt.Rows[0]["logo"].ToString();
            name.Text = dt.Rows[0]["aliasName"].ToString();
            level.Text = dt.Rows[0]["levelName"].ToString();
            d_title.InnerHtml += dt.Rows[0]["title"].ToString();
            d_text.InnerHtml += dt.Rows[0]["text"].ToString();
        }

        /// <summary>
        /// 实现点赞操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void editUp(object sender, CommandEventArgs e)
        {
            string followcardId = e.CommandArgument.ToString();
            string sql = "update followcard set praise = praise+1 where followcardId=@id";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", followcardId));
            reply_bind();
        }
        protected void reply_bind()
        {
            string sql = "select users.id,followcardId,level,levelName,aliasName,logo,praise,userId,sendcardId,text,date from users inner join followcard on id=userId inner join levels on levelID=level where sendcardId=@sendcardId order by date desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@sendcardId", cardId));
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 20;
            curPage = this.lblPageCur.Text;
            pds.DataSource = ds.Tables[0].DefaultView;
            pds.CurrentPageIndex = Convert.ToInt32(curPage) - 1;
            this.lblPageTotal.Text = pds.PageCount.ToString();
            this.Button1.Enabled = true;
            this.Button2.Enabled = true;
            if (curPage == "1")
            {
                this.Button1.Enabled = false;
            }
            if (curPage == pds.PageCount.ToString())
            {
                this.Button2.Enabled = false;
            }
            this.lv_reply.DataSource = pds;
            this.lv_reply.DataBind();
            this.lblMesTotal.Text = Convert.ToString(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, "select count(*) from followcard where sendcardId=" + cardId + ""));
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            Boolean Login = false;
            Login = Convert.ToBoolean(Session["Login"]);
            if (Login)
            {
                string userId = Session["userID"].ToString();
                if (FreeTextBox1.Text.Trim().Length == 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('内容不能为空！')</script>");
                    return;
                }
                if (true)
                {
                    string text = FreeTextBox1.Text.Trim();
                    string sql = "insert into followcard(userId,sendcardId,text,date) values(@userId,@sendcardId,@text,@date)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@sendcardId", cardId),
                            new MySqlParameter("@userId", userId),
                            new MySqlParameter("@text", text),
                            new MySqlParameter("@date", System.DateTime.Now));
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发布成功！')</script>");
                    FreeTextBox1.Text = "";
                    reply_bind();
                    return;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发布失败！');</script>");
                    return;
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请先登录哦！')</script>");
                return;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) - 1);
            reply_bind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) + 1);
            reply_bind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = "1";
            reply_bind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = this.lblPageTotal.Text;
            reply_bind();
        }
        protected void cancle_Click(object sender, EventArgs e)
        {

        }
    }
}