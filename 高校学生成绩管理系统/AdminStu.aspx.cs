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
    public partial class AdminStu : System.Web.UI.Page
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
            sql = string.Format("select * from 学生信息表");
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
    
        private void ExeSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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
            Response.Redirect("AdminStuAdd.aspx");
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetData();
        }

        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            this.DataGrid1.EditItemIndex = e.Item.ItemIndex;
            GetData();
        }

        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {
            this.DataGrid1.EditItemIndex = -1;
            GetData();
        }

        protected void DataGrid1_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            string sid = e.Item.Cells[0].Text;
            string sql = string.Format("delete 学生信息表 where 学号 = '{0}'", sid);
            ExeSql(sql);
            this.DataGrid1.EditItemIndex = -1;
            GetData();
        }

        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            string sid = e.Item.Cells[0].Text;

            TextBox txtName = new TextBox();
            txtName = (TextBox)e.Item.Cells[1].Controls[0];
            string name = txtName.Text.ToString();
            

            TextBox txtAge = new TextBox();
            txtAge = (TextBox)e.Item.Cells[3].Controls[0];
            string age = txtAge.Text.ToString();

            TextBox txtS = new TextBox();
            txtS = (TextBox)e.Item.Cells[4].Controls[0];
            string s = txtS.Text.ToString();

            TextBox txtClass = new TextBox();
            txtClass = (TextBox)e.Item.Cells[5].Controls[0];
            string classname = txtClass.Text.ToString();

            string sql = string.Empty;
            sql = string.Format("update 学生信息表 set 姓名='{0}',年龄='{1}',所在院系='{2}',班级名='{3}' where 学号='{4}'", name, age, s, classname, sid);
            ExeSql(sql);
            this.DataGrid1.EditItemIndex = -1;
            GetData();
        }

        protected void DataGrid1_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.EditItem)
            {
                TextBox t1 = (TextBox)e.Item.Cells[1].Controls[0];
                
                TextBox t3 = (TextBox)e.Item.Cells[3].Controls[0];
                TextBox t4 = (TextBox)e.Item.Cells[4].Controls[0];
                TextBox t5 = (TextBox)e.Item.Cells[5].Controls[0];

                t1.Width = 30;
                
                t3.Width = 70;
                t4.Width = 30;
                t5.Width = 50;
            }
        }
        
    }
}