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
    public partial class Billboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dataGridBind();
            }
        }
        public void dataGridBind()
        {
            string sql = "select * from users order by score desc";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql);
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 20;
            pds.DataSource = ds.Tables[0].DefaultView;
            this.ListView1.DataSource = pds;
            this.ListView1.DataBind();

            string sql2 = "select * from users order by level desc";
            DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql2);
            PagedDataSource pds2 = new PagedDataSource();
            pds2.AllowPaging = true;
            pds2.PageSize = 20;
            pds2.DataSource = ds2.Tables[0].DefaultView;
            this.ListView2.DataSource = pds2;
            this.ListView2.DataBind();

            string sql3 = "select * from users order by workTime desc";
            DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3);
            PagedDataSource pds3 = new PagedDataSource();
            pds3.AllowPaging = true;
            pds3.PageSize = 20;
            pds3.DataSource = ds3.Tables[0].DefaultView;
            this.ListView3.DataSource = pds3;
            this.ListView3.DataBind();
        }

        protected void editUp(object sender, CommandEventArgs e)
        {
            string _id=e.CommandArgument.ToString();
            string sql = "update users set up = up+1 where id=@id";
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", _id));
            dataGridBind();
        }
        protected void lkbUser_Click(object sender, CommandEventArgs e)
        {
            string userID = e.CommandArgument.ToString();
            Response.Redirect("perPage.aspx?userID=" + userID + "");           
        }


    }
}