<%@ Page Title="" Language="C#" MasterPageFile="frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmDetalhesSolucoes.aspx.cs" Inherits="wappSSI.frmDetalhesSolucoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
        .style4
        {
            height: 126px;
        }
        .style5
        {
            height: 296px;
        }
        .style6
        {
            height: 50px;
        }
        .style7
        {
            height: 61px;
        }
        .style8
        {
            height: 296px;
            width: 1062px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <table class="auto-style1" style="width: 100%; height: 281px;">
        <tr>
            <td class="style4" colspan="2">
                <asp:Panel ID="pnImagens" runat="server" BorderStyle="Outset" Height="100%" 
                    HorizontalAlign="Left" ScrollBars="Vertical" Width="100%">
                    <asp:Table ID="tbImagens" runat="server" Height="100%" 
                        HorizontalAlign="Left" Width="100%">
                    </asp:Table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style8" style="vertical-align: top; text-align: left">
                <asp:Label ID="lblDescSolucao" runat="server"></asp:Label>
            </td>
            <td class="style5">
                <table class="auto-style1" style="width: 100%; height: 100%">
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:ImageButton ID="imgbSolucionado" runat="server" 
                                ImageUrl="~/Imagens/OK.png" onclick="imgbSolucionado_Click" Width="100px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="text-align: right">
                            <asp:ImageButton ID="imgbPrevious" runat="server" 
                                ImageUrl="~/Imagens/previous.png" onclick="imgbPrevious_Click" Width="55px" />
                        </td>
                        <td class="style6" style="text-align: left">
                            <asp:ImageButton ID="imgbNext" runat="server" ImageUrl="~/Imagens/next.png" 
                                onclick="imgbNext_Click" Width="55px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" colspan="2">
                            <asp:ImageButton ID="imgbBack" runat="server" ImageUrl="~/Imagens/back.png" 
                                onclick="imgbBack_Click" Width="100px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
