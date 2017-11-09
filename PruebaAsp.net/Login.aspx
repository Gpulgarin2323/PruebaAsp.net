<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebaAsp.net.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/Loginstyle.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="form">
                <p class="message">Por favor ingrese al sistema</p>
                <br />
                <asp:TextBox ID="txtusername" CssClass="input" runat="server" placeholder="Ingrese ususario" requerid="on" MaxLength="15" TabIndex="1" ></asp:TextBox>
                <asp:TextBox ID="txtpassword" CssClass="input" runat="server" placeholder="Ingrese contraseña" requerid="on" TextMode="Password" MaxLength="10" TabIndex="2" ></asp:TextBox>
                <asp:Label ID="lblerrorpass" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Button ID="btningresar" CssClass="button" runat="server" Text="ingresar" TabIndex="3" OnClick="btningresar_Click" />
                <br />
                <br />
               <asp:HyperLink ID="Hypervolver" NavigateUrl="~/Registrarse.aspx" runat="server">Registro</asp:HyperLink>
            </div>
        </div>


    </form>
</body>
</html>
