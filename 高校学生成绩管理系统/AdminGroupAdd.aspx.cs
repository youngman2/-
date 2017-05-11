using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminGroupAdd : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void AddGroup()
        {
            string sql = string.Empty;
            sql = string.Format("insert into AdminGroup([group],comment) values('{0}','{1}')", this.txtGname.Text, this.txtGinfo.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("AdminGroup.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            AddGroup();
        }

    }
}