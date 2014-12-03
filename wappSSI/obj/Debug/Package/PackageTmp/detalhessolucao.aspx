<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="detalhessolucao.aspx.cs" Inherits="wappSSI.detalhessolucao" %>
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
                    <h3 class="panel-title">Detalhes da Solução</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:Literal ID="ltMensagem" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6" align="left" style="float: left">
                            <!--<asp:Button ID="imgbtnPrevious" CssClass="btn btn-sm btn-primary" 
                                runat="server" Text="<< Solução Anterior" onclick="imgbtnPrevious_Click" 
                                Width="225px"/>-->
                            <asp:ImageButton ID="imgbPrevious" runat="server" onclick="imgbtnPrevious_Click" 
                                ImageUrl="~/Icons/previous.png" Height="55px" Width="55px" />
                        </div>
                        <div class="col-sm-6" align="right" style="float: right">
                            <!--<asp:Button ID="imgbtnNext" CssClass="btn btn-sm btn-primary" runat="server" 
                                Text="Próxima Solução >>" onclick="imgbtnNext_Click" Width="225px"/>-->
                            <asp:ImageButton ID="imgbNext" runat="server" onclick="imgbtnNext_Click" 
                                ImageUrl="~/Icons/next.png" Height="55px" Width="55px" />
                        </div>                        
                    </div>
                    <div class="row">
                        <div class="col-sm-6" align="right" style="vertical-align:middle; float: left">
                            <!--<asp:Button ID="Button1" CssClass="btn btn-sm btn-success" runat="server" 
                                    Text="Defeito Solucionado" Width="225px" onclick="btnSolucionado_Click"/>-->
                            <asp:ImageButton ID="imgbSolucionado" runat="server" onclick="btnSolucionado_Click" 
                                ImageUrl="~/Icons/Confirma.png" Height="55px" Width="55px" />
                        </div>
                        <div class="col-sm-6" align="left" style="vertical-align:middle; float: right">
                            <!--<asp:Button ID="btnVoltar" CssClass="btn btn-sm btn-primary" runat="server" 
                                Text="Voltar - lista de solção" onclick="btnVoltar_Click" Width="225px"/>-->
                            <asp:ImageButton ID="imgbVoltar" runat="server" onclick="btnVoltar_Click" 
                                ImageUrl="~/Icons/back.png" Height="55px" Width="55px" />
                        </div>                        
                    </div>
                    <div class="page-header">
                        <h3>Descrição da solução</h3></div>
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="well">
                                <asp:Label ID="lblDescSolucao" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                    <div class="page-header"><h3>Imagens da solução</h3></div>
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
                </div><!--Corpo do panel-->
            </div>
        </div>
    </div>
</asp:Content>