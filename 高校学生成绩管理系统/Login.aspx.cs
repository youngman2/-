using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class Login : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void userLogin()
        {
            string sql = string.Empty;
            string user = this.txtUsername.Text;
            //string pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.txtPassword.Text, "MD5");
            string pwd = this.txtPassword.Text;

            
            MembershipUser newUser = Membership.CreateUser(user, pwd);

            sql = string.Format("select username,password,[group] from Admin where username='{0}' and password='{1}'", user, pwd);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Session["username"] = dr["username"].ToString();
                    Session["group"] = dr["group"].ToString();
                    Response.Redirect("Main.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户名或者密码错误,请重新输入!')</script>");
                }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            userLogin();
        }
    }
}