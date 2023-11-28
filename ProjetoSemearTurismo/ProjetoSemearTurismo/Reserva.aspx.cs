using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DocumentFormat.OpenXml.Drawing.Charts;
using ProjetoSemearTurismo.Classes;


namespace ProjetoSemearTurismo.Views
{
    public partial class Download : System.Web.UI.Page
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
                GVBing();

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
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter a = new SqlDataAdapter("SELECT   V.NOME_VIAGEM,   P.Nome, " +
                "  P.CPF,  H.Nome as Nome_Hospedagem,  T.NOME as Nome_Transporte, R.SQ_HPR_PK, SQ_TRANSPORTE_FK, SQ_HOSPEDAGEM_FK, SQ_VIAGEM_FK, SQ_CLIENTE_FK,V.DT_InicialPeriodo_viagem  " +
                "FROM   SEMEAR_VIAGEM V" +
                "  JOIN SEMEAR_ASSOCIATIVA_VPR R ON V.SQ_VIAGEM = R.SQ_VIAGEM_FK" +
                "   JOIN SEMEAR_PESSOA P ON P.SQ_PESSOA = R.SQ_CLIENTE_FK " +
                "LEFT JOIN SEMEAR_HOSPEDAGEM_TEMP H ON R.SQ_HOSPEDAGEM_FK = H.SEQ_HOSPEDAGEM" +
                "   LEFT JOIN SEMEAR_TRANSPORTE_TEMP T ON R.SQ_TRANSPORTE_FK = T.SQ_TRANSPORTE" +
                "  LEFT JOIN SEMEAR_HOSPEDAGEM_TEMP H_NULL ON R.SQ_TRANSPORTE_FK IS NOT NULL AND R.SQ_HOSPEDAGEM_FK IS NULL" +
                " LEFT JOIN SEMEAR_TRANSPORTE_TEMP T_NULL ON R.SQ_HOSPEDAGEM_FK IS NOT NULL AND R.SQ_TRANSPORTE_FK IS NULL " +
                " WHERE " +
                "R.DT_EXCLUSAO is null and  (H.SEQ_HOSPEDAGEM IS NOT NULL " +
                "OR T.SQ_TRANSPORTE IS NOT NULL " +
                "OR (H_NULL.SEQ_HOSPEDAGEM IS NULL " +
                "AND T_NULL.SQ_TRANSPORTE IS NULL))", conn);
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            DataSet ds = new DataSet();
            a.Fill(ds);

            GridViewReservas.DataSource = ds;
            GridViewReservas.DataBind();

