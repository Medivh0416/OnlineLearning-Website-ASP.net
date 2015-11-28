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
    public partial class perView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["userID"].ToString());
            string sql = "select * from users where id=@id";
            //DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql);
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            DataTable dt = ds.Tables[0];
            //DataRowCollection rows = dt.Rows;
            int cityId = Convert.ToInt32(dt.Rows[0]["cityId"].ToString());
            string sql1 = "select * from city where id=@cityId";
            DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@cityId", cityId));
            DataTable dt1 = ds1.Tables[0];
            userName.Text = dt.Rows[0]["name"].ToString();
            aliasName.Text = dt.Rows[0]["aliasName"].ToString();
            gender.Text = dt.Rows[0]["gender"].ToString();
            email.Text = dt.Rows[0]["email"].ToString();
            level.Text = dt.Rows[0]["level"].ToString();
            score.Text = dt.Rows[0]["score"].ToString();
            city.Text = dt1.Rows[0]["city"].ToString();
        }
    }
}