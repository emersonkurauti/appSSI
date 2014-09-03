<%@ Page Title="" Language="C#" MasterPageFile="frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmDetalhesDefeitos.aspx.cs" Inherits="wappSSI.frmDetalhes" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
        .style4
        {
            width: 1144px;
        }
        .style6
        {
            height: 153px;
        }
        .style7
        {
            height: 175px;
        }
        .style18
        {
            height: 126px;
        }
        .style19
        {
            height: 100%;
        }
        .style20
        {
            height: 36%;
        }
        .style21
        {
            width: 82%;
        }
        .style22
        {
            height: 115%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <table class="auto-style1" style="height: 100%; width: 100%;">
        <tr>
            <td class="style18" colspan="2">
                <asp:Panel ID="pnImagens" runat="server" BorderStyle="Outset" Height="100%" 
                    HorizontalAlign="Left" ScrollBars="Vertical" Width="100%">
                    <asp:Table ID="tbImagens" runat="server" Height="100%" 
                        HorizontalAlign="Left" Width="100%">
                    </asp:Table>
                </asp:Panel>
            </td>
            <td class="style18">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <table class="auto-style1" style="width: 100%; height: 100%">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="lblTitulo" runat="server" Text="Descrição do defeito:"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" style="text-align: left; vertical-align: top">
                            <asp:Label ID="lblDescDefeito" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; vertical-align: top">
                            <asp:Label ID="lblAviso" runat="server" 
                                Text="Este defeito está em verificação..."></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7" style="vertical-align: top">
                        <asp:GridView ID="gvSolucoesDefeitos" runat="server" CellPadding="4" ForeColor="#333333" 
                            GridLines="None" Height="100%" Width="100%" AllowPaging="True" 
                            AutoGenerateColumns="False" 
                                onselectedindexchanged="gvSolucoesDefeitos_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="#CCCCFF" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="cdSolucao" HeaderText="Cód. Soluçao">
                                <FooterStyle HorizontalAlign="Left" />
                                <HeaderStyle Width="10%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="deSolucao" HeaderText="Descrição da Solução" />
                                <asp:CommandField SelectText="Detalhes..." ShowSelectButton="True">
                                <HeaderStyle Width="10%" />
                                </asp:CommandField>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="lbltexto" runat="server">Caso seja este o defeito e nenhuma das soluções foram válidas, </asp:Label>
&nbsp;<asp:LinkButton ID="lnkbLink" runat="server">clique aqui.</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="text-align: center; vertical-align: top">
                <table class="auto-style1" style="width: 100%; height: 100%">
                    <tr>
                        <td class="style20" colspan="2">
                            </td>
                    </tr>
                    <tr>
                        <td class="style21">
                            <asp:ImageButton ID="imgbLeft" runat="server" 
                                ImageUrl="~/Imagens/previous.png" onclick="imgbLeft_Click" Width="55px" />
                        </td>
                        <td class="auto-style1">
                            <asp:ImageButton ID="imgbRight" runat="server" ImageUrl="~/Imagens/next.png" 
                                onclick="imgbRight_Click" Width="55px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style22" style="text-align: center; vertical-align: top" colspan="2">
                            <asp:ImageButton ID="imgbVoltar" runat="server" 
                                ImageUrl="~/Imagens/back.png" Width="100px" onclick="imgbVoltar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style22" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td class="style19" colspan="2">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td style="text-align: center; vertical-align: top">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
