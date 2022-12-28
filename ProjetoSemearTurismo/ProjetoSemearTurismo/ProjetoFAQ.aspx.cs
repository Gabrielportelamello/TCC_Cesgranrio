using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSemearTurismo
{
    public partial class ProjetoFAQ : System.Web.UI.Page
    {
        public string sq_faqBD { get; set; }
        //public AdConexao m_oConexao;




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVBing();
            }
        }


        protected void GVBing()
        {
            //string oradb = "data source=SEID;user ID=system;password=mid;Pooling=false";
            //OracleConnection conn = new OracleConnection(oradb);
            //OracleDataAdapter a = new OracleDataAdapter(" SELECT c.sq_faq,c.nu_sistema,c.co_orgao,da.de_aplicativo, do.de_orgao, c.de_pergunta,c.de_resposta, c.fl_excluido FROM CRIMINAL.faq c , detran.aplicativo da, DETRAN.orgaos do where da.nu_aplicativo=c.nu_sistema and do.co_orgao = c.co_orgao order by c.sq_faq ", conn);
            //conn.Open();
            //OracleCommandBuilder builder = new OracleCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds);

            //GridView1.DataSource = ds;
            //GridView1.DataBind();

            //conn.Close();
            //conn.Dispose();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////(string)this.grid.DataKeys[rowIndex]["myKey"];


            //btnCadastrar.Visible = false;
            //btnEditar.Visible = true;
            //string sIndiceRegistro = GridView1.SelectedDataKey.Value.ToString();

            //preencheFrmEdicao(sIndiceRegistro);

            //mp2.Show();

        }

        private void preencheFrmEdicao(string sIndiceRegistro)
        {
            //if (DropDownListOrgaos.Items.Count < 1)
            //{
            //    try
            //    {
            //        DropDownListOrgaos.Items.Add("");
            //        preencheComboOrgaos();
            //    }
            //    catch
            //    {

            //    }
            //}
            //if (DropDownListSistemas.Items.Count < 1)
            //{
            //    try
            //    {
            //        DropDownListSistemas.Items.Add("");
            //        preencheComboSistemas();
            //    }
            //    catch
            //    {

            //    }
            //}
            //if (sIndiceRegistro != null)
            //{
            //    try { preencheFormEdicao(sIndiceRegistro); } catch { }

            //}


        }

        private void preencheFormEdicao(string sIndiceRegistro)
        {
            //string oradb = "data source=SEID;user ID=system;password=mid;Pooling=false";
            //OracleConnection conn = new OracleConnection(oradb);
            //OracleDataAdapter a = new OracleDataAdapter(" select * from criminal.faq a, CRIMINAL.faq_imagens b where a.sq_faq =b.sq_faq (+) and a.sq_faq = " + sIndiceRegistro, conn);
            //conn.Open();
            //OracleCommandBuilder builder = new OracleCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds, "faq");
            ////continnuar daqui.
            //foreach (DataRow r in ds.Tables["faq"].Rows)
            //{

            //    DropDownListOrgaos.SelectedIndex = Convert.ToInt32(r["CO_ORGAO"].ToString());
            //    DropDownListSistemas.SelectedIndex = Convert.ToInt32(r["NU_SISTEMA"].ToString());
            //    tbxPergunta.Text = r["DE_PERGUNTA"].ToString();
            //    tbxResposta.Text = r["DE_RESPOSTA"].ToString();
            //    lblNumeroRegistro.Text = r["SQ_FAQ"].ToString();
            //    DropDownListFLExcluidos.SelectedValue = r["FL_EXCLUIDO"].ToString();
            //    imgBanner1.ImageUrl = GetImage((byte[])r["IM_FAQ1"]);
            //}



            //conn.Close();
            //conn.Dispose();
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var indice = GridView1.Rows[e.RowIndex].Cells[0].Text.ToString();
            excluiRegistro(indice);

        }

        private void excluiRegistro(string indice)
        {
            //update
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVBing();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();

        }
        protected void preencheComboOrgaos()
        {

            //string oradb = "data source=SEID;user ID=system;password=mid;Pooling=false";
            //OracleConnection conn = new OracleConnection(oradb);
            //OracleDataAdapter a = new OracleDataAdapter(" SELECT * FROM DETRAN.orgaos order by co_orgao ", conn);
            //conn.Open();
            //OracleCommandBuilder builder = new OracleCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds, "orgaos");
            //foreach (DataRow r in ds.Tables["orgaos"].Rows)
            //{
            //    DropDownListOrgaos.Items.Add(r["CO_ORGAO"].ToString() + " - " + r["DE_ORGAO"].ToString());
            //}

            //conn.Close();
            //conn.Dispose();
        }
        protected void exibeImg()
        {
            //byte[] arqSelecionado;
            //arqSelecionado = fileUpload1.FileBytes;
            //Console.WriteLine("arquivo : " + arqSelecionado.ToString());
            ///*fileUpload1.SaveAs(); */
        }
        protected void preencheComboSistemas()
        {
            //string oradb = "data source=SEID;user ID=system;password=mid;Pooling=false";
            //OracleConnection conn = new OracleConnection(oradb);
            //OracleDataAdapter a = new OracleDataAdapter(" SELECT * FROM DETRAN.aplicativo order by nu_aplicativo ", conn);
            //conn.Open();
            //OracleCommandBuilder builder = new OracleCommandBuilder(a);
            //DataSet ds = new DataSet();
            //a.Fill(ds, "aplicativo");
            //foreach (DataRow r in ds.Tables["aplicativo"].Rows)
            //{
            //    DropDownListSistemas.Items.Add(r["nu_aplicativo"].ToString() + " - " + r["DE_APLICATIVO"].ToString());
            //}

            //conn.Close();
            //conn.Dispose();
        }
        protected void preencheCmbOrgaos(object sender, EventArgs e)
        {

            //if (DropDownListOrgaos.Items.Count < 1)
            //{
            //    try
            //    {
            //        DropDownListOrgaos.Items.Add("");
            //        preencheComboOrgaos();
            //    }
            //    catch
            //    {

            //    }
            //}

        }
        protected void realizaEdicaoCadastro(object sender, EventArgs e)
        {

            ////if (DropDownListOrgaos.SelectedIndex>0 && DropDownListSistemas.SelectedIndex>0 & string.IsNullOrWhiteSpace(tbxPergunta.Text) && string.IsNullOrWhiteSpace(tbxResposta.Text))
            ////{
            ////exibeImg();

            //if (DropDownListOrgaos.SelectedIndex > 0 && DropDownListSistemas.SelectedIndex > 0 & !string.IsNullOrWhiteSpace(tbxPergunta.Text) && !string.IsNullOrWhiteSpace(tbxResposta.Text))
            //{
            //    string sIndiceRegistro = GridView1.SelectedDataKey.Value.ToString();
            //    editaPR(sIndiceRegistro);
            //    EditaImagensPR(sIndiceRegistro);
            //    //exibeImg();

            //}
            ////}


        }
        protected string editaPR(string SQRegistro)
        {

            //m_oConexao = new AdConexao();
            string sq_faq = null;
            //string sSQL = null;


            ////string Str_Existencia = "";


            //OracleCommand oCmd = default(OracleCommand);
            //OracleDataReader odrRet;



            ////fazer um update na ultima sqdrvcol registrada do SQ_DRV fornecido , "primary key"

            //sSQL += "UPDATE CRIMINAL.faq SET SQ_FAQ = " + SQRegistro + ", NU_SISTEMA = " + DropDownListSistemas.SelectedItem.Text.Substring(0, DropDownListSistemas.SelectedItem.Text.IndexOf("-") - 1) + ", CO_ORGAO = " + DropDownListOrgaos.SelectedItem.Text.Substring(0, DropDownListOrgaos.SelectedItem.Text.IndexOf("-") - 1) + " , DE_PERGUNTA = '" + tbxPergunta.Text + "' , DE_RESPOSTA = '" + tbxResposta.Text + "', FL_EXCLUIDO = " + DropDownListFLExcluidos.SelectedItem.Value;
            //sSQL += " WHERE SQ_FAQ = " + SQRegistro;

            //if (!m_oConexao.Aberta())
            //    m_oConexao.Abrir();

            //m_oConexao.IniciarTransacao();

            //oCmd = m_oConexao.ComandoSQL(sSQL.ToString());
            //oCmd.BindByName = true;
            ////oCmd.Parameters.Add("IM_FAQ1", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img1;
            ////oCmd.Parameters.Add("IM_FAQ2", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img2;
            ////oCmd.Parameters.Add("IM_FAQ3", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img3;

            //try { oCmd.ExecuteNonQuery(); } catch (Exception ex) { }

            //m_oConexao.FinalizarTransacao(true);
            //m_oConexao.Fechar();


            return sq_faq;
        }

        protected void realizaCadastro(object sender, EventArgs e)
        {
            sq_faqBD = "";
            if (DropDownListOrgaos.SelectedIndex > 0 && DropDownListSistemas.SelectedIndex > 0 & !string.IsNullOrWhiteSpace(tbxPergunta.Text) && !string.IsNullOrWhiteSpace(tbxResposta.Text))
            {
                sq_faqBD = cadastraPR();
                cadastraImagensPR(sq_faqBD);

                //exibeImg();

            }
        }

        private string cadastraImagensPR(string sq_faqBD)
        {
            //pronto


            //m_oConexao = new AdConexao();
            string sq_faqImagens = null;
            //string sSQL = null;
            ////string Str_Existencia = "";


            //OracleCommand oCmd = default(OracleCommand);
            //OracleDataReader odrRet;


            ////já existe em drv insert com a foto atual, data atual como data de inclusão, criar sqdrvcol continuando do ultimo drvcol "primary key"
            //if (!m_oConexao.Aberta())
            //    m_oConexao.Abrir();

            //m_oConexao.IniciarTransacao();
            //sq_faqImagens = m_oConexao.ProximoValorSequence("CRIMINAL.SEQ_FAQIMG").ToString();

            //sSQL += "insert into CRIMINAL.faq_imagens (SQ_FAQ, SQ_FAQIMG, IM_FAQ1, IM_FAQ2, IM_FAQ3) ";
            //sSQL += " values (" + sq_faqBD + "," + sq_faqImagens + ", :IM_FAQ1, :IM_FAQ2, :IM_FAQ3) ";

            //oCmd = m_oConexao.ComandoSQL(sSQL.ToString());

            //oCmd.Parameters.Add("IM_FAQ1", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = fileUpload1.FileBytes;
            //oCmd.Parameters.Add("IM_FAQ2", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = fileUpload2.FileBytes;
            //oCmd.Parameters.Add("IM_FAQ3", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = fileUpload3.FileBytes;

            //oCmd.ExecuteNonQuery();
            //oCmd.Dispose();
            //m_oConexao.FinalizarTransacao(true);
            //m_oConexao.Fechar();

            return sq_faqImagens;

        }
        private string EditaImagensPR(string sq_faqBD)
        {
            //pronto


            //m_oConexao = new AdConexao();
            string sq_faqImagens = null;
            //string sSQL = null;

            //byte[] img1 = null;
            //byte[] img2 = null;
            //byte[] img3 = null;

            //img1 = Convert.FromBase64String(imgBanner1.ImageUrl);
            //img2 = Convert.FromBase64String(imgBanner2.ImageUrl);
            //img3 = Convert.FromBase64String(imgBanner3.ImageUrl);

            ////string Str_Existencia = "";


            //OracleCommand oCmd = default(OracleCommand);
            //OracleDataReader odrRet;



            ////fazer um update na ultima sqdrvcol registrada do SQ_DRV fornecido , "primary key"

            //sSQL += "UPDATE CRIMINAL.faq_imagens SET IM_FAQ1 = :IM_FAQ1, IM_FAQ2 = :IM_FAQ2, IM_FAQ3 = :IM_FAQ3 ";
            //sSQL += " WHERE SQ_FAQ = " + sq_faqBD;

            //if (!m_oConexao.Aberta())
            //    m_oConexao.Abrir();

            //m_oConexao.IniciarTransacao();

            //oCmd = m_oConexao.ComandoSQL(sSQL.ToString());
            //oCmd.BindByName = true;
            //oCmd.Parameters.Add("IM_FAQ1", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img1;
            //oCmd.Parameters.Add("IM_FAQ2", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img2;
            //oCmd.Parameters.Add("IM_FAQ3", Oracle.ManagedDataAccess.Client.OracleDbType.Blob).Value = img3;

            //try { oCmd.ExecuteNonQuery(); } catch (Exception ex) { }

            //m_oConexao.FinalizarTransacao(true);
            //m_oConexao.Fechar();


            return sq_faqImagens;

        }

        protected string cadastraPR()
        {
            ////adicionar as imagens


            //m_oConexao = new AdConexao();
            string SQ_FAQ = null;
            //string sSQL = null;
            ////string Str_Existencia = "";


            //OracleCommand oCmd = default(OracleCommand);
            //OracleDataReader odrRet;

            ////if (tipoSalvar == "0" || tipoSalvar == "1" || tipoSalvar == "2")
            ////{
            ////já existe em drv insert com a foto atual, data atual como data de inclusão, criar sqdrvcol continuando do ultimo drvcol "primary key"
            //if (!m_oConexao.Aberta())
            //    m_oConexao.Abrir();

            //m_oConexao.IniciarTransacao();
            //SQ_FAQ = m_oConexao.ProximoValorSequence("CRIMINAL.SEQ_FAQ").ToString();

            //sSQL = "INSERT INTO criminal.faq (SQ_FAQ,NU_SISTEMA,CO_ORGAO,DE_PERGUNTA,DE_RESPOSTA,FL_EXCLUIDO)";
            //sSQL += " VALUES (" + SQ_FAQ + "," + DropDownListSistemas.SelectedIndex + "," + DropDownListOrgaos.SelectedIndex + ",'" + tbxPergunta.Text + "','" + tbxResposta.Text + "'," + DropDownListFLExcluidos.SelectedValue + ")";

            //oCmd = m_oConexao.ComandoSQL(sSQL.ToString());


            //oCmd.ExecuteNonQuery();
            //oCmd.Dispose();
            //m_oConexao.FinalizarTransacao(true);
            //m_oConexao.Fechar();

            return SQ_FAQ;


        }






        protected void preencheCmbSistemas(object sender, EventArgs e)
        {

            if (DropDownListSistemas.Items.Count < 1)
            {
                try
                {
                    DropDownListSistemas.Items.Add("");
                    preencheComboSistemas();
                }
                catch
                {

                }
            }

        }

        protected void limpaCadastro()
        {
            DropDownListFLExcluidos.SelectedIndex = 0;
            DropDownListOrgaos.SelectedIndex = 0;
            DropDownListSistemas.SelectedIndex = 0;
            tbxPergunta.Text = "";
            tbxResposta.Text = "";
            //fileUpload1 = null;
            //fileUpload2 = null;
            //fileUpload3 = null;
            //imgBanner1 = null   ;
            //imgBanner2 = null   ;
            //imgBanner3 = null   ;
            btnCadastrar.Visible = true;
            btnEditar.Visible = false;

        }

        protected void BtnCriar_Click(object sender, EventArgs e)
        {
            limpaCadastro();
            mp2.Show();
        }

        protected void BtnCancelar2_Click(object sender, EventArgs e)
        {
            limpaCadastro();
        }
    }
}