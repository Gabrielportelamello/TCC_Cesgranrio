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


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_HOSPEDAGEM_TEMP ORDER BY NOME", conn);
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

                //TbxTel1PopupHospedagemCadastro.Text = r["Telefone"].ToString();

                //TbxEmailPopupHospedagemCadastro.Text = r["Email"].ToString();

                //if (r["Data_Nascimento"].ToString() != "")
                //{
                //    TbxNascimentoPopupHospedagemCadastro.Text = r["Data_Nascimento"].ToString().Substring(6, 4) + "-" + r["Data_Nascimento"].ToString().Substring(3, 2) + "-" + r["Data_Nascimento"].ToString().Substring(0, 2);

                //}

                //TbxCPFPopupHospedagemCadastro.Text = r["CPF"].ToString();
                //TbxNumPassPopupHospedagemCadastro.Text = r["Passaporte"].ToString();

                //if (r["emissao_passaporte"].ToString() != "")
                //{
                //    TbxDataEmissPassPopupHospedagemCadastro.Text = r["emissao_passaporte"].ToString().Substring(6, 4) + "-" + r["emissao_passaporte"].ToString().Substring(3, 2) + "-" + r["emissao_passaporte"].ToString().Substring(0, 2);

                //}
                //if (r["Validade_Passaporte"].ToString() != "")
                //{
                //    TbxDataValiPassPopupHospedagemCadastro.Text = r["Validade_Passaporte"].ToString().Substring(6, 4) + "-" + r["Validade_Passaporte"].ToString().Substring(3, 2) + "-" + r["Validade_Passaporte"].ToString().Substring(0, 2);

                //}

                //TbxNumRGPopupHospedagemCadastro.Text = r["RG"].ToString();
                ////,[orgao_emissor_RG]
                ////,[data_emissao_RG]
                ////,[Perfil_Acesso]
                ////,[salario]
                ////,[Saldo]
                ////,[FL_FUNCIONARIO]
                ////,[FL_EXCLUIDO]
                ////,[bairro_endereco]
                ////,[cidade_endereco]
                ////,[uf_endereco]
                ////,[rua_endereco]
                ////,[CEP]
                ////,[SQ_Hospedagem]
                ////          FROM[tailandia].[dbo].[SEMEAR_HOSPEDAGEM_TEMP]
                //TbxOrgaoEmissorPopupHospedagemCadastro.Text = r["orgao_emissor_RG"].ToString();
                //string resulta = r["data_emissao_RG"].ToString();

                //if (r["data_emissao_RG"].ToString() != "")
                //{
                //    TbxDataEmissRGPopupHospedagemCadastro.Text = r["data_emissao_RG"].ToString().Substring(6, 4) + "-" + r["data_emissao_RG"].ToString().Substring(3, 2) + "-" + r["data_emissao_RG"].ToString().Substring(0, 2);
                //}

                ////TbxNumRGPopupHospedagemCadastro.Text = r["Saldo"].ToString();
                //DropDownListFuncionarioPopupHospedagemCadastro.SelectedValue = r["FL_FUNCIONARIO"].ToString();
                ////.Text = r["FL_EXCLUIDO"].ToString();
                TbxBairroPopupHospedagemCadastro.Text = r["bairro_endereco"].ToString();
                TbxCidadePopupHospedagemCadastro.Text = r["cidade_endereco"].ToString();
                TbxUFPopupHospedagemCadastro.Text = r["uf_endereco"].ToString();
                TbxRuaPopupHospedagemCadastro.Text = r["rua_endereco"].ToString();
                TbxCEPPopupHospedagemCadastro.Text = r["CEP"].ToString();



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
         "'"+TbxNomePopupHospedagemCadastro.Text+"'" +
         " ,'"+TbxRuaPopupHospedagemCadastro.Text+"'" +
         " ,'"+TbxCNPJPopupHospedagemCadastro.Text+"'" +
         " ,'"+TbxTel1PopupHospedagemCadastro.Text+"'" +
         " ,'"+TbxEmailPopupHospedagemCadastro.Text+"'" +
          ",'"+TbxCEPPopupHospedagemCadastro.Text+"'" +
          ","+TbxQTDQuartosPopupHospedagemCadastro.Text+
        ",(Select CONVERT(datetime,'" + TbxChekinPopupHospedagemCadastro.Text + "',20)) "+
        ", (Select CONVERT(datetime,'" + TbxChekoutPopupHospedagemCadastro.Text + "',20))" +
          ","+TbxPrecoPopupHospedagemCadastro.Text+")";



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
  //          UPDATE[dbo].[SEMEAR_HOSPEDAGEM_TEMP]
  // SET[SEQ_HOSPEDAGEM] = < SEQ_HOSPEDAGEM, bigint,>
  //    ,[Nome] = < Nome, varchar(250),>
  //    ,[Endereco] = < Endereco, varchar(max),>
  //    ,[CNPJ] = < CNPJ, varchar(50),>
  //    ,[Telefones] = < Telefones, varchar(50),>
  //    ,[Email] = < Email, varchar(max),>
  //    ,[CEP] = < CEP, varchar(50),>
  //    ,[qtd_quartos] = < qtd_quartos, int,>
  //    ,[qtd_camas] = < qtd_camas, int,>
  //    ,[tipo_cama] = < tipo_cama, smallint,>
  //    ,[pacote_incluso] = < pacote_incluso, varchar(max),>
  //    ,[data_checkin] = < data_checkin, datetime,>
  //    ,[data_checkout] = < data_checkout, datetime,>
  //    ,[preco] = < preco, float,>
  //WHERE < Critérios de Pesquisa,,>
            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = "UPDATE[dbo].[SEMEAR_HOSPEDAGEM_TEMP] "+
                                    "SET "+
                                       "[Nome] = '"+TbxNomePopupHospedagemCadastro.Text+"' "+
                                       ",[Endereco] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                       ",[CNPJ] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                       ",[Telefones] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[Email] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[CEP] = '" + TbxNomePopupHospedagemCadastro.Text + "' " +
                                      ",[qtd_quartos] = "+TbxQTDQuartosPopupHospedagemCadastro +
                                       ",[data_checkin] = (Select CONVERT(datetime,'" + TbxChekinPopupHospedagemCadastro.Text + "',20)) " +
                                       ",[data_checkout] = (Select CONVERT(datetime,'" + TbxChekoutPopupHospedagemCadastro.Text + "',20)) " +
                                       ",[preco] = " + TbxPrecoPopupHospedagemCadastro.Text+

                " WHERE SEQ_Hospedagem = " + indiceRegistro ;


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

            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_HOSPEDAGEM_TEMP where Nome LIKE '%" + TbxPesquisarGridHospedagems.Text + "%' ORDER BY Nome", conn);
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

            if (BtnEditarCadastroPopupHospedagemCadastro.Visible == true)
            {
                limparCadastro();

            }
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
            TbxBairroPopupHospedagemCadastro.Text = "";
            TbxCidadePopupHospedagemCadastro.Text = "";
            TbxUFPopupHospedagemCadastro.Text = "";
            TbxRuaPopupHospedagemCadastro.Text = "";
            TbxCEPPopupHospedagemCadastro.Text = "";
            GridViewHospedagems.SelectedIndex = -1;


        }

        protected void btnLimparPopupHospedagemCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }
    }
}