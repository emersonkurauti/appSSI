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
                            <h4>
                                <asp:Label ID="lblNenhumDefeito" class="label label-default" runat="server" Visible="True">
                                    Caso não seja um dos defeitos listados,
                                    <asp:LinkButton ID="lnkNenhumDefeito" runat="server" 
                                        onclick="lnkNenhumDefeito_Click">clique aqui</asp:LinkButton>
                                        para abrir um chamado.
                                </asp:Label>
                            </h4>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:GridView ID="gvDefeitos" runat="server" 
                                CssClass="table table-bordered table-hover" AllowPaging="True" 
                                onselectedindexchanged="gvDefeitos_SelectedIndexChanged" 
                                DataKeyNames="cdDefeito">
                                <AlternatingRowStyle CssClass="warning" />
                                <Columns>
                                    <asp:BoundField DataField="cdDefeito" Visible="False" />
                                    <asp:BoundField DataField="deDefeito" HeaderText="Descrição" />
                                    <asp:CommandField ButtonType="Button" SelectText="Detalhes..." 
                                        ShowSelectButton="True">
                                        <ControlStyle CssClass="btn btn-lg btn-primary btn-block" />
                                    <ItemStyle Width="20%" />
                                    </asp:CommandField>
                                </Columns>
                                <HeaderStyle CssClass="info" />
                            </asp:GridView>
                            <h4>
                                <asp:Label ID="lblAviso" class="label" runat="server" style="color:Black; font-style:normal; font-weight:normal"
                                    Visible="True">Defeito não encontrado,
                                    <asp:LinkButton ID="lnkAbrirChamado" runat="server" 
                                        onclick="lnkAbrirChamado_Click">clique aqui</asp:LinkButton>
                                    para abrir um chamado.
                                </asp:Label>
                            </h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
