<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="wappSSI.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Login</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="page-header">
        </div>
        <div class="container theme-showcase" role="main">
            <div class="row">
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Entrar</h3>
                        </div>
                        <div class="panel-body">
                            <asp:TextBox ID="txtUsuario" class="form-control" runat="server" placeholder="Usuário" required autofocus></asp:TextBox>
                            <asp:TextBox ID="txtSenha" class="form-control" runat="server" 
                                placeholder="Senha" required TextMode="Password"></asp:TextBox>
                            <br/>
                            <asp:Button ID="btnEntrar" class="btn btn-lg btn-primary btn-block" 
                                runat="server" Text="Entrar" onclick="btnEntrar_Click" />
                           <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                </div>
            </div>
        </div>
    </form>
</body>
</html>
