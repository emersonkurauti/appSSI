<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="consultardefeitos.aspx.cs" Inherits="wappSSI.consultardefeitos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Parâmetros da consulta</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-5">
                            <h1 class="panel-title">Sistema</h1>
                                <asp:DropDownList ID="ddlSistema" class="btn btn-default dropdown-toggle" style="text-align:left" 
                                runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlSistema_SelectedIndexChanged">
                                </asp:DropDownList>
                            <asp:TextBox ID="txtSistema" class="form-control" runat="server" 
                                placeholder="Sistema..." Visible="False"></asp:TextBox>
                            <h1 class="panel-title">Módulo</h1>
                                <asp:DropDownList ID="ddlModulo" class="btn btn-default dropdown-toggle" style="text-align:left" 
                                runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlModulo_SelectedIndexChanged">
                                </asp:DropDownList>
                            <asp:TextBox ID="txtModulo" class="form-control" runat="server" 
                                placeholder="Módulo..." Visible="False"></asp:TextBox>
                            <h1 class="panel-title">Tela</h1>
                                <asp:DropDownList ID="ddlTela" class="btn btn-default dropdown-toggle" style="text-align:left" 
                                runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlTela_SelectedIndexChanged">
                                </asp:DropDownList>
                            <asp:TextBox ID="txtTela" class="form-control" runat="server" 
                                placeholder="Tela..." Visible="False"></asp:TextBox>
                            <h1 class="panel-title">Ação</h1>
                                <asp:DropDownList ID="ddlAcao" class="btn btn-default dropdown-toggle" style="text-align:left" 
                                runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlAcao_SelectedIndexChanged">
                                </asp:DropDownList>
                            <asp:TextBox ID="txtAcao" class="form-control" runat="server" 
                                placeholder="Ação..." Visible="False"></asp:TextBox>
                        </div> <!--Parametros DorpDownList-->
                        <div class="col-sm-7">
                            <br />
                            <asp:TextBox ID="txtDescDefeito" runat="server" Height="100%" class="form-control"
                                TextMode="MultiLine" placeholder="Descrição do defeito..." Width="100%" 
                                Rows="7"></asp:TextBox>
                        </div> <!--Parametros Textbox Descrição do Defeito-->
                    </div> <!--Painel de Parametros-->
                    <br/>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Button ID="btnConsultar" class="btn btn-lg btn-primary btn-block" 
                                runat="server" Text="Consultar" onclick="btnConsultar_Click"/>
                        </div>
                    </div> <!--Botão consultar-->
                </div> <!--Panel Body-->
            </div>
        </div>
    </div>
</asp:Content>
