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
    public partial class study4_2 : System.Web.UI.Page
    {
        string quesId;
        protected string tips5(string strtip5)
        {
            string tip5 = "select text from tips where OrderId=20 and quesId=@id";
            MySqlDataReader tip5Reader = null;
            tip5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip5,new MySqlParameter("@id",quesId));
            while (tip5Reader.Read())
            {
                strtip5 = tip5Reader["text"].ToString();
            }
            tip5Reader.Close();
            return strtip5;
        }
        protected string tips6(string strtip6)
        {
            string tip6 = "select text from tips where OrderId=21 and quesId=@id";
            MySqlDataReader tip6Reader = null;
            tip6Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip6, new MySqlParameter("@id", quesId));
            while (tip6Reader.Read())
            {
                strtip6 = tip6Reader["text"].ToString();
            }
            tip6Reader.Close();
            return strtip6;
        }
        protected string tips7(string strtip7)
        {
            string tip7 = "select text from tips where OrderId=22 and quesId=@id";
            MySqlDataReader tip7Reader = null;
            tip7Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip7, new MySqlParameter("@id", quesId));
            while (tip7Reader.Read())
            {
                strtip7 = tip7Reader["text"].ToString();
            }
            tip7Reader.Close();
            return strtip7;
        }
        protected string tips8(string strtip8)
        {
            string tip8 = "select text from tips where OrderId=23 and quesId=@id";
            MySqlDataReader tip8Reader = null;
            tip8Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip8, new MySqlParameter("@id", quesId));
            while (tip8Reader.Read())
            {
                strtip8 = tip8Reader["text"].ToString();
            }
            tip8Reader.Close();
            return strtip8;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.quesId = Session["quesId"].ToString();
            }
            catch { }
            if (string.IsNullOrEmpty(quesId))
            {
                quesId = "3";
            }

            //传递所用时间
            string time = Request.QueryString["time"];
            temp.Value = time;
            //////////////////////////////////////////
            //思维目标1
            string ti1 = "select text from tips where OrderId=16 and quesId=@id";
            MySqlDataReader tip1Reader = null;
            tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ti1, new MySqlParameter("@id", quesId));
            while (tip1Reader.Read())
            {
                tip1.InnerHtml += tip1Reader["text"].ToString();
            }
            tip1Reader.Close();
            //思维目标2

            string ti2 = "select text from tips where OrderId=17 and quesId=@id";
            MySqlDataReader tip2Reader = null;
            tip2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ti2, new MySqlParameter("@id", quesId));
            while (tip2Reader.Read())
            {
                tip2.InnerHtml += tip2Reader["text"].ToString();
            }
            tip2Reader.Close();
            //思维目标3

            string ti3 = "select text from tips where OrderId=18 and quesId=@id";
            MySqlDataReader tip3Reader = null;
            tip3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ti3, new MySqlParameter("@id", quesId));
            while (tip3Reader.Read())
            {
                tip3.InnerHtml += tip3Reader["text"].ToString();
            }
            tip3Reader.Close();
            //思维目标4

            string ti4 = "select text from tips where OrderId=19 and quesId=@id";
            MySqlDataReader tip4Reader = null;
            tip4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, ti4, new MySqlParameter("@id", quesId));
            while (tip4Reader.Read())
            {
                tip4.InnerHtml += tip4Reader["text"].ToString();
            }
            tip4Reader.Close();
            //目标1
            string sql1 = "select slts from silutansuo where OrderId =5 and quesId=@id";
            MySqlDataReader dr1 = null;
            dr1 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, new MySqlParameter("@id", quesId));
            while(dr1.Read())
            {
                goal1_text.InnerHtml += dr1["slts"].ToString();
            }
           dr1.Close();
            //目标2
           string sql2 = "select slts from silutansuo where OrderId =6 and quesId=@id";
            MySqlDataReader dr2 = null;
            dr2 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, new MySqlParameter("@id", quesId));
            while (dr2.Read())
            {
                goal2_text.InnerHtml += dr2["slts"].ToString();
            }
            dr2.Close();
            //目标3
            string sql3 = "select slts from silutansuo where OrderId =7 and quesId=@id";
            MySqlDataReader dr3 = null;
            dr3 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, new MySqlParameter("@id", quesId));
            while (dr3.Read())
            {
                goal3_text.InnerHtml += dr3["slts"].ToString();
            }
            dr3.Close();
            //目标4
            string sql4 = "select slts from silutansuo where OrderId =8 and quesId=@id";
            MySqlDataReader dr4 = null;
            dr4 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sql4, new MySqlParameter("@id", quesId));
            while (dr4.Read())
            {
                goal4_text.InnerHtml += dr4["slts"].ToString();
            }
            dr4.Close();
            if (!IsPostBack)
            {
                string sqls1 = "select selection from result_selection where quesId=@id and OrderId between 5 and 8";
                DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqls1, new MySqlParameter("@id", quesId));
                DataTable dt1 = ds1.Tables[0];
                resultsel.DataSource = dt1;
                resultsel.DataBind();

                string sqls2 = "select statusoptions from statusoptions where quesId=@id and OrderId between 7 and 12";
                DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqls2, new MySqlParameter("@id", quesId));
                DataTable dt2 = ds2.Tables[0];
                zhuangtaisel.DataSource = dt2;
                zhuangtaisel.DataBind();

                string sqls3 = "select formula from formula where quesId=@id and OrderId<=4";
                DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqls3, new MySqlParameter("@id", quesId));
                DataTable dt3 = ds3.Tables[0];
                formulasel.DataSource = dt3;
                formulasel.DataBind();

                string sqls4 = "select text from kejie";
                DataSet ds4 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqls4, new MySqlParameter("@id", quesId));
                DataTable dt4 = ds4.Tables[0];
                kejiesel.DataSource = dt4;
                kejiesel.DataBind();

            }



            string sqlpic0 = "select url from questionpic where OrderId= 9";
            string pic0;
            MySqlDataReader drpic0 = null;
            drpic0 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic0, new MySqlParameter("@id", quesId));
            while (drpic0.Read())
            {

                pic0 = drpic0.GetString("url");
                ps0.InnerHtml = "<img src='questionpic/" + pic0 + "' >";
            }
            drpic0.Close();

            string sqlpic1 = "select url from questionpic where OrderId= 10";
            string pic1;
            MySqlDataReader drpic1 = null;
            drpic1 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic1, new MySqlParameter("@id", quesId));
            while (drpic1.Read())
            {

                pic1 = drpic1.GetString("url");
                ps1.InnerHtml = "<img src='questionpic/" + pic1 + "' >";
            }
            drpic1.Close();

            string sqlpic2 = "select url from questionpic where OrderId= 11";
            string pic2;
            MySqlDataReader drpic2 = null;
            drpic2 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic2, new MySqlParameter("@id", quesId));
            while (drpic2.Read())
            {

                pic2 = drpic2.GetString("url");
                ps2.InnerHtml = "<img src='questionpic/" + pic2 + "' >";
            }
            drpic2.Close();

            string sqlpic3 = "select url from questionpic where OrderId= 12";
            string pic3;
            MySqlDataReader drpic3 = null;
            drpic3 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic3, new MySqlParameter("@id", quesId));
            while (drpic3.Read())
            {

                pic3 = drpic3.GetString("url");
                ps3.InnerHtml = "<img src='questionpic/" + pic3 + "' >";
            }
            drpic3.Close();

            string sqlpic4 = "select url from questionpic where OrderId= 13";
            string pic4;
            MySqlDataReader drpic4 = null;
            drpic4 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic4, new MySqlParameter("@id", quesId));
            while (drpic4.Read())
            {

                pic4 = drpic4.GetString("url");
                ps4.InnerHtml = "<img src='questionpic/" + pic4 + "' >";
            }
            drpic4.Close();

            string piczhuangtai = "select url from questionpic where OrderId= 8";
            string ztpic;
            MySqlDataReader drzt = null;
            drzt = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, piczhuangtai, new MySqlParameter("@id", quesId));
            while (drzt.Read())
            {

                ztpic = drzt.GetString("url");
                left1.InnerHtml = "<img src='questionpic/" + ztpic + "' >";
            }
            drzt.Close();
        }
    }
}