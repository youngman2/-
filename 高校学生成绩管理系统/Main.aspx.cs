using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class Main : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);

        private string username;
        private string promise;
        public string promiseUrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            try
            {
                username = Session["username"].ToString();
            }
            catch
            {
                Response.Redirect("Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                GetPromise();
                GetUrlByPromise();
            }
        }
        
        private void GetPromise()
        {
            string sql = string.Empty;
            sql = string.Format("select promise from Admin inner join AdminGroup on Admin.[Group] = AdminGroup.[Group] where username = '{0}'", username);
            //Response.Write(sql);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //promiseUrl = dr["promise"].ToString();
                    //sb.Append(dr["url"].ToString());
                    this.promise = dr["promise"].ToString();
                }
                //promiseUrl = sb.ToString();
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
        
        private void GetUrlByPromise()
        {
            string sql = string.Empty;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            try
            {
                sql = string.Format("select url,urlname from AdminUrl where id in ({0})", promise.Substring(0, promise.Length - 1));
            }
            catch
            {
                //Response.Write("你输入的用户名不存在任何组,请与管理员联系!");
            }
            //Response.Write(sql);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        sb.Append("<table width=\"207\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
                        do
                        {
                            sb.Append("<tr><td width=\"207\" height=\"33\" background=\"images/Sys_menu.jpg\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a target=\"main\" href=\"" + dr["url"].ToString() + "\">" + dr["urlname"].ToString() + "</a></td></tr>\n");
                        } while (dr.Read());
                        sb.Append("</table>");
                    }
                }
                catch
                {
                    Response.Write("你输入的用户名尚未分组,或者分组信息丢失,请与管理员联系!");
                }
                promiseUrl = sb.ToString();
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