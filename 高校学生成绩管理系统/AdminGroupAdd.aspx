﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGroupAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminGroupAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminGroupAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<table id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
					<tr>
						<td style="WIDTH: 69px">组名称:</td>
						<td>
							<asp:TextBox id="txtGname" runat="server"></asp:TextBox>
							<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtGname"></asp:RequiredFieldValidator></td>
					</tr>
					<tr>
						<td style="WIDTH: 69px">组说明:</td>
						<td>
							<asp:TextBox id="txtGinfo" runat="server"></asp:TextBox></td>
					</tr>
					<tr>
						<td style="WIDTH: 69px"></td>
						<td>
							&nbsp;&nbsp;&nbsp;&nbsp;
							<asp:Button id="Button1" runat="server" Text="确  定" OnClick="Button1_Click" style="margin-left: 0px"></asp:Button>
			<font face="宋体">
				&nbsp;&nbsp;
			</font></td>
					</tr>
					
				</table>
			</font>
		</form>
	</body>
</html>
