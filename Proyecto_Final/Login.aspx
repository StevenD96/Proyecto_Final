<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Proyecto_Final.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form id="Content1" runat="server">
        <div>
            <div class="form-group">
                <label for="exampleInputEmail1">Usuario</label>
                <asp:TextBox ID="txtUsuario" runat="server" class="form-control" aria-describedby="emailHelp"></asp:TextBox>

            </div>

            <div class="form-group">
                <label for="exampleInputPassword1">Contrasena</label>
                <asp:TextBox ID="txtContrasena" runat="server" class="form-control" aria-describedby="emailHelp"></asp:TextBox>

            </div>

            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary" />

        </div>
    </form>
</body>
</html>
