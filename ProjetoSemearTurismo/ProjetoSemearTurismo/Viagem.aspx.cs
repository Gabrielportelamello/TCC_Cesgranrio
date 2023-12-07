using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ProjetoSemearTurismo
{
    public partial class Viagem : Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewViagens.SelectedIndex = -1;
            if (!IsPostBack)
            {

                GridViewViagens.SelectedIndex = -1;

                if (TbxPesquisarGridViagens.Text != "")
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


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_VIAGEM where fl_status != 1 ORDER BY NOME_VIAGEM ", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewViagens.DataSource = ds;
            GridViewViagens.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void GridViewViagens_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (TbxPesquisarGridViagens.Text != "")
            {
                GVBingSearch();
                GridViewViagens.PageIndex = e.NewPageIndex;
                GridViewViagens.DataBind();
            }
            else
            {
                GVBing();
                GridViewViagens.PageIndex = e.NewPageIndex;
                GridViewViagens.DataBind();
            }

        }

        protected void GridViewViagens_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

       
            // Obtém o índice da linha sendo deletada
            string indiceRegistro = GridViewViagens.DataKeys[e.RowIndex].Value.ToString();           

            // Atualiza o banco de dados com a data de exclusão
            AtualizarDataExclusao(indiceRegistro);

            if (!string.IsNullOrEmpty(TbxPesquisarGridViagens.Text))
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
                string updateQuery = "UPDATE [dbo].[SEMEAR_VIAGEM] " +
                                     "SET [FL_STATUS] = 1 " +
                                     "WHERE SQ_VIAGEM = " + indiceRegistro;

                using (SqlCommand queryUpdate = new SqlCommand(updateQuery))
                {
                    queryUpdate.Connection = openCon;

                    openCon.Open();
                    queryUpdate.ExecuteNonQuery();
                }
            }
        }

        protected void GridViewViagens_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridViewViagens_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sIndiceRegistro = GridViewViagens.SelectedDataKey.Value.ToString();

            preencheFrmEdicao(sIndiceRegistro);

            MPEViagensGRID.Show();

            BtnCadastrarPopupViagemCadastro.Visible = false;
            BtnEditarCadastroPopupViagemCadastro.Visible = true;
            btnLimparPopupViagemCadastro.Visible = false;


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
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_VIAGEM where SQ_VIAGEM = " + sIndiceRegistro, conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds, "SEMEAR_VIAGEM");
            //continnuar daqui.
            foreach (DataRow r in ds.Tables["SEMEAR_VIAGEM"].Rows)
            {                
                TbxNomePopupViagemCadastro.Text= r["NOME_VIAGEM"].ToString();

                if (r["DT_InicialPeriodo_viagem"].ToString() != "")
                {
                    TbxDataInicialPopupViagemCadastro.Text = r["DT_InicialPeriodo_viagem"].ToString().Substring(6, 4) + "-" + r["DT_InicialPeriodo_viagem"].ToString().Substring(3, 2) + "-" + r["DT_InicialPeriodo_viagem"].ToString().Substring(0, 2);
                }
                if (r["DTFinalperiodo_viagem"].ToString() != "")
                {
                    TbxDataFinalPopupViagemCadastro.Text = r["DTFinalperiodo_viagem"].ToString().Substring(6, 4) + "-" + r["DTFinalperiodo_viagem"].ToString().Substring(3, 2) + "-" + r["DTFinalperiodo_viagem"].ToString().Substring(0, 2);
                }

                TbxDescPopupViagemCadastro.Text = r["Descricao_do_pacote"].ToString();
                TbxPrecoViagemPopupViagemCadastro.Text = r["Preco"].ToString();
                TbxOBSViagemPopupViagemCadastro.Text = r["OBSERVACAO"].ToString();
                DropDownListViagemPopupViagemCadastro.SelectedValue = r["FL_STATUS"].ToString();                


            }



            conn.Close();
            conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }


        protected void BtnCadastrarViagemModal_Click(object sender, EventArgs e)
        {
            if (TbxNomePopupViagemCadastro.Text != "" )
            {
                RealizaCadastroViagem();
                RealizaCadastroImagensViagem();
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

        private void RealizaCadastroImagensViagem()
        {

        }

        private void RealizaCadastroViagem()
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                if (TbxPrecoViagemPopupViagemCadastro.Text == "")
                    TbxPrecoViagemPopupViagemCadastro.Text = "0000.00";
                string saveStaff = "INSERT INTO [dbo].[SEMEAR_VIAGEM] ([NOME_VIAGEM] ,[DT_InicialPeriodo_viagem] ,[DTFinalperiodo_viagem] ,[Descricao_do_pacote] ,[Preco]  ,[OBSERVACAO] ,[FL_STATUS]) VALUES ('"+TbxNomePopupViagemCadastro.Text+ "' , (Select CONVERT(datetime,'" + TbxDataInicialPopupViagemCadastro.Text + "',20))" + ", (Select CONVERT(datetime,'" + TbxDataFinalPopupViagemCadastro.Text + "',20)), '"+TbxDescPopupViagemCadastro.Text+"' , "+TbxPrecoViagemPopupViagemCadastro.Text+" ,'"+TbxOBSViagemPopupViagemCadastro.Text+"',"+ DropDownListViagemPopupViagemCadastro.SelectedValue +")";
                
                
                //string saveStaff = " INSERT INTO [dbo].[SEMEAR_PESSOA]  ([Nome]  ,[Telefone] ,[Email]" +
                //    "  ,[Data_Nascimento]  ,[CPF],[Passaporte] ,[emissao_passaporte],[Validade_Passaporte] ,[RG] " +
                //    ",[orgao_emissor_RG] ,[data_emissao_RG] ,[Perfil_Acesso] ,[salario] ,[Saldo] ,[FL_FUNCIONARIO] " +
                //    ",[FL_EXCLUIDO] ,[bairro_endereco],[cidade_endereco] ,[uf_endereco] ,[rua_endereco] ,[CEP])  " +
                //    " VALUES ('" + TbxNomePopupViagemCadastro.Text + "', '" +
                //    "" + TbxTel1PopupViagemCadastro.Text + "', '" + TbxEmailPopupViagemCadastro.Text + "', (Select CONVERT(datetime,'" + TbxNascimentoPopupViagemCadastro.Text + "',20)) ,'" + TbxCPFPopupViagemCadastro.Text +
                //    "', '" + TbxNumPassPopupViagemCadastro.Text + "', (Select CONVERT(datetime,'" + TbxDataEmissPassPopupViagemCadastro.Text + "',20)),(Select CONVERT(datetime,'" + TbxDataValiPassPopupViagemCadastro.Text + "',20)),'" + TbxNumRGPopupViagemCadastro.Text + "" +
                //    "', '" + TbxOrgaoEmissorPopupViagemCadastro.Text + "',(Select CONVERT(datetime,'" + TbxDataEmissRGPopupViagemCadastro.Text + "',20))," + DropDownListFuncionarioPopupViagemCadastro.SelectedValue + " ," + TbxSalarioFuncionaroPopupViagemCadastro.Text + "," + TbxSaldoPopupViagemCadastro.Text + ","
                //    + DropDownListFuncionarioPopupViagemCadastro.SelectedValue
                //    + " ," + DropDownListFlagExcluidoPopupViagemCadastro.SelectedValue + " ,'" + TbxBairroPopupViagemCadastro.Text + "','"
                //    + TbxCidadePopupViagemCadastro.Text + "','" + TbxUFPopupViagemCadastro.Text
                //    + "' ,'" + TbxRuaPopupViagemCadastro.Text + "','" + TbxCEPPopupViagemCadastro.Text + "') ";


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
        private void RealizaEdicaoCadastroViagem(string indiceRegistro)
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = "";
                saveStaff =" UPDATE[dbo].[SEMEAR_VIAGEM] SET [NOME_VIAGEM] = '"+TbxNomePopupViagemCadastro.Text+ "' ,[DT_InicialPeriodo_viagem] = (Select CONVERT(datetime, '" + TbxDataInicialPopupViagemCadastro.Text + "', 20)) ,[DTFinalperiodo_viagem] = (Select CONVERT(datetime, '" + TbxDataFinalPopupViagemCadastro.Text + "', 20)) ,[Descricao_do_pacote] = '"+TbxDescPopupViagemCadastro.Text+"' ,[Preco] = "+TbxPrecoViagemPopupViagemCadastro.Text+" ,[OBSERVACAO] = '"+TbxOBSViagemPopupViagemCadastro.Text+"' ,[FL_STATUS] = "+ DropDownListViagemPopupViagemCadastro.SelectedValue +" WHERE SQ_VIAGEM = " + indiceRegistro ;

                //string saveStaff = " UPDATE[dbo].[SEMEAR_PESSOA] SET[Nome] = '" + TbxNomePopupViagemCadastro.Text + "' ," +
                //    "[Telefone] = '" + TbxTel1PopupViagemCadastro.Text + "',[Email] = '" + TbxEmailPopupViagemCadastro.Text + "'" +
                //    ",[Data_Nascimento] = (Select CONVERT(datetime, '" + TbxNascimentoPopupViagemCadastro.Text + "', 20)) ,[CPF] = " +
                //    "'" + TbxCPFPopupViagemCadastro.Text + "'      ,[Passaporte] = '" + TbxNumPassPopupViagemCadastro.Text + "' " +
                //    ",[emissao_passaporte] = (Select CONVERT(datetime, '" + TbxDataEmissPassPopupViagemCadastro.Text + "', 20))" +
                //    ",[Validade_Passaporte] = (Select CONVERT(datetime, '" + TbxDataValiPassPopupViagemCadastro.Text + "', 20))" +
                //    ",[RG] = '" + TbxNumRGPopupViagemCadastro.Text + "'" +
                //    ",[orgao_emissor_RG] = '" + TbxOrgaoEmissorPopupViagemCadastro.Text + "',[data_emissao_RG] = " +
                //    "(Select CONVERT(datetime, '" + TbxDataEmissRGPopupViagemCadastro.Text + "', 20)) ,[Perfil_Acesso] =" +
                //    " " + DropDownListFuncionarioPopupViagemCadastro.SelectedValue + ",[salario] = "
                //    + TbxSalarioFuncionaroPopupViagemCadastro.Text + " ,[Saldo] = " + TbxSaldoPopupViagemCadastro.Text + "" +
                //    ",[FL_FUNCIONARIO] = " + DropDownListFuncionarioPopupViagemCadastro.SelectedValue + "" +
                //    ",[FL_EXCLUIDO] = " + DropDownListFlagExcluidoPopupViagemCadastro.SelectedValue + "" +
                //    ",[bairro_endereco] = '" + TbxBairroPopupViagemCadastro.Text + "',[cidade_endereco] = " +
                //    "'" + TbxCidadePopupViagemCadastro.Text + "',[uf_endereco] = '" + TbxUFPopupViagemCadastro.Text + "'" +
                //    ",[rua_endereco] = '" + TbxRuaPopupViagemCadastro.Text + "',[CEP] = '" + TbxCEPPopupViagemCadastro.Text +
                //    "' WHERE SQ_PESSOA = " + indiceRegistro + " ";


                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }
            }


            if (TbxPesquisarGridViagens.Text != "")
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

        protected void ImgBtnPesquisarGridViagens_Click(object sender, ImageClickEventArgs e)
        {
            if (TbxPesquisarGridViagens.Text != "")
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
            if (!string.IsNullOrEmpty(TbxPesquisarGridViagens.Text))
            {
                SqlConnection conn = new SqlConnection(connectionString);

                SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_VIAGEM where fl_status != 1 and NOME_VIAGEM LIKE '%" + TbxPesquisarGridViagens.Text + "%' ORDER BY NOME_VIAGEM", conn);
                conn.Open();
                SqlCommandBuilder builder = new SqlCommandBuilder(a);
                DataSet ds = new DataSet();
                a.Fill(ds);

                GridViewViagens.DataSource = ds;
                GridViewViagens.DataBind();

                conn.Close();
                conn.Dispose();

            }
            else
            {
                GVBing();
            }
            

        }

        protected void DropDownListFuncionarioPopupViagemCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        protected void DropDownListFuncionarioPopupViagemCadastro_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void BtnEditarCadastroPopupViagemCadastro_Click(object sender, EventArgs e)
        {
            string sIndiceRegistro = GridViewViagens.SelectedDataKey.Value.ToString();
            RealizaEdicaoCadastroViagem(sIndiceRegistro);

            if (TbxPesquisarGridViagens.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
            GridViewViagens.SelectedIndex = -1;
        }

        protected void BtnModalViagensGRID_Click(object sender, EventArgs e)
        {
            MPEViagensGRID.Show();
            BtnCadastrarPopupViagemCadastro.Visible = true;
            BtnEditarCadastroPopupViagemCadastro.Visible = false;
            btnLimparPopupViagemCadastro.Visible = true;
        }

        protected void btnCancelarPopupViagemCadastro_Click(object sender, EventArgs e)
        {
            GridViewViagens.SelectedIndex = -1;

            if (BtnEditarCadastroPopupViagemCadastro.Visible == true)
            {
                limparCadastro();

            }
        }

        private void limparCadastro()
        {
            TbxNomePopupViagemCadastro.Text = "";
 
            TbxDataInicialPopupViagemCadastro.Text = "";
            TbxDataFinalPopupViagemCadastro.Text = "";

            DropDownListViagemPopupViagemCadastro.SelectedValue = "0";
            TbxPrecoViagemPopupViagemCadastro.Text = "0000.00";

            TbxDescPopupViagemCadastro.Text = "";
            TbxOBSViagemPopupViagemCadastro.Text = "";

            GridViewViagens.SelectedIndex = -1;


        }

        protected void btnLimparPopupViagemCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
            MPEViagensGRID.Show();
        }
    }
}