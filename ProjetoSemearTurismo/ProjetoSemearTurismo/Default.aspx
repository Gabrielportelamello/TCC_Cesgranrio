<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoSemearTurismo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Semear Turismo</h2>
        <p class="lead">Sistema de Gerenciamento de Viagens Semear Turismo. Gerencie o cadastro de clientes, transportes, hospedagens, viagens e reservas em um só lugar.</p>
        <p><a runat="server" href="~/Viagem" class="btn btn-primary btn-lg">Viagens &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Clientes</h2>
            <p> O gerenciamento de clientes permite cadastrar, editar e excluir os clientes e funcionarios da empresa.
                
                </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Cliente">Clientes &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Reservas </h2>
            <p>
               Local de gerenciamento de reservas feitas por clientes, status de pagamento de cada reserva, inclusao e cancelamento de reservas.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Reserva">Reservas &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Viagens</h2>
            <p>
                O gerenciamento de Viagens permite cadastrar, editar e excluir Viagens </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Viagem">Viagens &raquo;</a>
            </p>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Transportes</h2>
            <p> O gerenciamento de transportes permite cadastrar, editar e excluir os transportes que atenderão os clientes.
                
                </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Transporte">Transportes &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Hospedagem  </h2>
            <p>
               Local de gerenciamento de hospedagem de cada viagem .
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Hospedagem">Hospedagens &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Relatórios</h2>
            <p>
                O gerenciamento de Viagens permite cadastrar, editar e excluir Viagens </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Viagem">Viagens &raquo;</a>
            </p>
        </div>
    </div>
    
     
</asp:Content>
