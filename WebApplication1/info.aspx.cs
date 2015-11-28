using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class info : System.Web.UI.Page
    {
        protected string getId()
        {
            return Request.QueryString["id"];
        }
        protected string getIdLength()
        {
            string maxId = "select count(*) from info where 1";
            MySqlDataReader maxReader = null;
            maxReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, maxId);
            while (maxReader.Read())
            {
                return maxReader["count(*)"].ToString();
            }
            return "error";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];             //url传值代码
            int aid = Convert.ToInt32(id);
            ////////////////////////////////////////////
            string title0 = "select title from info order by id DESC limit " + aid + ",1";
            MySqlDataReader title0Reader = null;
            title0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title0);
            while (title0Reader.Read())
            {
                title.InnerHtml = title0Reader["title"].ToString();
            }
            title0Reader.Close();
            ////////////////////////////////////////////
            string content = "select content from info order by id DESC limit " + aid + ",1";
            MySqlDataReader contentReader = null;
            contentReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, content);
            while (contentReader.Read())
            {
                content1.InnerHtml += contentReader["content"].ToString();
            }
            contentReader.Close();
            ////////////////////////////////////////////
            string date = "select date from info order by id DESC limit " + aid + ",1";
            MySqlDataReader dateReader = null;
            dateReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, date);
            while (dateReader.Read())
            {
                date0.InnerHtml = dateReader["date"].ToString();
            }
            dateReader.Close();
        }
    }
}