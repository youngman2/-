using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminGradeAddNext : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Add()
        {
            string sql = string.Empty;
            sql = string.Format("insert into 成绩表(学号,课程号,成绩) values('{0}','{1}',{2})", Request.QueryString["StuId"].ToString(), this.txtcid.Text.ToString(), this.txtgrade.Text.ToString());
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('成绩添加成功!')</script>");
            }
            catch//(Exception ex)
            {
                //Response.Write(ex);
                Response.Write("<script>alert('成绩添加失败!')</script>");
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
 
    }
}