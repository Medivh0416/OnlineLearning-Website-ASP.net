using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class query : System.Web.UI.Page
    {
        static DataSet ds1 = null;
        static DataTable dt1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql1 = "select * from record";
            ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1);
            dt1 = ds1.Tables[0];
            gvShow.DataSource = dt1;//绑定数据
            gvShow.DataBind();
            gvShow.HeaderRow.Cells[0].Text = " 序号 ";
            gvShow.HeaderRow.Cells[1].Text = " 省份 ";
            gvShow.HeaderRow.Cells[2].Text = " 姓名 ";
            gvShow.HeaderRow.Cells[3].Text = " 科目 ";
            gvShow.HeaderRow.Cells[4].Text = " 高考分数 ";
            gvShow.HeaderRow.Cells[5].Text = " 位次 ";
            gvShow.HeaderRow.Cells[6].Text = " 批次 ";
            gvShow.HeaderRow.Cells[7].Text = "查询日期";
        }
        protected void gvShow_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvShow.PageIndex = e.NewPageIndex;
            gvShow.DataBind();
            gvShow.HeaderRow.Cells[0].Text = " 序号 ";
            gvShow.HeaderRow.Cells[1].Text = " 省份 ";
            gvShow.HeaderRow.Cells[2].Text = " 姓名 ";
            gvShow.HeaderRow.Cells[3].Text = " 科目 ";
            gvShow.HeaderRow.Cells[4].Text = " 高考分数 ";
            gvShow.HeaderRow.Cells[5].Text = " 位次 ";
            gvShow.HeaderRow.Cells[6].Text = " 批次 ";
            gvShow.HeaderRow.Cells[7].Text = "查询日期";
        }
    }
}