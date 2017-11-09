<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="PruebaAsp.net.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/Loginstyle.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />

    <title>Registro</title>
</head>

<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="form">
                <p class="message">Registro</p>
                <br />
                <div class="container">
                <div class="col-md-4">

                    <div class="col-md-2">
                        
                        <asp:TextBox ID="Txtnombreusuario" CssClass="input" runat="server"  placeholder="Ingrese Usuario" MaxLength="15" ToolTip="ingrese su usuario" TabIndex="1" required="on"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="REVnombre" runat="server" ControlToValidate="Txtnombreusuario" ErrorMessage="EL NOMBRE NO PUEDE PASAR DE LOS 30 CARACTERES Y TENER UN MINIMO DE 3 CARACTERES SIN USAR ESPACIOS" SetFocusOnError="True" ValidationExpression="([A-Z]|[a-z]|[0-9])([A-Z]|[a-z]|[0-9])([A-Z]|[a-z]|[0-9])+"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="TxtContrasena" CssClass="input" runat="server"  placeholder="Ingrese Contraseña" MaxLength="15" TabIndex="2" ToolTip="ingrese su contraseña" required="on" TextMode="Password"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="REVcontraseña" runat="server" ControlToValidate="TxtContrasena" ErrorMessage="DEBE TENER MINIMO 4 CARACTERES Y UN MAXIMO DE 50" SetFocusOnError="True" ValidationExpression="([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])([a-z]|[A-Z]|[0-9])+"></asp:RegularExpressionValidator>
                    </div>
                    <div class="col-md-1">
                       
                        <asp:TextBox ID="TxtNombre" CssClass="input"  runat="server"  placeholder="Ingrese Nombre completo" MaxLength="35" TabIndex="3" ToolTip="ingrese su nombre completo" required="on"></asp:TextBox>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtNombre" ErrorMessage="EL NOMBRE NO PUEDE PASAR DE LOS 30 CARACTERES Y TENER UN MINIMO DE 3 CARACTERES" SetFocusOnError="True" ValidationExpression="[a-zA-Z ]*"></asp:RegularExpressionValidator>
                        <asp:TextBox ID="TxtEmail" CssClass="input" runat="server"  placeholder="Ingrese Email" MaxLength="30" TabIndex="4" ToolTip="ingrese su Email" required="on" TextMode="Email"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="REVemail" runat="server" ControlToValidate="TxtEmail" ErrorMessage="EMAIL INVALIDO, PORFAVOR VERIFICARLO" SetFocusOnError="True" ValidationExpression="(([A-Z]|[a-z]|[0-9]|[-]|[.])+)@([a-z|A-Z|0-9]+).([a-z|A-Z|0-9]+).([a-z|A-Z|0-9]+)"></asp:RegularExpressionValidator>
                         <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
                    </div>
                    <asp:Button ID="BtnRegistrar" CssClass="button" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click" />
                    <br />
                    <br />
                    <asp:HyperLink ID="Hypervolver" NavigateUrl="~/Login.aspx" runat="server">Volver</asp:HyperLink>
                    
                     </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
