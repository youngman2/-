<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminTeacherAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminTeacherAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminTeacherAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<table id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
					<tr>
						<td>教师名</td>
						<td>
							<asp:TextBox id="txtTname" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>课程号
						</td>
						<td>
							<asp:TextBox id="txtCid" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>学时数</td>
						<td>
							<asp:TextBox id="txtTime" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td>班级名</td>
						<td>
							<asp:TextBox id="txtClass" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="HEIGHT: 27px"></td>
						<td style="HEIGHT: 27px">
							&nbsp;&nbsp;&nbsp;<asp:Button id="Button1" runat="server" Text="添  加" OnClick="Button1_Click"></asp:Button></td>
					</tr>
					
				</table>
			</font>
		</form>
	</body>
</html>
