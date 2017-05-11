<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStuStat.aspx.cs" Inherits="高校学生成绩管理系统.AdminStuStat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminStuStat</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			课程统计
			<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="320px" OnPageIndexChanged="DataGrid1_PageIndexChanged">
				<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
				<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</html>
