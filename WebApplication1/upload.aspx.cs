using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.Security;
namespace WebApplication1
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

        }
        //protected void submit_Click1(object sender, EventArgs e)
        //{
        //if (question.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('题目不能为空');</script>");
        //    return;
        //}
        //else if (yjdx.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert(研究对象不能为空');</script>");
        //    return;
        //}
        //else if (yztj.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('已知条件不能为空');</script>");
        //    return;
        //}
        //else if (yzl.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('已知量不能为空');</script>");
        //    return;
        //}
        //else if (wzl.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('未知量不能为空');</script>");
        //    return;
        //}


        //else if (task.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('任务不能为空');</script>");
        //    return;
        //}
        //else if (selection.Text == "")
        //{
        //    Response.Write("<script language = javascript>alert('选项不能为空');</script>");
        //    return;
        //}
        //else
        //{
        //    //题目的上传
        //    MySqlConnection conn = new MySqlConnection(MySqlHelper.Conn);
        //    string val = question.Text;
        //    string ins = "insert into questions(questionTitle)values('" + val + "')";
        //    MySqlCommand inscom = new MySqlCommand(ins, conn);
        //    MySqlDataAdapter da = new MySqlDataAdapter();
        //    conn.Open();
        //    da.InsertCommand = inscom;
        //    da.InsertCommand.ExecuteNonQuery();
        //    // 图片的上传
        //    if (quespicup.HasFile)
        //    {
        //        string path = MapPath("~/questionpic/") + quespicup.FileName;
        //        quespicup.SaveAs(path);
        //    }
        //    //研究对象
        //    string valyjdx = yjdx.Text;
        //    string inyjdx = "insert into yanjiuduixiang(yjdx)values('" + val + "')";
        //    MySqlCommand yjdxcom = new MySqlCommand(inyjdx, conn);
        //    MySqlDataAdapter dayjdx = new MySqlDataAdapter();
        //    dayjdx.InsertCommand = yjdxcom;
        //    dayjdx.InsertCommand.ExecuteNonQuery();
        //    //已知条件
        //    string valyztj = yztj.Text;
        //    string inyztj = "insert into yizhitiaojian(yztj)values('" + val + "')";
        //    MySqlCommand yztjcom = new MySqlCommand(inyztj, conn);
        //    MySqlDataAdapter dayztj = new MySqlDataAdapter();
        //    dayztj.InsertCommand = yztjcom;
        //    dayztj.InsertCommand.ExecuteNonQuery();
        //    //已知量
        //    string valyzl = yzl.Text;
        //    string inyzl = "insert into yizhiliang(yzl)values('" + val + "')";
        //    MySqlCommand yzlcom = new MySqlCommand(inyzl, conn);
        //    MySqlDataAdapter dayzl = new MySqlDataAdapter();
        //    dayzl.InsertCommand = yzlcom;
        //    dayzl.InsertCommand.ExecuteNonQuery();
        //    //未知量
        //    string valwzl = wzl.Text;
        //    string inwzl = "insert into weizhiliang(wzl)values('" + val + "')";
        //    MySqlCommand wzlcom = new MySqlCommand(inwzl, conn);
        //    MySqlDataAdapter dawzl = new MySqlDataAdapter();

        //    dawzl.InsertCommand = wzlcom;
        //    dawzl.InsertCommand.ExecuteNonQuery();
        //    //任务
        //    string valtask = task.Text;
        //    string intask = "insert into tips(text)values('" + val + "')";
        //    MySqlCommand taskcom = new MySqlCommand(intask, conn);
        //    MySqlDataAdapter datask = new MySqlDataAdapter();

        //    datask.InsertCommand = taskcom;
        //    datask.InsertCommand.ExecuteNonQuery();
        //    // 选项

        //    string valsel = selection.Text;
        //    string insel = "insert into selection(selection)values('" + val + "')";
        //    MySqlCommand selcom = new MySqlCommand(insel, conn);
        //    MySqlDataAdapter dasel = new MySqlDataAdapter();
        //    dasel.InsertCommand = selcom;
        //    dasel.InsertCommand.ExecuteNonQuery();
        //    Response.Write("<script language = javascript>alert('上传题目成功');</script>");
     
    }
}
        
            
        

           
        
