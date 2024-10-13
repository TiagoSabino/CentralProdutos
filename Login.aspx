<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CentralProdutos.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tela de Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="styles.css">
</head>
<body>

<form id="form1" runat="server" >
    <div class="container d-flex justify-content-center align-items-center vh-100">
        <div class="login-box d-flex shadow bg-white">
            <!-- Imagem à esquerda -->
            <div class="image-container">
                <img src="Imagens/Login.jpg" alt="Login Image" class="login-image">
            </div>
            <!-- Formulário de login à direita -->
            <div class="form-container p-4">
                <h3 class="mb-4">Login</h3>
                <asp:Label Text="" runat="server" id="lbmsg" Visible="false"/>
                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="name@example.com"></asp:TextBox>
                    <label for="txtUsuario">Usuario</label>
                </div>
                <div class="form-floating mb-3">
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                    <label for="txtSenha">Senha</label>
                </div>
                <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary w-100" Text="Entrar" OnClick="btnLogin_Click"/>
            </div>
        </div>
    </div>
</form>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
