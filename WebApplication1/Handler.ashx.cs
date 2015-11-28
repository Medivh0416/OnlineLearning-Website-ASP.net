using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    /// <summary>
    /// Handler 的摘要说明
    /// </summary>
    public class Handler : IHttpHandler
    {
        //context.Request.Params["参数"].ToString();方法来获取前台传来的值
        public void ProcessRequest(HttpContext context)
        {
            //StringBuilder strBul = new StringBuilder();
            
            //strBul.Append("<option value='wangtao'>test");
            //strBul.Append(context.Request.Params["type"].ToString());
            //strBul.Append("</option>");
            //context.Response.ContentType = "text/plain";
            //context.Response.Write(strBul.ToString());
            //context.Response.Write方法给前台传值

            string method = context.Request.Params["method"].ToString();
            switch (method)
            {
                case "getTitle": { 
                    //虽然比较怪，但是可以按这个套路去用ajax读取数据库数据。
                    //getTitle函数包括了读取数据库的代码，参数是前台返回的id值，返回读取的值。最后在传给前台代码
                    string title1 = getTitle(context.Request.Params["id"].ToString());
                    context.Response.ContentType = "text/plain";
                    context.Response.Write(title1.ToString());
                }; break;

                default: context.Response.Write("找不到方法"); break;

            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        protected string getTitle(string str)
        {
            
            string title0 = "select title from news order by id DESC limit "+ str +",1";
            MySqlDataReader contentReader = null;
            contentReader = MySqlHelper.ExecuteReader(MySqlHelper.Conn, System.Data.CommandType.Text, title0);
            while (contentReader.Read())
            {
                return contentReader["title"].ToString();
            }
            contentReader.Close();
            return "error"; 
        }
    }
}