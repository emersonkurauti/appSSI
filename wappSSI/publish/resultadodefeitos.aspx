<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="resultadodefeitos.aspx.cs" Inherits="wappSSI.resultadodefeitos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Defeitos encotrados</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <div id="DivNenhumDefeito" class="well" runat="server">
                                Caso não seja um dos defeitos listados,
                                <strong>
                                    <asp:LinkButton ID="lnkNenhumDefeito" runat="server" 
                                        onclick="lnkNenhumDefeito_Click">clique aqui </asp:LinkButton>
                                </strong>
                                para abrir um chamado.
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:GridView ID="gvDefeitos" runat="server" 
                                CssClass="table table-bordered table-hover" AllowPaging="True" 
                                onselectedindexchanged="gvDefeitos_SelectedIndexChanged" 
                                DataKeyNames="cdDefeito" 
                                onpageindexchanging="gvDefeitos_PageIndexChanging">
                                <AlternatingRowStyle CssClass="warning" />
                                <Columns>
                                    <asp:BoundField DataField="cdDefeito" Visible="False" />
                                    <asp:BoundField DataField="deDefeito" HeaderText="Descrição" />
                                    <asp:CommandField ButtonType="Button" SelectText="Detalhes..." 
                                        ShowSelectButton="True">
                                        <ControlStyle CssClass="btn btn-sm btn-primary btn-block" />
                                    <ItemStyle Width="20%" />
                                    </asp:CommandField>
                                </Columns>
                                <HeaderStyle CssClass="info" />
                            </asp:GridView>
                            <div class="row">
                                <div class="col-sm-12">
                                    <div id="DivNenhumChamado" class="well" runat="server">
                                        Defeito não encontrado,
                                        <strong>
                                            <asp:LinkButton ID="lnkAbrirChamado" runat="server" 
                                                onclick="lnkAbrirChamado_Click">clique aqui </asp:LinkButton>
                                        </strong>
                                        para abrir um chamado.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
