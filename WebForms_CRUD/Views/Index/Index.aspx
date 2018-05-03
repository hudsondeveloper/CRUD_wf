<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebForms_CRUD.Views.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			
        </div>
    	<asp:Button ID="Cadastrar" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
		<p>
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Listar" />
		</p>
    	<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Relatório" />
    </form>
</body>
</html>
