﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="abrirchamado.aspx.cs" Inherits="wappSSI.abrirchamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Abrir chamado</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <h1 class="panel-title">Título do defeito</h1>
                            <asp:TextBox ID="txtTitulo" class="form-control" runat="server" 
                                placeholder="Título..." Visible="true"></asp:TextBox>
                            <br />
                            <h1 class="panel-title">Descrição</h1>
                            <asp:TextBox ID="txtDescDefeito" runat="server" Height="100%" class="form-control"
                                TextMode="MultiLine" placeholder="Descrição do defeito..." Width="100%" 
                                Rows="5"></asp:TextBox>
                            <br />
                            <h1 class="panel-title">Imagens</h1>
                            <div class="row">
                                <div class="col-sm-7">
                                    <asp:FileUpload ID="fluImagem" runat="server" CssClass="btn-lg btn-default" Width="100%" />
                                </div>
                                <div class="col-sm-5">
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">
                                    <asp:Image ID="imgUp" runat="server" Height="150px" Width="100%" 
                                        ImageAlign="Middle" ImageUrl="~/Imagens/null.png" />
                                    <br /><br />
                                    <asp:Button ID="btnCarregar" CssClass="btn btn-lg btn-info" runat="server" 
                                        Text="Carregar imagem" Width="100%" onclick="btnCarregar_Click"/>
                                </div>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="txtDescIMG" runat="server" Height="150px" class="form-control"
                                        TextMode="MultiLine" placeholder="Descrição da imagem..." Width="100%" 
                                        Rows="4"></asp:TextBox>
                                        <br />
                                    <asp:Button ID="btnEnviarImg" CssClass="btn btn-lg btn-primary" runat="server" 
                                        Text="Adicionar imagem" Width="100%" onclick="btnEnviarImg_Click"/>
                                </div>
                                <div class="col-sm-5">
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-12">
                                <!-- Grid de imagens -->
                                    <br />
                                    <asp:GridView ID="gvImagens" runat="server"
                                        CssClass="table table-bordered table-hover" AllowPaging="True" 
                                        DataKeyNames="deCaminho" onrowdeleting="gvImagens_RowDeleting">
                                        <AlternatingRowStyle CssClass="warning" />
                                        <Columns>
                                            <asp:BoundField DataField="deImagem" HeaderText="Descrição da imagem" />
                                            <asp:BoundField DataField="deCaminho" HeaderText="deCaminho" Visible="False" />
                                            <asp:CommandField DeleteText="Remover..." ShowDeleteButton="True" >
                                                <ControlStyle CssClass="btn btn-lg btn-danger btn-block" />
                                                <ItemStyle Width="20%" />
                                            </asp:CommandField>
                                        </Columns>
                                        <HeaderStyle CssClass="info" />
                                    </asp:GridView>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-sm-6" align="center">
                                    <asp:Button ID="btnConfirmar" CssClass="btn btn-lg btn-success" runat="server" 
                                        Text="Confirmar" Width="225px" onclick="btnConfirmar_Click"/>
                                </div>
                                <div class="col-sm-6" align="center">
                                    <asp:Button ID="btnCancelar" CssClass="btn btn-lg btn-danger" runat="server" 
                                        Text="Cancelar" Width="225px" onclick="btnCancelar_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>