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
    public partial class study2t : System.Web.UI.Page
    {
        string quesId;
        protected void Page_Load(object sender, EventArgs e)
        {
            string time = Request.QueryString["time"];
            temp.Value = time;
            //////////////////////////////////////////
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
            try
            {
                string title = "select questionTitle from questions where id=@id";
                MySqlDataReader dataReader = null;
                dataReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title, new MySqlParameter("@id", quesId));
                while (dataReader.Read())
                {
                    left.InnerHtml += dataReader["questionTitle"].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                string javaScript = @" <script  language=javascript> layer.alert('加载题目信息时出错了，请重试！', 8);</script> ";
                ClientScript.RegisterStartupScript(this.GetType(), "javaScript", javaScript);
                return;
            }
            //                 
            string yjdx = "select yjdx from yanjiuduixiang where OrderId=1 and quesId=@id";
            MySqlDataReader duixiangReader = null;
            duixiangReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yjdx,new MySqlParameter("@id",quesId));
            while (duixiangReader.Read())
            {
                duixiang.InnerHtml += duixiangReader["yjdx"].ToString();
            }
            duixiangReader.Close();
            //已知条件
          
                string yizhi1 = "select yztj from yizhitiaojian where quesId=@id and OrderId = 1";
                MySqlDataReader yizhi1Reader = null;
                yizhi1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhi1, new MySqlParameter("@id", quesId));
                while (yizhi1Reader.Read())
                {
                    yizhia.InnerHtml += yizhi1Reader["yztj"].ToString();
                }
                yizhi1Reader.Close();
                // 
                string yizhi2 = "select yztj from yizhitiaojian where quesId=@id and OrderId =2";
                MySqlDataReader yizhi2Reader = null;
                yizhi2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhi2, new MySqlParameter("@id", quesId));
                while (yizhi2Reader.Read())
                {
                    yizhib.InnerHtml += yizhi2Reader["yztj"].ToString();
                }
                yizhi2Reader.Close();
                //
                string yizhi3 = "select yztj from yizhitiaojian where quesId=@id and OrderId =3";
                MySqlDataReader yizhi3Reader = null;
                yizhi3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhi3, new MySqlParameter("@id", quesId));
                while (yizhi3Reader.Read())
                {
                    yizhic.InnerHtml += yizhi3Reader["yztj"].ToString();
                }
                yizhi3Reader.Close();
                //
                string yizhi4 = "select yztj from yizhitiaojian where quesId=@id and OrderId =4";
                MySqlDataReader yizhi4Reader = null;
                yizhi4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhi4, new MySqlParameter("@id", quesId));
                while (yizhi4Reader.Read())
                {
                    yizhid.InnerHtml += yizhi4Reader["yztj"].ToString();
                }
                yizhi4Reader.Close();
                //
                string yizhi5 = "select yztj from yizhitiaojian where quesId=@id and OrderId =5";
                MySqlDataReader yizhi5Reader = null;
                yizhi5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yizhi5, new MySqlParameter("@id", quesId));
                while (yizhi5Reader.Read())
                {
                    yizhie.InnerHtml += yizhi5Reader["yztj"].ToString();
                }
                yizhi5Reader.Close();
            
            //已知量
            string yzl = "select yzl from yizhiliang where quesId = @id and OrderId = 1";
            MySqlDataReader yzlReader = null;
            yzlReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, yzl,new MySqlParameter("@id",quesId));
            while (yzlReader.Read())
            {
                yizhiliang.InnerHtml += yzlReader["yzl"].ToString();
            }
            yzlReader.Close();
            //
            string wzl = "select wzl from weizhiliang where quesId=@id and OrderId =1";
            MySqlDataReader wzlReader = null;
            wzlReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, wzl,new MySqlParameter("@id",quesId));
            while (wzlReader.Read())
            {
                weizhiliang.InnerHtml += wzlReader["wzl"].ToString();
            }
            wzlReader.Close();
            //
            string wzl2 = "select wzl from weizhiliang where quesId=@id and OrderId =2";
            MySqlDataReader wzl2Reader = null;
            wzl2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, wzl2,new MySqlParameter("@id",quesId));
            while (wzl2Reader.Read())
            {
                weizhiliang2.InnerHtml += wzl2Reader["wzl"].ToString();
            }
            wzl2Reader.Close();

            if (!IsPostBack)
            {
                string sqls1 = "select selection from selection where quesId = @id and OrderId <=6";
                DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqls1,new MySqlParameter("@id",quesId));
                DataTable dt1 = ds1.Tables[0];
               select.DataSource = dt1;
                select.DataBind();
            }
        }
       
            protected string tips1(string strtip1)
            {
                string tip1 = "select text from tips where quesId = @id and OrderId =1";
                MySqlDataReader tip1Reader = null;
                tip1Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip1,new MySqlParameter("@id",quesId));
                while (tip1Reader.Read())
                {
                    strtip1 = tip1Reader["text"].ToString();
                   }
                tip1Reader.Close();
                return strtip1;
            }
            protected string tips2(string strtip2)
            {
                string tip2 = "select text from tips where quesId = @id and OrderId =2";
                MySqlDataReader tip2Reader = null;
                tip2Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip2, new MySqlParameter("@id", quesId));
                while (tip2Reader.Read())
                {
                    strtip2 = tip2Reader["text"].ToString();
                }
                tip2Reader.Close();
                return strtip2;
            }
            protected string tips3(string strtip3)
            {
                string tip3 = "select text from tips where quesId = @id and OrderId =3";
                MySqlDataReader tip3Reader = null;
                tip3Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip3, new MySqlParameter("@id", quesId));
                while (tip3Reader.Read())
                {
                    strtip3 = tip3Reader["text"].ToString();
                }
                tip3Reader.Close();
                return strtip3;
            }
            protected string tips4(string strtip4)
            {
                string tip4 = "select text from tips where quesId = @id and OrderId =4";
                MySqlDataReader tip4Reader = null;
                tip4Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip4, new MySqlParameter("@id", quesId));
                while (tip4Reader.Read())
                {
                    strtip4 = tip4Reader["text"].ToString();
                }
                tip4Reader.Close();
                return strtip4;
            }
            protected string tips5(string strtip5)
            {
                string tip5 = "select text from tips where quesId = @id and OrderId =5";
                MySqlDataReader tip5Reader = null;
                tip5Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip5, new MySqlParameter("@id", quesId));
                while (tip5Reader.Read())
                {
                    strtip5 = tip5Reader["text"].ToString();
                }
                tip5Reader.Close();
                return strtip5;
            }
            protected string tips6(string strtip6)
            {
                string tip6 = "select text from tips where quesId = @id and OrderId =6";
                MySqlDataReader tip6Reader = null;
                tip6Reader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, tip6, new MySqlParameter("@id", quesId));
                while (tip6Reader.Read())
                {
                    strtip6 = tip6Reader["text"].ToString();
                }
                tip6Reader.Close();
                return strtip6;
            }
        }

      
    }
