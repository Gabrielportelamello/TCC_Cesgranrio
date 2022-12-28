using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSemearTurismo.Views
{
    public partial class Reserva : System.Web.UI.Page
    {
        string connectionString = "Data Source=BEATRIZ\\SQLEXPRESS;Initial Catalog=tailandia;Integrated Security=true";

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewClientes.SelectedIndex = -1;
            if (!IsPostBack)
            {

                GridViewClientes.SelectedIndex = -1;

                if (TbxPesquisarGridClientes.Text != "")
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


            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA ORDER BY NOME", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewClientes.DataSource = ds;
            GridViewClientes.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void GridViewClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (TbxPesquisarGridClientes.Text != "")
            {
                GVBingSearch();
                GridViewClientes.PageIndex = e.NewPageIndex;
                GridViewClientes.DataBind();
            }
            else
            {
                GVBing();
                GridViewClientes.PageIndex = e.NewPageIndex;
                GridViewClientes.DataBind();
            }

        }

        protected void GridViewClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridViewClientes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sIndiceRegistro = GridViewClientes.SelectedDataKey.Value.ToString();

            preencheFrmEdicao(sIndiceRegistro);

            MPEClientesGRID.Show();

            BtnCadastrarPopupClienteCadastro.Visible = false;
            BtnEditarCadastroPopupClienteCadastro.Visible = true;
            btnLimparPopupClienteCadastro.Visible = false;


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
            string oradb = "Data Source = BEATRIZ\\SQLEXPRESS; Initial Catalog = tailandia; Integrated Security = true";
            SqlConnection conn = new SqlConnection(oradb);
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA where SQ_PESSOA = " + sIndiceRegistro, conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds, "SEMEAR_PESSOA");
            //continnuar daqui.
            foreach (DataRow r in ds.Tables["SEMEAR_PESSOA"].Rows)
            {

                //          SELECT TOP(1000) [Nome]
                //,[Telefone]
                //,[Email]
                //,[Data_Nascimento]
                //,[CPF]
                //,[Passaporte]
                //,[emissao_passaporte]
                //,[Validade_Passaporte]
                //,[RG]


                TbxNomePopupClienteCadastro.Text = r["NOME"].ToString();

                TbxTel1PopupClienteCadastro.Text = r["Telefone"].ToString();

                TbxEmailPopupClienteCadastro.Text = r["Email"].ToString();

                if (r["Data_Nascimento"].ToString() != "")
                {
                    TbxNascimentoPopupClienteCadastro.Text = r["Data_Nascimento"].ToString().Substring(6, 4) + "-" + r["Data_Nascimento"].ToString().Substring(3, 2) + "-" + r["Data_Nascimento"].ToString().Substring(0, 2);

                }

                TbxCPFPopupClienteCadastro.Text = r["CPF"].ToString();
                TbxNumPassPopupClienteCadastro.Text = r["Passaporte"].ToString();

                if (r["emissao_passaporte"].ToString() != "")
                {
                    TbxDataEmissPassPopupClienteCadastro.Text = r["emissao_passaporte"].ToString().Substring(6, 4) + "-" + r["emissao_passaporte"].ToString().Substring(3, 2) + "-" + r["emissao_passaporte"].ToString().Substring(0, 2);

                }
                if (r["Validade_Passaporte"].ToString() != "")
                {
                    TbxDataValiPassPopupClienteCadastro.Text = r["Validade_Passaporte"].ToString().Substring(6, 4) + "-" + r["Validade_Passaporte"].ToString().Substring(3, 2) + "-" + r["Validade_Passaporte"].ToString().Substring(0, 2);

                }

                TbxNumRGPopupClienteCadastro.Text = r["RG"].ToString();
                //,[orgao_emissor_RG]
                //,[data_emissao_RG]
                //,[Perfil_Acesso]
                //,[salario]
                //,[Saldo]
                //,[FL_FUNCIONARIO]
                //,[FL_EXCLUIDO]
                //,[bairro_endereco]
                //,[cidade_endereco]
                //,[uf_endereco]
                //,[rua_endereco]
                //,[CEP]
                //,[SQ_PESSOA]
                //          FROM[tailandia].[dbo].[SEMEAR_PESSOA]
                TbxOrgaoEmissorPopupClienteCadastro.Text = r["orgao_emissor_RG"].ToString();
                string resulta = r["data_emissao_RG"].ToString();

                if (r["data_emissao_RG"].ToString() != "")
                {
                    TbxDataEmissRGPopupClienteCadastro.Text = r["data_emissao_RG"].ToString().Substring(6, 4) + "-" + r["data_emissao_RG"].ToString().Substring(3, 2) + "-" + r["data_emissao_RG"].ToString().Substring(0, 2);
                }

                //TbxNumRGPopupClienteCadastro.Text = r["Saldo"].ToString();
                DropDownListFuncionarioPopupClienteCadastro.SelectedValue = r["FL_FUNCIONARIO"].ToString();
                //.Text = r["FL_EXCLUIDO"].ToString();
                TbxBairroPopupClienteCadastro.Text = r["bairro_endereco"].ToString();
                TbxCidadePopupClienteCadastro.Text = r["cidade_endereco"].ToString();
                TbxUFPopupClienteCadastro.Text = r["uf_endereco"].ToString();
                TbxRuaPopupClienteCadastro.Text = r["rua_endereco"].ToString();
                TbxCEPPopupClienteCadastro.Text = r["CEP"].ToString();



                //DropDownListOrgaos.SelectedValue = r["CO_ORGAO"].ToString() + " - " + r["DE_ORGAO"].ToString();
                //DropDownListSistemas.SelectedValue = r["NU_APLICATIVO"].ToString() + " - " + r["DE_APLICATIVO"].ToString();
                //tbxPergunta.Text = r["DE_PERGUNTA"].ToString();
                //tbxResposta.Text = r["DE_RESPOSTA"].ToString();
                //lblNumeroRegistro.Text = r["SQ_FAQ"].ToString();
                //DropDownListFLExcluidos.SelectedValue = r["FL_EXCLUIDO"].ToString();


                //imgBanner1.ImageUrl = GetImage((byte[])r["IM_FAQ1"]);
                //imgBanner2.ImageUrl = GetImage((byte[])r["IM_FAQ2"]);
                //imgBanner3.ImageUrl = GetImage((byte[])r["IM_FAQ3"]);
            }



            conn.Close();
            conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }


        protected void BtnCadastrarClienteModal_Click(object sender, EventArgs e)
        {
            if (TbxNomePopupClienteCadastro.Text != "" && TbxCPFPopupClienteCadastro.Text != ""
                && TbxTel1PopupClienteCadastro.Text != "")
            {
                RealizaCadastroCliente();
                RealizaCadastroImagensCliente();
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

        private void RealizaCadastroImagensCliente()
        {

        }

        private void RealizaCadastroCliente()
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = " INSERT INTO " +
                    "[dbo].[SEMEAR_PESSOA] " +
                    " ([Nome]  " +
                    ",[Telefone] " +
                    ",[Email]" +
                    "  ,[Data_Nascimento] " +
                    " ,[CPF],[Passaporte] ,[emissao_passaporte],[Validade_Passaporte] ,[RG] " +
                    ",[orgao_emissor_RG] ,[data_emissao_RG] ,[Perfil_Acesso] ,[salario] ,[Saldo] ,[FL_FUNCIONARIO] " +
                    ",[FL_EXCLUIDO] ,[bairro_endereco],[cidade_endereco] ,[uf_endereco] ,[rua_endereco] ,[CEP])  " +
                    " VALUES ('" + TbxNomePopupClienteCadastro.Text + "', '" +
                    "" + TbxTel1PopupClienteCadastro.Text +
                    "', '" + TbxEmailPopupClienteCadastro.Text +
                    "', (Select CONVERT(datetime,'" + TbxNascimentoPopupClienteCadastro.Text + "',20)) ,'"
                    + TbxCPFPopupClienteCadastro.Text +
                    "', '" + TbxNumPassPopupClienteCadastro.Text +
                    "', (Select CONVERT(datetime,'" + TbxDataEmissPassPopupClienteCadastro.Text + "',20)),(Select CONVERT(datetime,'" + TbxDataValiPassPopupClienteCadastro.Text + "',20)),'" + TbxNumRGPopupClienteCadastro.Text + "" +
                    "', '" + TbxOrgaoEmissorPopupClienteCadastro.Text + "',(Select CONVERT(datetime,'" + TbxDataEmissRGPopupClienteCadastro.Text + "',20))," + DropDownListFuncionarioPopupClienteCadastro.SelectedValue + " ," + TbxSalarioFuncionaroPopupClienteCadastro.Text + "," + TbxSaldoPopupClienteCadastro.Text + ","
                    + DropDownListFuncionarioPopupClienteCadastro.SelectedValue
                    + " ," + DropDownListFlagExcluidoPopupClienteCadastro.SelectedValue + " ,'" + TbxBairroPopupClienteCadastro.Text + "','"
                    + TbxCidadePopupClienteCadastro.Text + "','" + TbxUFPopupClienteCadastro.Text
                    + "' ,'" + TbxRuaPopupClienteCadastro.Text + "','" + TbxCEPPopupClienteCadastro.Text + "') ";


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
        private void RealizaEdicaoCadastroCliente(string indiceRegistro)
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = " UPDATE[dbo].[SEMEAR_PESSOA] SET[Nome] = '" + TbxNomePopupClienteCadastro.Text + "' ," +
                    "[Telefone] = '" + TbxTel1PopupClienteCadastro.Text + "',[Email] = '" + TbxEmailPopupClienteCadastro.Text + "'" +
                    ",[Data_Nascimento] = (Select CONVERT(datetime, '" + TbxNascimentoPopupClienteCadastro.Text + "', 20)) ,[CPF] = " +
                    "'" + TbxCPFPopupClienteCadastro.Text + "'      ,[Passaporte] = '" + TbxNumPassPopupClienteCadastro.Text + "' " +
                    ",[emissao_passaporte] = (Select CONVERT(datetime, '" + TbxDataEmissPassPopupClienteCadastro.Text + "', 20))" +
                    ",[Validade_Passaporte] = (Select CONVERT(datetime, '" + TbxDataValiPassPopupClienteCadastro.Text + "', 20))" +
                    ",[RG] = '" + TbxNumRGPopupClienteCadastro.Text + "'" +
                    ",[orgao_emissor_RG] = '" + TbxOrgaoEmissorPopupClienteCadastro.Text + "',[data_emissao_RG] = " +
                    "(Select CONVERT(datetime, '" + TbxDataEmissRGPopupClienteCadastro.Text + "', 20)) ,[Perfil_Acesso] =" +
                    " " + DropDownListFuncionarioPopupClienteCadastro.SelectedValue + ",[salario] = "
                    + TbxSalarioFuncionaroPopupClienteCadastro.Text + " ,[Saldo] = " + TbxSaldoPopupClienteCadastro.Text + "" +
                    ",[FL_FUNCIONARIO] = " + DropDownListFuncionarioPopupClienteCadastro.SelectedValue + "" +
                    ",[FL_EXCLUIDO] = " + DropDownListFlagExcluidoPopupClienteCadastro.SelectedValue + "" +
                    ",[bairro_endereco] = '" + TbxBairroPopupClienteCadastro.Text + "',[cidade_endereco] = " +
                    "'" + TbxCidadePopupClienteCadastro.Text + "',[uf_endereco] = '" + TbxUFPopupClienteCadastro.Text + "'" +
                    ",[rua_endereco] = '" + TbxRuaPopupClienteCadastro.Text + "',[CEP] = '" + TbxCEPPopupClienteCadastro.Text +
                    "' WHERE SQ_PESSOA = " + indiceRegistro + " ";


                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }
            }


            if (TbxPesquisarGridClientes.Text != "")
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

        protected void ImgBtnPesquisarGridClientes_Click(object sender, ImageClickEventArgs e)
        {
            if (TbxPesquisarGridClientes.Text != "")
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

            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA where Nome LIKE '%" + TbxPesquisarGridClientes.Text + "%' ORDER BY Nome", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewClientes.DataSource = ds;
            GridViewClientes.DataBind();

            conn.Close();
            conn.Dispose();

        }

        protected void DropDownListFuncionarioPopupClienteCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListFuncionarioPopupClienteCadastro.SelectedValue == "0")
            {
                LblSalarioFuncionaroPopupClienteCadastro.Visible = false;
                TbxSalarioFuncionaroPopupClienteCadastro.Visible = false;
            }
            else
            {
                LblSalarioFuncionaroPopupClienteCadastro.Visible = true;
                TbxSalarioFuncionaroPopupClienteCadastro.Visible = true;
            }

        }

        protected void DropDownListFuncionarioPopupClienteCadastro_TextChanged(object sender, EventArgs e)
        {
            if (DropDownListFuncionarioPopupClienteCadastro.SelectedValue == "0")
            {
                LblSalarioFuncionaroPopupClienteCadastro.Visible = false;
                TbxSalarioFuncionaroPopupClienteCadastro.Visible = false;
            }
            else
            {
                LblSalarioFuncionaroPopupClienteCadastro.Visible = true;
                TbxSalarioFuncionaroPopupClienteCadastro.Visible = true;
            }
        }

        protected void BtnEditarCadastroPopupClienteCadastro_Click(object sender, EventArgs e)
        {
            string sIndiceRegistro = GridViewClientes.SelectedDataKey.Value.ToString();
            RealizaEdicaoCadastroCliente(sIndiceRegistro);

            if (TbxPesquisarGridClientes.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
            GridViewClientes.SelectedIndex = -1;
        }

        protected void BtnModalClientesGRID_Click(object sender, EventArgs e)
        {
            MPEClientesGRID.Show();
            BtnCadastrarPopupClienteCadastro.Visible = true;
            BtnEditarCadastroPopupClienteCadastro.Visible = false;
            btnLimparPopupClienteCadastro.Visible = true;
        }

        protected void btnCancelarPopupClienteCadastro_Click(object sender, EventArgs e)
        {
            GridViewClientes.SelectedIndex = -1;

            if (BtnEditarCadastroPopupClienteCadastro.Visible == true)
            {
                limparCadastro();

            }
        }

        private void limparCadastro()
        {
            TbxNomePopupClienteCadastro.Text = "";
            TbxTel1PopupClienteCadastro.Text = "";
            TbxEmailPopupClienteCadastro.Text = "";
            TbxNascimentoPopupClienteCadastro.Text = "";
            TbxCPFPopupClienteCadastro.Text = "";
            TbxNumPassPopupClienteCadastro.Text = "";
            TbxDataEmissPassPopupClienteCadastro.Text = "";
            TbxDataValiPassPopupClienteCadastro.Text = "";
            TbxNumRGPopupClienteCadastro.Text = "";
            TbxOrgaoEmissorPopupClienteCadastro.Text = "";
            TbxDataEmissRGPopupClienteCadastro.Text = "";
            DropDownListFuncionarioPopupClienteCadastro.SelectedValue = "0";
            TbxSalarioFuncionaroPopupClienteCadastro.Text = "";
            TbxSaldoPopupClienteCadastro.Text = "";
            DropDownListFuncionarioPopupClienteCadastro.SelectedValue = "0";
            DropDownListFlagExcluidoPopupClienteCadastro.SelectedValue = "0";
            TbxBairroPopupClienteCadastro.Text = "";
            TbxCidadePopupClienteCadastro.Text = "";
            TbxUFPopupClienteCadastro.Text = "";
            TbxRuaPopupClienteCadastro.Text = "";
            TbxCEPPopupClienteCadastro.Text = "";
            GridViewClientes.SelectedIndex = -1;


        }

        protected void btnLimparPopupClienteCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }
    }
}