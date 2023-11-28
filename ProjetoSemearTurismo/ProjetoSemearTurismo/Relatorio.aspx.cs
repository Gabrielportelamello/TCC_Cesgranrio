using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System.Text.RegularExpressions;
using TableCell = System.Web.UI.WebControls.TableCell;
using Font = iTextSharp.text.Font;
using Newtonsoft.Json;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace ProjetoSemearTurismo
{
    public partial class Relatorio : System.Web.UI.Page
    {


        // ... Seu código existente ...
        protected void Application_Start(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Rest of your Application_Start code
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ObterDadosGrafico(dataInicial.Text, dataFinal.Text);
            }

        }
        //string dataInicial, string dataFinal
        protected string ObterDadosGrafico(string dataInicial, string dataFinal)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;
                // Consulta SQL para obter dados do banco de dados
                string query = "SELECT NOME_VIAGEM, COUNT(*) AS QtdReservas FROM SEMEAR_ASSOCIATIVA_VPR " +
                               "INNER JOIN SEMEAR_VIAGEM ON SEMEAR_ASSOCIATIVA_VPR.SQ_VIAGEM_FK = SEMEAR_VIAGEM.SQ_VIAGEM " +
                               "WHERE DT_INCLUSAO BETWEEN @DataInicial AND @DataFinal " +
                               "GROUP BY NOME_VIAGEM";

                // Lista para armazenar os resultados da consulta
                List<string> labels = new List<string>();
                List<int> data = new List<int>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parâmetros para a consulta SQL
                        command.Parameters.AddWithValue("@DataInicial", DateTime.Parse(dataInicial));
                        command.Parameters.AddWithValue("@DataFinal", DateTime.Parse(dataFinal));

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                labels.Add(reader["NOME_VIAGEM"].ToString());
                                data.Add(Convert.ToInt32(reader["QtdReservas"]));
                            }
                        }
                    }
                }
                // Formata os dados em um objeto para ser convertido em JSON
                var result = new
                {
                    labels = labels,
                    datasets = new List<object> { new { data = data } }
                };
                // Converte o objeto em formato JSON
                string jsonResult = new JavaScriptSerializer().Serialize(result);
                // Chame a função JavaScript para renderizar o gráfico
                ScriptManager.RegisterStartupScript(this, GetType(), "renderizarGrafico", "renderizarGrafico(" + jsonResult + ")", true);

                return "";
            }
            catch
            {
                return "";

            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            ObterDadosGrafico(dataInicial.Text, dataFinal.Text);
        }
    }
}