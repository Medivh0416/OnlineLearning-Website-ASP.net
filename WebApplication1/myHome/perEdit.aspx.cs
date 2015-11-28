using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace WebApplication1
{
    public partial class perEdit : System.Web.UI.Page
    {
        int userId;
        string id;
        string userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.userId = Convert.ToInt32(Session["userID"].ToString());
            if (!IsPostBack)
            {
                string sql1 = "select * from province";
                DataSet ds1 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql1);
                DataTable dt1 = ds1.Tables[0];
                DDLprovince.DataSource = dt1;
                DDLprovince.DataBind();

                string sql2 = "select * from school";
                DataSet ds2 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql2);
                DataTable dt2 = ds2.Tables[0];
                DDLschool.DataSource = dt2;
                DDLschool.DataBind();

                string sql3 = "select * from grade";
                DataSet ds3 = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql3);
                DataTable dt3 = ds3.Tables[0];
                DDLgrade.DataSource = dt3;
                DDLgrade.DataBind();
            }
            this.userName = Session["userName"].ToString();
            this.id = Session["userID"].ToString();
            string sql = "select * from users where id=@id";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            DataTable dt = ds.Tables[0];
            string img = dt.Rows[0]["logo"].ToString();
            pic.ImageUrl = img;
            pic_mid.ImageUrl = img;
            pic_s.ImageUrl = img;
        }
        protected void btn_upload_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (pic_upload.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(pic_upload.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);
                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过300K
                    if (pic_upload.PostedFile.ContentLength < 1024000)
                    {
                        string filepath = "/logo/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        string virpath = filepath + userName + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                        pic_upload.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        pic.ImageUrl = virpath;
                        //清空提示
                        lbl_pic.Text = "";
                        try 
                        {
                            string sql = "update users set logo=@logo where id=@id";
                            MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                            new MySqlParameter("@logo",virpath),new MySqlParameter("@id", id));
                            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传成功！');</script>");
                            //submit.Attributes.Add("onclick", "return confirm('返回')");
                            return;
                        }
                        catch 
                        {
                            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('上传失败！');</script>");
                            return;
                        }
                    }
                    else
                    {
                        pic.ImageUrl = "";
                        lbl_pic.Text = "文件大小超出1M！请重新选择！";
                    }
                }
                else
                {
                    pic.ImageUrl = "";
                    lbl_pic.Text = "要上传的文件类型不对！请重新选择！";
                }
            }
            else
            {
                pic.ImageUrl = "";
                lbl_pic.Text = "请选择要上传的图片！";
            }
        }

        /// <summary>
        /// 验证是否指定的图片格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            //限定只能上传jpg和gif图片
            string[] allowExtension = { ".jpg", ".gif", ".bmp", ".png" };
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }
        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            string oldPwd;
            string pwd=oldPsw.Text;
            string sql = "select password from users where id=@id";
            DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
            DataTable dt = ds.Tables[0];
            oldPwd = dt.Rows[0]["password"].ToString();
            if (oldPwd != pwd)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('原密码不正确！');</script>");
                return;
            }
            btn_submit_Click1();
        }
        protected void DDLprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int id = Convert.ToInt32(DDLprovince.SelectedValue);
                string sql = "select * from city where provinceId=@id";
                DataSet ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, System.Data.CommandType.Text, sql, new MySqlParameter("@id", id));
                DataTable dt = ds.Tables[0];
                DDLcity.DataSource = dt;
                DDLcity.DataBind();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update users set aliasName=@aliasName,schoolID=@schoolID,cityId=@cityId,gredeId=@gradeId where id=@ID";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                    new MySqlParameter("@ID", userId), new MySqlParameter("@aliasName", aliasName.Text),
                    new MySqlParameter("@cityId", DDLcity.SelectedValue), new MySqlParameter("@schoolID", DDLschool.SelectedValue),
                    new MySqlParameter("@gradeId", DDLgrade.SelectedValue));
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('失败了！')</script>");
                return;
            }
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            per_view.SetActiveView(v_input);
        }

        protected void btn_pic_Click(object sender, EventArgs e)
        {
            per_view.SetActiveView(upPic);
        }

        protected void btn_pass_Click(object sender, EventArgs e)
        {
            per_view.SetActiveView(passWord);
        }

        protected void btn_submit_Click1()
        {
            string pwd1 = newPsw.Text;
            try
            {
                string sql = "update users set password=@password where id=@ID";
                MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, System.Data.CommandType.Text, sql,
                    new MySqlParameter("@ID", userId), new MySqlParameter("@password", pwd1));
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！')</script>");
            }
            catch
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('失败了！')</script>");
                return;
            }
        }
    }
}