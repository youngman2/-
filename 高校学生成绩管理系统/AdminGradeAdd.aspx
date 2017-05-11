<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGradeAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminGradeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminGradeAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<table id="Table1" cellSpacing="1" cellPadding="1" width="616" border="1" style="WIDTH: 616px; HEIGHT: 183px">
					<tr>
						<td style="WIDTH: 120px; HEIGHT: 4px">请选择班级</td>
						<td style="HEIGHT: 4px"><FONT face="宋体">学生选择</FONT></td>
					</tr>
					<tr>
						<td style="WIDTH: 120px" vAlign="top">
							<asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" Width="136px" AllowPaging="True" OnPageIndexChanged="DataGrid1_PageIndexChanged">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
									<asp:HyperLinkColumn Text="班级名" DataNavigateUrlField="班级名" DataNavigateUrlFormatString="AdminGradeAdd.aspx?Action=Add&amp;班级名={0}"
										HeaderText="请选择" NavigateUrl="AdminGradeAdd.aspx"></asp:HyperLinkColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid>
                        </td>
						<td vAlign="top"><asp:DataGrid id="DataGrid2" runat="server" AutoGenerateColumns="False" Width="392px" AllowPaging="True" OnPageIndexChanged="DataGrid2_PageIndexChanged">
								<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="学号" HeaderText="学号"></asp:BoundColumn>
									<asp:BoundColumn DataField="姓名" HeaderText="姓名"></asp:BoundColumn>
									<asp:BoundColumn DataField="性别" HeaderText="性别"></asp:BoundColumn>
									<asp:BoundColumn DataField="班级名" HeaderText="班级名"></asp:BoundColumn>
									<asp:BoundColumn DataField="所在院系" HeaderText="所在院系"></asp:BoundColumn>
									<asp:HyperLinkColumn Target="_blank" DataNavigateUrlField="学号" DataNavigateUrlFormatString="AdminGradeAddNext.aspx?StuId={0}"
										DataTextField="学号" HeaderText="录入成绩" NavigateUrl="AdminGradeAddNext.aspx"></asp:HyperLinkColumn>
								</Columns>
								<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
							</asp:DataGrid></td>
					</tr>
				</table>
			</font>
		</form>
	</body>
</html>
