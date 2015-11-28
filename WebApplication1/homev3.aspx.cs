using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class homev3 : System.Web.UI.Page
    {
        protected string getIdLength()
        {
            string maxId = "select count(*) from news where 1";
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

            /////////////////////////////////////////////
            string title0 = "select title from news order by id DESC limit 0,1";    //读取news表中最新一条的title记录
            string time0 = "select date from news order by id DESC limit 0,1";
            string ititle0 = "select title from info order by id DESC limit 0,1";
            string itime0 = "select date from info order by id DESC limit 0,1";
            MySqlDataReader title0Reader = null;
            MySqlDataReader time0Reader = null;
            MySqlDataReader ititle0Reader = null;
            MySqlDataReader itime0Reader = null;
            title0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title0);
            time0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time0);
            ititle0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle0);
            itime0Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime0);
            while (title0Reader.Read() && time0Reader.Read() && itime0Reader.Read() && ititle0Reader.Read())
            {
                //加上时间badge裁剪。
                string timeString = time0Reader["date"].ToString();
                string itimeString = itime0Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news0.InnerHtml += title0Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info0.InnerHtml += ititle0Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";

            }   //在给id为news0的a标签添加文本的同时添加用于显示时间的span标签（动态添加内容）
            title0Reader.Close();
            time0Reader.Close();
            ititle0Reader.Close();
            time0Reader.Close();
            //          
            string title1 = "select title from news order by id DESC limit 1,1";    //读取news表中第二条记录的title
            string time1 = "select date from news order by id DESC limit 1,1";
            string ititle1 = "select title from info order by id DESC limit 1,1";
            string itime1 = "select date from info order by id DESC limit 1,1";
            MySqlDataReader title1Reader = null;
            MySqlDataReader time1Reader = null;
            MySqlDataReader ititle1Reader = null;
            MySqlDataReader itime1Reader = null;
            title1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title1);
            time1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time1);
            ititle1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle1);
            itime1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime1);
            while (title1Reader.Read() && time1Reader.Read() && itime1Reader.Read() && ititle1Reader.Read())
            {
                string timeString = time1Reader["date"].ToString();
                string itimeString = itime1Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news1.InnerHtml = title1Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info1.InnerHtml = ititle1Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";
            }
            title1Reader.Close(); time1Reader.Close();ititle1Reader.Close();time1Reader.Close();
            //          
            string title2 = "select title from news order by id DESC limit 2,1";
            string time2 = "select date from news order by id DESC limit 2,1";
            string ititle2 = "select title from info order by id DESC limit 2,1";
            string itime2 = "select date from info order by id DESC limit 2,1";
            MySqlDataReader title2Reader = null;
            MySqlDataReader time2Reader = null;
            MySqlDataReader ititle2Reader = null;
            MySqlDataReader itime2Reader = null;
            title2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title2);
            time2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time2);
            ititle2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle2);
            itime2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime2);
            while (title2Reader.Read() && time2Reader.Read() && itime2Reader.Read() && ititle2Reader.Read())
            {
                string timeString = time2Reader["date"].ToString();
                string itimeString = itime2Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news2.InnerHtml = title2Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info2.InnerHtml = ititle2Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";
            }
            title2Reader.Close(); time2Reader.Close(); ititle2Reader.Close();time2Reader.Close();
            //          
            string title3 = "select title from news order by id DESC limit 3,1";
            string time3 = "select date from news order by id DESC limit 3,1";
            string ititle3 = "select title from info order by id DESC limit 3,1";
            string itime3 = "select date from info order by id DESC limit 3,1";
            MySqlDataReader title3Reader = null;
            MySqlDataReader time3Reader = null;
            MySqlDataReader ititle3Reader = null;
            MySqlDataReader itime3Reader = null;
            title3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title3);
            time3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time3);
            ititle3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle3);
            itime3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime3);
            while (title3Reader.Read() && time3Reader.Read() && itime3Reader.Read() && ititle3Reader.Read())
            {
                string timeString = time3Reader["date"].ToString();
                string itimeString = itime3Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news3.InnerHtml = title3Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info3.InnerHtml = ititle3Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";
            }
            title3Reader.Close(); time3Reader.Close(); ititle3Reader.Close();time3Reader.Close();
            //                 
            string title4 = "select title from news order by id DESC limit 4,1";
            string time4 = "select date from news order by id DESC limit 4,1";
            string ititle4 = "select title from info order by id DESC limit 4,1";
            string itime4 = "select date from info order by id DESC limit 4,1";
            MySqlDataReader title4Reader = null;
            MySqlDataReader time4Reader = null;
            MySqlDataReader ititle4Reader = null;
            MySqlDataReader itime4Reader = null;
            title4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title4);
            time4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time4);
            ititle4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle4);
            itime4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime4);
            while (title4Reader.Read() && time4Reader.Read() && itime4Reader.Read() && ititle4Reader.Read())
            {
                string timeString = time4Reader["date"].ToString();
                string itimeString = itime4Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news4.InnerHtml = title4Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info4.InnerHtml = ititle4Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";

            }
            title4Reader.Close(); time4Reader.Close(); ititle4Reader.Close();time4Reader.Close();
            //          
            string title5 = "select title from news order by id DESC limit 5,1";
            string time5 = "select date from news order by id DESC limit 5,1";
            string ititle5 = "select title from info order by id DESC limit 5,1";
            string itime5 = "select date from info order by id DESC limit 5,1";
            MySqlDataReader title5Reader = null;
            MySqlDataReader time5Reader = null;
            MySqlDataReader ititle5Reader = null;
            MySqlDataReader itime5Reader = null;
            title5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title5);
            time5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, time5);
            ititle5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ititle5);
            itime5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, itime5);
            while (title5Reader.Read() && time5Reader.Read() && itime5Reader.Read() && ititle5Reader.Read())
            {
                string timeString = time5Reader["date"].ToString();
                string itimeString = itime5Reader["date"].ToString();
                string itimeResult = "";
                string timeResult = "";
                if (timeString.IndexOf(" ") > 0)
                {
                    timeResult = timeString.Substring(0, timeString.IndexOf(" "));
                }
                else
                {
                    timeResult = timeString;
                }
                if (itimeString.IndexOf(" ") > 0)
                {
                    itimeResult = itimeString.Substring(0, itimeString.IndexOf(" "));
                }
                else
                {
                    itimeResult = itimeString;
                }
                news5.InnerHtml = title5Reader["title"].ToString() + "<span runat='server' class='badge'>" + timeResult + "</span>";
                info5.InnerHtml = ititle5Reader["title"].ToString() + "<span runat='server' class='badge'>" + itimeResult + "</span>";

            }
            title5Reader.Close(); time5Reader.Close(); ititle5Reader.Close();time5Reader.Close();
            //             
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}