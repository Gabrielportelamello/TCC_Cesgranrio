<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Relatorio.aspx.cs" Inherits="ProjetoSemearTurismo.Relatorio" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Relatório</title>
    <!-- Inclua os links para os scripts necessários (Chart.js) aqui -->
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Adicione um elemento canvas para o gráfico -->
            <canvas id="meuGrafico" width="400" height="200"></canvas>
        </div>
    </form>

    <script>
        // Obtém os dados do servidor e renderiza o gráfico
        renderizarGrafico(<%= ObterDadosGrafico() %>);

        function renderizarGrafico(dados) {
            var ctx = document.getElementById('meuGrafico').getContext('2d');

            var meuGrafico = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: dados.labels,
                    datasets: [{
                        label: 'Reservas por Data',
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
</body>
</html>