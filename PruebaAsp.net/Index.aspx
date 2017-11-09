<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PruebaAsp.net.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--<link href="Content/StyleBase.css" rel="stylesheet" />--%>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
    <link rel="stylesheet" href="Content/assets/css/main.css" />
    <!--[if lte IE 8]><link rel="stylesheet" href="assets/css/ie8.css" /><![endif]-->
    <!--[if lte IE 9]><link rel="stylesheet" href="assets/css/ie9.css" /><![endif]-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio</title>
</head>
<body>
    <form id="form1" runat="server">



        <!-- Header -->
        <div id="header">

            <div class="top">

                <!-- Logo -->
                <div id="logo">
                    <span class="image avatar48">
                        <img src="Content/images/avatar.jpg" alt="" /></span>
                    <h1 id="title">
                        <asp:Label ID="lblusuario" runat="server" Text=""></asp:Label></h1>

                    <p>Hyperspace Engineer</p>
                </div>

                <!-- Nav -->
                <nav id="nav">
                    <!--

								Prologue's nav expects links in one of two formats:

								1. Hash link (scrolls to a different section within the page)

								   <li><a href="#foobar" id="foobar-link" class="icon fa-whatever-icon-you-want skel-layers-ignoreHref"><span class="label">Foobar</span></a></li>

								2. Standard link (sends the user to another page/site)

								   <li><a href="http://foobar.tld" id="foobar-link" class="icon fa-whatever-icon-you-want"><span class="label">Foobar</span></a></li>

							-->
                    <ul>
                        <li><a href="#top" id="top-link" class="skel-layers-ignoreHref"><span class="icon fa-home">Inicio</span></a></li>
                        <li><a href="#libros" id="portfolio-link" class="skel-layers-ignoreHref"><span class="icon fa-th">libros</span></a></li>
                    </ul>
                </nav>

            </div>



        </div>

        <!-- Main -->
        <div id="main">

            <!-- Intro -->
            <section id="top" class="one dark cover">
                <div class="container">

                    <header>
                        <h2 class="alt"><strong>Workspace</strong></h2>

                    </header>


                </div>
            </section>

            <!-- Portfolio -->
            <section id="libros" class="two">
                <div class="container">

                    <header>
                        <h2>libros</h2>
                    </header>

                    <asp:TextBox ID="Txtbuscar" CssClass="input" runat="server" ToolTip="Buscar Referencia" MaxLength="5" placeholder="buscar"></asp:TextBox>
                    <asp:Button ID="btnbuscar" runat="server" Text="buscar" ToolTip="buscar" OnClick="btnbuscar_Click" />

                    <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
                    <asp:GridView ID="DGridlibros" runat="server"></asp:GridView>
                    <div class="col-md-4">

                        <div class="col-md-1">
                            <asp:RegularExpressionValidator ID="IDnombrelibro" runat="server" ControlToValidate="TxtNombrelibro" ErrorMessage="EL NOMBRE NO PUEDE PASAR DE LOS 20 CARACTERES Y TENER UN MINIMO DE 3 CARACTERES" SetFocusOnError="True" ValidationExpression=".{3}.*"></asp:RegularExpressionValidator><br />
                            <asp:RegularExpressionValidator ID="IDGeneroLibro" runat="server" ControlToValidate="TxtGenero" ErrorMessage="EL NOMBRE NO PUEDE PASAR DE LOS 30 CARACTERES Y TENER UN MINIMO DE 3 CARACTERES" SetFocusOnError="True" ValidationExpression=".{3}.*"></asp:RegularExpressionValidator><br />
                            <asp:RegularExpressionValidator ID="IDPrecioLibro" runat="server" ControlToValidate="TxtPrecio" ErrorMessage="Recuerde que sólo se puede ingresar números, minumo 1 maximo 9" SetFocusOnError="True" ValidationExpression=".{2}.*"></asp:RegularExpressionValidator>
                        </div>



                    </div>

                    <div class="col-md-4">

                        <div class="col-md-1">
                            <asp:TextBox ID="TxtNombrelibro" CssClass="input" placeholder="Ingrese Nombre del libro." MaxLength="20" runat="server"></asp:TextBox>
                             <br />
                            <asp:TextBox ID="TxtGenero" CssClass="input" placeholder="Ingrese Genero del libro" MaxLength="30" runat="server"></asp:TextBox>
                             <br />
                            <asp:TextBox ID="TxtPrecio" CssClass="input" placeholder="Ingrese precio." MaxLength="9" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                        </div>



                    </div>
                    <br />
                    <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" />
                    <%--<asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />--%>
                </div>

            </section>





        </div>
        <!-- Scripts -->
        <script src="Content/assets/js/jquery.min.js"></script>
        <script src="Content/assets/js/jquery.scrolly.min.js"></script>
        <script src="Content/assets/js/jquery.scrollzer.min.js"></script>
        <script src="Content/assets/js/skel.min.js"></script>
        <script src="Content/assets/js/util.js"></script>
        <!--[if lte IE 8]><script src="Content/assets/js/ie/respond.min.js"></script><![endif]-->
        <script src="Content/assets/js/main.js"></script>



    </form>
</body>
</html>

