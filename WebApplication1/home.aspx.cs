using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string maxId = "select max(id) from news";
            MySqlDataReader maxReader = null;
            maxReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, maxId);
            while (maxReader.Read())
            {
                Response.Write("<script type='text/javascript'> idLength = " + maxReader["max(id)"].ToString() + "</script>");
            }
            /////////////////////////////////////////////
            string title0 = "select title from newstitle where id IN((select max(id) from newstitle)-5)";     //这条语句实现查找id第五大的title值
            string time0 = "select date from newstitle where id IN((select max(id) from newstitle)-5)";
            MySqlDataReader title0Reader = null;
            MySqlDataReader time0Reader = null;
            title0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title0);
            time0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time0);
            while (title0Reader.Read() && time0Reader.Read())
            {
                news0.InnerHtml += title0Reader["title"].ToString() + "<span runat='server' class='badge'>" + time0Reader["date"].ToString() + "</span>";
                news6.InnerHtml += title0Reader["title"].ToString() + "<span runat='server' class='badge'>" + time0Reader["date"].ToString() + "</span>";

            }   //在给id为news0的a标签添加文本的同时添加用于显示时间的span标签（动态添加内容）
            title0Reader.Close();
            time0Reader.Close();
            //          
            string title1 = "select title from newstitle where id IN((select max(id) from newstitle)-4)";
            string time1 = "select date from newstitle where id IN((select max(id) from newstitle)-4)";
            MySqlDataReader title1Reader = null;
            MySqlDataReader time1Reader = null;
            title1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title1);
            time1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time1);
            while (title1Reader.Read() && time1Reader.Read())
            {
                news1.InnerHtml = title1Reader["title"].ToString() + "<span runat='server' class='badge'>" + time1Reader["date"].ToString() + "</span>";
                news7.InnerHtml = title1Reader["title"].ToString() + "<span runat='server' class='badge'>" + time1Reader["date"].ToString() + "</span>";

            }
            title1Reader.Close(); time1Reader.Close();
            //          
            string title2 = "select title from newstitle where id IN((select max(id) from newstitle)-3)";
            string time2 = "select date from newstitle where id IN((select max(id) from newstitle)-3)";
            MySqlDataReader title2Reader = null;
            MySqlDataReader time2Reader = null;
            title2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title2);
            time2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time2);
            while (title2Reader.Read() && time2Reader.Read())
            {
                news2.InnerHtml = title2Reader["title"].ToString() + "<span runat='server' class='badge'>" + time2Reader["date"].ToString() + "</span>";
                news8.InnerHtml = title2Reader["title"].ToString() + "<span runat='server' class='badge'>" + time2Reader["date"].ToString() + "</span>";

            }
            title2Reader.Close(); time2Reader.Close();         
            //          
            string title3 = "select title from newstitle where id IN((select max(id) from newstitle)-2)";
            string time3 = "select date from newstitle where id IN((select max(id) from newstitle)-2)";
            MySqlDataReader title3Reader = null;
            MySqlDataReader time3Reader = null;
            title3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title3);
            time3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time3);
            while (title3Reader.Read() && time3Reader.Read())
            {
                news3.InnerHtml = title3Reader["title"].ToString() + "<span runat='server' class='badge'>" + time3Reader["date"].ToString() + "</span>";
                news9.InnerHtml = title3Reader["title"].ToString() + "<span runat='server' class='badge'>" + time3Reader["date"].ToString() + "</span>";
            }
            title3Reader.Close(); time3Reader.Close();
            //                 
            string title4 = "select title from newstitle where id IN((select max(id) from newstitle)-1)";
            string time4 = "select date from newstitle where id IN((select max(id) from newstitle)-1)";
            MySqlDataReader title4Reader = null;
            MySqlDataReader time4Reader = null;
            title4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title4);
            time4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time4);
            while (title4Reader.Read() && time4Reader.Read())
            {
                news4.InnerHtml = title4Reader["title"].ToString() + "<span runat='server' class='badge'>" + time4Reader["date"].ToString() + "</span>";
                news10.InnerHtml = title4Reader["title"].ToString() + "<span runat='server' class='badge'>" + time4Reader["date"].ToString() + "</span>";

            }
            title4Reader.Close(); time4Reader.Close();         
            //          
            string title5 = "select title from newstitle where id IN((select max(id) from newstitle))";   //这条语句从newstitle表中查找id值最大的title
            string time5 = "select date from newstitle where id IN((select max(id) from newstitle))";
            MySqlDataReader title5Reader = null;
            MySqlDataReader time5Reader = null;
            title5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title5);
            time5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time5);
            while (title5Reader.Read() && time5Reader.Read())
            {
                news5.InnerHtml = title5Reader["title"].ToString() + "<span runat='server' class='badge'>" + time5Reader["date"].ToString() + "</span>";
                news11.InnerHtml = title5Reader["title"].ToString() + "<span runat='server' class='badge'>" + time5Reader["date"].ToString() + "</span>";

            }
            title5Reader.Close(); time5Reader.Close();
            //             
            //////////////////////////////////////////////////////////////////
            //动态更改锚标签的href.
            string href0 = "select href from newstitle where id IN((select max(id) from newstitle)-5)";
            MySqlDataReader href0Reader = null;
            href0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href0);
            while (href0Reader.Read())
            {
                news0.Attributes["href"] = href0Reader["href"].ToString();
            }
            href0Reader.Close();
            //
            string href1 = "select href from newstitle where id IN((select max(id) from newstitle)-4)";
            MySqlDataReader href1Reader = null;
            href1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href1);
            while (href1Reader.Read())
            {
                news1.Attributes["href"] = href1Reader["href"].ToString();
            }
            href1Reader.Close();
            //
            string href2 = "select href from newstitle where id IN((select max(id) from newstitle)-3)";
            MySqlDataReader href2Reader = null;
            href2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href2);
            while (href2Reader.Read())
            {
                news2.Attributes["href"] = href2Reader["href"].ToString();
            }
            href2Reader.Close();
            //
            string href3 = "select href from newstitle where id IN((select max(id) from newstitle)-2)";
            MySqlDataReader href3Reader = null;
            href3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href3);
            while (href3Reader.Read())
            {
                news3.Attributes["href"] = href3Reader["href"].ToString();
            }
            href3Reader.Close();
            //
            string href4 = "select href from newstitle where id IN((select max(id) from newstitle)-1)";
            MySqlDataReader href4Reader = null;
            href4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href4);
            while (href4Reader.Read())
            {
                news4.Attributes["href"] = href4Reader["href"].ToString();
            }
            href4Reader.Close();
            //
            string href5 = "select href from newstitle where id IN((select max(id) from newstitle))";
            MySqlDataReader href5Reader = null;
            href5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, href5);
            if (href5Reader.Read())
            {
                news5.Attributes["href"] = href5Reader["href"].ToString();
            }
            href5Reader.Close();
            //     
        }
    }
}