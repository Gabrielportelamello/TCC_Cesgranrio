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

                if (TbxPesquisarGridTransporte.Text != "")
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


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE ORDER BY SQ_TRANSPORTE", conn);
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
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE where SQ_TRANSPORTE = " + sIndiceRegistro, conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds, "SEMEAR_TRANSPORTE");
            //continnuar daqui.
            foreach (DataRow r in ds.Tables["SEMEAR_TRANSPORTE"].Rows)
            {


                TbxNomePopupTransporteCadastro.Text = r["SQ_TRANSPORTE"].ToString();

              
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
            if ( TbxCNPJPopupTransporteCadastro.Text != ""
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

                string saveStaff = "INSERT INTO [dbo].[SEMEAR_TRANSPORTE] " +
               "([CNPJ]" +
                        " ,[Endereco]" +
                         ",[Telefones]" +
                          ",[Email]" +
                          ",[CEP]" +
                         ",[QTD_Assentos]" +                        
                         ",[Preco]" +
                         ")" +
    " VALUES ('" +
           TbxCNPJPopupTransporteCadastro.Text +
          "','" + TbxEnderecoPopupTransporteCadastro.Text +
          "','" + TbxTel1PopupTransporteCadastro.Text +
          "','" + TbxEmailPopupTransporteCadastro.Text +
          "','" + TbxCEPPopupTransporteCadastro.Text+
          "',"+TbxQTDAssentosPopupTransporteCadastro.Text+
           ","+ TbxPrecosPopupTransporteCadastro.Text +
           ")";

              
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

            "UPDATE[dbo].[SEMEAR_TRANSPORTE]"+
                "SET[CNPJ] = "+TbxCNPJPopupTransporteCadastro.Text+
     ",[Endereco] = "+TbxEnderecoPopupTransporteCadastro.Text+
     ",[Telefones] = "+TbxTel1PopupTransporteCadastro.Text+
      ",[Email] = "+TbxEmailPopupTransporteCadastro.Text+
      ",[CEP] = "+TbxCEPPopupTransporteCadastro.Text+
      ",[QTD_Assentos] = "+TbxQTDAssentosPopupTransporteCadastro.Text+
   ",[Preco] = "+TbxPrecosPopupTransporteCadastro.Text+
    " WHERE SQ_TRANSPORTE = " + indiceRegistro + " ";



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

            //SqlConnection conn = new SqlConnection(connectionString);

            //SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_TRANSPORTE where Nome LIKE '%" + TbxPesquisarGridTransporte.Text + "%' ORDER BY Nome", conn);
            //conn.Open();
            //SqlCommandBuilder builder = new SqlCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds);

            //GridViewTransporte.DataSource = ds;
            //GridViewTransporte.DataBind();

            //conn.Close();
            //conn.Dispose();

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