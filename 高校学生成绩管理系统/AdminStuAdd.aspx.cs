using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminStuAdd : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Add()
        {
            string sql = string.Empty;
            string sid = this.txtsid.Text.ToString();
            string name = this.txtname.Text.ToString();
            string sex = string.Empty;
            if (this.rbman.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            int age = Convert.ToInt32(this.txtage.Text.ToString());
            string s = this.txts.Text.ToString();
            string classname = this.txtclassname.Text.ToString();
            string years = this.txtyear.Text.ToString();

            sql = string.Format("insert into 学生信息表(学号,姓名,性别,年龄,所在院系,班级名,入学年份 ) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')", sid, name, sex, age, s, classname, years);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('学生信息添加成功!')</script>");
            }
            catch//(Exception ex)
            {
                //Response.Write(ex);
                Response.Write("<script>alert('该学号已经存在,添加失败!')</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Add();
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("AdminStu.aspx");
        }
    }
}