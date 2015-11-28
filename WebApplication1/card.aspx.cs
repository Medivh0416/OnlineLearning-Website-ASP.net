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
    public partial class card : System.Web.UI.Page
    {
        static string sectId;
        string curPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sectId = "0";
                this.lblPageCur.Text = "1";//不能放到dataGridBind()后面,不然lblPageCur.Text没有被初始化,出错
                classcard();
                bl_subjectbind();
                lb_dis.Text = "综合讨论区";
            }
        }
        /// <summary>
        /// 点击标题进行查看帖子内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lkbTitle_Click(object sender, CommandEventArgs e)
        {
            string cardId = e.CommandArgument.ToString();
            Response.Redirect("forum.aspx?cardId=" + cardId + "");
        }
        protected void bl_subjectbind()
        {
            var item = new ListItem("综合讨论区", "0");
            string sql = "select * from sections";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql);
            DataTable dt = ds.Tables[0];
            bl_subject.DataSource = dt;
            bl_subject.DataBind();
            bl_subject.Items.Insert(0, item);
        }
        /// <summary>
        /// 绑定帖子列表 
        /// </summary>
        protected void classcard() 
        {
            string sql = "select id,aliasName,logo,userId,sendcardId,title,text,date from users inner join sendcard on id=userId where sectId=@sectId order by date desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@sectId", sectId));
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
            this.dl_card.DataSource = pds;
            this.dl_card.DataBind();
            this.lblMesTotal.Text = Convert.ToString(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, "select count(*) from sendcard where sectId="+sectId+""));
            //int a = pds.PageCount;
            //for (int i = 1; i <= a; i++)
            //{
            //    this.DropDownList1.Items.Add(i.ToString());
            //}
        }
        /// <summary>
        /// 点击发帖
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    string title=TB_title.Text.Trim();
                    string sql = "insert into sendcard(sectId,userId,title,text,date) values(@sectId,@userId,@title,@text,@date)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                            new MySqlParameter("@sectId",sectId),new MySqlParameter("@userId",userId),
                            new MySqlParameter("@title",title),new MySqlParameter("@text",text),
                            new MySqlParameter("@date", System.DateTime.Now));
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('发布成功！')</script>");
                    classcard();
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
        protected void cancle_Click(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) - 1);
            classcard();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) + 1);
            classcard();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = "1";
            classcard();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = this.lblPageTotal.Text;
            classcard();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void bl_subject_Click(object sender, BulletedListEventArgs e)
        {
            sectId = bl_subject.Items[e.Index].Value.ToString();
            lb_dis.Text = bl_subject.Items[e.Index].Text.ToString();
            classcard();
        }
    }
}