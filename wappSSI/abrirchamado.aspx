<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="abrirchamado.aspx.cs" Inherits="wappSSI.abrirchamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Abrir chamado...</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <h1 class="panel-title">Título do defeito :</h1>
                            <asp:TextBox ID="txtTitulo" class="form-control" runat="server" 
                                placeholder="Título..." Visible="true"></asp:TextBox>
                            <br />
                            <h1 class="panel-title">Descrição :</h1>
                            <asp:TextBox ID="txtDescDefeito" runat="server" Height="100%" class="form-control"
                                TextMode="MultiLine" placeholder="Descrição do defeito..." Width="100%" 
                                Rows="7"></asp:TextBox>
                            <br />
                            <h1 class="panel-title">Imagens :</h1>

                            <div class="row">
                                <div class="col-sm-6" align="center">
                                    <asp:Button ID="btnEnviar" CssClass="btn btn-lg btn-success" runat="server" 
                                        Text="Enviar" Width="225px"/>
                                </div>
                                <div class="col-sm-6" align="center">
                                    <asp:Button ID="btnCancelar" CssClass="btn btn-lg btn-danger" runat="server" 
                                        Text="Cancelar" Width="225px"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
