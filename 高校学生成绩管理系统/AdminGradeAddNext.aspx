<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGradeAddNext.aspx.cs" Inherits="高校学生成绩管理系统.AdminGradeAddNext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminGradeAddNext</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 288px; POSITION: absolute; TOP: 8px; HEIGHT: 90px"
				cellSpacing="1" cellPadding="1" width="288" border="1">
				<tr>
					<td><FONT face="宋体">课程号</FONT></td>
					<td>
						<asp:TextBox id="txtcid" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtcid"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td><font face="宋体">成&nbsp; 绩</font></td>
					<td>
						<asp:TextBox id="txtgrade" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtgrade"></asp:RequiredFieldValidator>
						<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="输入无效" ControlToValidate="txtgrade"
							Type="Integer" MaximumValue="100" MinimumValue="0"></asp:RangeValidator></td>
				</tr>
				<tr>
					<td></td>
					<td>
						&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Button id="Button1" runat="server" Text="确 定" OnClick="Button1_Click"></asp:Button></td>
				</tr>
			</table>
		</form>
	</body>
</html>