            conn.Close();
            conn.Dispose();

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
            if (GridViewReservas.SelectedRow != null)
            {
                string transporteID = GridViewReservas.DataKeys[GridViewReservas.SelectedRow.RowIndex]["SQ_TRANSPORTE_FK"].ToString();
                string hospedagemID = GridViewReservas.DataKeys[GridViewReservas.SelectedRow.RowIndex]["SQ_HOSPEDAGEM_FK"].ToString();
                string viagemID = GridViewReservas.DataKeys[GridViewReservas.SelectedRow.RowIndex]["SQ_VIAGEM_FK"].ToString();
                string clienteID = GridViewReservas.DataKeys[GridViewReservas.SelectedRow.RowIndex]["SQ_CLIENTE_FK"].ToString();

                string sIndiceRegistro = GridViewReservas.DataKeys[GridViewReservas.SelectedRow.RowIndex]["SQ_HPR_PK"].ToString();
                // Obtém os valores dos campos da linha selecionada
                if (!string.IsNullOrEmpty(transporteID))
                    DropDownListTransportePopupReservaCadastro.SelectedValue = transporteID;
                else
                    DropDownListTransportePopupReservaCadastro.SelectedValue = "0";


                if (!string.IsNullOrEmpty(hospedagemID))
                    DropDownListHospedagemPopupReservaCadastro.SelectedValue = hospedagemID;
                else
                    DropDownListHospedagemPopupReservaCadastro.SelectedValue = "0";


                if (!string.IsNullOrEmpty(clienteID))
                    DropDownListClientePopupReservaCadastro.SelectedValue = clienteID;
                else
                    DropDownListClientePopupReservaCadastro.SelectedValue = "0";

                if (!string.IsNullOrEmpty(viagemID))
                    DropDownListViagemPopupReservaCadastro.SelectedValue = viagemID;
                else
                    DropDownListViagemPopupReservaCadastro.SelectedValue = "0";
                BtnCadastrarPopupReservaCadastro.Visible = false;
                BtnEditarCadastroPopupReservaCadastro.Visible = true;
               
            }
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }
        protected void BtnCadastrarReservaModal_Click(object sender, EventArgs e)
        {
            if (DropDownListViagemPopupReservaCadastro.SelectedIndex > 0 && DropDownListClientePopupReservaCadastro.SelectedIndex > 0)
            {
                RealizaCadastroReservaAssociativa();
            }

        }
        private void RealizaCadastroReservaAssociativa()
        {
            string viagem = DropDownListViagemPopupReservaCadastro.SelectedValue;
            string cliente = DropDownListClientePopupReservaCadastro.SelectedValue;
            string hospedagem = "null";
            string transporte = "null";
            if (DropDownListHospedagemPopupReservaCadastro.SelectedIndex > 0)
                hospedagem = DropDownListHospedagemPopupReservaCadastro.SelectedValue;
            if (DropDownListTransportePopupReservaCadastro.SelectedIndex > 0)
                transporte = DropDownListTransportePopupReservaCadastro.SelectedValue;
            if (DropDownListViagemPopupReservaCadastro.SelectedIndex > 0 && DropDownListClientePopupReservaCadastro.SelectedIndex > 0)
            {
                using (SqlConnection openCon = new SqlConnection(connectionString))
                {
                    string saveStaff = "INSERT INTO[dbo].[SEMEAR_ASSOCIATIVA_VPR] " + "([SQ_VIAGEM_FK],[SQ_CLIENTE_FK],[DT_INCLUSAO],[DT_EDICAO],[SQ_HOSPEDAGEM_FK],[SQ_TRANSPORTE_FK])" +
                    " VALUES ( " + viagem + " , " + cliente + " , (SELECT GETDATE() AS CurrentDateTime),(SELECT GETDATE() AS CurrentDateTime)," + hospedagem + "," + transporte + ")";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;

                        openCon.Open();

                        querySaveStaff.ExecuteNonQuery();

                        openCon.Dispose();
                        openCon.Close();
                    }
                }
            }
            else
            {
                //mensagem de retorno "selecionar uma viagem e um cliente"
            }



            GVBing();
        }
        private void RealizaCadastroReserva()
        {
            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
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
        private void RealizaEdicaoCadastroReserva(string indiceRegistro, string clienteID, string viagemID, string transporteID, string hospedagemID)
        {

            using (SqlConnection openCon = new SqlConnection(connectionString))
            {
                string saveStaff = "UPDATE [dbo].[SEMEAR_ASSOCIATIVA_VPR]   SET [SQ_VIAGEM_FK] = " + viagemID + " ,[SQ_CLIENTE_FK] = " + clienteID + "  ,[DT_EDICAO] = " + viagemID + "    ,[SQ_HOSPEDAGEM_FK] = " + hospedagemID + "      ,[SQ_TRANSPORTE_FK] = " + transporteID + "  WHERE <Critérios de Pesquisa,,>  WHERE SQ_HPR_PK = " + indiceRegistro;


                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();

                    openCon.Dispose();
                    openCon.Close();
                }
            }


            if (TbxPesquisarGridReservas.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
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

            if (GridViewReservas.SelectedIndex >= 0)
            {
                string sIndiceRegistro = GridViewReservas.SelectedDataKey.Value.ToString();
                // Obtém os valores dos campos da linha selecionada
                string transporteID = GridViewReservas.SelectedRow.Cells[5].Text;
                string hospedagemID = GridViewReservas.SelectedRow.Cells[6].Text;
                string clienteID = GridViewReservas.SelectedRow.Cells[8].Text;
                string viagemID = GridViewReservas.SelectedRow.Cells[7].Text;
                RealizaEdicaoCadastroReserva(sIndiceRegistro, clienteID, viagemID, transporteID, hospedagemID);
            }

            if (TbxPesquisarGridReservas.Text != "")
            {
                GVBingSearch();
            }
            else
            {
                GVBing();
            }
            GridViewReservas.SelectedIndex = -1;

            BtnCadastrarPopupReservaCadastro.Visible = true;
            BtnEditarCadastroPopupReservaCadastro.Visible = false;
            btnLimparPopupReservaCadastro.Visible = true;
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
            GridViewReservas.SelectedIndex = -1;

            if (BtnEditarCadastroPopupReservaCadastro.Visible == true)
            {
                limparCadastro();

            }
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
            GridViewReservas.SelectedIndex = -1;
            DropDownListClientePopupReservaCadastro.SelectedValue = "0";
            DropDownListTransportePopupReservaCadastro.SelectedValue = "0";
            DropDownListHospedagemPopupReservaCadastro.SelectedValue = "0";
            DropDownListViagemPopupReservaCadastro.SelectedValue = "0";
            BtnCadastrarPopupReservaCadastro.Visible = true;
            BtnEditarCadastroPopupReservaCadastro.Visible = false;
            btnLimparPopupReservaCadastro.Visible = true;


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

    }
}