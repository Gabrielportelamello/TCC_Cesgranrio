<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Relatorio.aspx.cs" Inherits="ProjetoSemearTurismo.Relatorio" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
        <br />

        <h2 style="text-align: center;">Relatório</h2>

    <div id="form1" runat="server">
        <div>
                <label for="dataInicial">Data Inicial:</label>
                <asp:TextBox ID="dataInicial" runat="server" Text="2020-11-10" type="date"></asp:TextBox>

            
           <label for="dataFinal">Data Final:</label>
    <asp:TextBox ID="dataFinal" runat="server" Text="2024-11-20" type="date"></asp:TextBox>
          

            <asp:Button ID="btnBuscar" runat="server" Text="Gerar Relatório" OnClick="btnBuscar_Click" />
            
            <canvas id="meuGrafico" width="400" height="200"></canvas>
        </div>
    </div>

    <script>
 

        function renderizarGrafico(dados) {
            var ctx = document.getElementById('meuGrafico').getContext('2d');

            var meuGrafico = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: dados.labels,
                    datasets: [{
                        label: 'Quantidade de reservas por Viagem',
                        data: dados.datasets[0].data,
                        backgroundColor: 'rgba(75, 192, 192, 0.2)',
                        borderColor: 'rgba(75, 192, 192, 1)',
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        }
    </script>

    </asp:Content>