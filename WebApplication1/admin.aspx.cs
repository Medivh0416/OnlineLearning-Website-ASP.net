using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class admin : System.Web.UI.Page
    {
        string curPage;
        string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            d_lv_user.Visible = false;
            try
            {
                if (Convert.ToBoolean(Session["admin"].ToString()) == false)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('您不是管理员！')</script>");
                    Response.Redirect("homev3.aspx");
                }
                if (!IsPostBack)
                {
                    this.lblPageCur.Text = "1";//不能放到dataGridBind()后面,不然lblPageCur.Text没有被初始化,出错
                    contack();
                }
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请登录！')</script>");
                Response.Redirect("homev3.aspx");
            }
        }
        protected void contack()
        {
            string sql = "select id,name,logo,userId,conName,tel,text,date from users inner join contack on id=userId order by date desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql);
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
            this.lv_contack.DataSource = pds;
            this.lv_contack.DataBind();
        }
        protected void lv_bind()
        {
            string sql = "select * from users where name=@name";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql,new MySqlParameter("@name",name));
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 1;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) - 1);
            contack();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = Convert.ToString(Convert.ToInt32(this.lblPageCur.Text) + 1);
            contack();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = "1";
            contack();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            this.lblPageCur.Text = this.lblPageTotal.Text;
            contack();
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            d_lv_contack.Visible = false;
            d_lv_user.Visible = true;
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            name = tb_name.Text.Trim();
            lv_bind();
        }
    }
}