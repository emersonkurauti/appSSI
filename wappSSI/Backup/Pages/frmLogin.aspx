<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="wappSSI.frmLogin" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
        .auto-style2
        {
            height: 195px;
        }
        .auto-style3
        {
            height: 23px;
        }
        .auto-style4
        {
            height: 23px;
            width: 495px;
        }
        .auto-style5
        {
            height: 195px;
            width: 495px;
        }
        .auto-style6
        {
            width: 495px;
        }
        .auto-style7
        {
            width: 91px;
        }
        .auto-style10
        {
            height: 45px;
        }
        .auto-style11
        {
            width: 73px;
            height: 45px;
        }
        .auto-style12
        {
            width: 189px;
            height: 45px;
        }
        .auto-style13
        {
            width: 189px;
        }
        .auto-style14
        {
            width: 85px;
        }
        .auto-style15
        {
            width: 85px;
            height: 45px;
        }
        .auto-style16
        {
            width: 73px;
        }
        .style2
        {
            height: 160px;
            width: 349px;
        }
        .style3
        {
            height: 31px;
            width: 349px;
        }
        .style10
        {
            width: 349px;
        }
        .style11
        {
            height: 31px;
            width: 1032px;
        }
        .style12
        {
            height: 160px;
            width: 1032px;
        }
        .style13
        {
            width: 1032px;
        }
        .style14
        {
            height: 31px;
            width: 354px;
        }
        .style15
        {
            height: 160px;
            width: 354px;
        }
        .style16
        {
            width: 354px;
        }
        .style19
        {
            width: 64px;
        }
        .style20
        {
            width: 276px;
        }
        .style21
        {
            width: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    
    <table class="auto-style1" style="width: 100%; height: 100%;">
        <tr>
            <td class="style14">
            </td>
            <td class="style11">
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style15">
                &nbsp;</td>
            <td class="style12" style="width: 100%; height: 100%;">
                <asp:Panel ID="Panel1" runat="server">
                    <table class="auto-style1" 
    style="width: 100%; height: 100%">
                        <tr>
                            <td class="style19">
                                &nbsp;</td>
                            <td class="style21" style="text-align: right">
                                &nbsp;</td>
                            <td class="style20">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style19">
                                &nbsp;</td>
                            <td class="style21" style="text-align: right">
                                Usuário :</td>
                            <td class="style20">
                                <asp:TextBox ID="txtUsuario" runat="server" Width="100%"></asp:TextBox>
                            </td>
                            <td style="text-align: left; vertical-align: bottom">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsuario" 
                ErrorMessage="Informe o usuário..." Font-Italic="True" Font-Size="Small" 
                ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style19">
                                &nbsp;</td>
                            <td class="style21" style="text-align: right">
                                Senha :</td>
                            <td class="style20">
                                <asp:TextBox ID="txtSenha" runat="server" Width="100%"></asp:TextBox>
                            </td>
                            <td style="text-align: left; vertical-align: bottom">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSenha" 
                ErrorMessage="Informe a senha..." Font-Italic="True" Font-Size="Small" 
                ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style19">
                                &nbsp;</td>
                            <td class="style21" style="text-align: right">
                                &nbsp;</td>
                            <td class="style20">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style19">
                                &nbsp;</td>
                            <td class="style21" style="text-align: right">
                                &nbsp;</td>
                            <td class="style20">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:DropShadowExtender ID="Panel1_DropShadowExtender" runat="server" 
                    Enabled="True" TargetControlID="Panel1">
                </asp:DropShadowExtender>
                <asp:RoundedCornersExtender ID="Panel1_RoundedCornersExtender" runat="server" 
                    Enabled="True" TargetControlID="Panel1">
                </asp:RoundedCornersExtender>
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td class="style13">
                &nbsp;</td>
            <td class="style10">
                &nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
