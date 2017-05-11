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
    public partial class AdminGrade : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetData();
            }
        }

        private void GetData()
        {
            string sql = string.Empty;
            sql = string.Format("select 成绩表.学号,姓名,课程号,成绩,性别,班级名  from 成绩表 join 学生信息表 on 成绩表.学号 = 学生信息表.学号");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "t");
                this.DataGrid1.DataSource = ds.Tables["t"];
                this.DataGrid1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }


        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("AdminGradeAdd.aspx");
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetData();
        }
    }
}