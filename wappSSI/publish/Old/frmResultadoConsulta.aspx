<%@ Page Title="" Language="C#" MasterPageFile="frmPrincipal.Master" AutoEventWireup="true" CodeBehind="frmResultadoConsulta.aspx.cs" Inherits="wappSSI.frmResultadoConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecalho" runat="server">
    <style type="text/css">
    .style4
    {
        height: 344px;
    }
    .style5
    {
            width: 937px;
        }
    .style6
    {
        height: 344px;
        width: 937px;
    }
    .style7
    {
        height: 276px;
    }
    .style8
    {
            width: 468px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <table class="auto-style1" style="width: 100%; height: 100%">
    <tr>
        <td>
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
        </td>
        <td class="style6">
            <table class="auto-style1" style="width: 100%; height: 100%">
                <tr>
                    <td class="style8">
                        <asp:Label ID="lbl1" runat="server" Text="Defeito não encontrado,"></asp:Label>
&nbsp;<asp:LinkButton ID="lnkbtnAbrirChamado" runat="server">clique aqui</asp:LinkButton>
&nbsp;<asp:Label ID="lbl2" runat="server" Text="para abrir um chamado."></asp:Label>
                    </td>
                    <td style="text-align: left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style7" colspan="2" style="text-align: center; vertical-align: top">
                        <asp:GridView ID="gvDefeitosSolucoes" runat="server" CellPadding="4" ForeColor="#333333" 
                            GridLines="None" Height="100%" Width="100%" AllowPaging="True" 
                            AutoGenerateColumns="False" 
                            onselectedindexchanged="gvDefeitosSolucoes_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="#CCCCFF" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="score" HeaderText="Score">
                                <HeaderStyle Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="cdDefeito" HeaderText="Cód. Defeito" >
                                <HeaderStyle Width="5%" />
                                </asp:BoundField>
                                <asp:BoundField DataField="deDefeito" HeaderText="Defeito" />
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
                    <td class="style8">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </td>
        <td class="style4">
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
