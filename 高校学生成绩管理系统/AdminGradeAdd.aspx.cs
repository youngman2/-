using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminGradeAdd : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            GetClassName();
            try
            {
                if (Request.QueryString["Action"].ToString() == "Add")
                {
                    GetStu();
                }
            }
            catch
            { }
        }

        private void GetClassName()
        {
            string sql = string.Empty;
            sql = string.Format("select 班级名 from 学生信息表 group by 班级名");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "t");
                this.DataGrid1.DataSource = ds.Tables["t"];
                this.DataGrid1.DataBind();
            }
            catch
            { }
        }

        private void GetStu()
        {
            string sql = string.Empty;
            sql = string.Format("select 学号,姓名,性别,班级名,所在院系 from 学生信息表 where 班级名='{0}'", Request.QueryString["班级名"].ToString());
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "t");
                this.DataGrid2.DataSource = ds.Tables["t"];
                this.DataGrid2.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetClassName();
        }

        protected void DataGrid2_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.DataGrid2.CurrentPageIndex = e.NewPageIndex;
            GetStu();

        }
        
    }
}