using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSemearTurismo
{
    public partial class Transporte : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewTransporte.SelectedIndex = -1;
            if (!IsPostBack)
            {

                GridViewTransporte.SelectedIndex = -1;

                if (!string.IsNullOrEmpty(TbxPesquisarGridTransporte.Text))
                {
                    GVBingSearch();
                }
                else
                {
                    GVBing();
                }
            }
        }


        protected void GVBing()
        {

            SqlConnection conn = new SqlConnection(connectionString);


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE_TEMP WHERE (fl_excluido != 1 OR fl_excluido IS NULL)   ORDER BY SQ_TRANSPORTE", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewTransporte.DataSource = ds;
            GridViewTransporte.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void GridViewTransporte_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (TbxPesquisarGridTransporte.Text != "")
            {
                GVBingSearch();
                GridViewTransporte.PageIndex = e.NewPageIndex;
                GridViewTransporte.DataBind();
            }
            else
            {
                GVBing();
                GridViewTransporte.PageIndex = e.NewPageIndex;
                GridViewTransporte.DataBind();
            }

        }

        protected void GridViewTransporte_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            // Obtém o índice da linha sendo deletada
            string indiceRegistro = GridViewTransporte.DataKeys[e.RowIndex].Value.ToString();

            // Atualiza o banco de dados com a data de exclusão
            AtualizarDataExclusao(indiceRegistro);

            if (!string.IsNullOrEmpty(TbxPesquisarGridTransporte.Text))
            {
                GVBingSearch();


            }
            else
            {
                GVBing();

            }
            // Resto do seu código para a exclusão da linha no GridView
        }

        private void AtualizarDataExclusao(string indiceRegistro)
        {
            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE [dbo].[SEMEAR_TRANSPORTE_TEMP] " +
                                     "SET [FL_EXCLUIDO] = 1 " +
                                     "WHERE SQ_TRANSPORTE = " + indiceRegistro;

                using (SqlCommand queryUpdate = new SqlCommand(updateQuery))
                {
                    queryUpdate.Connection = openCon;

                    openCon.Open();
                    queryUpdate.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewTransporte_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridViewTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sIndiceRegistro = GridViewTransporte.SelectedDataKey.Value.ToString();

            preencheFrmEdicao(sIndiceRegistro);

            MPETransporteGRID.Show();

            BtnCadastrarPopupTransporteCadastro.Visible = false;
            BtnEditarCadastroPopupTransporteCadastro.Visible = true;
            btnLimparPopupTransporteCadastro.Visible = false;


        }

        private void preencheFrmEdicao(string sIndiceRegistro)
        {
            if (sIndiceRegistro != null)
            {
                try { preencheFormEdicao(sIndiceRegistro); } catch { }

            }

        }
        private void preencheFormEdicao(string sIndiceRegistro)
        {
            //limpaCadastroEdicao();
            string oradb = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(oradb);
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE_TEMP where  SQ_TRANSPORTE = " + sIndiceRegistro, conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds, "SEMEAR_TRANSPORTE_TEMP");
            //continnuar daqui.
            foreach (DataRow r in ds.Tables["SEMEAR_TRANSPORTE_TEMP"].Rows)
            {


                hdnLblIDselecionado.Text = r["SQ_TRANSPORTE"].ToString();
                TbxNomePopupTransporteCadastro.Text = r["NOME"].ToString();
                TbxCNPJPopupTransporteCadastro.Text = r["CNPJ"].ToString();
                TbxEnderecoPopupTransporteCadastro.Text = r["ENDERECO"].ToString();
                TbxTel1PopupTransporteCadastro.Text = r["TELEFONES"].ToString();
                TbxEmailPopupTransporteCadastro.Text = r["EMAIL"].ToString();
                TbxQTDAssentosPopupTransporteCadastro.Text = r["QTD_Assentos"].ToString();
                TbxCEPPopupTransporteCadastro.Text = r["CEP"].ToString();
                TbxPrecosPopupTransporteCadastro.Text = r["Preco"].ToString();


            }



            conn.Close();
            conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }


        protected void BtnCadastrarTransporteModal_Click(object sender, EventArgs e)
        {
            if (TbxCNPJPopupTransporteCadastro.Text != ""
                && TbxTel1PopupTransporteCadastro.Text != "")
            {
                RealizaCadastroTransporte();
                RealizaCadastroImagensTransporte();
            }
            else
            {
                //mbox
            }
        }

        private void RealizaCadastroImagensFuncionario()
        {

        }

        private void RealizaCadastroFuncionario()
        {

        }

        private void RealizaCadastroImagensTransporte()
        {

        }

        private void RealizaCadastroTransporte()
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {

                string saveStaff = "INSERT INTO [dbo].[SEMEAR_TRANSPORTE_TEMP] " +
               "(" +
               "[NOME]" +
               ",[CNPJ]" +
                        " ,[Endereco]" +
                         ",[Telefones]" +
                          ",[Email]" +
                          ",[CEP]" +
                         ",[QTD_Assentos]" +
                         ",[Preco]" +
                         ")" +
                    " VALUES ('" +
                   TbxNomePopupTransporteCadastro.Text +
                  "','" + TbxCNPJPopupTransporteCadastro.Text +
                  "','" + TbxEnderecoPopupTransporteCadastro.Text +
                  "','" + TbxTel1PopupTransporteCadastro.Text +
                  "','" + TbxEmailPopupTransporteCadastro.Text +
                  "','" + TbxCEPPopupTransporteCadastro.Text;

                if (string.IsNullOrEmpty(TbxQTDAssentosPopupTransporteCadastro.Text))
                {
                    saveStaff += "',0";

                }
                else
                {
                    saveStaff += "'," + TbxQTDAssentosPopupTransporteCadastro.Text;

                }

                if (string.IsNullOrEmpty(TbxPrecosPopupTransporteCadastro.Text))
                {
                    saveStaff += ",0";

                }
                else
                {
                    saveStaff += "," + TbxPrecosPopupTransporteCadastro.Text;

                }
                saveStaff += ")";


                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }

            }


            GVBing();
        }
        private void RealizaEdicaoCadastroTransporte(string indiceRegistro)
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {



                string saveStaff =

                "UPDATE[dbo].[SEMEAR_TRANSPORTE_TEMP]" +
                "SET" +
                "[NOME] = '" + TbxNomePopupTransporteCadastro.Text +
                "',[CNPJ] = '" + TbxCNPJPopupTransporteCadastro.Text +
                 "',[Endereco] = '" + TbxEnderecoPopupTransporteCadastro.Text +
                 "',[Telefones] = '" + TbxTel1PopupTransporteCadastro.Text +
                  "',[Email] = '" + TbxEmailPopupTransporteCadastro.Text +
                  "',[CEP] = '" + TbxCEPPopupTransporteCadastro.Text;
                if (string.IsNullOrEmpty(TbxQTDAssentosPopupTransporteCadastro.Text))
                {
                    saveStaff += "',[QTD_Assentos] = 0";

                }
                else
                {
                    saveStaff += "',[QTD_Assentos] = " + TbxQTDAssentosPopupTransporteCadastro.Text;

                }

                if (string.IsNullOrEmpty(TbxPrecosPopupTransporteCadastro.Text))
                {
                    saveStaff += ",[Preco] = 0";

                }
                else
                {
                    saveStaff += ",[Preco] = " + TbxPrecosPopupTransporteCadastro.Text;

                }

                saveStaff += " WHERE SQ_TRANSPORTE = " + indiceRegistro + " ";



                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }
            }


            if (TbxPesquisarGridTransporte.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
        }

        private void preencheVazioComNull()
        {

        }
        private void preencheNullComVazio()
        {

        }

        protected void ImgBtnPesquisarGridTransporte_Click(object sender, ImageClickEventArgs e)
        {
            if (TbxPesquisarGridTransporte.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
        }
        protected void GVBingSearch()
        {

            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE_TEMP where (fl_excluido != 1 OR fl_excluido IS NULL)  and Nome LIKE '%" + TbxPesquisarGridTransporte.Text + "%' ORDER BY Nome", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewTransporte.DataSource = ds;
            GridViewTransporte.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void DropDownListFuncionarioPopupTransporteCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void DropDownListFuncionarioPopupTransporteCadastro_TextChanged(object sender, EventArgs e)
        {
        }

        protected void BtnEditarCadastroPopupTransporteCadastro_Click(object sender, EventArgs e)
        {
            string sIndiceRegistro = GridViewTransporte.SelectedDataKey.Value.ToString();
            RealizaEdicaoCadastroTransporte(sIndiceRegistro);

            //if (TbxPesquisarGridTransporte.Text != "")
            //{
            //    GVBingSearch();
            //}
            //else
            //{
            GVBing();
            //}
            GridViewTransporte.SelectedIndex = -1;
        }

        protected void BtnModalTransporteGRID_Click(object sender, EventArgs e)
        {
            MPETransporteGRID.Show();
            BtnCadastrarPopupTransporteCadastro.Visible = true;
            BtnEditarCadastroPopupTransporteCadastro.Visible = false;
            btnLimparPopupTransporteCadastro.Visible = true;
        }

        protected void btnCancelarPopupTransporteCadastro_Click(object sender, EventArgs e)
        {
            GridViewTransporte.SelectedIndex = -1;

            if (BtnEditarCadastroPopupTransporteCadastro.Visible == true)
            {
                limparCadastro();

            }
        }

        private void limparCadastro()
        {
            TbxNomePopupTransporteCadastro.Text = "";
            TbxTel1PopupTransporteCadastro.Text = "";
            TbxEmailPopupTransporteCadastro.Text = "";

            TbxCNPJPopupTransporteCadastro.Text = "";

            DropDownListFlagExcluidoPopupTransporteCadastro.SelectedValue = "0";

            TbxCEPPopupTransporteCadastro.Text = "";
            GridViewTransporte.SelectedIndex = -1;


        }

        protected void btnLimparPopupTransporteCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }
    }
}