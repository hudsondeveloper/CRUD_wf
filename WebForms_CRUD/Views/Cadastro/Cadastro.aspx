<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebForms_CRUD.Views.Cadastro.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
	
    <form id="form1" runat="server">
        <div>

        	CADASTRO<br />
			<br />
			<br />
			nome:&nbsp;
			<asp:TextBox ID="nome" runat="server" Height="23px" Wrap="False"></asp:TextBox>

        </div>
    	<p>
			email:
			<asp:TextBox ID="Email" runat="server"></asp:TextBox>
		</p>
		sexo:&nbsp;<asp:CheckBox ID="Masculino" runat="server" Text="Masculino"/>
		<asp:CheckBox ID="Feminino" runat="server" Text="Feminino"/>
&nbsp;<p>
			estudo:&nbsp;
			<asp:TextBox ID="Estudo" runat="server"></asp:TextBox>
		</p>
		<asp:Button ID="Cadastrar" runat="server" OnClick="Cadastrar_Click" Text="Cadastrar" />
		<p>
			<asp:Button ID="Button2" runat="server" Height="29px" Text="Voltar" Width="82px" OnClick="Button2_Click" />
		</p>
    </form>
</body>
</html>
