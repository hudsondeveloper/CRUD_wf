<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="WebForms_CRUD.Views.Listar.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<asp:CheckBoxList ID="CheckBoxList1" runat="server">
			</asp:CheckBoxList>
			<br />
			<asp:GridView ID="GridView1" runat="server" DataKeyNames="Id" AutoGenerateColumns="true" OnRowCommand="grdDados_RowCommand">
				<Columns>
					<asp:TemplateField>
						<ItemTemplate>
							<asp:Button ID="btnEditar" runat="server" CommandName="Editar" Text="Editar"
								CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' Width="70" />
							<asp:Button ID="btnExcluir" runat="server" CommandName="Excluir" Text="Excluir"
								CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id")%>' Width="70" />
						</ItemTemplate>
					</asp:TemplateField>
				</Columns>
			</asp:GridView>
		</div>
		<p>
			<asp:Button ID="Button2" runat="server" Height="29px" Text="Voltar" Width="82px" OnClick="Button2_Click" />
		</p>
	</form>

</body>
</html>
