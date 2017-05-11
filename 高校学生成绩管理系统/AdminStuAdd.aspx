<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStuAdd.aspx.cs" Inherits="高校学生成绩管理系统.AdminStuAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminStuAdd</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table id="Table1" cellSpacing="1" cellPadding="1" width="400" border="1">
				<tr>
					<td style="WIDTH: 89px">学号</td>
					<td>
						<asp:TextBox id="txtsid" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtsid"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">姓名</td>
					<td>
						<asp:TextBox id="txtname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtname"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">性别</td>
					<td>
						<asp:RadioButton id="rbman" runat="server" Text="男" Checked="True" GroupName="sex"></asp:RadioButton>
						<asp:RadioButton id="rbwoman" runat="server" Text="女" GroupName="sex"></asp:RadioButton></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">年龄</td>
					<td>
						<asp:TextBox id="txtage" runat="server"></asp:TextBox>
						<asp:RangeValidator id="RangeValidator1" runat="server" ErrorMessage="输入无效" ControlToValidate="txtage"
							Type="Integer" MaximumValue="150" MinimumValue="0"></asp:RangeValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">所在院系</td>
					<td>
						<asp:TextBox id="txts" runat="server"></asp:TextBox></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">班级名</td>
					<td>
						<asp:TextBox id="txtclassname" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" ControlToValidate="txtclassname" ErrorMessage="必填"></asp:RequiredFieldValidator></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px">入学年份</td>
					<td>
						<asp:TextBox id="txtyear" runat="server">2001-09-01</asp:TextBox></td>
				</tr>
				<tr>
					<td style="WIDTH: 89px"></td>
					<td>
						&nbsp;
						<asp:Button id="Button1" runat="server" Text="添 加" OnClick="Button1_Click"></asp:Button><font face="宋体">&nbsp;&nbsp;
						</font>
						<asp:Button id="Button2" runat="server" Text="返 回" OnClick="Button2_Click"></asp:Button></td>
				</tr>
			</table>
		</form>
	</body>
</html>
