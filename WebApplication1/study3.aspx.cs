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
    public partial class study3 : System.Web.UI.Page
    {
        string quesId;
        protected string tips1(string strtip1)
        {
            string tip1 = "select text from tips where id=7";
            MySqlDataReader tip1Reader = null;
            tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip1);
            while (tip1Reader.Read())
            {
                strtip1 = tip1Reader["text"].ToString();
            }
            tip1Reader.Close();
            return strtip1;
        }
        protected string tips2(string strtip2)
        {
            string tip2 = "select text from tips where id=24";
            MySqlDataReader tip1Reader = null;
            tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip2);
            while (tip1Reader.Read())
            {
                strtip2 = tip1Reader["text"].ToString();
            }
            tip1Reader.Close();
            return strtip2;
        }
        protected string tips3(string strtip3)
        {
            string tip3 = "select text from tips where id=25";
            MySqlDataReader tip1Reader = null;
            tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip3);
            while (tip1Reader.Read())
            {
                strtip3 = tip1Reader["text"].ToString();
            }
            tip1Reader.Close();
            return strtip3;
        }
        protected string tips4(string strtip1)
        {
            string tip1 = "select text from tips where id=26";
            MySqlDataReader tip1Reader = null;
            tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip1);
            while (tip1Reader.Read())
            {
                strtip1 = tip1Reader["text"].ToString();
            }
            tip1Reader.Close();
            return strtip1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.quesId = Session["quesId"].ToString();

            }
            catch
            {

            }
            if (string.IsNullOrEmpty(quesId))
            {
                quesId = "3";
            }
            string time = Request.QueryString["time"];
            temp.Value = time;
            //////////////////////////////////////////
            if (!IsPostBack)
            {

                string sql1 = "select statusoptions from statusoptions where quesId=@id and OrderId <7 ";
                DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1,new MySqlParameter("@id",quesId));
                DataTable dt1 = ds1.Tables[0];
                sop.DataSource = dt1;
                sop.DataBind();


                string sql2 = "select tiaojian from characteristic_tiaojian where quesId=@id and OrderId <=5";
                DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, new MySqlParameter("@id", quesId));
                DataTable dt2 = ds2.Tables[0];
                dx.DataSource = dt2;
                dx.DataBind();

                string sql3 = "select fangxiang from fangxiang where quesId =@id and OrderId <=4";
                DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, new MySqlParameter("@id", quesId));
                DataTable dt3 = ds3.Tables[0];
                fx.DataSource = dt3;
                fx.DataBind();

                string sql4 = "select tiaojian from tiaojian where quesId=@id and OrderId <=9";
                DataSet ds4 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql4, new MySqlParameter("@id", quesId));
                DataTable dt4 = ds4.Tables[0];
                tj.DataSource = dt4;
                tj.DataBind();

                string sql5 = "select yiju from yiju where quesId= @id and OrderId <=9";
                DataSet ds5 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql5, new MySqlParameter("@id", quesId));
                DataTable dt5 = ds5.Tables[0];
                yj.DataSource = dt5;
                yj.DataBind();
                //研究对象

                string yanjiuduixiang1 = "select yjdx from yanjiuduixiang where quesId=@id and OrderId=1";
                MySqlDataReader dataReader = null;
                dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yanjiuduixiang1,new MySqlParameter("@id",quesId));
                while (dataReader.Read())
                {
                    understand_yanjiuduixiang1.InnerHtml += dataReader["yjdx"].ToString();
                }
                dataReader.Close();

                string yanjiuduixiang2 = "select text from tips where quesId=@id and OrderId=1";
                MySqlDataReader yjdxReader = null;
                yjdxReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yanjiuduixiang2,new MySqlParameter("@id",quesId));
                while (yjdxReader.Read())
                {
                    understand_yanjiuduixiang2.InnerHtml += yjdxReader["text"].ToString();
                }
                yjdxReader.Close();
                //已知条件
                string yizhitiaojian1 = "select yztj from yizhitiaojian where quesId=@id and OrderId = 1";
                MySqlDataReader yztj1Reader = null;
                yztj1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian1, new MySqlParameter("@id", quesId));
                while (yztj1Reader.Read())
                {
                    understand_yizhitiaojian1.InnerHtml += yztj1Reader["yztj"].ToString();
                }
                yztj1Reader.Close();

                string yizhitiaojian2 = "select yztj from yizhitiaojian where quesId=@id and OrderId =2";
                MySqlDataReader yztj2Reader = null;
                yztj2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian2, new MySqlParameter("@id", quesId));
                while (yztj2Reader.Read())
                {
                    understand_yizhitiaojian2.InnerHtml += yztj2Reader["yztj"].ToString();
                }
                yztj2Reader.Close();

                string yizhitiaojian21 = "select text from tips where quesId=@id and OrderId=2";
                MySqlDataReader yztj21Reader = null;
                yztj21Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian21, new MySqlParameter("@id", quesId));
                while (yztj21Reader.Read())
                {
                    understand_yizhitiaojian21.InnerHtml += yztj21Reader["text"].ToString();
                }
                yztj21Reader.Close();

                string yizhitiaojian3 = "select yztj from yizhitiaojian where quesId=@id and OrderId =3";
                MySqlDataReader yztj3Reader = null;
                yztj3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian3, new MySqlParameter("@id", quesId));
                while (yztj3Reader.Read())
                {
                    understand_yizhitiaojian3.InnerHtml += yztj3Reader["yztj"].ToString();
                }
                yztj3Reader.Close();

                string yizhitiaojian31 = "select text from tips where quesId=@id and OrderId=3";
                MySqlDataReader yztj31Reader = null;
                yztj31Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian31, new MySqlParameter("@id", quesId));
                while (yztj31Reader.Read())
                {
                    understand_yizhitiaojian31.InnerHtml += yztj31Reader["text"].ToString();
                }
                yztj31Reader.Close();

                string yizhitiaojian4 = "select yztj from yizhitiaojian where quesId=@id and OrderId =4";
                MySqlDataReader yztj4Reader = null;
                yztj4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian4, new MySqlParameter("@id", quesId));
                while (yztj4Reader.Read())
                {
                    understand_yizhitiaojian4.InnerHtml += yztj4Reader["yztj"].ToString();
                }
                yztj4Reader.Close();

                string yizhitiaojian41 = "select text from tips where quesId=@id and OrderId=4";
                MySqlDataReader yztj41Reader = null;
                yztj41Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian41, new MySqlParameter("@id", quesId));
                while (yztj41Reader.Read())
                {
                    understand_yizhitiaojian41.InnerHtml += yztj41Reader["text"].ToString();
                }
                yztj41Reader.Close();

                string yizhitiaojian5 = "select yztj from yizhitiaojian where quesId=@id and OrderId =5";
                MySqlDataReader yztj5Reader = null;
                yztj5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhitiaojian5, new MySqlParameter("@id", quesId));
                while (yztj5Reader.Read())
                {
                    understand_yizhitiaojian5.InnerHtml += yztj5Reader["yztj"].ToString();
                }
                yztj5Reader.Close();
                //已知量
                string yizhiliang = "select yzl from yizhiliang where quesId = @id and OrderId = 1";
                MySqlDataReader yzlReader = null;
                yzlReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhiliang, new MySqlParameter("@id", quesId));
                while (yzlReader.Read())
                {
                    understand_yizhiliang.InnerHtml += yzlReader["yzl"].ToString();
                }
                yzlReader.Close();
                //未知量
                string weizhiliang1 = "select wzl from weizhiliang where quesId=@id and OrderId =1";
                MySqlDataReader wzl1Reader = null;
                wzl1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, weizhiliang1, new MySqlParameter("@id", quesId));
                while (wzl1Reader.Read())
                {
                    understand_weizhiliang1.InnerHtml += wzl1Reader["wzl"].ToString();
                }
                wzl1Reader.Close();
                string weizhiliang11 = "select text from tips where quesId=@id and OrderId=5";
                MySqlDataReader wzl11Reader = null;
                wzl11Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, weizhiliang11, new MySqlParameter("@id", quesId));
                while (wzl11Reader.Read())
                {
                    understand_weizhiliang11.InnerHtml += wzl11Reader["text"].ToString();
                }
                wzl11Reader.Close();

                string weizhiliang2 = "select wzl from weizhiliang where quesId=@id and OrderId =2";
                MySqlDataReader wzl2Reader = null;
                wzl2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, weizhiliang2, new MySqlParameter("@id", quesId));
                while (wzl2Reader.Read())
                {
                    understand_weizhiliang2.InnerHtml += wzl2Reader["wzl"].ToString();
                }
                wzl2Reader.Close();

                string weizhiliang21 = "select text from tips where quesId=@id and OrderId=6";
                MySqlDataReader wzl21Reader = null;
                wzl21Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, weizhiliang21, new MySqlParameter("@id", quesId));
                while (wzl21Reader.Read())
                {
                    understand_weizhiliang21.InnerHtml += wzl21Reader["text"].ToString();
                }
                wzl21Reader.Close();

                string sqlpic = "select url from questionpic where id= 6";
                string pic4_1;
                MySqlDataReader drpic4_1 = null;
                drpic4_1 = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, sqlpic, new MySqlParameter("@id", quesId));
                while (drpic4_1.Read())
                {

                    pic4_1 = drpic4_1.GetString("url");
                    left.InnerHtml = "<img src='questionpic/" + pic4_1 + "' >";
                }
                drpic4_1.Close();

            }

        }
       
      

        protected void next_Click(object sender, EventArgs e)
        {
            Response.Redirect("study4-1.aspx");
        }


    }
}







