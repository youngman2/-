<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="高校学生成绩管理系统.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<font face="宋体">
				<br>
				<br>
				<br>
				<br>
				<br>
				<table align="center" cellSpacing="0" cellPadding="0" width="526" border="0">
					<tr>
						<td colSpan="3"><IMG height="41" alt="" src="images/login_1.jpg" width="526"></td>
					</tr>
					<tr>
						<td><IMG height="219" alt="" src="images/login_2.jpg" width="321"></td>
						<td width="187" height="219">
							<table id="Table3" height="219" cellSpacing="0" cellPadding="0" width="187" border="0">
								<tr>
									<td>&nbsp;
										<table id="Table1" cellSpacing="1" cellPadding="1" border="0">
											<tr>
												<td>用户名:</td>
												<td>
													<asp:TextBox id="txtUsername" runat="server" BorderStyle="Groove" Width="100px"></asp:TextBox></td>
											</tr>
											<tr>
												<td>密&nbsp; 码:</td>
												<td>
													<asp:TextBox id="txtPassword" runat="server" TextMode="Password" BorderStyle="Groove" Width="100px"></asp:TextBox></td>
											</tr>
											<tr>
												<td></td>
												<td>
													<asp:Button id="Button1" runat="server" Text="确 定" OnClick="Button1_Click"></asp:Button></td>
											</tr>
										</table>
									</td>
								</tr>
							</table>
						</td>
						<td><img height="219" alt="" src="images/login_4.jpg" width="18"></td>
					</tr>
					<tr>
						<td colSpan="3"><img height="42" alt="" src="images/login_5.jpg" width="526"></td>
					</tr>
				</table>
			</font>
		</form>
	</body>
</html>
