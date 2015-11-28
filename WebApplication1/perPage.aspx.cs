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
    public partial class perPage : System.Web.UI.Page
    {
        string id; //初始化主页ID
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
                this.id = Request.QueryString["userID"].ToString()+"";
                mainPage();
                boradPage();
                study_bind();
                record();
            //}
            //catch
            //{
            //    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('出错了哦，返回主页！')</script>");
            //    Response.Redirect("homev3.aspx");
            //}
        }

        protected void record()
        {
            string sql = "select questions.id,questions.questionName,userId,quesId,workTime,date from questions left join qurecord on questions.id=qurecord.quesId where userId=@id order by date desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 10;
            pds.DataSource = ds.Tables[0].DefaultView;
            this.lvRecord.DataSource = pds;
            this.lvRecord.DataBind();
        }
        /// <summary>
        /// 近期学习记录的绑定
        /// </summary>
        protected void study_bind()
        {
            string sql = "select sName,pic,comment from sections where id in (select sectID from purchase where userID=@id order by buyTime desc)";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 10;
            pds.DataSource = ds.Tables[0].DefaultView;
            this.lv_study.DataSource = pds;
            this.lv_study.DataBind();
        }
        /// <summary>
        /// 留言板页面的绑定
        /// </summary>
        protected void boradPage()
        {
            string sql = "select users.id,aliasName,name,logo,userId,tipId,text,time from users inner join board on users.id=board.tipId where userId=@userId order by time desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql,new MySqlParameter("@userId",id));
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 5;
            pds.DataSource = ds.Tables[0].DefaultView;
            this.board.DataSource = pds;
            this.board.DataBind();
        }
        /// <summary>
        /// 个人信息及徽章的绑定
        /// </summary>
        protected void mainPage() 
        {
            string sql = "select * from users where id=@id";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            DataTable dt = ds.Tables[0];
            int cityId = Convert.ToInt32(dt.Rows[0]["cityId"].ToString());
            string sql1 = "select * from city where id=@cityId";
            DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@cityId", cityId));
            DataTable dt1 = ds1.Tables[0];
            l_name.Text = dt.Rows[0]["aliasName"].ToString();
            l_name1.Text = dt.Rows[0]["aliasName"].ToString();
            logo.ImageUrl = dt.Rows[0]["logo"].ToString();
            //gender.Text = dt.Rows[0]["gender"].ToString();
            //email.Text = dt.Rows[0]["email"].ToString();
            l_level.Text = dt.Rows[0]["level"].ToString();
            l_score.Text = dt.Rows[0]["score"].ToString();
            l_city.Text = dt1.Rows[0]["city"].ToString();
            l_fans.Text = dt.Rows[0]["fans"].ToString();
            l_follow.Text = dt.Rows[0]["follows"].ToString();
            l_sign.Text = dt.Rows[0]["sign"].ToString();
            string intro = dt.Rows[0]["intro"].ToString();
            if (string.IsNullOrEmpty(intro))
            {
                l_intro.Text = "还什么都没写";
            }
            else
            {
                l_intro.Text = intro;
            }
            if(Convert.ToInt32(l_score.Text.ToString())>100)
            {
                Image score100=new Image();
                score100.ImageUrl = "/images/Badge/tps.png";
                score100.Height = 120;
                p_badge.Controls.Add(score100);
                if (Convert.ToInt32(l_score.Text.ToString()) > 200)
                {
                    Image score200 = new Image();
                    score200.ImageUrl = "/images/Badge/tag.png";
                    score200.Height = 120;
                    p_badge.Controls.Add(score200);
                    if (Convert.ToInt32(l_score.Text.ToString()) > 500)
                    {
                        Image score500 = new Image();
                        score500.Height = 120;
                        score500.ImageUrl = "/images/Badge/rib.png";
                        p_badge.Controls.Add(score500);                    
                    }
                }
            }
            if (Convert.ToInt32(dt.Rows[0]["coin"].ToString()) > 10) 
            {
                Image coin = new Image();
                Label lcoin = new Label();
                coin.ImageUrl = "/images/Badge/coin.png";
                coin.Height = 120;
                lcoin.Text = "我有金币";
                p_badge.Controls.Add(coin);
                p_badge.Controls.Add(lcoin);
            }
            if (Convert.ToInt32(l_fans.Text.ToString()) > 100) 
            {
                Image fans = new Image();
                fans.ImageUrl = "/images/Badge/target.png";
                fans.Height = 120;
                p_badge.Controls.Add(fans);                                
            }
            if (Convert.ToInt32(dt.Rows[0]["workTime"].ToString()) > 1000)
            {
                Image time = new Image();
                time.ImageUrl = "/images/Badge/pen.png";
                time.Height = 120;
                p_badge.Controls.Add(time);
            }
        }
        /// <summary>
        /// 发表留言的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Submit_Click(object sender, EventArgs e)
        {
            Boolean Login = Convert.ToBoolean(Session["Login"]);
            if (Login)
            {
                try
                {
                    string userId = Session["userID"].ToString();
                    string text = TextWord.Text.Trim();
                    if (string.IsNullOrEmpty(text))
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请不要输入空的字符！')</script>");
                        return;
                    }
                    else
                    {
                        string sql = "insert into board (userId,text,time,tipId) values(@userId,@text,@time,@tipId)";
                        MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                                    new MySqlParameter("@userId", id), new MySqlParameter("text", text),
                                    new MySqlParameter("time", DateTime.Now), new MySqlParameter("tipId", userId));
                        boradPage();
                        TextWord.Text = "";
                    }

                }
                catch
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('留言失败！')</script>");
                    return;
                }
            }
            else
            {
                //string javaScript = @" <script  language=javascript> layer.alert('请登录哦！', 8);</script> ";
                //ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                //return;
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请先登录哦！')</script>");
                return;
            }

        }

    }
}