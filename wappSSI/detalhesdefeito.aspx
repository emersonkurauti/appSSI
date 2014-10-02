<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="detalhesdefeito.aspx.cs" Inherits="wappSSI.detalhesdefeito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="JavaScript">
        function Visualizar(imgurl, W, H) {


            var newwin = window.open('', 'miniwin', 'toolbar=0,location=0,directories=0,status=0,menubar=0,scrollbars=0,resizable=0,width=' + W + ',height=' + H + ',top=100,left=100');

            newwin.document.write('<html><head><title></title></head>');
            newwin.document.write('<body>');
            newwin.document.write('<img src=' + imgurl + ' width=100% height=100%>');
            newwin.document.write('</body></html>');

            newwin.document.close();
        }
    </script>
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Detalhes do Defeito</h3>
                </div>           
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4" align="left">
                            <asp:Button ID="imgbtnPrevious" CssClass="btn btn-sm btn-primary" 
                                runat="server" Text="<< Defeito Anterior" onclick="imgbtnPrevious_Click" 
                                Width="225px"/>
                        </div>
                        <div class="col-sm-4" align="center" style="vertical-align:middle">
                            <asp:Button ID="btnVoltar" CssClass="btn btn-sm btn-primary" runat="server" 
                                Text="Voltar - lista de defeitos" onclick="btnVoltar_Click" Width="225px"/>
                        </div>
                        <div class="col-sm-4" align="right">
                            <asp:Button ID="imgbtnNext" CssClass="btn btn-sm btn-primary" runat="server" 
                                Text="Próximo Defeito >>" onclick="imgbtnNext_Click" Width="225px"/>
                        </div>
                    </div>
                    <div class="page-header"><h3>Descrição do defeito</h3></div>     
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="well">
                                <asp:Label ID="lblDescDefeito" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="page-header"><h3>Imagens do defeito</h3></div>
                    <div class="row">
                        <div class="col-sm-12">
                            <div id="carouselimagens" class="carousel slide" data-ride="carousel">
                                <ol class="carousel-indicators">
                                    <asp:Literal ID="listSlide" runat="server" />
                                </ol>
                                <div class="carousel-inner" align="center">
                                    <asp:Literal ID="listImagem" runat="server" />
                                </div>
                                <a class="left carousel-control" href="#carouselimagens" role="button" data-slide="prev">
                                    <span class="glyphicon glyphicon-chevron-left"></span>
                                </a>
                                <a class="right carousel-control" href="#carouselimagens" role="button" data-slide="next">
                                    <span class="glyphicon glyphicon-chevron-right"></span>
                                </a>
                            </div>
                        </div>
                    </div><!--Imagens-->
                    <div class="page-header"><h3>Soluções para o defeito</h3></div>
                    <div class="row">
                        <div class="col-sm-12">
                            <h4>
                                <asp:Label ID="lblNenhumaSolucaoValida" class="label label-default" runat="server" Visible="True">
                                    Caso seja este o defeito mas nenhuma solução foi válida ou não existe,
                                    <asp:LinkButton ID="lnkNenhumaSolucaoEncontrada" runat="server" 
                                        onclick="lnkNenhumaSolucaoEncontrada_Click">clique aqui </asp:LinkButton>
                                        para solicitar a priorização da solução para o defeito.
                                </asp:Label>
                            </h4>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:GridView ID="gvSolucoes" runat="server" 
                                CssClass="table table-bordered table-hover" AllowPaging="True" 
                                DataKeyNames="cdSolucao" 
                                onselectedindexchanged="gvSolucoes_SelectedIndexChanged">
                                <AlternatingRowStyle CssClass="warning" />
                                <Columns>
                                    <asp:BoundField DataField="cdSolucao" Visible="False" />
                                    <asp:BoundField DataField="deSolucao" HeaderText="Descrição" />
                                    <asp:CommandField ButtonType="Button" SelectText="Detalhes..." 
                                        ShowSelectButton="True">
                                        <ControlStyle CssClass="btn btn-sm btn-primary btn-block" />
                                    <ItemStyle Width="20%" />
                                    </asp:CommandField>
                                </Columns>
                                <HeaderStyle CssClass="info" />
                            </asp:GridView>
                        </div>
                    </div><!--Solucoes-->
                </div><!--Corpo do panel-->
            </div>
        </div>
    </div>
</asp:Content>
