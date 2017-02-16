<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/login.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/reset.css" rel="stylesheet" />
    <link href="css/supersized.css" rel="stylesheet" />
    <title>Lista de produccion</title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="container">
            <h1 class="col-sm-12 col-md-12 col-lg-12">Global Integral Services</h1>
            <br />
            <h2 class="col-sm-12 col-md-12 col-lg-12">"Haciendo que el mundo siga evolucionando"</h2>
        </header>

        <div class="page-container">
            <h1 class="log">Iniciar Sesión</h1>

            <div class="login">
                <input runat="server" id="txtuser" type="text" name="username" class="username" placeholder="Usuario" />
                <input runat="server" id="txtpswd" type="password" name="password" class="password" placeholder="Contraseña" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Log In" CssClass="button" OnClick="btnLogin_Click" />
            <div class="error"><span>+</span></div>

            <div class="connect">
                <p>Visita el sitio:</p>
                <p>
                    <a href="http://www.globalintegralservices.com">
                        <img class="gis" src="img/LOGO.png" width="250" height="180" />
                    </a>
                </p>
            </div>
        </div>

        <footer class="foot">
            <div class="row">
                <div class="col-xs-12"><span class="footer-legal"><span id="copyright-year" class="fa fa-copyright">&nbsp; 2017</span> Diseñado por Global Integral Services S.A. de C.V.</span></div>
            </div>
        </footer>
    </form>
    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/supersized.3.2.7.min.js"></script>
    <script src="js/supersized-init.js"></script>
</body>
</html>
