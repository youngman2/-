<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGrade.aspx.cs" Inherits="高校学生成绩管理系统.AdminGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminGrade</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<asp:Button id="Button1" runat="server" Text="学生成绩录入" OnClick="Button1_Click"></asp:Button><br>
				</br>
				<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="336px" OnPageIndexChanged="DataGrid1_PageIndexChanged">
					<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
					<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
				</asp:DataGrid>
			</font>
		</form>
	</body>
</html>
