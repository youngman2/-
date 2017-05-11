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
    public partial class AdminGroup : System.Web.UI.Page
    {
        static string conStr = @"Data Source= HOMEMIC-53CA6E3\SQLSERVER;User ID=sa;Password=123;Initial Catalog=GradeSys";
        SqlConnection conn = new SqlConnection(conStr);
        
        private string GetSelects;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetGroupList();
                GetData();
            }
            JS();
        }

        private void GetData()
        {
            string sql = string.Empty;
            sql = string.Format("select * from AdminUrl");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new System.Data.DataSet();
            try
            {
                da.Fill(ds, "s");
                this.DataGrid1.DataSource = ds.Tables["s"];
                try
                {
                    this.DataGrid1.DataBind();
                }
                catch
                {
                    this.DataGrid1.CurrentPageIndex = 0;
                    this.DataGrid1.DataBind();
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
        
        private void GetGroupList()
        {
            string sql = string.Empty;
            sql = string.Format("select id,[Group] from AdminGroup order by id asc");
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.DropDownList1.Items.Clear();
                    do
                    {
                        ListItem ls = new ListItem(dr["group"].ToString(), dr["id"].ToString());
                        this.DropDownList1.Items.Add(ls);
                    } while (dr.Read());
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
       
        private void JS()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script language=javascript>");
            sb.Append("function Del(){");
            sb.Append("return confirm('确定要删除[" + this.DropDownList1.SelectedItem.Text + "]吗?操作将不可逆!!!');}");
            sb.Append("</script>");

            String js = sb.ToString();
            if (!ClientScript.IsClientScriptBlockRegistered( "Del"))
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Del", js);
            }
            Button2.Attributes.Add("onclick", "return Del()");

        }
  
        private void UpdateGroup()
        {
            string sql = string.Empty;
            sql = string.Format("update AdminGroup set Promise = '{0}' where [Group] = '{1}' ", GetSelects, this.DropDownList1.SelectedItem.Text.ToString());
            //Response.Write(sql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (GetSelects != null)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Response.Write("<script>alert('您没有选择信息任何需要更新的记录?')</script>");
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

        protected void cmdSelectAll_Click(object sender, System.EventArgs e)
        {
            System.Web.UI.WebControls.CheckBox chkExport;
            if (cmdSelectAll.Text == "全选")
            {
                foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
                {
                    //建立CheckBox的引用
                    chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
                    chkExport.Checked = true;
                }
                cmdSelectAll.Text = "全消";
            }
            else
            {
                foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
                {
                    chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
                    chkExport.Checked = false;
                }
                cmdSelectAll.Text = "全选";
            }
        }

        protected void cmdSP_Click(object sender, System.EventArgs e)
        {
            CheckBox chkExport;
            string sID;
            //System.Text.StringBuilder strMsg = new System.Text.StringBuilder("选中的项为:<hr color=red>");
            System.Text.StringBuilder strMsg = new System.Text.StringBuilder();
            foreach (DataGridItem oDataGridItem in this.DataGrid1.Items)
            {
                chkExport = (CheckBox)oDataGridItem.FindControl("chkExport");
                //若选中则取值
                if (chkExport.Checked)
                {
                    sID = oDataGridItem.Cells[1].Text.ToString();
                    strMsg.Append(sID + ",");
                }
            }
            GetSelects = strMsg.ToString().Trim();
            //Response.Write(GetSelects);

            UpdateGroup();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Label1.Text = "当前选择:" + this.DropDownList1.SelectedItem.Text.ToString();
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("AdminGroupAdd.aspx");
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            string sql = string.Format("delete AdminGroup where [Group]='{0}'", this.DropDownList1.SelectedItem.Text.ToString());
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                if (this.DropDownList1.SelectedItem.Text.ToString() == "超级管理组")
                {
                    Response.Write("<script>alert('你不能删除超级管理组!')</script>");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
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

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            GetData();
        }
    }
}