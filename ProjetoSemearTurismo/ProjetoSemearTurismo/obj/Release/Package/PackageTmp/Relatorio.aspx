<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Relatorio.aspx.cs" Inherits="ProjetoSemearTurismo.Relatorio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center;">Downloads</h2>

    <div id="DivRelatorioReservas" class="row">
        <div class="col-md-6">
            
            <asp:DropDownList ID="ddlSelectTipoRelatorio" runat="server">
                <asp:ListItem Value="0" Text="Selecione uma opção..."></asp:ListItem>
                <asp:ListItem Value="1" Text="Viagem"></asp:ListItem>
                <asp:ListItem Value="2" Text="Cliente"></asp:ListItem>
                <asp:ListItem Value="3" Text="Transporte"></asp:ListItem>
                <asp:ListItem Value="4" Text="Hospedagem"></asp:ListItem>
                <asp:ListItem Value="5" Text="Reserva"></asp:ListItem>

            </asp:DropDownList>
            
            <asp:TextBox runat="server" ID="txtFiltroNome" ToolTip="Filtrar por nome"></asp:TextBox>
        </div>
        <div class="col-md-6">
        </div>
    </div>

    <div id="DivRelatorioClientes" class="row">
        <div class="col-md-6">
            <h2>Visualizar Viagens em Excel e PDF</h2>
            
                    <asp:GridView ID="gridViewExcel" CssClass="table table-striped table-bordered table-condensed w-100" runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="SQ_VIAGEM">
                        <Columns>
                            <asp:BoundField HeaderText="Identificador" DataField="SQ_VIAGEM"/>
                            <asp:BoundField HeaderText="Nome" DataField="NOME_VIAGEM">
                               
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Inicio viagem" DataField="DT_InicialPeriodo_viagem">
                               
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Final viagem" DataField="DTFinalperiodo_viagem">
                               
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Descricao do pacote" DataField="Descricao_do_pacote">
                              
                            </asp:BoundField>
                            <asp:BoundField DataField="Tipo_Transporte" HeaderText="Transporte" Visible="False">
                                
                            </asp:BoundField>
                            <asp:BoundField DataField="Preco" HeaderText="Preço">
                              
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="OBSERVACAO" HeaderText="Observação">
                                
                            </asp:BoundField>
                         
                  

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

<%--            <asp:GridView ID="gridViewExcel" runat="server" AutoGenerateColumns="true" CssClass="table table-striped table-bordered table-condensed w-100">
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
            </asp:GridView>--%>
            <asp:Button ID="btnGenerateExcelClientes" runat="server" Text="Gerar Excel" OnClick="btnGenerateExcel_Click" CssClass="btn btn-default w-100" />
            <asp:Button ID="btnGeneratePDFClientes" runat="server" Text="Gerar PDF" OnClick="btnGeneratePDF_Click" CssClass="btn btn-default w-100" />

        </div>
        <div class="col-md-6">
        </div>
    </div>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</asp:Content>
