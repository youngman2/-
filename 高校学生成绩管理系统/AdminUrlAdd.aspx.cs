using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminUrlAdd : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string sql = string.Empty;
            sql = string.Format("insert into AdminUrl(urlname,url,comment) values('{0}','{1}','{2}')", this.txtname.Text, this.txturl.Text, this.TextBox3.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("AdminUrl.aspx");
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
    }
}