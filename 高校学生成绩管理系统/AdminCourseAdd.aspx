<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCourseAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminCourseAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminCourseAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<table id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
					<tr>
						<td>课程号</td>
						<td>
							<asp:TextBox id="txtid" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtid"></asp:RequiredFieldValidator></td>
					</tr>
					<tr>
						<td>课程名
						</td>
						<td>
							<asp:TextBox id="txtname" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtname"></asp:RequiredFieldValidator></td>
					</tr>
					<tr>
						<td>先修课
						</td>
						<td>
							<asp:TextBox id="txtpre" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
						</td>
						<td>
							<asp:Button id="Button1" runat="server" Text="添  加" OnClick="Button1_Click"></asp:Button>&nbsp;
							<asp:Button id="Button2" runat="server" Text="返 回" OnClick="Button2_Click"></asp:Button>
						</td>
					</tr>
				</table>
			</font>
		</form>
	</body>
</html>
