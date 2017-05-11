<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUrlAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminUrlAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminUrlAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体"></font>
			<br>
			<br>
			<br>
			<br>
			<br>
			<table align="center" id="Table1" cellSpacing="1" cellPadding="1" width="300" border="0">
				<tr>
					<td style="WIDTH: 110px"><font face="宋体"></font></td>
					<td></td>
				</tr>
				<tr>
					<td style="WIDTH: 110px"><font face="宋体">功能模块名称</font></td>
					<td>
						<asp:TextBox id="txtname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtname"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 110px"><font face="宋体">功能模块URL</font></td>
					<td>
						<asp:TextBox id="txturl" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txturl"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 110px"><font face="宋体">功能模块说明</font></td>
					<td>
						<asp:TextBox id="TextBox3" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td style="WIDTH: 110px"></td>
					<td>
						&nbsp;&nbsp;&nbsp;<asp:Button id="Button1" runat="server" Text="确  定" OnClick="Button1_Click" style="height: 21px"></asp:Button></td>
				</tr>
			</table>
		</form>
	</body>
</html>
