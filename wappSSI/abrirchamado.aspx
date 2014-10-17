<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="abrirchamado.aspx.cs" Inherits="wappSSI.abrirchamado" %>
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
                            <div class="row">
                                <div class="col-sm-4">
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
                                </div>
                                <div class="col-sm-8">
                                    <h1 class="panel-title">Título do defeito</h1>
                                    <asp:TextBox ID="txtTitulo" class="form-control" runat="server" 
                                        placeholder="Título..." Visible="true"></asp:TextBox>
                                    <br />
                                    <h1 class="panel-title">Descrição</h1>
                                    <asp:TextBox ID="txtDescDefeito" runat="server" Height="100%" class="form-control"
                                        TextMode="MultiLine" placeholder="Descrição do defeito..." Width="100%" 
                                        Rows="5"></asp:TextBox>
                                </div>
                            </div>
                            
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
                                    <asp:Button ID="btnCarregar" CssClass="btn btn-sm btn-info" runat="server" 
                                        Text="Carregar imagem" Width="100%" onclick="btnCarregar_Click"/>
                                </div>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="txtDescIMG" runat="server" Height="150px" class="form-control"
                                        TextMode="MultiLine" placeholder="Descrição da imagem..." Width="100%" 
                                        Rows="4"></asp:TextBox>
                                        <br />
                                    <asp:Button ID="btnEnviarImg" CssClass="btn btn-sm btn-primary" runat="server" 
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
                                        DataKeyNames="deCaminho" onrowdeleting="gvImagens_RowDeleting" 
                                        onpageindexchanging="gvImagens_PageIndexChanging">
                                        <AlternatingRowStyle CssClass="warning" />
                                        <Columns>
                                            <asp:ImageField DataImageUrlField="blImagem" 
                                                DataImageUrlFormatString="~/Imagens/Temp/{0}">
                                                <ControlStyle Height="150px" Width="150px" />
                                                <ItemStyle Height="150px" Width="150px" />
                                            </asp:ImageField>
                                            <asp:BoundField DataField="deImagem" HeaderText="Descrição da imagem" />
                                            <asp:BoundField DataField="deCaminho" HeaderText="deCaminho" Visible="False" />
                                            <asp:CommandField DeleteText="Remover..." ShowDeleteButton="True" >
                                                <ControlStyle CssClass="btn btn-sm btn-danger btn-block" />
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
                                    <!--<asp:Button ID="btnConfirmar" CssClass="btn btn-lg btn-success" runat="server" 
                                        Text="Confirmar" Width="225px" onclick="btnConfirmar_Click"/>-->
                                    <asp:ImageButton ID="imgbConfirma" runat="server" 
                                        ImageUrl="~/Icons/Confirma.png" Height="75px" Width="75px" onclick="btnConfirmar_Click" />
                                </div>
                                <div class="col-sm-6" align="center">
                                    <!--<asp:Button ID="btnCancelar" CssClass="btn btn-lg btn-danger" runat="server" 
                                        Text="Cancelar" Width="225px" onclick="btnCancelar_Click"/>-->
                                    <asp:ImageButton ID="imgbCancel" runat="server" 
                                        ImageUrl="~/Icons/Cancelar.png" Height="75px" Width="75px" onclick="btnCancelar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
