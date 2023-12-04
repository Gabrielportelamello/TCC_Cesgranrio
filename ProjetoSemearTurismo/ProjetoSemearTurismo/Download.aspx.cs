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

namespace ProjetoSemearTurismo
{
    public partial class Download : System.Web.UI.Page
    {
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

                GVBing();


            }

        }
        protected void GVBing()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString);


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_VIAGEM ORDER BY NOME_VIAGEM", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();

            a.Fill(ds);

            gridViewExcel.DataSource = ds;
            gridViewExcel.DataBind();

            conn.Close();
            conn.Dispose();

        }

        private DataTable GridViewToDataTable(GridView gridView)
        {
            DataTable dt = new DataTable();

            // Adicione colunas ao DataTable com base nas colunas na GridView
            foreach (DataControlField column in gridView.Columns)
            {
                if (column is BoundField)
                {
                    BoundField boundField = column as BoundField;
                    dt.Columns.Add(boundField.HeaderText); // Use o HeaderText da coluna como nome da coluna
                }
            }

            // Adicione linhas ao DataTable com base nas linhas na GridView
            foreach (GridViewRow row in gridView.Rows)
            {
                DataRow dataRow = dt.NewRow();

                for (int i = 0; i < gridView.Columns.Count; i++)
                {
                    DataControlFieldCell cell = row.Cells[i] as DataControlFieldCell;

                    if (cell != null && cell.ContainingField is BoundField)
                    {
                        dataRow[i] = cell.Text;
                    }
                }

                dt.Rows.Add(dataRow);
            }

            return dt;
        }



        protected void btnGenerateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Dados");

                    // Adicione manualmente o cabeçalho
                    int headerIndex = 1;
                    foreach (TableCell cell in gridViewExcel.HeaderRow.Cells)
                    {
                        worksheet.Cells[1, headerIndex].Value = DecodeHtmlEntities(cell.Text); // Decodifique entidades HTML
                        headerIndex++;
                    }

                    // Defina o formato de célula para as colunas de data
                    using (ExcelRange dateColumn = worksheet.Cells["B2:B" + (gridViewExcel.Rows.Count + 1)])
                    {
                        dateColumn.Style.Numberformat.Format = "dd/MM/yyyy HH:mm:ss";
                    }

                    // Preencha a planilha do Excel com os dados da GridView
                    int rowIndex = 2;

                    // Loop pelas linhas da GridView
                    foreach (GridViewRow row in gridViewExcel.Rows)
                    {
                        int cellIndex = 1;

                        // Loop pelas células da linha
                        foreach (TableCell cell in row.Cells)
                        {
                            string cellText = DecodeHtmlEntities(cell.Text); // Decodifique entidades HTML

                            // Remova os espaços não quebráveis (&nbsp;)
                            cellText = cellText.Replace("&nbsp;", " ");

                            worksheet.Cells[rowIndex, cellIndex].Value = cellText;
                            cellIndex++;
                        }

                        rowIndex++;
                    }

                    // Configuração do tipo de resposta e nome do arquivo Excel
                    Response.Clear();
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.ContentEncoding = System.Text.Encoding.UTF8; // Configuração do charset
                    Response.AddHeader("Content-Disposition", "attachment; filename=sample.xlsx");

                    // Envie o arquivo Excel como resposta para o cliente
                    Response.BinaryWrite(package.GetAsByteArray());
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                // Lide com qualquer exceção aqui
                Response.Write("Erro ao gerar o arquivo Excel: " + ex.Message);
            }
        }



        private string DecodeHtmlEntities(string input)
        {
            // Decodifique entidades HTML
            return Regex.Replace(input, "&#\\d+;", match =>
            {
                int code;
                if (int.TryParse(match.Value.Substring(2, match.Value.Length - 3), out code))
                {
                    return char.ConvertFromUtf32(code);
                }
                return match.Value;
            });
        }



        protected void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurações do documento PDF
                Document doc = new Document();
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
                doc.Open();

                // Crie uma tabela para armazenar os dados da GridView
                PdfPTable table = new PdfPTable(gridViewExcel.HeaderRow.Cells.Count);
                table.WidthPercentage = 100;

                // Crie uma fonte personalizada para o cabeçalho
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font headerFont = new Font(baseFont, 12, Font.BOLD);

                // Adicione o cabeçalho da GridView à tabela
                foreach (TableCell cell in gridViewExcel.HeaderRow.Cells)
                {
                    PdfPCell pdfCell = new PdfPCell(new Phrase(HttpUtility.HtmlDecode(cell.Text), headerFont));
                    pdfCell.BackgroundColor = new BaseColor(gridViewExcel.HeaderStyle.BackColor);
                    table.AddCell(pdfCell);
                }

                // Crie uma fonte personalizada para os dados
                Font dataFont = new Font(baseFont, 10);

                // Adicione as linhas de dados da GridView à tabela
                foreach (GridViewRow row in gridViewExcel.Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        PdfPCell pdfCell = new PdfPCell(new Phrase(HttpUtility.HtmlDecode(cell.Text), dataFont));
                        table.AddCell(pdfCell);
                    }
                }

                // Adicione a tabela ao documento PDF
                doc.Add(table);

                // Feche o documento
                doc.Close();

                // Configuração do tipo de resposta e nome do arquivo PDF
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "attachment; filename=sample.pdf");

                // Especifique o charset como UTF-8
                Response.ContentEncoding = System.Text.Encoding.UTF8;

                // Envie o arquivo PDF como resposta para o cliente
                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                // Lide com qualquer exceção aqui
                Response.Write("Erro ao gerar o arquivo PDF: " + ex.Message);
            }
        }

        protected void ddlSelectTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlSelectTipoRelatorio.SelectedValue)
            {
                case "0":
                    GVBing();
                    break;
                case "1":
                    GVBing();
                    break;
                case "2":
                    GVBing();
                    break;
                case "3":
                    GVBing();
                    break;
                case "4":
                    GVBing();
                    break;
                case "5":
                    GVBing();
                    break;
            }
        }

        protected void ddlSelectTipoRelatorio_TextChanged(object sender, EventArgs e)
        {
            switch (ddlSelectTipoRelatorio.SelectedValue)
            {
                case "0":
                    GVBing();
                    break;
                case "1":
                    GVBing();
                    break;
                case "2":
                    GVBing();
                    break;
                case "3":
                    GVBing();
                    break;
                case "4":
                    GVBing();
                    break;
                case "5":
                    GVBing();
                    break;
            }
        }
    }
}