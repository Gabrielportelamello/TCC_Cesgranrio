using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSemearTurismo.Views
{
    public partial class Hospedagem : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewHospedagems.SelectedIndex = -1;
            if (!IsPostBack)
            {

                GridViewHospedagems.SelectedIndex = -1;

                if (TbxPesquisarGridHospedagems.Text != "")
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
            //      SELECT[SEQ_HOSPEDAGEM]
            //,[Nome]
            //,[Endereco]
            //,[CNPJ]
            //,[Telefones]
            //,[Email]
            //,[CEP]
            //,[qtd_quartos]
            //,[qtd_camas]
            //,[tipo_cama]
            //,[pacote_incluso]
            //,[data_checkin]
            //,[data_checkout]
            //,[preco]
            //      FROM[dbo].[SEMEAR_HOSPEDAGEM_TEMP]

            SqlConnection conn = new SqlConnection(connectionString);


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_HOSPEDAGEM_TEMP WHERE (fl_excluido != 1 OR fl_excluido IS NULL)  ORDER BY NOME", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewHospedagems.DataSource = ds;
            GridViewHospedagems.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void GridViewHospedagems_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (TbxPesquisarGridHospedagems.Text != "")
            {
                GVBingSearch();
                GridViewHospedagems.PageIndex = e.NewPageIndex;
                GridViewHospedagems.DataBind();
            }
            else
            {
                GVBing();
                GridViewHospedagems.PageIndex = e.NewPageIndex;
                GridViewHospedagems.DataBind();
            }

        }

        protected void GridViewHospedagems_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            // Obtém o índice da linha sendo deletada
            string indiceRegistro = GridViewHospedagems.DataKeys[e.RowIndex].Value.ToString();

            // Atualiza o banco de dados com a data de exclusão
            AtualizarDataExclusao(indiceRegistro);

            if (!string.IsNullOrEmpty(TbxPesquisarGridHospedagems.Text))
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
                string updateQuery = "UPDATE [dbo].[SEMEAR_HOSPEDAGEM_TEMP] " +
                                     "SET [FL_EXCLUIDO] = 1 " +
                                     "WHERE SEQ_HOSPEDAGEM = " + indiceRegistro;

                using (SqlCommand queryUpdate = new SqlCommand(updateQuery))
                {
                    queryUpdate.Connection = openCon;

                    openCon.Open();
                    queryUpdate.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewHospedagems_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridViewHospedagems_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sIndiceRegistro = GridViewHospedagems.SelectedDataKey.Value.ToString();

            preencheFrmEdicao(sIndiceRegistro);

            MPEHospedagemsGRID.Show();

            BtnCadastrarPopupHospedagemCadastro.Visible = false;
            BtnEditarCadastroPopupHospedagemCadastro.Visible = true;
            btnLimparPopupHospedagemCadastro.Visible = false;


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
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_HOSPEDAGEM_TEMP where SEQ_Hospedagem = " + sIndiceRegistro, conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds, "SEMEAR_HOSPEDAGEM_TEMP");
            //continnuar daqui.
            foreach (DataRow r in ds.Tables["SEMEAR_HOSPEDAGEM_TEMP"].Rows)
            {
                TbxNomePopupHospedagemCadastro.Text = r["NOME"].ToString();
                TbxRuaPopupHospedagemCadastro.Text = r["Endereco"].ToString();
               
                TbxCEPPopupHospedagemCadastro.Text = r["CEP"].ToString();
                TbxCNPJPopupHospedagemCadastro.Text = r["CNPJ"].ToString();

                if (!string.IsNullOrEmpty(r["data_checkin"].ToString()))
                {
                    TbxChekinPopupHospedagemCadastro.Text = r["data_checkin"].ToString().Substring(6, 4) + "-" + r["data_checkin"].ToString().Substring(3, 2) + "-" + r["data_checkin"].ToString().Substring(0, 2);

                }


                if (!string.IsNullOrEmpty(r["data_checkout"].ToString()))
                {
                    TbxChekoutPopupHospedagemCadastro.Text = r["data_checkout"].ToString().Substring(6, 4) + "-" + r["data_checkout"].ToString().Substring(3, 2) + "-" + r["data_checkout"].ToString().Substring(0, 2);

                }
                
               
                TbxTel1PopupHospedagemCadastro.Text = r["Telefones"].ToString();
                TbxEmailPopupHospedagemCadastro.Text = r["Email"].ToString();
                TbxPrecoPopupHospedagemCadastro.Text = r["preco"].ToString();
                TbxQTDQuartosPopupHospedagemCadastro.Text = r["qtd_quartos"].ToString();
            }



            conn.Close();
            conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }


        protected void BtnCadastrarHospedagemModal_Click(object sender, EventArgs e)
        {
            if (TbxNomePopupHospedagemCadastro.Text != "" && TbxCNPJPopupHospedagemCadastro.Text != ""
                && TbxTel1PopupHospedagemCadastro.Text != "")
            {
                RealizaCadastroHospedagem();
                RealizaCadastroImagensHospedagem();
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

        private void RealizaCadastroImagensHospedagem()
        {

        }

        private void RealizaCadastroHospedagem()
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = "INSERT INTO[dbo].[SEMEAR_HOSPEDAGEM_TEMP] " +
           "(" +
         "[Nome]" +
         ",[Endereco]" +
         ",[CNPJ]" +
         ",[Telefones]" +
         ",[Email]" +
         ",[CEP]" +
         ",[qtd_quartos]" +
         ",[data_checkin]" +
         ",[data_checkout]" +
         ",[preco])" +
    " VALUES " +
         "(" +
         "'" + TbxNomePopupHospedagemCadastro.Text + "'" +
         " ,'" + TbxRuaPopupHospedagemCadastro.Text + "'" +
         " ,'" + TbxCNPJPopupHospedagemCadastro.Text + "'" +
         " ,'" + TbxTel1PopupHospedagemCadastro.Text + "'" +
         " ,'" + TbxEmailPopupHospedagemCadastro.Text + "'" +
          ",'" + TbxCEPPopupHospedagemCadastro.Text + "'" +
          "," + TbxQTDQuartosPopupHospedagemCadastro.Text +
        ",(Select CONVERT(datetime,'" + TbxChekinPopupHospedagemCadastro.Text + "',20)) " +
        ", (Select CONVERT(datetime,'" + TbxChekoutPopupHospedagemCadastro.Text + "',20))" +
          "," + TbxPrecoPopupHospedagemCadastro.Text + ")";



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
        private void RealizaEdicaoCadastroHospedagem(string indiceRegistro)
        {
          
            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = "UPDATE[dbo].[SEMEAR_HOSPEDAGEM_TEMP] " +
                                    "SET " +
                                       "[Nome] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                       ",[Endereco] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                       ",[CNPJ] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                       ",[Telefones] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[Email] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[CEP] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[qtd_quartos] = " + TbxQTDQuartosPopupHospedagemCadastro.Text +
                                       ",[data_checkin] = (Select CONVERT(datetime,'" + TbxChekinPopupHospedagemCadastro.Text + "',20)) " +
                                       ",[data_checkout] = (Select CONVERT(datetime,'" + TbxChekoutPopupHospedagemCadastro.Text + "',20)) " +
                                       ",[preco] = " + TbxPrecoPopupHospedagemCadastro.Text +

                " WHERE SEQ_Hospedagem = " + indiceRegistro;


                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }
            }


            if (TbxPesquisarGridHospedagems.Text != "")
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

        protected void ImgBtnPesquisarGridHospedagems_Click(object sender, ImageClickEventArgs e)
        {
            if (TbxPesquisarGridHospedagems.Text != "")
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

            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_HOSPEDAGEM_TEMP where (fl_excluido != 1 OR fl_excluido IS NULL) AND Nome LIKE '%" + TbxPesquisarGridHospedagems.Text + "%' ORDER BY Nome", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewHospedagems.DataSource = ds;
            GridViewHospedagems.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void DropDownListFuncionarioPopupHospedagemCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void DropDownListFuncionarioPopupHospedagemCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnEditarCadastroPopupHospedagemCadastro_Click(object sender, EventArgs e)
        {
            string sIndiceRegistro = GridViewHospedagems.SelectedDataKey.Value.ToString();
            RealizaEdicaoCadastroHospedagem(sIndiceRegistro);

            if (TbxPesquisarGridHospedagems.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
            GridViewHospedagems.SelectedIndex = -1;
        }

        protected void BtnModalHospedagemsGRID_Click(object sender, EventArgs e)
        {
            MPEHospedagemsGRID.Show();
            BtnCadastrarPopupHospedagemCadastro.Visible = true;
            BtnEditarCadastroPopupHospedagemCadastro.Visible = false;
            btnLimparPopupHospedagemCadastro.Visible = true;
        }

        protected void btnCancelarPopupHospedagemCadastro_Click(object sender, EventArgs e)
        {
            GridViewHospedagems.SelectedIndex = -1;

            
                limparCadastro();

            
        }

        private void limparCadastro()
        {
            TbxNomePopupHospedagemCadastro.Text = "";
            TbxTel1PopupHospedagemCadastro.Text = "";
            TbxEmailPopupHospedagemCadastro.Text = "";

            TbxChekinPopupHospedagemCadastro.Text = "";
            TbxChekoutPopupHospedagemCadastro.Text = "";
            TbxQTDQuartosPopupHospedagemCadastro.Text = "";

            TbxPrecoPopupHospedagemCadastro.Text = "";
            DropDownListFlagExcluidoPopupHospedagemCadastro.SelectedValue = "0";
          
            TbxRuaPopupHospedagemCadastro.Text = "";
            TbxCEPPopupHospedagemCadastro.Text = "";
            GridViewHospedagems.SelectedIndex = -1;
            TbxCNPJPopupHospedagemCadastro.Text = "";
           




        }

        protected void btnLimparPopupHospedagemCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }
    }
}