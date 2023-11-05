<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Relatorio.aspx.cs" Inherits="ProjetoSemearTurismo.Relatorio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- ... (seu código atual) ... -->

    <div id="DivRelatorioReservas" class="row">
        <div class="col-md-6">
            <h2>Filtros </h2>
            <asp:TextBox runat="server" ID="txtFiltroNome"></asp:TextBox>
            <asp:DropDownList ID="ddlCpf" runat="server" />          
            <%--<asp:Button ID="btnFiltrarDdlNome" runat="server" Text="Gerar Excel" OnClick="btnGenerateExcel_Click" CssClass="btn btn-default w-100" />--%>
        </div>
        <div class="col-md-6">
        <%--    <h2>Visualizar PDF</h2>--%>
            <%--<iframe id="iframePDF" runat="server" style="width:100%; height:500px;"></iframe>--%>
            <%--<asp:Button ID="btnGeneratePDF" runat="server" Text="Gerar PDF" OnClick="btnGeneratePDF_Click" CssClass="btn btn-default" />--%>
        </div>
    </div>

    <div id="DivRelatorioClientes" class="row">
        <div class="col-md-6">
            <h2>Visualizar Viagens em Excel e PDF</h2>
            <asp:GridView ID="gridViewExcel" runat="server" AutoGenerateColumns="true" CssClass="table table-striped table-bordered table-condensed w-100"></asp:GridView>
            <asp:Button ID="btnGenerateExcelClientes" runat="server" Text="Gerar Excel" OnClick="btnGenerateExcel_Click" CssClass="btn btn-default w-100" />
           <asp:Button ID="btnGeneratePDFClientes" runat="server" Text="Gerar PDF" OnClick="btnGeneratePDF_Click" CssClass="btn btn-default w-100" />

            <%--<asp:Button ID="btnSaveExcel" runat="server" Text="Gerar Excel" OnClick="btnSaveExcel_Click" CssClass="btn btn-default" />--%>
        </div>
        <div class="col-md-6">
            <%--<h2>Visualizar PDF</h2>--%>
            <%--<iframe id="iframePDFClientes" runat="server" style="width:100%; height:500px;"></iframe>--%>
        </div>
    </div>

   <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</asp:Content>