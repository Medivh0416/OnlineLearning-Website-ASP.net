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
    public partial class input : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            string province = txtPro.Value;
            int course = int.Parse(ddlCourse.Value);
            int batch = int.Parse(ddlBatch.Value);
            int rank = int.Parse(txtRanking.Value);
            string name = txtUniname.Value;
            int level = int.Parse(ddlLevel.Value);
            string city = txtCity.Value;
            int cp = int.Parse(txtCitypoint.Value);
            //string result;
            MySqlParameter[] param = new MySqlParameter[] 
            {   new MySqlParameter("?proid",MySqlDbType.Int32),
                new MySqlParameter("?province",MySqlDbType.String),
                new MySqlParameter("?batch",MySqlDbType.Int32),
                new MySqlParameter("?name",MySqlDbType.String),
                new MySqlParameter("?level",MySqlDbType.Int32),
                new MySqlParameter("?city",MySqlDbType.String),
                new MySqlParameter("?citypoint",MySqlDbType.Int32),
                new MySqlParameter("?rank",MySqlDbType.Int32),
                new MySqlParameter("?levelpoint",MySqlDbType.Int32),
                new MySqlParameter("?course",MySqlDbType.Int32)
            };
           
            param[1].Value = province;
            param[2].Value = batch;
            param[3].Value = name;
            param[4].Value = level;
            param[5].Value = city;
            param[6].Value = cp;
            param[7].Value = rank;
            //Label1.Text = ddlPro.Value;
            //Label2.Text = ddlBatch.Value;
            //Label3.Text = name;
            //Label4.Text = ddlLevel.Value;
            //Label5.Text = city;
            //Label6.Text = txtCitypoint.Value;
            //Label7.Text = txtRanking.Value;
            //Label8.Text = ddlBatch.Value;
            try
            {
                string pro = "";
                string sql1 = "select province from typed_in where province=?province";
                pro = pro+ Convert.ToString(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, param[1]));
                if (pro == "")
                {
                    string sql2 = "insert into typed_in(province)values(?province)";
                    int val = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, param[1]);
                };

            }
            catch
            {
                //Label1.Text = "省市数据加载失败";
            }
            int levelpoint = 0;
            switch (level)
            {
                case 0: levelpoint = 0;
                    break;
                case 1: levelpoint = 6;
                    break;
                case 2: levelpoint = 4;
                    break;
            }
            param[8].Value = levelpoint;
            param[9].Value = course;
            string sqlSelect_id = "select id from typed_in where province = ?province";
            int id = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sqlSelect_id, param[1]));
            param[0].Value = id;
            string sql3 = "insert ignore into univers(province,university,level,levelpoint,city,citypoint,rank,batch,course)values(?proid,?name,?level,?levelpoint,?city,?citypoint,?rank,?batch,?course)";
                
           
            int i = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, param[0], param[2], param[3], param[4], param[5], param[6], param[7], param[8],param[9]);
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {   

            if (this.fuUpload.HasFile)
            {
                String sheetname = "sheet1"; 
                //讀取Excel資料流並轉換成DataTable。 
                DataTable table = DataTableRenderToExcel.RenderDataTableFromExcel(this.fuUpload.FileContent, sheetname,0);
                table.Columns.Add("是否插入成功");
                
                MySqlParameter[] paramRe = new MySqlParameter[] 
                {   new MySqlParameter("?province",MySqlDbType.String),
                    new MySqlParameter("?university",MySqlDbType.String),
                    new MySqlParameter("?level",MySqlDbType.Int32),
                    new MySqlParameter("?levelpoint",MySqlDbType.Int32),
                    new MySqlParameter("?city",MySqlDbType.String),
                    new MySqlParameter("?citypoint",MySqlDbType.Int32),
                    new MySqlParameter("?rank1",MySqlDbType.Int32),
                    new MySqlParameter("?rank2",MySqlDbType.Int32),
                    new MySqlParameter("?rank3",MySqlDbType.Int32),
                    new MySqlParameter("?sum",MySqlDbType.Int32),
                    new MySqlParameter("?rank",MySqlDbType.Int32),
                    new MySqlParameter("?batch",MySqlDbType.Int32),
                    new MySqlParameter("?course",MySqlDbType.Int32),
                    new MySqlParameter("?pro_id",MySqlDbType.Int32)
                 };

                for(int i = 0;i<table.Rows.Count;i++)
                {
                    if(table.Rows[i]!=null)
                    {
                        try
                        {
                            string pro = "";
                            string sql1 = "select province from typed_in where province=?province";
                            pro = pro+ Convert.ToString(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, paramRe[0]));
                            if (pro == "")
                            {
                                string sql2 = "insert into typed_in(province)values(?province)";
                                int val = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, paramRe[0]);
                            };

                        }
                        catch { }
                        paramRe[0].Value = table.Rows[i][1];
                        paramRe[1].Value = table.Rows[i][2];
                        paramRe[2].Value = table.Rows[i][3];
                        //paramRe[3].Value = Convert.ToInt32(table.Rows[i][4]);
                        //paramRe[4].Value = Convert.ToString(table.Rows[i][5]);
                        //paramRe[5].Value = Convert.ToInt32(table.Rows[i][6]);
                        paramRe[3].Value = table.Rows[i][4];
                        paramRe[4].Value = table.Rows[i][5];
                        paramRe[5].Value = table.Rows[i][6];
                        paramRe[6].Value = table.Rows[i][7];
                        paramRe[7].Value = table.Rows[i][8];
                        paramRe[8].Value = table.Rows[i][9];
                        paramRe[9].Value = table.Rows[i][10];
                        paramRe[10].Value = table.Rows[i][11];
                        paramRe[11].Value = table.Rows[i][12];
                        paramRe[12].Value = table.Rows[i][13];

                        
                            string sqlSelect = "select id from typed_in where province = ?province";
                            int pro_id = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sqlSelect, paramRe[0]));
                            paramRe[13].Value = pro_id;
                            string sqlInsert = "insert into univers (province,university,level,levelpoint,city,citypoint,rank1,rank2,rank3,sum,rank,batch,course) values (?pro_id,?university,?level,?levelpoint,?city,?citypoint,?rank1,?rank2,?rank3,?sum,?rank,?batch,?course)";
                        try
                        {
                            int r = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sqlInsert, paramRe[13], paramRe[1], paramRe[2], paramRe[3], paramRe[4], paramRe[5], paramRe[6], paramRe[7], paramRe[8], paramRe[9], paramRe[10], paramRe[11], paramRe[12]);
                            table.Rows[i][14] = "是";
                        }
                        catch
                        {
                            table.Rows[i][14] = "否";
                        }
                    }
                }
                this.gvExcel.DataSource = table;
                this.gvExcel.DataBind();
                

            }
        }

        //导出Excel按钮事件

        protected void btnImportgrade_Click(object sender, EventArgs e)
        {
            if (this.fuGrade.HasFile)
            {
                String sheetname = "sheet1";
                //讀取Excel資料流並轉換成DataTable。 
                DataTable table = DataTableRenderToExcel.RenderDataTableFromExcel(this.fuGrade.FileContent, sheetname, 0);
                table.Columns.Add("是否插入成功");
                //this.gvExcel.DataSource = table;
                //this.gvExcel.DataBind();

                MySqlParameter[] paramGR = new MySqlParameter[] 
                {   new MySqlParameter("?province",MySqlDbType.String),
                    new MySqlParameter("?pro_id",MySqlDbType.Int32),
                    new MySqlParameter("?grade",MySqlDbType.Int32),
                    new MySqlParameter("?rank",MySqlDbType.Int32),
                    new MySqlParameter("?course",MySqlDbType.Int32)
                    
                 };

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i] != null & table.Rows[i][1] != "")
                    {
                        string pro_string = Convert.ToString(table.Rows[i][1]);
                        paramGR[0].Value = pro_string;
                        string sql1 = "select id from typed_in where province=?province";
                        int pro_id = -1;
                        pro_id = Convert.ToInt32(MySqlHelper.ExecuteScalar(MySqlHelper.Conn, System.Data.CommandType.Text, sql1, paramGR[0]));
                        paramGR[1].Value = pro_id;
                        if (pro_id == -1)
                        {
                            string sql2 = "insert into typed_in (province)values(?province) ";
                            int val = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql2, paramGR[0]);
                        }

                        paramGR[2].Value = table.Rows[i][2];
                        paramGR[3].Value = table.Rows[i][3];
                        paramGR[4].Value = table.Rows[i][4];
                        string sql3 = "insert into grade_rank (province,grade,rank,course)values(?pro_id,?grade,?rank,?course)";
                        try
                        {
                            int v = MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql3, paramGR[1], paramGR[2], paramGR[3], paramGR[4]);
                            table.Rows[i][5] = "是";
                        }
                        catch
                        {
                            table.Rows[i][5] = "否";
                        }
                    }
                }
                this.gvExcel.DataSource = table;
                this.gvExcel.DataBind();
            }
        }

        //NPOI导出excel表
        public class DataTableRenderToExcel
        {
           

            public static DataTable RenderDataTableFromExcel(Stream ExcelFileStream, string SheetName, int HeaderRowIndex)
            {
                HSSFWorkbook workbook = new HSSFWorkbook(ExcelFileStream);
                HSSFSheet sheet = workbook.GetSheet(SheetName);

                DataTable table = new DataTable();

                HSSFRow headerRow = sheet.GetRow(HeaderRowIndex);
                int cellCount = headerRow.LastCellNum;

                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    if (headerRow.GetCell(i) != null)
                    {
                        headerRow.GetCell(i).SetCellType(HSSFCell.CELL_TYPE_STRING);
                        //stuUser.setPhone(row.getCell(0).getStringCellValue());
                    }
                    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                    table.Columns.Add(column);
                    
                }

                int rowCount = sheet.LastRowNum;



                //table.Rows.Add();
                //table.Rows.Add(); 
                //table.Rows.Add();
                //for (int i = (sheet.FirstRowNum + 2); i < sheet.LastRowNum; i++)
                //{
                //    HSSFRow row = sheet.GetRow(i);
                //    //DataRow dataRow = table.Rows.Add();
                //    table.Rows.Add();

                //    for (int j = row.FirstCellNum; j < cellCount; j++)
                //        //dataRow[j] = row.GetCell(j).ToString();
                //        table.Rows[i][j] = row.GetCell(j).ToString();
                //}
                for (int i = (sheet.FirstRowNum + 1); i < sheet.LastRowNum; i++)
                {
                    HSSFRow row = sheet.GetRow(i);
                    DataRow dataRow = table.NewRow();
                    //HSSFCellStyle cellStyle = workbook.CreateCellStyle();
                    //    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0");

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        if (row.GetCell(j) != null)
                            if (row.GetCell(j).CellType == HSSFCell.CELL_TYPE_STRING)
                                dataRow[j] = row.GetCell(j).ToString();
                            else
                            {
                                
                                dataRow[j] = Convert.ToInt32(row.GetCell(j).NumericCellValue);

                            }
                         
                       
                    }

                    table.Rows.Add(dataRow);
 
                }


                ExcelFileStream.Close();
                workbook = null;
                sheet = null;
                return table;
            }

            public static DataTable RenderDataTableFromExcel(Stream ExcelFileStream, int SheetIndex, int HeaderRowIndex)
            {
                HSSFWorkbook workbook = new HSSFWorkbook(ExcelFileStream);
                HSSFSheet sheet = workbook.GetSheetAt(SheetIndex);

                DataTable table = new DataTable();

                HSSFRow headerRow = sheet.GetRow(HeaderRowIndex);
                int cellCount = headerRow.LastCellNum;

                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                    table.Columns.Add(column);
                }

                int rowCount = sheet.LastRowNum;

                for (int i = (sheet.FirstRowNum + 1); i < sheet.LastRowNum; i++)
                {
                    HSSFRow row = sheet.GetRow(i);
                    DataRow dataRow = table.NewRow();

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        if (row.GetCell(j) != null)
                            dataRow[j] = row.GetCell(j).ToString();
                    }

                    table.Rows.Add(dataRow);
                }

                ExcelFileStream.Close();
                workbook = null;
                sheet = null;
                return table;
            }

            /// <summary>读取excel  
            /// 默认第一行为标头  
            /// </summary>  
            /// <param name="path">excel文档路径</param>  
            /// <returns></returns>  
            public static DataTable RenderDataTableFromExcel(string path)
            {
                DataTable dt = new DataTable();

                HSSFWorkbook hssfworkbook;
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    hssfworkbook = new HSSFWorkbook(file);
                }
                HSSFSheet sheet = hssfworkbook.GetSheetAt(0);
                System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

                HSSFRow headerRow = sheet.GetRow(0);
                int cellCount = headerRow.LastCellNum;

                for (int j = 0; j < cellCount; j++)
                {
                    HSSFCell cell = headerRow.GetCell(j);
                    dt.Columns.Add(cell.ToString());
                }

                for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
                {
                    HSSFRow row = sheet.GetRow(i);
                    DataRow dataRow = dt.NewRow();

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        if (row.GetCell(j) != null)
                            dataRow[j] = row.GetCell(j).ToString();
                    }

                    dt.Rows.Add(dataRow);
                }

                //while (rows.MoveNext())  
                //{  
                //    HSSFRow row = (HSSFRow)rows.Current;  
                //    DataRow dr = dt.NewRow();  

                //    for (int i = 0; i < row.LastCellNum; i++)  
                //    {  
                //        HSSFCell cell = row.GetCell(i);  


                //        if (cell == null)  
                //        {  
                //            dr[i] = null;  
                //        }  
                //        else  
                //        {  
                //            dr[i] = cell.ToString();  
                //        }  
                //    }  
                //    dt.Rows.Add(dr);  
                //}  

                return dt;
            }
        }

    }

}
