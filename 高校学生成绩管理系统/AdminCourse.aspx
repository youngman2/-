<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCourse.aspx.cs" Inherits="高校学生成绩管理系统.AdminCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminCourse</title>
</head>
<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Button id="Button2" runat="server" Text="课程信息录入" OnClick="Button2_Click"></asp:Button><br>
			<br>
			<asp:DataGrid id="DataGrid1" runat="server" AllowPaging="True" Width="344px" AutoGenerateColumns="False" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnUpdateCommand="DataGrid1_UpdateCommand">
				<HeaderStyle BackColor="#CCCC66"></HeaderStyle>
				<Columns>
					<asp:BoundColumn DataField="课程号" ReadOnly="True" HeaderText="课程号"></asp:BoundColumn>
					<asp:BoundColumn DataField="课程名" HeaderText="课程名"></asp:BoundColumn>
					<asp:BoundColumn DataField="先修课" HeaderText="先修课"></asp:BoundColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="更新" CancelText="取消" EditText="编辑"></asp:EditCommandColumn>
					<asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle NextPageText="下一页" PrevPageText="上一页"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</html>
