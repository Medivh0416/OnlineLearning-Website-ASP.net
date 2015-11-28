using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.POIFS;
using NPOI.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HSSF.Util;


namespace WebApplication1
{
    public partial class declare : System.Web.UI.Page
    {
        static DataSet ds1 = null;
        static DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataSet dsddl = null;
                try
                {
                    string sqlddl = "select * from typed_in";
                    dsddl = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sqlddl);
                }
                catch
                {
                    Label1.Text = "省市数据加载失败";
                }
                if (dsddl == null)
                {
                    Label1.Text = "当前数据库中没有录入省市数据";
                }

                DataTable dtddl = dsddl.Tables[0];
                ddlPro.DataSource = dtddl;//设置数据源

                ddlPro.DataTextField = "province";//设置所要读取的数据表里的列名

                ddlPro.DataValueField = "id";

                ddlPro.DataBind();//数据绑定
            }
            Label1.Text = "";
            
        }

        public struct record
        {
            public int id, lp, r, cp, x, y;
            //id记录id；l为大学层次；lp为层次赋分；cp为城市赋分；r为平均位次；x为加权前的录取分值，y为加权后分值
            public string uni, city, l;//uni大学名称，city所在城市
        }
       
        protected void Sort(record[] Rec, int n)//排序
        {
            int m, min, k;
            record temp;
            for (m = 0; m <= n - 1; m++)
            {
                min = m;
                for (k = m + 1; k <= n - 1; k++)
                    if (Rec[min].y > Rec[k].y)
                        min = k;
                if (min != m)
                {
                    temp = Rec[m];
                    Rec[m] = Rec[min];
                    Rec[min] = temp;
                }

            }
        }

        protected DataTable Write(DataTable dt1, int rank,string title)
        {
            string strAbove = " ";
            string strUnder = " ";
            string strPS = "表格中的大学是智能软件通过运算，推荐适合您填在A志愿为“冲一冲”的可供选择的5所院校，适合您填在B、C志愿“稳一稳”的可供选择的5所院校，适合您填在D 、E志愿“保一保”的可供选择5所院校，每一志愿中选择一所填在正式表格中,A、B、C院校建议专业服从调剂，D、E院校可以不专业服从调剂，以上结果仅供考生和家长参考，不代表最终实际投档结果。";
            int i, c, j,k,test, p, q;
            c = 0;
            for (i = 0; i < 50; i++)
            {
                if (Convert.ToInt32(dt1.Rows[i][6]) < rank)
                {
                    test = Convert.ToInt32(dt1.Rows[i][6]);
                    c = i;
                }
                else
                    break;
            }//判断有多少所大学排名在实际排名之上

            if (c < 5)
            {
                j = 0;
                p = c+1;
            }
            else
            {
                j = c - 4;
                p = 5;
                for (k = 0; k<3&k<j; k++)
                {   //if(dt1.Rows[k]!=null)
                    strAbove = strAbove + dt1.Rows[k][1] + "   ";//strAbove、strUnder记录A类志愿以上或E类志愿以后的推荐学校
                    
                }
            }
            k = c + 21;
            int s = k;
            for (i = 0; i < 26; i++)
            {
                if (dt1.Rows.Count >= i + 1)
                {
                    c = i;
                }

            }
            if (c != 25)
                q = c - p;
            else
            {
                q = 20;
                //int l;
                for (; k <s+3&k<dt1.Rows.Count; k++)
                {   //if(dt1.Rows[k]!=null)
                    strUnder = strUnder + dt1.Rows[k][1] + "   ";
                    //if (l / 5 == 0)
                    //{
                    //    strUnder = strUnder + "\n";
                    //}
                }
                
            }
            record[] recA = new record[p];//志愿A

            
            for (i = 0; i < p; i++, j++)
            {

                recA[i].uni = Convert.ToString(dt1.Rows[j][1]);
                recA[i].city = Convert.ToString(dt1.Rows[j][2]);
                recA[i].cp = Convert.ToInt32(dt1.Rows[j][3]);
                if (dt1.Rows[j][4] != null)
                    recA[i].l = Convert.ToString(dt1.Rows[j][4]);
                recA[i].lp = Convert.ToInt32(dt1.Rows[j][5]);
                recA[i].r = Convert.ToInt32(dt1.Rows[j][6]);
                recA[i].x = 76 + i;
                recA[i].y = recA[i].x - recA[i].cp - recA[i].lp;
            }//将表中数据赋值给数组
            Sort(recA, p);//排序


            record[] recB = new record[q];//志愿B——E
            //j = k - 21;
            for (i = 0; i <q; i++, j++)
            {
                if (dt1.Rows.Count >= j + 1)
                {
                    recB[i].uni = Convert.ToString(dt1.Rows[j][1]);
                    recB[i].city = Convert.ToString(dt1.Rows[j][2]);
                    recB[i].cp = Convert.ToInt32(dt1.Rows[j][3]);
                    if (dt1.Rows[j][4] != null)
                        recB[i].l = Convert.ToString(dt1.Rows[j][4]);
                    recB[i].lp = Convert.ToInt32(dt1.Rows[j][5]);
                    recB[i].r = Convert.ToInt32(dt1.Rows[j][6]);
                    recB[i].x = 81 + i;
                    recB[i].y = recB[i].x - recB[i].cp - recB[i].lp;
                }

            }//将表中数据赋值给数组
            Sort(recB, q);
            dt1.Clear();//清除原有表中记录
            dt1 = new DataTable();
            string name_gv = Convert.ToString(txtName.Value);
            dt1.Columns.Add("");
            dt1.Columns.Add("");
            dt1.Columns.Add("");
            dt1.Columns.Add("");
            dt1.Columns.Add("");
            dt1.Columns.Add("");
            

            for (i = 0; i < 37; i++)
            {
                dt1.Rows.Add();
            }
            j = 3;
            for (i = 0; i < p; i++, j++)
            {
                dt1.Rows[j][1] = recA[i].uni;
                //dt1.Rows[j][2] = recA[i].x;
                if (recA[i].l != null)
                    dt1.Rows[j][2] = recA[i].l;
                dt1.Rows[j][3] = recA[i].city;
                dt1.Rows[j][4] = recA[i].y;
            }//将排序过的数组赋值给表
            j = 8;
            for (i = 0; i <q; i++, j++)
            {
                if (dt1.Rows.Count >= j + 1)
                {
                    dt1.Rows[j][1] = recB[i].uni;
                    if (recB[i].l != null)
                        dt1.Rows[j][2] = recB[i].l;
                    dt1.Rows[j][3] = recB[i].city;
                    dt1.Rows[j][4] = recB[i].y;

                }
            }//将排序过的数组赋值给表
            dt1.Rows[3][0] = "A志愿";
            dt1.Rows[8][0] = "B志愿";
            dt1.Rows[13][0] = "C志愿";
            dt1.Rows[18][0] = "D志愿";
            dt1.Rows[23][0] = "E志愿";
            dt1.Rows[2][0] = "志愿类型";
            dt1.Rows[0][0] = title;
            dt1.Rows[2][1] = "推荐大学名称";
            dt1.Rows[2][2] = "学院性质";
            dt1.Rows[2][3] = "学院地域";
            dt1.Rows[2][4] = "加权后的录取分值";
            dt1.Rows[2][5] = "意愿标记";//添加列名
            dt1.Rows[28][0] = "一、加权后的录取分值的说明：";
            dt1.Rows[29][0] = "加权后的录取分值为运用位次定位法与分差定位法结合地域、院校性质等因素的综合运算的结果，录取分值为软件依据大量数据估算，按此填报志愿，成功录取率在90%以上，录取分值越大，录取的可能性越大。过于冒险和过于保守的学校不会被推荐。";
            dt1.Rows[30][0] = "二、适合A志愿录取可能性更小的可供选择的学院为：";
            dt1.Rows[31][0] = strAbove;
            dt1.Rows[32][0] = "三、适合B、C、D、E录取可能性更大的可供选择的学院为：";
            dt1.Rows[33][0] = strUnder;
            dt1.Rows[34][0] = "四、注释：";
            dt1.Rows[35][0] = strPS;
            dt1.Rows[36][0] = "五、专业的选择填报事宜，参考报考指南或线下咨询专家。";
            return dt1;
        }


        protected void Submit_Click(object Sender, EventArgs e)
        {

            //if (txtGrade.Value == "" || txtName.Value == "" || txtRanking.Value == "")
            //    Label1.Text = "请输入完整信息";
            if (txtGrade.Value == "" || txtName.Value == "" )
                Label1.Text = "请输入完整信息";
            else
            {
                int n = 5;
                int o = 10;
                int course = int.Parse(ddlCourse.Value);
                int batch = int.Parse(ddlBatch.Value);
                int province = int.Parse(ddlPro.SelectedValue);
                string name = txtName.Value;
                MySqlParameter paramGa = new MySqlParameter("?grade", MySqlDbType.Int32);
                MySqlParameter paramCo = new MySqlParameter("?course", MySqlDbType.Int32);
                paramCo.Value = course;
                paramGa.Value = txtGrade.Value;
                string sqlSelectrank = "select rank from grade_rank where grade =?grade and course=?course";
                int Rank = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sqlSelectrank, paramGa,paramCo));
                int gradeadd = int.Parse(txtGrade.Value) + n;
                int gradecut = int.Parse(txtGrade.Value) - o;
                int rank = Rank;
                    
                    //grade、rank、course、batch、province、name分别记录分数，排名，文/理科，批次，省份，学生姓名



                    MySqlParameter[] param = new MySqlParameter[] 
                    {   new MySqlParameter("?gradeadd",MySqlDbType.Int32),
                        new MySqlParameter("?gradecut",MySqlDbType.Int32),
                        new MySqlParameter("?ranku",MySqlDbType.Int32),
                        new MySqlParameter("?rankd",MySqlDbType.Int32),
                        new MySqlParameter("?province",MySqlDbType.Int32),
                        new MySqlParameter("?batch",MySqlDbType.Int32),
                        new MySqlParameter("?course",MySqlDbType.Int32),
                        new MySqlParameter("?name_record",MySqlDbType.String),
                        new MySqlParameter("?course_record",MySqlDbType.String),
                        new MySqlParameter("?grade_record",MySqlDbType.Int32),
                        new MySqlParameter("?rank_record",MySqlDbType.Int32),
                        new MySqlParameter("?batch_record",MySqlDbType.String),
                        new MySqlParameter("?pro_string",MySqlDbType.String),
                        new MySqlParameter("?datatime",MySqlDbType.DateTime),

                    };
                    param[0].Value = gradeadd;
                    param[1].Value = gradecut;
                    param[6].Value = course;


                    try
                    {
                        string sql1 = "select rank from grade_rank where grade =?gradeadd and course=?course";
                        int ranku = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, param[0],param[6]));
                        string sql2 = "select rank from grade_rank where grade = ?gradecut and course=?course";
                        int rankd = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, param[1],param[6]));
                        //查询分数上下界对应的名次
                        param[2].Value = ranku;
                        param[3].Value = rankd;
                        param[4].Value = province;
                        param[5].Value = batch;
                        

                        string sql3 = "select id,university,city,citypoint,level,levelpoint,rank from(select id,university,city,citypoint,level,levelpoint,rank from univers where rank between ?ranku and ?rankd and province = ?province and batch= ?batch and course= ?course)as a order by rank asc";
                        ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, param[2], param[3], param[4], param[5], param[6]);
                        //取出推荐数据
                    }
                    catch
                    {
                        string str = "数据查询失败";
                        Label1.Text = str;
                    }

                    dt1 = ds1.Tables[0];
                    if (dt1.Rows.Count == 0)
                    {
                        Label1.CssClass = "lbl";
                        Label1.Text = "该部分数据暂未录入";
                    }


                    else
                    {
                        string sql5 = "select province from typed_in where id = ?province";
                        param[4].Value = province;
                        string pro_string = Convert.ToString(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql5, param[4]));
                        string sql4 = "insert into record(province,name,course,grade,rank,batch,time)values(?pro_string,?name_record,?course_record,?grade_record,?rank_record,?batch_record,?datatime)";
                        param[12].Value = pro_string;
                        param[7].Value = name;
                        if (course == 0)
                            param[8].Value = "理科";
                        else
                            param[8].Value = "文科";
                        param[9].Value = int.Parse(txtGrade.Value);
                        param[10].Value = rank;
                        param[13].Value = DateTime.Now.ToString();
                        switch (batch)
                        {
                            case 0: param[11].Value = "一本";
                                break;
                            case 1: param[11].Value = "二本";
                                break;
                            case 2: param[11].Value = "三本";
                                break;

                        }
                        int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql4, param[12], param[7], param[8], param[9], param[10], param[11],param[13]);

                        string title = "省份:" + pro_string +" "+" "+" "+"姓名："+name+"    "+"报考类别：" + param[8].Value +"     "+"分数：" + txtGrade.Value +"     "+"位次:"+rank+"     "+"批次：" + param[11].Value;
                        dt1 = Write(dt1, rank, title);//向表中写入数据
                        //DataTable dt2 = dt1;
                        //dt2.Rows.RemoveAt(0);
                        //dt2.Rows.RemoveAt(1);
                        //dt2.Rows.RemoveAt(2);
                        Gv1.DataSource = dt1;//绑定数据
                        Gv1.DataBind();
                        GroupCol(Gv1, 0, 3, 8);
                        GroupCol(Gv1, 0, 8, 13);
                        GroupCol(Gv1, 0, 13, 18);
                        GroupCol(Gv1, 0, 18, 23);
                        GroupCol(Gv1, 0, 23, 28);
                        GroupRow(Gv1, 0, 0, 6);
                        GroupRow(Gv1, 28, 0, 6);
                        GroupRow(Gv1, 29, 0, 6);
                        GroupRow(Gv1, 30, 0, 6);
                        GroupRow(Gv1, 31, 0, 6);
                        GroupRow(Gv1, 32, 0, 6);
                        GroupRow(Gv1, 33, 0, 6);
                        GroupRow(Gv1, 34, 0, 6);
                        GroupRow(Gv1, 35, 0, 6);
                        GroupRow(Gv1, 36, 0, 6);


                        btnExport.Visible = true;//显示导出Excel表按钮;


                    }

                }
           // }
        }
        protected void btnExport_Click(object Sender, EventArgs e)
        {
            //dt1.Rows.RemoveAt(0);
            //Label1.Text = Convert.ToString(dt1.Rows[1][1]);
            //string str = dt.ToString("yyyyMMddhhmmss");
            //str = str + ".xls";
            //文件名是当前日期时间
            MemoryStream ms = DataTableRenderToExcel.RenderDataTableToExcel(dt1) as MemoryStream;
            //    設定強制下載標頭 設定強制下載標頭。 。。 。 
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename=Download.xls"));
            //輸出檔案。 。。 。 
            Response.BinaryWrite(ms.ToArray());
            ms.Close();
            ms.Dispose();

            //Gv1.AllowPaging = false;//禁止分页显示

            //            GridViewToExcel(Gv1, "application/ms-excel", str);

        }


        ///<summary>   
        /// 合并单元格 合并某一列中的某些行   
        /// </summary>   
        /// <param name="gridView">GridView ID</param>   
        /// <param name="cols">列</param>   
        /// <param name="sRow">开始行</param>   
        /// <param name="eRow">结束列</param>   
        public static void GroupCol(GridView gridView, int cols, int sRow, int eRow)
        {
            //if (gridView.Rows.Count < 1 || cols > gridView.Columns.Count - 1)
            //{
            //    return;
            //}
            TableCell oldTc = gridView.Rows[sRow].Cells[cols];
            for (int i = 1; i < eRow - sRow; i++)
            {
                TableCell tc = gridView.Rows[sRow + i].Cells[cols];
                tc.Visible = false;
                if (oldTc.RowSpan == 0)
                {
                    oldTc.RowSpan = 1;
                }
                oldTc.RowSpan++;
                oldTc.VerticalAlign = VerticalAlign.Middle;
            }
        }
        /// <summary>
        /// 合并单元格 合并一行中的几列
        /// </summary>
        /// <param name="GridView1">GridView ID</param>
        /// <param name="rows">行</param>
        /// <param name="sCol">开始列</param>
        /// <param name="eCol">结束列</param>
        public static void GroupRow(GridView gridView, int rows, int sCol, int eCol)
        {
            TableCell oldTc = gridView.Rows[rows].Cells[sCol];
            for (int i = 1; i < eCol - sCol; i++)
            {
                TableCell tc = gridView.Rows[rows].Cells[i + sCol];　 //Cells[0]就是你要合并的列
                tc.Visible = false;
                if (oldTc.ColumnSpan == 0)
                {
                    oldTc.ColumnSpan = 1;
                }
                oldTc.ColumnSpan++;
                oldTc.VerticalAlign = VerticalAlign.Middle;
            }
        }


        //导出Excel按钮事件


        //NPOI导出excel表
        public class DataTableRenderToExcel
        {
            public static Stream RenderDataTableToExcel(DataTable SourceTable)
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                MemoryStream ms = new MemoryStream();
                HSSFSheet sheet = workbook.CreateSheet();
                HSSFRow headerRow = sheet.CreateRow(0);
                HSSFCellStyle style = workbook.CreateCellStyle();
                HSSFFont font = workbook.CreateFont();
                font.FontHeightInPoints = 11;
                HSSFFont font_small1 = workbook.CreateFont();
                font_small1.FontHeightInPoints = 11;
                font_small1.Boldweight = 8;
                HSSFFont font_small2 = workbook.CreateFont();
                font_small2.FontHeightInPoints = 10;
                style.Alignment = HSSFCellStyle.ALIGN_CENTER;//设置水平居中
                style.VerticalAlignment = HSSFCellStyle.VERTICAL_CENTER;//设置垂直居中
                style.WrapText = true;//自动换行
                style.BorderBottom = HSSFCellStyle.BORDER_THIN;//设置边框
                style.BorderLeft = HSSFCellStyle.BORDER_THIN;
                style.BorderRight = HSSFCellStyle.BORDER_THIN;
                style.BorderTop = HSSFCellStyle.BORDER_THIN;
                style.SetFont(font);

                HSSFCellStyle stylefoot1 = workbook.CreateCellStyle();//字体加粗行格式
                stylefoot1.WrapText = true;//自动换行
                stylefoot1.VerticalAlignment = HSSFCellStyle.VERTICAL_CENTER;//设置垂直居中
                stylefoot1.Alignment = HSSFCellStyle.ALIGN_LEFT;//右对齐
                stylefoot1.BorderBottom = HSSFCellStyle.BORDER_NONE;
                stylefoot1.BorderLeft = HSSFCellStyle.BORDER_NONE;
                stylefoot1.BorderRight = HSSFCellStyle.BORDER_NONE;
                stylefoot1.BorderTop = HSSFCellStyle.BORDER_NONE;
                stylefoot1.SetFont(font_small1);

                HSSFCellStyle stylefoot2 = workbook.CreateCellStyle();//正常字体说明行格式
                stylefoot2.WrapText = true;//自动换行
                stylefoot2.VerticalAlignment = HSSFCellStyle.VERTICAL_CENTER;//设置垂直居中
                stylefoot2.Alignment = HSSFCellStyle.ALIGN_LEFT;//右对齐
                stylefoot2.BorderBottom = HSSFCellStyle.BORDER_NONE;
                stylefoot2.BorderLeft = HSSFCellStyle.BORDER_NONE;
                stylefoot2.BorderRight = HSSFCellStyle.BORDER_NONE;
                stylefoot2.BorderTop = HSSFCellStyle.BORDER_NONE;
                stylefoot2.SetFont(font_small2);


                HSSFCellStyle titlestyle = workbook.CreateCellStyle();//空白行格式
                titlestyle.Alignment = HSSFCellStyle.ALIGN_CENTER;//设置水平居中
                titlestyle.VerticalAlignment = HSSFCellStyle.VERTICAL_CENTER;//设置垂直居中
                titlestyle.BorderBottom = HSSFCellStyle.BORDER_NONE;
                titlestyle.BorderLeft = HSSFCellStyle.BORDER_NONE;
                titlestyle.BorderRight = HSSFCellStyle.BORDER_NONE;
                titlestyle.BorderTop = HSSFCellStyle.BORDER_NONE;
                titlestyle.SetFont(font_small1);

                HSSFCellStyle titlestyle1 = workbook.CreateCellStyle();//标题格式
                titlestyle1.Alignment = HSSFCellStyle.ALIGN_CENTER;//设置水平居中
                titlestyle1.VerticalAlignment = HSSFCellStyle.VERTICAL_CENTER;//设置垂直居中
                titlestyle1.BorderBottom = HSSFCellStyle.BORDER_NONE;
                titlestyle1.BorderLeft = HSSFCellStyle.BORDER_NONE;
                titlestyle1.BorderRight = HSSFCellStyle.BORDER_NONE;
                titlestyle1.BorderTop = HSSFCellStyle.BORDER_NONE;
                titlestyle1.SetFont(font);



                //sheet.AddMergedRegion(new Region(2, 2, 4, 4));
                SetCellRangeAddress(sheet,4,8,0,0);
                SetCellRangeAddress(sheet,9,13,0,0);
                SetCellRangeAddress(sheet,14,18,0,0);
                SetCellRangeAddress(sheet,19,23,0,0);
                SetCellRangeAddress(sheet,24,28,0,0);
                SetCellRangeAddress(sheet, 0, 0, 0, 5);
                SetCellRangeAddress(sheet, 2, 2, 0, 5);
                for (int c = 29; c < 38; c++)
                    SetCellRangeAddress(sheet, c, c, 0, 5);
                sheet.SetColumnWidth(0, 10* 256);
                sheet.SetColumnWidth(1, 28* 256);
                sheet.SetColumnWidth(2, 12* 256);
                sheet.SetColumnWidth(3, 12* 256);
                sheet.SetColumnWidth(4, 18* 256);
                sheet.SetColumnWidth(5, 10* 256);//设置列宽
                sheet.CreateRow(0).HeightInPoints = 30;//设置列高
                int col;
                //HSSFRow headrow = sheet.CreateRow(0);//设置表头
                for (col = 0; col < 6; col++)
                {
                    HSSFCell cell = headerRow.CreateCell(col);
                    cell.CellStyle = titlestyle1;
                    headerRow.HeightInPoints = 30;
                }

                DataRow headrow = SourceTable.Rows[0];
                    foreach (DataColumn column in SourceTable.Columns)
                    {
                        headerRow.GetCell(column.Ordinal).SetCellValue(headrow[column].ToString());

                    }

                
                
                // handling value.  
                int rowIndex = 1;

                foreach (DataRow row in SourceTable.Rows)//写入主体表数据
                {
                    HSSFRow dataRow = sheet.CreateRow(rowIndex);

                    foreach (DataColumn column in SourceTable.Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                        
                    }
                    
                    for (col = 0; col <6; col++)
                    {
                        HSSFCell cell = dataRow.GetCell(col);
                        cell.CellStyle = style;
                    }
                    rowIndex++;
                }

                
                HSSFRow blankrow = sheet.CreateRow(1);//表头下空白行的设置
                for (col = 0; col <6; col++)
                {
                    HSSFCell cell = blankrow.CreateCell(col);
                    cell.CellStyle = titlestyle;
                    blankrow.HeightInPoints = 1;
                }
                HSSFRow blankrow1 = sheet.CreateRow(2);//表头下空白行2的设置
                for (col = 0; col < 6; col++)
                {
                    HSSFCell cell = blankrow1.CreateCell(col);
                    cell.CellStyle = titlestyle;
                    blankrow1.HeightInPoints = 32;
                }
                blankrow1.GetCell(0).SetCellValue("志  愿  选  择  分  析  报  告  单");

                for (int row = 29; row < 38;row+=2 )
                {
                    HSSFRow footrow_title = sheet.GetRow(row);
                    for(col = 0;col<6;col++)
                    {
                        HSSFCell cell = footrow_title.GetCell(col);
                        cell.CellStyle = stylefoot1;
                    }
                }
                for (int row = 30; row < 38; row += 2)
                {
                    HSSFRow footrow_title = sheet.GetRow(row);
                    for (col = 0; col < 6; col++)
                    {
                        HSSFCell cell = footrow_title.GetCell(col);

                        if (row == 36)
                        {
                            footrow_title.HeightInPoints = 52;
                            cell.CellStyle = stylefoot2;
                        }
                        else if (row == 30)
                        {
                            footrow_title.HeightInPoints = 42;
                            cell.CellStyle = stylefoot2;
                        }
                        else
                            cell.CellStyle = titlestyle;
                    }
                }


                    workbook.Write(ms);
                HSSFRow row0 = sheet.CreateRow(2);
                HSSFRow row1 = sheet.CreateRow(3);
                HSSFRow row2 = sheet.CreateRow(8);
                HSSFRow row3 = sheet.CreateRow(13);
                HSSFRow row4 = sheet.CreateRow(18);
                HSSFRow row5 = sheet.CreateRow(23);
                row0.CreateCell(0).SetCellValue("志愿");
                row1.CreateCell(0).SetCellValue("A志愿");
                row2.CreateCell(0).SetCellValue("B志愿");
                row3.CreateCell(0).SetCellValue("C志愿");
                row4.CreateCell(0).SetCellValue("D志愿");
                row5.CreateCell(0).SetCellValue("E志愿");
                sheet.DefaultRowHeight = 39* 20;

                
               

                

                ms.Flush();
                ms.Position = 0;

                sheet = null;
                headerRow = null;
                workbook = null;

                return ms;
            }

            public static void RenderDataTableToExcel(DataTable SourceTable, string FileName)
            {
                MemoryStream ms = RenderDataTableToExcel(SourceTable) as MemoryStream;
                FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                byte[] data = ms.ToArray();

                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();

                data = null;
                ms = null;
                fs = null;
            }

            
          
        }

        /// <summary>
        /// 合并Gridview单元格
        /// </summary>
        /// <param name="sheet">要合并单元格所在的sheet</param>
        /// <param name="rowstart">开始行的索引</param>
        /// <param name="rowend">结束行的索引</param>
        /// <param name="colstart">开始列的索引</param>
        /// <param name="colend">结束列的索引</param>
        public static void SetCellRangeAddress(HSSFSheet sheet, int rowstart, int rowend, int colstart, int colend)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(rowstart, rowend, colstart, colend);
            sheet.AddMergedRegion(cellRangeAddress);
        }
    }
}