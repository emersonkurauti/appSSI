<%@ Page Title="" Language="C#" MasterPageFile="frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmConsultarDefeito.aspx.cs" Inherits="wappSSI.frmConsultarDefeito" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
        .centro 
        {
            position:absolute; 
            top:61%; 
            margin-top:-100px; /* ou seja ele pega 50% da altura tela e sobe metade do valor da altura no caso 100 */
            left:53%;
            margin-left:-250px;
        }
        .style4
        {
            height: 37%;
        }
        .watermarked 
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <table class="auto-style1" style="width: 100%; height: 100%;">
        <tr>
            <td style="width: 25%">
                &nbsp;</td>
            <td style="height: 15%">
                &nbsp;</td>
            <td style="width: 25%">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 25%">
                &nbsp;</td>
            <td style="height: 70%">
                <table class="auto-style1" style="width: 100%; height: 100%">
                    <tr>
                        <td style="height: 40%; text-align: left;">
                            <asp:Label ID="lblSistema" runat="server" Text="Sistema :"></asp:Label>
                            <asp:DropDownList ID="ddlSistemas" runat="server" Width="100%" 
                                onselectedindexchanged="ddlSistemas_SelectedIndexChanged" 
                                AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtSistema" runat="server" Width="100%"></asp:TextBox>
                        </td>
                        <td rowspan="4" style="width: 70%">
                            <asp:TextBox ID="txtDescDefeito" runat="server" TextMode="MultiLine" 
                                Width="100%" Rows="10"></asp:TextBox>
                            <asp:TextBoxWatermarkExtender ID="txtDescDefeito_TextBoxWatermarkExtender" 
                                runat="server" Enabled="True" TargetControlID="txtDescDefeito" 
                                WatermarkText="Digite a descrição do defeito..." 
                                WatermarkCssClass="watermarked" ViewStateMode="Enabled">
                            </asp:TextBoxWatermarkExtender>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 40%; text-align: left;">
                            <asp:Label ID="lblModulo" runat="server" Text="Módulo :"></asp:Label>
                            <asp:DropDownList ID="ddlModulos" runat="server" Width="100%" 
                                AutoPostBack="True" onselectedindexchanged="ddlModulos_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtModulo" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 40%; text-align: left;">
                            <asp:Label ID="lblTela" runat="server" Text="Tela :"></asp:Label>
                            <asp:DropDownList ID="ddlTelas" runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlTelas_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtTela" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left;" class="style4">
                            <asp:Label ID="lblAcao" runat="server" Text="Ação :"></asp:Label>
                            <asp:DropDownList ID="ddlAcoes" runat="server" Width="100%" AutoPostBack="True" 
                                onselectedindexchanged="ddlAcoes_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:TextBox ID="txtAcao" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 40%">
                            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" Width="100%" 
                                onclick="btnConsultar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 25%">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 25%">
                &nbsp;</td>
            <td style="height: 15%; text-align: left; vertical-align: top;">
                <asp:Label ID="lblObs" runat="server" 
                    Text="Ao selecionar &quot;Outros&quot;, informe a descrição para que seja cadastrado no sistema posteriormente."></asp:Label>
            </td>
            <td style="width: 25%">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
