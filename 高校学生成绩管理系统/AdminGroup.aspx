<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGroup.aspx.cs" Inherits="高校学生成绩管理系统.AdminGroup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminGroup</title>
    
</head>
<body ms_positioning="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<table id="Table1" cellSpacing="1" cellPadding="1" width="500" border="1">
					<tr>
						<td>请选择组:
							<asp:DropDownList id="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                            &nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Label id="Label1" runat="server"></asp:Label>&nbsp;
							<asp:Button id="Button2" runat="server" Text="删除所选组" OnClick="Button2_Click"></asp:Button>&nbsp;
							<asp:Button id="Button1" runat="server" Text="添加新组" OnClick="Button1_Click"></asp:Button></td>
					</tr>
					<tr>
						<TD>
							<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" Width="440px" AllowPaging="True" OnPageIndexChanged="DataGrid1_PageIndexChanged">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:TemplateColumn HeaderText="选择">
										<ItemTemplate>
											<asp:CheckBox ID="chkExPort" Checked="false" Runat="server"></asp:CheckBox>
										</ItemTemplate>
										<EditItemTemplate>
											<asp:CheckBox ID="chkExPortON" Runat="server"></asp:CheckBox>
										</EditItemTemplate>
									</asp:TemplateColumn>
									<asp:BoundColumn DataField="id" HeaderText="序号"></asp:BoundColumn>
									<asp:BoundColumn DataField="UrlName" HeaderText="功能模块"></asp:BoundColumn>
									<asp:BoundColumn DataField="Url" HeaderText="Url地址"></asp:BoundColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid>
                        </TD>
					</tr>
					<TR>
						<TD>
							<asp:Button id="cmdSelectAll" runat="server" Text="全选" OnClick="cmdSelectAll_Click"></asp:Button>
							<asp:Button id="cmdSP" runat="server" Text="设置权限" OnClick="cmdSP_Click"></asp:Button><font face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
								(注:超级管理组不可删除!)</font></TD>
					</TR>
				</table>
			</font>
		</form>
	</body>
</html>
