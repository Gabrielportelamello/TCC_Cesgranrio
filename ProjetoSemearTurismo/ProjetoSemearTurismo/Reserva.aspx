<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Reserva.aspx.cs" Inherits="ProjetoSemearTurismo.Views.Reserva" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Estilos para melhorar a aparência */
        .jumbotron {
            background-color: #f8f9fa;
            padding: 2rem 1rem;
            margin-bottom: 2rem;
            border-radius: 0.3rem;
        }

        .lead {
            font-size: 1.25rem;
            font-weight: 300;
        }

        .reserva-section {
            margin-top: 20px;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 10px;
            background-color: #fff;
        }

        /* Estilos para os botões de ação */
        .action-btn {
            margin-right: 10px;
        }
    </style>

    <%--  <div class="jumbotron">
        <h2>Gerenciar Reservas</h2>
        <p class="lead">Cadastre, edite e exclua reservas facilmente.</p>
        <asp:Button ID="BtnModalReservasGRID" Visible="false" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Reserva" OnClick="BtnModalReservasGRID_Click" />
    </div>--%>
        <h2 style="text-align:center;">Reservas</h2>

    <div class="reserva-section">
        <h2>Cadastro de Reservas</h2>
        <hr />

        <!-- Formulário de cadastro de reserva -->
        <div>
            <h3>Dados de Reserva</h3>

            <!-- DropDownList para Viagem -->
            <asp:DropDownList ID="DropDownListViagemPopupReservaCadastro" runat="server" CssClass="form-control" ToolTip="Selecione a Viagem" placeholder="Selecione a Viagem"></asp:DropDownList>
                        <br />

            <!-- DropDownList para Cliente -->
            <asp:DropDownList ID="DropDownListClientePopupReservaCadastro" runat="server" CssClass="form-control" ToolTip="Selecione o Cliente" placeholder="Selecione o Cliente"></asp:DropDownList>
                        <br />

            <!-- DropDownList para Transporte -->
            <asp:DropDownList ID="DropDownListTransportePopupReservaCadastro" runat="server" CssClass="form-control" ToolTip="Selecione o Transporte" placeholder="Selecione o Transporte"></asp:DropDownList>
                        <br />

            <!-- DropDownList para Hospedagem -->
            <asp:DropDownList ID="DropDownListHospedagemPopupReservaCadastro" runat="server" CssClass="form-control" ToolTip="Selecione a Hospedagem" placeholder="Selecione a Hospedagem"></asp:DropDownList>

            <br />

            <!-- Outros campos de entrada e botões aqui -->

            <br />
            <asp:Button ID="BtnCadastrarPopupReservaCadastro" CssClass="btn btn-primary action-btn" runat="server" Text="Cadastrar Reserva" OnClick="BtnCadastrarReservaModal_Click" />
            <asp:Button ID="BtnEditarCadastroPopupReservaCadastro" CssClass="btn btn-primary action-btn" Visible="false" runat="server" Text="Editar Reserva" OnClick="BtnEditarCadastroPopupReservaCadastro_Click" />
            <asp:Button ID="btnCancelarPopupReservaCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary action-btn" OnClick="btnCancelarPopupReservaCadastro_Click" />
            <asp:Button ID="btnLimparPopupReservaCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary action-btn" OnClick="btnLimparPopupReservaCadastro_Click" />
        </div>
    </div>

    <div class="reserva-section">
        <h2>Reservas Cadastradas</h2>
        <hr />

        <!-- Campos de pesquisa e botão de pesquisa -->
        <div>
            <h4>Pesquisar Reserva</h4>
            <asp:TextBox ID="TbxPesquisarGridReservas" runat="server" CssClass="form-control" placeholder="Digite para pesquisar"></asp:TextBox>
            <br>
            <asp:Button ID="ImgBtnPesquisarGridReservas" runat="server" CssClass="btn btn-primary action-btn" Text="Pesquisar" />
        </div>

        <br />

        <!-- GridView para exibição de reservas -->
        <asp:GridView ID="GridViewReservas" runat="server" CssClass="table table-striped table-bordered table-condensed w-100"  CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_HPR_PK" OnPageIndexChanging="GridViewReservas_PageIndexChanging" OnRowDeleting="GridViewReservas_RowDeleting" OnSelectedIndexChanged="GridViewReservas_SelectedIndexChanged" OnSelectedIndexChanging="GridViewReservas_SelectedIndexChanging">
            <Columns>
                <asp:BoundField HeaderText="Viagem" DataField="NOME_VIAGEM" />
                <asp:BoundField HeaderText="Cliente" DataField="nome" />
                <asp:BoundField HeaderText="CPF" DataField="CPF" />
                <asp:BoundField HeaderText="Hospedagem" DataField="nome_hospedagem" />
                <asp:BoundField HeaderText="Transporte" DataField="nome_transporte" />
                <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btnEditar" UpdateText="Atualizar" SelectText="Editar" ShowSelectButton="True" HeaderText="Editar" />
                <asp:CommandField ButtonType="Button" InsertVisible="False" ShowDeleteButton="True" ControlStyle-CssClass="btnExcluir" HeaderText="Excluir" />
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
    </div>
        <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</asp:Content>
