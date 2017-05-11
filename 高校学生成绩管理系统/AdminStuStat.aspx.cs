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
    public partial class AdminStuStat : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }
        
        private void GetData()
        {
            string sql = string.Empty;
            sql = string.Format("select 课程号,sum(成绩) as 总分,avg(成绩) as 平均分,count(学号) as 人数 from 成绩表 group by 课程号");
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
        
        protected void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetData();
        }
    }
}