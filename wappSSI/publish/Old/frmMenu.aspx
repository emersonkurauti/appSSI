<%@ Page Title="" Language="C#" MasterPageFile="frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmMenu.aspx.cs" Inherits="wappSSI.frmMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
        .auto-style2
        {
            width: 100%;
            height: 2%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <table class="auto-style1" style="height: 483px">
        <tr>
            <td class="auto-style2">
                <asp:Menu ID="menu" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Small" ForeColor="#284E98" OnMenuItemClick="menu_MenuItemClick" Orientation="Horizontal" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem Text="Alterar Senha"></asp:MenuItem>
                        <asp:MenuItem Text="LogOut" Value="frmLogin.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Consultar Defeitos"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td style="width: 100%; height: 100%;">
                <asp:Panel ID="pnFrame" runat="server" Height="100%" Width="100%">
                    <iframe scrolling = "true" height="100%" width="100%"/>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
