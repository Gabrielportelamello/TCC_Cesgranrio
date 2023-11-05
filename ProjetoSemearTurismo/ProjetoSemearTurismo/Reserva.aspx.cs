using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


namespace ProjetoSemearTurismo.Views
{
    public partial class Reserva : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridViewReservas.SelectedIndex = -1;
            if (!IsPostBack)
            {
                PopularDropdownList();
                PopularDropdownListClientes();
                PopularDropdownListHospedagem();
                PopularDropdownListTransporte();

                //GridViewReservas.SelectedIndex = -1;

                //if (TbxPesquisarGridReservas.Text != "")
                //{
                //    GVBingSearch();
                //}
                //else
                //{
                //    GVBing();
                //}
            }
        }



        protected void GVBing()
        {

            //SqlConnection conn = new SqlConnection(connectionString);


            //SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA ORDER BY NOME", conn);
            //conn.Open();
            //SqlCommandBuilder builder = new SqlCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds);

            //GridViewReservas.DataSource = ds;
            //GridViewReservas.DataBind();

            //conn.Close();
            //conn.Dispose();

        }

        protected void GridViewReservas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //if (TbxPesquisarGridReservas.Text != "")
            //{
            //    GVBingSearch();
            //    GridViewReservas.PageIndex = e.NewPageIndex;
            //    GridViewReservas.DataBind();
            //}
            //else
            //{
            //    GVBing();
            //    GridViewReservas.PageIndex = e.NewPageIndex;
            //    GridViewReservas.DataBind();
            //}

        }

        protected void GridViewReservas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridViewReservas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void GridViewReservas_SelectedIndexChanged(object sender, EventArgs e)
        {


            //string sIndiceRegistro = GridViewReservas.SelectedDataKey.Value.ToString();

            //preencheFrmEdicao(sIndiceRegistro);

            //MPEReservasGRID.Show();

            //BtnCadastrarPopupReservaCadastro.Visible = false;
            //BtnEditarCadastroPopupReservaCadastro.Visible = true;
            //btnLimparPopupReservaCadastro.Visible = false;


        }

        private void preencheFrmEdicao(string sIndiceRegistro)
        {
            //if (sIndiceRegistro != null)
            //{
            //    try { preencheFormEdicao(sIndiceRegistro); } catch { }

            //}

        }
        private void preencheFormEdicao(string sIndiceRegistro)
        {
            ////limpaCadastroEdicao();
            ///            string oradb = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            //SqlConnection conn = new SqlConnection(oradb);
            //SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA where SQ_PESSOA = " + sIndiceRegistro, conn);
            //conn.Open();
            //SqlCommandBuilder builder = new SqlCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds, "SEMEAR_PESSOA");
            ////continnuar daqui.
            //foreach (DataRow r in ds.Tables["SEMEAR_PESSOA"].Rows)
            //{

            //    //          SELECT TOP(1000) [Nome]
            //    //,[Telefone]
            //    //,[Email]
            //    //,[Data_Nascimento]
            //    //,[CPF]
            //    //,[Passaporte]
            //    //,[emissao_passaporte]
            //    //,[Validade_Passaporte]
            //    //,[RG]


            //    TbxNomePopupReservaCadastro.Text = r["NOME"].ToString();

            //    TbxTel1PopupReservaCadastro.Text = r["Telefone"].ToString();

            //    TbxEmailPopupReservaCadastro.Text = r["Email"].ToString();

            //    if (r["Data_Nascimento"].ToString() != "")
            //    {
            //        TbxNascimentoPopupReservaCadastro.Text = r["Data_Nascimento"].ToString().Substring(6, 4) + "-" + r["Data_Nascimento"].ToString().Substring(3, 2) + "-" + r["Data_Nascimento"].ToString().Substring(0, 2);

            //    }

            //    TbxCPFPopupReservaCadastro.Text = r["CPF"].ToString();
            //    TbxNumPassPopupReservaCadastro.Text = r["Passaporte"].ToString();

            //    if (r["emissao_passaporte"].ToString() != "")
            //    {
            //        TbxDataEmissPassPopupReservaCadastro.Text = r["emissao_passaporte"].ToString().Substring(6, 4) + "-" + r["emissao_passaporte"].ToString().Substring(3, 2) + "-" + r["emissao_passaporte"].ToString().Substring(0, 2);

            //    }
            //    if (r["Validade_Passaporte"].ToString() != "")
            //    {
            //        TbxDataValiPassPopupReservaCadastro.Text = r["Validade_Passaporte"].ToString().Substring(6, 4) + "-" + r["Validade_Passaporte"].ToString().Substring(3, 2) + "-" + r["Validade_Passaporte"].ToString().Substring(0, 2);

            //    }

            //    TbxNumRGPopupReservaCadastro.Text = r["RG"].ToString();
            //    //,[orgao_emissor_RG]
            //    //,[data_emissao_RG]
            //    //,[Perfil_Acesso]
            //    //,[salario]
            //    //,[Saldo]
            //    //,[FL_FUNCIONARIO]
            //    //,[FL_EXCLUIDO]
            //    //,[bairro_endereco]
            //    //,[cidade_endereco]
            //    //,[uf_endereco]
            //    //,[rua_endereco]
            //    //,[CEP]
            //    //,[SQ_PESSOA]
            //    //          FROM[tailandia].[dbo].[SEMEAR_PESSOA]
            //    TbxOrgaoEmissorPopupReservaCadastro.Text = r["orgao_emissor_RG"].ToString();
            //    string resulta = r["data_emissao_RG"].ToString();

            //    if (r["data_emissao_RG"].ToString() != "")
            //    {
            //        TbxDataEmissRGPopupReservaCadastro.Text = r["data_emissao_RG"].ToString().Substring(6, 4) + "-" + r["data_emissao_RG"].ToString().Substring(3, 2) + "-" + r["data_emissao_RG"].ToString().Substring(0, 2);
            //    }

            //    //TbxNumRGPopupReservaCadastro.Text = r["Saldo"].ToString();
            //    DropDownListFuncionarioPopupReservaCadastro.SelectedValue = r["FL_FUNCIONARIO"].ToString();
            //    //.Text = r["FL_EXCLUIDO"].ToString();
            //    TbxBairroPopupReservaCadastro.Text = r["bairro_endereco"].ToString();
            //    TbxCidadePopupReservaCadastro.Text = r["cidade_endereco"].ToString();
            //    TbxUFPopupReservaCadastro.Text = r["uf_endereco"].ToString();
            //    TbxRuaPopupReservaCadastro.Text = r["rua_endereco"].ToString();
            //    TbxCEPPopupReservaCadastro.Text = r["CEP"].ToString();



            //    //DropDownListOrgaos.SelectedValue = r["CO_ORGAO"].ToString() + " - " + r["DE_ORGAO"].ToString();
            //    //DropDownListSistemas.SelectedValue = r["NU_APLICATIVO"].ToString() + " - " + r["DE_APLICATIVO"].ToString();
            //    //tbxPergunta.Text = r["DE_PERGUNTA"].ToString();
            //    //tbxResposta.Text = r["DE_RESPOSTA"].ToString();
            //    //lblNumeroRegistro.Text = r["SQ_FAQ"].ToString();
            //    //DropDownListFLExcluidos.SelectedValue = r["FL_EXCLUIDO"].ToString();


            //    //imgBanner1.ImageUrl = GetImage((byte[])r["IM_FAQ1"]);
            //    //imgBanner2.ImageUrl = GetImage((byte[])r["IM_FAQ2"]);
            //    //imgBanner3.ImageUrl = GetImage((byte[])r["IM_FAQ3"]);
            //}



            //conn.Close();
            //conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }


        protected void BtnCadastrarReservaModal_Click(object sender, EventArgs e)
        {
            if (false)

            {
                RealizaCadastroReserva();
                int SEQ = getMaxValue();
                RealizaCadastroReservaAssociativa(SEQ);
                //RealizaCadastroImagensReserva();
            }
            else
            {
                //mbox
            }
        }

        private void RealizaCadastroReservaAssociativa(int SEQ)
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {



                //           -----------------------------



                string saveStaff = "INSERT INTO[dbo].[SEMEAR_ASSOCIATIVA_VPR] " + "([SQ_VIAGEM_FK],[SQ_RESERVA_FK],[SQ_CLIENTE_FK],[DT_INCLUSAO],[DT_EDICAO])" +
                " VALUES ( " + DropDownListViagemPopupReservaCadastro.SelectedValue + " , " + SEQ + " , " + DropDownListClientePopupReservaCadastro.SelectedValue + " , (SELECT GETDATE() AS CurrentDateTime),(SELECT GETDATE() AS CurrentDateTime))";



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

        private void RealizaCadastroImagensFuncionario()
        {

        }

        private void RealizaCadastroFuncionario()
        {

        }

        private void RealizaCadastroImagensReserva()
        {

        }

        private void RealizaCadastroReserva()
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {



                //           -----------------------------

                //               INSERT INTO[dbo].[SEMEAR_ASSOCIATIVA_VPR]
                //      ([SQ_HPR_PK]
                //      ,[SQ_VIAGEM_FK]
                //      ,[SQ_RESERVA_FK]
                //      ,[SQ_CLIENTE_FK]
                //      ,[DT_INCLUSAO]
                //      ,[DT_EXCLUSAO]
                //      ,[DT_EDICAO])
                //VALUES
                //      (< SQ_HPR_PK, bigint,>
                //      ,< SQ_VIAGEM_FK, int,>
                //      ,< SQ_RESERVA_FK, bigint,>
                //      ,< SQ_CLIENTE_FK, int,>
                //      ,< DT_INCLUSAO, datetime,>
                //      ,< DT_EXCLUSAO, datetime,>
                //      ,< DT_EDICAO, datetime,>)

                string saveStaff = "INSERT INTO [dbo].[SEMEAR_RESERVA] ([SQ_CLIENTE]) VALUES (" + DropDownListClientePopupReservaCadastro.SelectedValue + ")";



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
        private void RealizaEdicaoCadastroReserva(string indiceRegistro)
        {

            //using (SqlConnection openCon = new SqlConnection(connectionString))
            //{
            //    string saveStaff = " UPDATE[dbo].[SEMEAR_PESSOA] SET[Nome] = '" + TbxNomePopupReservaCadastro.Text + "' ," +
            //        "[Telefone] = '" + TbxTel1PopupReservaCadastro.Text + "',[Email] = '" + TbxEmailPopupReservaCadastro.Text + "'" +
            //        ",[Data_Nascimento] = (Select CONVERT(datetime, '" + TbxNascimentoPopupReservaCadastro.Text + "', 20)) ,[CPF] = " +
            //        "'" + TbxCPFPopupReservaCadastro.Text + "'      ,[Passaporte] = '" + TbxNumPassPopupReservaCadastro.Text + "' " +
            //        ",[emissao_passaporte] = (Select CONVERT(datetime, '" + TbxDataEmissPassPopupReservaCadastro.Text + "', 20))" +
            //        ",[Validade_Passaporte] = (Select CONVERT(datetime, '" + TbxDataValiPassPopupReservaCadastro.Text + "', 20))" +
            //        ",[RG] = '" + TbxNumRGPopupReservaCadastro.Text + "'" +
            //        ",[orgao_emissor_RG] = '" + TbxOrgaoEmissorPopupReservaCadastro.Text + "',[data_emissao_RG] = " +
            //        "(Select CONVERT(datetime, '" + TbxDataEmissRGPopupReservaCadastro.Text + "', 20)) ,[Perfil_Acesso] =" +
            //        " " + DropDownListFuncionarioPopupReservaCadastro.SelectedValue + ",[salario] = "
            //        + TbxSalarioFuncionaroPopupReservaCadastro.Text + " ,[Saldo] = " + TbxSaldoPopupReservaCadastro.Text + "" +
            //        ",[FL_FUNCIONARIO] = " + DropDownListFuncionarioPopupReservaCadastro.SelectedValue + "" +
            //        ",[FL_EXCLUIDO] = " + DropDownListFlagExcluidoPopupReservaCadastro.SelectedValue + "" +
            //        ",[bairro_endereco] = '" + TbxBairroPopupReservaCadastro.Text + "',[cidade_endereco] = " +
            //        "'" + TbxCidadePopupReservaCadastro.Text + "',[uf_endereco] = '" + TbxUFPopupReservaCadastro.Text + "'" +
            //        ",[rua_endereco] = '" + TbxRuaPopupReservaCadastro.Text + "',[CEP] = '" + TbxCEPPopupReservaCadastro.Text +
            //        "' WHERE SQ_PESSOA = " + indiceRegistro + " ";


            //    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
            //    {
            //        querySaveStaff.Connection = openCon;

            //        openCon.Open();

            //        querySaveStaff.ExecuteNonQuery();

            //        openCon.Dispose();
            //        openCon.Close();
            //    }
            //}


            //if (TbxPesquisarGridReservas.Text != "")
            //{
            //    GVBingSearch();
            //}
            //else
            //{
            //    GVBing();
            //}
        }

        private void preencheVazioComNull()
        {

        }
        private void preencheNullComVazio()
        {

        }

        protected void ImgBtnPesquisarGridReservas_Click(object sender, ImageClickEventArgs e)
        {
            //if (TbxPesquisarGridReservas.Text != "")
            //{
            //    GVBingSearch();
            //}
            //else
            //{
            //    GVBing();
            //}
        }
        protected void GVBingSearch()
        {

            //SqlConnection conn = new SqlConnection(connectionString);

            //SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM SEMEAR_PESSOA where Nome LIKE '%" + TbxPesquisarGridReservas.Text + "%' ORDER BY Nome", conn);
            //conn.Open();
            //SqlCommandBuilder builder = new SqlCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds);

            //GridViewReservas.DataSource = ds;
            //GridViewReservas.DataBind();

            //conn.Close();
            //conn.Dispose();

        }

        protected void DropDownListFuncionarioPopupReservaCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (DropDownListFuncionarioPopupReservaCadastro.SelectedValue == "0")
            //{
            //    LblSalarioFuncionaroPopupReservaCadastro.Visible = false;
            //    TbxSalarioFuncionaroPopupReservaCadastro.Visible = false;
            //}
            //else
            //{
            //    LblSalarioFuncionaroPopupReservaCadastro.Visible = true;
            //    TbxSalarioFuncionaroPopupReservaCadastro.Visible = true;
            //}

        }

        protected void DropDownListFuncionarioPopupReservaCadastro_TextChanged(object sender, EventArgs e)
        {
            //if (DropDownListFuncionarioPopupReservaCadastro.SelectedValue == "0")
            //{
            //    LblSalarioFuncionaroPopupReservaCadastro.Visible = false;
            //    TbxSalarioFuncionaroPopupReservaCadastro.Visible = false;
            //}
            //else
            //{
            //    LblSalarioFuncionaroPopupReservaCadastro.Visible = true;
            //    TbxSalarioFuncionaroPopupReservaCadastro.Visible = true;
            //}
        }

        protected void BtnEditarCadastroPopupReservaCadastro_Click(object sender, EventArgs e)
        {
            //string sIndiceRegistro = GridViewReservas.SelectedDataKey.Value.ToString();
            //RealizaEdicaoCadastroReserva(sIndiceRegistro);

            //if (TbxPesquisarGridReservas.Text != "")
            //{
            //    GVBingSearch();
            //}
            //else
            //{
            //    GVBing();
            //}
            //GridViewReservas.SelectedIndex = -1;
        }

        protected void BtnModalReservasGRID_Click(object sender, EventArgs e)
        {
            //MPEReservasGRID.Show();
            BtnCadastrarPopupReservaCadastro.Visible = true;
            BtnEditarCadastroPopupReservaCadastro.Visible = false;
            btnLimparPopupReservaCadastro.Visible = true;
        }

        protected void btnCancelarPopupReservaCadastro_Click(object sender, EventArgs e)
        {
            //GridViewReservas.SelectedIndex = -1;

            //if (BtnEditarCadastroPopupReservaCadastro.Visible == true)
            //{
            //    limparCadastro();

            //}
        }

        protected void PopularDropdownList()
        {
            // Define a string de conexão com o banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            // Define a consulta SQL para selecionar os dados da tabela
            string query = "SELECT [NOME_VIAGEM] , [SQ_VIAGEM] FROM [dbo].[SEMEAR_VIAGEM] ";

            // Cria uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria um comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Executa o comando SQL e obtém um SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Cria uma lista para armazenar os itens do DropDownList
                        List<ListItem> items = new List<ListItem>();

                        // Adiciona o item "Selecione a viagem" à lista
                        items.Add(new ListItem("Selecione a viagem", "0"));

                        // Adiciona os itens do leitor à lista
                        while (reader.Read())
                        {
                            string nomeViagem = reader["NOME_VIAGEM"].ToString();
                            string sqViagem = reader["SQ_VIAGEM"].ToString();
                            items.Add(new ListItem(nomeViagem, sqViagem));
                        }

                        // Define os campos do DropDownList
                        DropDownListViagemPopupReservaCadastro.DataTextField = "Text";
                        DropDownListViagemPopupReservaCadastro.DataValueField = "Value";

                        // Atribui a lista como o DataSource do DropDownList
                        DropDownListViagemPopupReservaCadastro.DataSource = items;
                        DropDownListViagemPopupReservaCadastro.DataBind();
                    }
                }
            }
        }

        private void PopularDropdownListClientes()
        {
            // Define a string de conexão com o banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            // Define a consulta SQL para selecionar os dados da tabela
            string query = "SELECT [Nome] + ' - CPF: ' + [CPF] AS NomeCompleto, [SQ_PESSOA] FROM [dbo].[SEMEAR_PESSOA] ";

            // Cria uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria um comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Executa o comando SQL e obtém um SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Cria uma lista para armazenar os itens do DropDownList
                        List<ListItem> items = new List<ListItem>();

                        // Adiciona o item "Selecione o Cliente" à lista
                        items.Add(new ListItem("Selecione o Cliente", "0"));

                        // Adiciona os itens do leitor à lista
                        while (reader.Read())
                        {
                            string nomeCompleto = reader["NomeCompleto"].ToString();
                            string sqPessoa = reader["SQ_PESSOA"].ToString();
                            items.Add(new ListItem(nomeCompleto, sqPessoa));
                        }

                        // Define os campos do DropDownList
                        DropDownListClientePopupReservaCadastro.DataTextField = "Text";
                        DropDownListClientePopupReservaCadastro.DataValueField = "Value";

                        // Atribui a lista como o DataSource do DropDownList
                        DropDownListClientePopupReservaCadastro.DataSource = items;
                        DropDownListClientePopupReservaCadastro.DataBind();
                    }
                }
            }
        }

        private void PopularDropdownListHospedagem()
        {
            // Define a string de conexão com o banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            // Define a consulta SQL para selecionar os dados da tabela
            string query = "SELECT [SEQ_HOSPEDAGEM], [Nome] FROM [dbo].[SEMEAR_HOSPEDAGEM_TEMP]";

            // Cria uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria um comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Executa o comando SQL e obtém um SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Cria uma lista para armazenar os itens do DropDownList
                        List<ListItem> items = new List<ListItem>();

                        // Adiciona o item "Selecione a Hospedagem" à lista
                        items.Add(new ListItem("Selecione a Hospedagem", "0"));

                        // Adiciona os itens do leitor à lista
                        while (reader.Read())
                        {
                            string nomeHospedagem = reader["Nome"].ToString();
                            string seqHospedagem = reader["SEQ_HOSPEDAGEM"].ToString();
                            items.Add(new ListItem(nomeHospedagem, seqHospedagem));
                        }

                        // Define os campos do DropDownList
                        DropDownListHospedagemPopupReservaCadastro.DataTextField = "Text";
                        DropDownListHospedagemPopupReservaCadastro.DataValueField = "Value";

                        // Atribui a lista como o DataSource do DropDownList
                        DropDownListHospedagemPopupReservaCadastro.DataSource = items;
                        DropDownListHospedagemPopupReservaCadastro.DataBind();
                    }
                }
            }
        }

        private void PopularDropdownListTransporte()
        {
            // Define a string de conexão com o banco de dados
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConnectionString"].ConnectionString;

            // Define a consulta SQL para selecionar os dados da tabela
            string query = "SELECT [SQ_TRANSPORTE], [NOME] FROM [dbo].[SEMEAR_TRANSPORTE_TEMP]";

            // Cria uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Cria um comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Executa o comando SQL e obtém um SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Cria uma lista para armazenar os itens do DropDownList
                        List<ListItem> items = new List<ListItem>();

                        // Adiciona o item "Selecione o Transporte" à lista
                        items.Add(new ListItem("Selecione o Transporte", "0"));

                        // Adiciona os itens do leitor à lista
                        while (reader.Read())
                        {
                            string nomeTransporte = reader["NOME"].ToString();
                            string sqTransporte = reader["SQ_TRANSPORTE"].ToString();
                            items.Add(new ListItem(nomeTransporte, sqTransporte));
                        }

                        // Define os campos do DropDownList
                        DropDownListTransportePopupReservaCadastro.DataTextField = "Text";
                        DropDownListTransportePopupReservaCadastro.DataValueField = "Value";

                        // Atribui a lista como o DataSource do DropDownList
                        DropDownListTransportePopupReservaCadastro.DataSource = items;
                        DropDownListTransportePopupReservaCadastro.DataBind();
                    }
                }
            }
        }

        private void limparCadastro()
        {
            //TbxNomePopupReservaCadastro.Text = "";
            //TbxTel1PopupReservaCadastro.Text = "";
            //TbxEmailPopupReservaCadastro.Text = "";
            //TbxNascimentoPopupReservaCadastro.Text = "";
            //TbxCPFPopupReservaCadastro.Text = "";
            //TbxNumPassPopupReservaCadastro.Text = "";
            //TbxDataEmissPassPopupReservaCadastro.Text = "";
            //TbxDataValiPassPopupReservaCadastro.Text = "";
            //TbxNumRGPopupReservaCadastro.Text = "";
            //TbxOrgaoEmissorPopupReservaCadastro.Text = "";
            //TbxDataEmissRGPopupReservaCadastro.Text = "";
            //DropDownListFuncionarioPopupReservaCadastro.SelectedValue = "0";
            //TbxSalarioFuncionaroPopupReservaCadastro.Text = "";
            //TbxSaldoPopupReservaCadastro.Text = "";
            //DropDownListFuncionarioPopupReservaCadastro.SelectedValue = "0";
            //DropDownListFlagExcluidoPopupReservaCadastro.SelectedValue = "0";
            //TbxBairroPopupReservaCadastro.Text = "";
            //TbxCidadePopupReservaCadastro.Text = "";
            //TbxUFPopupReservaCadastro.Text = "";
            //TbxRuaPopupReservaCadastro.Text = "";
            //TbxCEPPopupReservaCadastro.Text = "";
            //GridViewReservas.SelectedIndex = -1;


        }

        protected void btnLimparPopupReservaCadastro_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int getMaxValue()
        {

            int maxValue = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(SQ_RESERVA) AS MaxValue FROM dbo.SEMEAR_RESERVA";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        maxValue = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }

            return maxValue;


        }
    }
}