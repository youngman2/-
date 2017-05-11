using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校学生成绩管理系统
{
    public partial class AdminStuSearch : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetStuData();
            }
        }

        private void GetStuData()
        {
            string sql = string.Empty;
            sql = GetSql();
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
        
        private string GetSql()
        {
            string sql = string.Empty;
            ArrayList sqlArr = new ArrayList();

            if (this.txtsid.Text.Length != 0)
            {
                sqlArr.Add(string.Format("学号 like '%{0}%' ", this.txtsid.Text.ToString()));
            }
            if (this.txtname.Text.Length != 0)
            {
                sqlArr.Add(string.Format("姓名 like '%{0}%' ", this.txtname.Text.ToString()));
            }
            if (this.txtage.Text.Length != 0)
            {
                sqlArr.Add(string.Format("年龄 like '%{0}%' ", this.txtage.Text.ToString()));
            }
            if (this.txtx.Text.Length != 0)
            {
                sqlArr.Add(string.Format("所有院系 like '%{0}%' ", this.txtx.Text.ToString()));
            }
            if (this.txty.Text.Length != 0)
            {
                sqlArr.Add(string.Format("入学年份 like '%{0}%' ", this.txty.Text.ToString()));
            }
            foreach (string str in sqlArr)
            {
                sql = sql + str + " and ";

            }
            sql = "select * from 学生信息表 where " + sql;
            int i = sql.Trim().Length - 5;
            sql = sql.Substring(0, i);
            return sql;
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            GetStuData();
        }

        protected void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetStuData();
        }
    }
}