using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSemearTurismo
{
    public partial class teste : System.Web.UI.Page
    {
     

            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();

            //public string SQ_DRV { get; private set; }
            //public string SQ_DRV_COLETA .Text{ get; private set; }
            //private Inicializa mVariaveis = Inicializa.getInstance();

            public string sPathImagem = "";
            //public MICaptura oMICaptura = null;
            public string nomeDriver;

            //Bitmap imgFoto = null;
            //Bitmap imgPolegarD = null;
            //Bitmap imgIndicadorD = null;
            //Bitmap imgMedioD = null;
            //Bitmap imgAnelarD = null;
            //Bitmap imgMinimoD = null;
            //Bitmap imgPolegarE = null;
            //Bitmap imgIndicadorE = null;
            //Bitmap imgMedioE = null;
            //Bitmap imgAnelarE = null;
            //Bitmap imgMinimoE = null;
            //public string SQ_DRV { get; set; }
            //private string SQ_DRV_IMAGENS.Text.Text { get; set; }
            //private string SQ_DRV_COLETA .Text{ get; set; }

            //private int scoreCert;

            private int resultadoCertificacaoPositivado { get; set; }
            private int resultadoCertificacaoScore { get; set; }

            protected void Page_Load(object sender, EventArgs e)
            {
                //if (!IsPostBack)
                //{

                //    TbxCPF.Focus();
                //}
                ////TbxCPF.TextMode;
            }

            protected void TbxCPF_TextChanged(object sender, EventArgs e)
            {
            }
            public static class ValidaCPF
            {
                //public static bool IsCpf(string cpf)
                //{
                //    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                //    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                //    string tempCpf;
                //    string digito;
                //    int soma;
                //    int resto;
                //    cpf = cpf.Trim();
                //    cpf = cpf.Replace(".", "").Replace("-", "");
                //    if (cpf.Length != 11)
                //        return false;
                //    tempCpf = cpf.Substring(0, 9);
                //    soma = 0;

                //    for (int i = 0; i < 9; i++)
                //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                //    resto = soma % 11;
                //    if (resto < 2)
                //        resto = 0;
                //    else
                //        resto = 11 - resto;
                //    digito = resto.ToString();
                //    tempCpf = tempCpf + digito;
                //    soma = 0;
                //    for (int i = 0; i < 10; i++)
                //        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                //    resto = soma % 11;
                //    if (resto < 2)
                //        resto = 0;
                //    else
                //        resto = 11 - resto;
                //    digito = digito + resto.ToString();
                //    return cpf.EndsWith(digito);
                //}
            }
            protected void ImgBtnConsultar_Click(object sender, ImageClickEventArgs e)
            {
                //try
                //{

                //    //todos sim
                //    if (TbxCPF.Text != "" && TbxCNH.Text != "" && TbxRG.Text != "")
                //    {
                //        BuscarPorCPF();
                //        if (TbxNome.Text == "" && TbxNascimento.Text == "")
                //        { BuscarPorCNH(); }
                //        if (TbxNome.Text == "" && TbxNascimento.Text == "")
                //        { BuscarPorRG(); }
                //    }
                //    //2 sim 1 não 
                //    else if (TbxCPF.Text == "" && TbxCNH.Text != "" && TbxRG.Text != "")
                //    {
                //        // VERIFICAR A PRIORIDADE DE BUSCAR 
                //        BuscarPorCNH();
                //        if (TbxNome.Text == "" && TbxNascimento.Text == "")
                //        { BuscarPorRG(); }

                //    }
                //    else if (TbxCPF.Text != "" && TbxCNH.Text == "" && TbxRG.Text != "")
                //    {
                //        BuscarPorCPF();
                //        if (TbxNome.Text == "" && TbxNascimento.Text == "")
                //        { BuscarPorRG(); }


                //    }
                //    else if (TbxCPF.Text != "" && TbxCNH.Text != "" && TbxRG.Text == "")
                //    {
                //        BuscarPorCPF();
                //        if (TbxNome.Text == "" && TbxNascimento.Text == "")
                //        { BuscarPorCNH(); }

                //    }
                //    //1 sim 2 não
                //    else if (TbxCPF.Text == "" && TbxCNH.Text == "" && TbxRG.Text != "")
                //    {
                //        BuscarPorRG();
                //    }
                //    else if (TbxCPF.Text != "" && TbxCNH.Text == "" && TbxRG.Text == "")
                //    {
                //        BuscarPorCPF();

                //    }
                //    else if (TbxCPF.Text == "" && TbxCNH.Text != "" && TbxRG.Text == "")
                //    {
                //        BuscarPorCNH();
                //    }

                //    //todos não
                //    else if (TbxCPF.Text == "" && TbxCNH.Text == "" && TbxRG.Text == "")
                //    {
                //        LblDescricaoMessageBox.Text = "Preencha, CPF, CNH OU RG para realizar uma consulta";

                //        MessageBoxPopup.Show();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    LblDescricaoMessageBox.Text = "Erro! - " + ex.Message;
                //    MessageBoxPopup.Show();

                //}

            }



            //The actual converting function
            public string GetImage(object img)
            {
                return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
            }



            protected void BtnLimpar_Click(object sender, EventArgs e)
            {
                //limparComCPF();
                //desativaBtn();
            }

            protected void btnCapturarFoto_Click(object sender, EventArgs e)
            {
                //if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "")
                //{
                //    btnSalvar.Visible = true;
                //    btnCertificarCidadao.Visible = false;
                //    mp2.Show();
                //}
                //else
                //{
                //    LblDescricaoMessageBox.Text = "Preencha todos os dados antes de capturar a foto";
                //    MessageBoxPopup.Show();
                //}


            }

            protected void btnRegistrar_Click(object sender, EventArgs e)
            {
                //if ( TbxNome.Text != "" && 
                //   TbxNascimento.Text != "" && ImgCidadao.ImageUrl.Length > 21 )
                //{
                //    try
                //    {
                //        //SQ_DRV_COLETA .Text= null; 
                //        ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
                //        bool existenciaDeRegistro = obj.VerificaExistenciaCPF(TbxCPF.Text);

                //        if (SQ_DRV.Text != null && SQ_DRV_COLETA.Text!= null)
                //        {



                //            //SQ_DRV = obj.Salvar_Entrega(txtnome.Text, txtpai.Text, txtmae.Text, txtrg.Text, txtcpf.Text, txtnascimento.Text, "0");
                //            byte[] imgFoto1 = null;
                //            byte[] imgPolegarD1 = null;
                //            byte[] imgIndicadorD1 = null;
                //            byte[] imgMedioD1 = null;
                //            byte[] imgAnelarD1 = null;
                //            byte[] imgMinimoD1 = null;
                //            byte[] imgPolegarE1 = null;
                //            byte[] imgIndicadorE1 = null;
                //            byte[] imgMedioE1 = null;
                //            byte[] imgAnelarE1 = null;
                //            byte[] imgMinimoE1 = null;
                //            // no caso de um novo registro (que não esteja presente na base do SEI e DRV), SERÃO COLETADAS TODAS AS DIGITAIS DO CIDADÃO, DADOS BIOGRAFICOS, E FOTO DO ROSTO
                //            if (ImgCidadao.ImageUrl.Length > 21) {
                //                var b = ImgCidadao.ImageUrl;

                //                    b = b.Substring(22);
                //                imgFoto1 = Convert.FromBase64String(b);

                //                }

                //            ////teste restirar
                //            //imgMinimoE1 = ImageToByte2(imgAnelarE);

                //            //SQ_DRV_COLETA .Text= obj.SalvarEntregaColetaSSED("0", SQ_DRV, imgFoto1);
                //            //SQ_DRV_IMAGENS.Text = obj.Salvar_Entrega_Imagens(SQ_DRV.Text, imgFoto1, imgPolegarD1, imgIndicadorD1, imgMedioD1, imgAnelarD1, imgMinimoD1, imgPolegarE1, imgIndicadorE1, imgMedioE1, imgAnelarE1, imgMinimoE1);

                //            //MessageBox.Show("Registro efetuado", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        }
                //        else { /*MessageBox.Show("ERRO AO CADASTRAR CPF já cadastrado na DRV");*/ }
                //    }
                //    catch (Exception ex) { /*MessageBox.Show("ERRO: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error); */}
                //    //MessageBox.Show(obj.Salvar_Entrega());
                //}
                //else {/* MessageBox.Show("Preencha os dados, realize a captura da foto, e realize a captura das digitais antes de registrar", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); */}


            }

            protected void btnCertificar_Click(object sender, EventArgs e)
            {

                //btnSalvar.Visible = false;
                //btnCertificarCidadao.Visible = true;
                //mp2.Show();


            }

            private void BuscarPorCPF()
            {
                ////pronto testar 2022.09.08
                //try
                //{


                //    limpar();

                //    if (TbxCPF.Text != "")
                //    {
                //        if (ValidaCPF.IsCpf(TbxCPF.Text))
                //        {

                //            desativaBtn();
                //            //m_oConexao = new AdConexao();
                //            //oadc = new AdConsulta();           
                //            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
                //            string[] sDados;
                //            string[] sDadosDRV;
                //            string[] sDadosCNH;
                //            byte[] bfoto;
                //            byte[] bfotoDRV;
                //            byte[] bfotoCNH;

                //            sDadosDRV = obj.Ler_Cpf_DRV(TbxCPF.Text).Split(';');
                //            //sDadosDRV = obj.Ler_Cpf_DRV("001122556688").Split(';');

                //            if (sDadosDRV.Length > 5)
                //            {
                //                TbxNome.Text = sDadosDRV[1].ToString();
                //                TbxNomePai.Text = sDadosDRV[2].ToString();
                //                TbxNomeMae.Text = sDadosDRV[3].ToString();

                //                TbxNascimento.Text = sDadosDRV[6].ToString().Substring(6, 4) + "-" + sDadosDRV[6].ToString().Substring(3, 2) + "-" + sDadosDRV[6].ToString().Substring(0, 2);

                //                TbxRG.Text = sDadosDRV[4].ToString();
                //                TbxCNH.Text = sDadosDRV[9].ToString();

                //                bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
                //                //bfotoDRV = obj.LerFotoAtualCNH(TbxCPF.Text);
                //                byte[] pData = bfotoDRV;
                //                if (pData.Length > 1)
                //                {
                //                    if (pData.Length > 0)
                //                    {
                //                        ImgCidadao.ImageUrl = GetImage(pData);
                //                        TxtImg2.Value = ImgCidadao.ImageUrl;
                //                    }
                //                    else
                //                    {
                //                        ImgCidadao.ImageUrl = null;
                //                        TxtImg2.Value = null;
                //                    }

                //                    //MemoryStream mStream = new MemoryStream();

                //                    //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                    //Bitmap bm = new Bitmap(mStream, false);
                //                    //mStream.Dispose();
                //                    //if (bm != null)
                //                    //    pctbFoto.Image = bm;
                //                }
                //                else
                //                {
                //                    bfotoCNH = obj.LerFotoAtualCNH(TbxCPF.Text);
                //                    pData = bfotoCNH;
                //                    if (pData.Length > 1)
                //                    {
                //                        if (pData.Length > 0)
                //                        {
                //                            ImgCidadao.ImageUrl = GetImage(pData);
                //                            TxtImg2.Value = ImgCidadao.ImageUrl;
                //                        }
                //                        else
                //                        {
                //                            ImgCidadao.ImageUrl = null;
                //                            TxtImg2.Value = null;
                //                        }

                //                        //MemoryStream mStream = new MemoryStream();

                //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                        //Bitmap bm = new Bitmap(mStream, false);
                //                        //mStream.Dispose();
                //                        //if (bm != null)
                //                        //    pctbFoto.Image = bm;
                //                    }
                //                }

                //                SQ_DRV.Text = sDadosDRV[0].ToString();

                //                //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
                //                SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("2", SQ_DRV.Text, pData);


                //                ativaBtnCertificar();
                //                //teste
                //                //btnCapturarDigital.Enabled = true;
                //                //BtnRegistrar.Enabled = true;
                //            }
                //            else
                //            {
                //                sDados = obj.Ler_Cpf(TbxCPF.Text).Split(';');
                //                //sDados = obj.Ler_Cpf("001122556688").Split(';');
                //                if (sDados.Length > 5)
                //                {

                //                    TbxNome.Text = sDados[0].ToString();
                //                    TbxNomePai.Text = sDados[1].ToString();
                //                    TbxNomeMae.Text = sDados[2].ToString();
                //                    TbxNascimento.Text = sDados[3].ToString().Substring(6, 4) + "-" + sDados[3].ToString().Substring(3, 2) + "-" + sDados[3].ToString().Substring(0, 2);
                //                    TbxRG.Text = sDados[6].ToString();
                //                    TbxCNH.Text = sDados[7].ToString();

                //                    bfoto = obj.LerFotoAtual(sDados[4].ToString(), sDados[5].ToString());
                //                    byte[] pData = bfoto;
                //                    if (pData.Length > 1)
                //                    {
                //                        //System.Web.UI.WebControls.Image image = (System.Web.UI.WebControls.Image)e.Item.FindControl("image");

                //                        if (pData.Length > 0)
                //                        {
                //                            ImgCidadao.ImageUrl = GetImage(pData);
                //                            TxtImg2.Value = ImgCidadao.ImageUrl;
                //                        }
                //                        else
                //                        {
                //                            ImgCidadao.ImageUrl = null;
                //                            TxtImg2.Value = null;
                //                        }

                //                        //MemoryStream mStream = new MemoryStream();

                //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                        //Bitmap bm = new (mStream, false);
                //                        //mStream.Dispose();
                //                        //if (bm != null)
                //                        //    ImgCidadao.ImageUrl = pData;
                //                    }
                //                    else
                //                    {
                //                        bfotoCNH = obj.LerFotoAtualCNH(TbxCPF.Text);
                //                        pData = bfotoCNH;
                //                        if (pData.Length > 1)
                //                        {
                //                            if (pData.Length > 0)
                //                            {
                //                                ImgCidadao.ImageUrl = GetImage(pData);
                //                                TxtImg2.Value = ImgCidadao.ImageUrl;
                //                            }
                //                            else
                //                            {
                //                                ImgCidadao.ImageUrl = null;
                //                                TxtImg2.Value = null;
                //                            }
                //                            //MemoryStream mStream = new MemoryStream();

                //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                            //Bitmap bm = new Bitmap(mStream, false);
                //                            //mStream.Dispose();
                //                            //if (bm != null)
                //                            //    pctbFoto.Image = bm;
                //                        }
                //                        else
                //                        {
                //                            bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
                //                            pData = bfotoDRV;
                //                            if (pData.Length > 1)
                //                            {
                //                                if (pData.Length > 0)
                //                                {
                //                                    ImgCidadao.ImageUrl = GetImage(pData);
                //                                    TxtImg2.Value = ImgCidadao.ImageUrl;
                //                                }
                //                                else
                //                                {
                //                                    ImgCidadao.ImageUrl = null;
                //                                    TxtImg2.Value = null;
                //                                }
                //                                //    MemoryStream mStream = new MemoryStream();

                //                                //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                                //    Bitmap bm = new Bitmap(mStream, false);
                //                                //    mStream.Dispose();
                //                                //    if (bm != null)
                //                                //        pctbFoto.Image = bm;
                //                            }


                //                        }
                //                    }

                //                    if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "" && ImgCidadao.ImageUrl != null)
                //                    {

                //                        //retornar o SQ_DRV para uma variavel global e utilizar no salvar 
                //                        bool exitenciaDeRegistro = obj.VerificaExistenciaCPF(TbxCPF.Text);

                //                        if (exitenciaDeRegistro == false)
                //                        {
                //                            SQ_DRV.Text = obj.Salvar_Entrega(TbxNome.Text, TbxNomePai.Text, TbxNomeMae.Text, TbxRG.Text, TbxCPF.Text, TbxNascimento.Text, "1", TbxCNH.Text);


                //                            //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
                //                            SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("1", SQ_DRV.Text, pData);

                //                        }
                //                        else
                //                        {

                //                            //SQ_DRV_COLETA .Text= obj.SalvarEntregaColetaSSED("1", "2", pData);
                //                            //MessageBox.Show("CPF já cadastrado na DRV", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //                        }



                //                    }
                //                    ativaBtnCertificar();


                //                }
                //                else
                //                {
                //                    sDadosCNH = obj.Ler_Cpf_CNH(TbxCPF.Text).Split(';');
                //                    if (sDadosCNH.Length > 1 && sDadosCNH.Length < 3)
                //                    {
                //                        TbxNome.Text = sDadosCNH[0].ToString();
                //                        TbxCNH.Text = sDadosCNH[2].ToString();
                //                        TbxNascimento.Text = sDadosCNH[1].ToString().Substring(6, 4) + "-" + sDadosCNH[1].ToString().Substring(3, 2) + "-" + sDadosCNH[1].ToString().Substring(0, 2); ;
                //                        TbxCPF.Text = sDadosCNH[3].ToString();
                //                        TbxNomePai.Text = sDadosCNH[4].ToString();
                //                        TbxNomeMae.Text = sDadosCNH[5].ToString();
                //                        bfotoCNH = obj.LerFotoAtualCNH(TbxCPF.Text);
                //                        byte[] pData = bfotoCNH;
                //                        if (pData.Length > 1)
                //                        {
                //                            if (pData.Length > 0)
                //                            {
                //                                ImgCidadao.ImageUrl = GetImage(pData);
                //                                TxtImg2.Value = ImgCidadao.ImageUrl;
                //                            }
                //                            else
                //                            {
                //                                ImgCidadao.ImageUrl = null;
                //                                TxtImg2.Value = null;
                //                            }
                //                            //MemoryStream mStream = new MemoryStream();

                //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                //                            //Bitmap bm = new Bitmap(mStream, false);
                //                            //mStream.Dispose();
                //                            //if (bm != null)
                //                            //    pctbFoto.Image = bm;
                //                        }



                //                    }
                //                    else
                //                    {
                //                        //MessageBox.Show("Cidadão não encontrado, realize uma nova consulta ou faça um novo registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //                        ativaBtnNenhumRegistro();
                //                        ////teste
                //                        //btnCapturarDigital.Enabled = true;

                //                    }
                //                }
                //            }


                //        }
                //        else { LblCPFinvalido.Visible = true; }

                //    }
                //    //else { MessageBox.Show("Digite o CPF", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                //}
                //catch (Exception ex)
                //{
                //    //MessageBox.Show("ERRO: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            private void BuscarPorCNH()
            {
            //    //pronto testar 2022.09.08
            //    try
            //    {


            //        limpar();

            //        if (TbxCNH.Text != "")
            //        {
            //            //if (ValidaCPF.IsCpf(TbxCPF.Text))
            //            //{

            //            desativaBtn();
            //            //m_oConexao = new AdConexao();
            //            //oadc = new AdConsulta();           
            //            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            //            string[] sDados;
            //            string[] sDadosDRV;
            //            string[] sDadosCNH;
            //            byte[] bfoto;
            //            byte[] bfotoDRV;
            //            byte[] bfotoCNH;

            //            sDadosDRV = obj.LerCNHDRV(TbxCNH.Text).Split(';');
            //            //sDadosDRV = obj.Ler_Cpf_DRV("001122556688").Split(';');

            //            if (sDadosDRV.Length > 5)
            //            {
            //                TbxNome.Text = sDadosDRV[1].ToString();
            //                TbxNomePai.Text = sDadosDRV[2].ToString();
            //                TbxNomeMae.Text = sDadosDRV[3].ToString();
            //                TbxCPF.Text = sDadosDRV[5].ToString();
            //                TbxNascimento.Text = sDadosDRV[6].ToString().Substring(6, 4) + "-" + sDadosDRV[6].ToString().Substring(3, 2) + "-" + sDadosDRV[6].ToString().Substring(0, 2);
            //                //TbxNascimento.TEX;
            //                TbxRG.Text = sDadosDRV[4].ToString();
            //                TbxCNH.Text = sDadosDRV[9].ToString();

            //                bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
            //                //bfotoDRV = obj.LerFotoAtualCNH(TbxCPF.Text);
            //                byte[] pData = bfotoDRV;
            //                if (pData.Length > 1)
            //                {
            //                    if (pData.Length > 0)
            //                    {
            //                        ImgCidadao.ImageUrl = GetImage(pData);
            //                        TxtImg2.Value = ImgCidadao.ImageUrl;
            //                    }
            //                    else
            //                    {
            //                        ImgCidadao.ImageUrl = null;
            //                        TxtImg2.Value = null;
            //                    }

            //                    //MemoryStream mStream = new MemoryStream();

            //                    //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                    //Bitmap bm = new Bitmap(mStream, false);
            //                    //mStream.Dispose();
            //                    //if (bm != null)
            //                    //    pctbFoto.Image = bm;
            //                }
            //                else
            //                {
            //                    bfotoCNH = obj.LerFotoAtualCNHporCNH(TbxCNH.Text);
            //                    pData = bfotoCNH;
            //                    if (pData.Length > 1)
            //                    {
            //                        if (pData.Length > 0)
            //                        {
            //                            ImgCidadao.ImageUrl = GetImage(pData);
            //                            TxtImg2.Value = ImgCidadao.ImageUrl;
            //                        }
            //                        else
            //                        {
            //                            ImgCidadao.ImageUrl = null;
            //                            TxtImg2.Value = null;
            //                        }

            //                        //MemoryStream mStream = new MemoryStream();

            //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                        //Bitmap bm = new Bitmap(mStream, false);
            //                        //mStream.Dispose();
            //                        //if (bm != null)
            //                        //    pctbFoto.Image = bm;
            //                    }
            //                }

            //                SQ_DRV.Text = sDadosDRV[0].ToString();

            //                //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
            //                SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("2", SQ_DRV.Text, pData);


            //                ativaBtnCertificar();
            //                //teste
            //                //btnCapturarDigital.Enabled = true;
            //                //BtnRegistrar.Enabled = true;
            //            }
            //            else
            //            {
            //                sDados = obj.LerCNH(TbxCNH.Text).Split(';');
            //                //sDados = obj.Ler_Cpf("001122556688").Split(';');
            //                if (sDados.Length > 5)
            //                {

            //                    TbxNome.Text = sDados[0].ToString();
            //                    TbxNomePai.Text = sDados[1].ToString();
            //                    TbxNomeMae.Text = sDados[2].ToString();
            //                    TbxNascimento.Text = sDados[3].ToString().Substring(6, 4) + "-" + sDados[3].ToString().Substring(3, 2) + "-" + sDados[3].ToString().Substring(0, 2);
            //                    TbxRG.Text = sDados[6].ToString();
            //                    TbxCNH.Text = sDados[7].ToString();
            //                    TbxCPF.Text = sDados[8].ToString();


            //                    bfoto = obj.LerFotoAtual(sDados[4].ToString(), sDados[5].ToString());
            //                    byte[] pData = bfoto;
            //                    if (pData.Length > 1)
            //                    {
            //                        //System.Web.UI.WebControls.Image image = (System.Web.UI.WebControls.Image)e.Item.FindControl("image");

            //                        if (pData.Length > 0)
            //                        {
            //                            ImgCidadao.ImageUrl = GetImage(pData);
            //                            TxtImg2.Value = ImgCidadao.ImageUrl;
            //                        }
            //                        else
            //                        {
            //                            ImgCidadao.ImageUrl = null;
            //                            TxtImg2.Value = null;
            //                        }

            //                        //MemoryStream mStream = new MemoryStream();

            //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                        //Bitmap bm = new (mStream, false);
            //                        //mStream.Dispose();
            //                        //if (bm != null)
            //                        //    ImgCidadao.ImageUrl = pData;
            //                    }
            //                    else
            //                    {
            //                        bfotoCNH = obj.LerFotoAtualCNHporCNH(TbxCNH.Text);
            //                        pData = bfotoCNH;
            //                        if (pData.Length > 1)
            //                        {
            //                            if (pData.Length > 0)
            //                            {
            //                                ImgCidadao.ImageUrl = GetImage(pData);
            //                                TxtImg2.Value = ImgCidadao.ImageUrl;
            //                            }
            //                            else
            //                            {
            //                                ImgCidadao.ImageUrl = null;
            //                                TxtImg2.Value = null;
            //                            }
            //                            //MemoryStream mStream = new MemoryStream();

            //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                            //Bitmap bm = new Bitmap(mStream, false);
            //                            //mStream.Dispose();
            //                            //if (bm != null)
            //                            //    pctbFoto.Image = bm;
            //                        }
            //                        else
            //                        {
            //                            bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
            //                            pData = bfotoDRV;
            //                            if (pData.Length > 1)
            //                            {
            //                                if (pData.Length > 0)
            //                                {
            //                                    ImgCidadao.ImageUrl = GetImage(pData);
            //                                    TxtImg2.Value = ImgCidadao.ImageUrl;
            //                                }
            //                                else
            //                                {
            //                                    ImgCidadao.ImageUrl = null;
            //                                    TxtImg2.Value = null;
            //                                }

            //                            }


            //                        }
            //                    }

            //                    if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "" && ImgCidadao.ImageUrl != null)
            //                    {

            //                        //retornar o SQ_DRV para uma variavel global e utilizar no salvar 
            //                        bool exitenciaDeRegistro = obj.VerificaExistenciaCNH(TbxCNH.Text);

            //                        if (exitenciaDeRegistro == false)
            //                        {
            //                            SQ_DRV.Text = obj.Salvar_Entrega(TbxNome.Text, TbxNomePai.Text, TbxNomeMae.Text, TbxRG.Text, TbxCPF.Text, TbxNascimento.Text, "1", TbxCNH.Text);


            //                            //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
            //                            SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("1", SQ_DRV.Text, pData);

            //                        }
            //                        else
            //                        {

            //                            //SQ_DRV_COLETA .Text= obj.SalvarEntregaColetaSSED("1", "2", pData);
            //                            //MessageBox.Show("CPF já cadastrado na DRV", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                        }



            //                    }
            //                    ativaBtnCertificar();


            //                }
            //                else
            //                {
            //                    sDadosCNH = obj.Ler_CNH_CNHBD(TbxCNH.Text).Split(';');
            //                    if (sDadosCNH.Length > 1 && sDadosCNH.Length < 3)
            //                    {
            //                        TbxNome.Text = sDadosCNH[0].ToString();
            //                        TbxCNH.Text = sDadosCNH[2].ToString();
            //                        TbxNascimento.Text = sDadosCNH[1].ToString().Substring(6, 4) + "-" + sDadosCNH[1].ToString().Substring(3, 2) + "-" + sDadosCNH[1].ToString().Substring(0, 2); ;

            //                        TbxCPF.Text = sDadosCNH[3].ToString();
            //                        TbxNomePai.Text = sDadosCNH[4].ToString();
            //                        TbxNomeMae.Text = sDadosCNH[5].ToString();
            //                        bfotoCNH = obj.LerFotoAtualCNHporCNH(TbxCNH.Text);
            //                        byte[] pData = bfotoCNH;
            //                        if (pData.Length > 1)
            //                        {
            //                            if (pData.Length > 0)
            //                            {
            //                                ImgCidadao.ImageUrl = GetImage(pData);
            //                                TxtImg2.Value = ImgCidadao.ImageUrl;
            //                            }
            //                            else
            //                            {
            //                                ImgCidadao.ImageUrl = null;
            //                                TxtImg2.Value = null;
            //                            }
            //                            //MemoryStream mStream = new MemoryStream();

            //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                            //Bitmap bm = new Bitmap(mStream, false);
            //                            //mStream.Dispose();
            //                            //if (bm != null)
            //                            //    pctbFoto.Image = bm;
            //                        }



            //                    }
            //                    else
            //                    {
            //                        //MessageBox.Show("Cidadão não encontrado, realize uma nova consulta ou faça um novo registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                        ativaBtnNenhumRegistro();
            //                        ////teste
            //                        //btnCapturarDigital.Enabled = true;

            //                    }
            //                }
            //            }


            //            //}
            //            //else { LblCPFinvalido.Visible = true; }

            //        }
            //        //else { MessageBox.Show("Digite o CPF", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            //    }
            //    catch (Exception ex)
            //    {
            //        //MessageBox.Show("ERRO: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //private void BuscarPorRG()
            //{
            //    //pronto testar 2022.09.08
            //    try
            //    {


            //        limpar();

            //        if (TbxRG.Text != "")
            //        {
            //            //if (ValidaCPF.IsCpf(TbxCPF.Text))
            //            //{

            //            desativaBtn();
            //            //m_oConexao = new AdConexao();
            //            //oadc = new AdConsulta();           
            //            //ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            //            string[] sDados;
            //            string[] sDadosDRV;
            //            string[] sDadosCNH;
            //            byte[] bfoto;
            //            byte[] bfotoDRV;
            //            byte[] bfotoCNH;

            //            sDadosDRV = obj.LerRGDRV(TbxRG.Text).Split(';');
            //            //sDadosDRV = obj.Ler_Cpf_DRV("001122556688").Split(';');

            //            if (sDadosDRV.Length > 5)
            //            {
            //                TbxNome.Text = sDadosDRV[1].ToString();
            //                TbxNomePai.Text = sDadosDRV[2].ToString();
            //                TbxNomeMae.Text = sDadosDRV[3].ToString();
            //                TbxCPF.Text = sDadosDRV[5].ToString();

            //                TbxNascimento.Text = sDadosDRV[6].ToString().Substring(6, 4) + "-" + sDadosDRV[6].ToString().Substring(3, 2) + "-" + sDadosDRV[6].ToString().Substring(0, 2);
            //                //TbxNascimento.TEX;
            //                TbxRG.Text = sDadosDRV[4].ToString();
            //                TbxCNH.Text = sDadosDRV[9].ToString();

            //                bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
            //                //bfotoDRV = obj.LerFotoAtualCNH(TbxCPF.Text);
            //                byte[] pData = bfotoDRV;
            //                if (pData.Length > 1)
            //                {
            //                    if (pData.Length > 0)
            //                    {
            //                        ImgCidadao.ImageUrl = GetImage(pData);
            //                        TxtImg2.Value = ImgCidadao.ImageUrl;
            //                    }
            //                    else
            //                    {
            //                        ImgCidadao.ImageUrl = null;
            //                        TxtImg2.Value = null;
            //                    }

            //                    //MemoryStream mStream = new MemoryStream();

            //                    //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                    //Bitmap bm = new Bitmap(mStream, false);
            //                    //mStream.Dispose();
            //                    //if (bm != null)
            //                    //    pctbFoto.Image = bm;
            //                }
            //                else
            //                {
            //                    bfotoCNH = obj.LerFotoAtualCNHporRG(TbxRG.Text);
            //                    pData = bfotoCNH;
            //                    if (pData.Length > 1)
            //                    {
            //                        if (pData.Length > 0)
            //                        {
            //                            ImgCidadao.ImageUrl = GetImage(pData);
            //                            TxtImg2.Value = ImgCidadao.ImageUrl;
            //                        }
            //                        else
            //                        {
            //                            ImgCidadao.ImageUrl = null;
            //                            TxtImg2.Value = null;
            //                        }

            //                        //MemoryStream mStream = new MemoryStream();

            //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                        //Bitmap bm = new Bitmap(mStream, false);
            //                        //mStream.Dispose();
            //                        //if (bm != null)
            //                        //    pctbFoto.Image = bm;
            //                    }
            //                }

            //                SQ_DRV.Text = sDadosDRV[0].ToString();

            //                //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
            //                SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("2", SQ_DRV.Text, pData);


            //                ativaBtnCertificar();
            //                //teste
            //                //btnCapturarDigital.Enabled = true;
            //                //BtnRegistrar.Enabled = true;
            //            }
            //            else
            //            {
            //                sDados = obj.LerRG(TbxRG.Text).Split(';');
            //                //sDados = obj.Ler_Cpf("001122556688").Split(';');
            //                if (sDados.Length > 5)
            //                {

            //                    TbxNome.Text = sDados[0].ToString();
            //                    TbxNomePai.Text = sDados[1].ToString();
            //                    TbxNomeMae.Text = sDados[2].ToString();
            //                    TbxNascimento.Text = sDados[3].ToString().Substring(6, 4) + "-" + sDados[3].ToString().Substring(3, 2) + "-" + sDados[3].ToString().Substring(0, 2);
            //                    TbxRG.Text = sDados[6].ToString();
            //                    TbxCNH.Text = sDados[7].ToString();
            //                    TbxCPF.Text = sDados[8].ToString();

            //                    bfoto = obj.LerFotoAtual(sDados[4].ToString(), sDados[5].ToString());
            //                    byte[] pData = bfoto;
            //                    if (pData.Length > 1)
            //                    {
            //                        //System.Web.UI.WebControls.Image image = (System.Web.UI.WebControls.Image)e.Item.FindControl("image");

            //                        if (pData.Length > 0)
            //                        {
            //                            ImgCidadao.ImageUrl = GetImage(pData);
            //                            TxtImg2.Value = ImgCidadao.ImageUrl;
            //                        }
            //                        else
            //                        {
            //                            ImgCidadao.ImageUrl = null;
            //                            TxtImg2.Value = null;
            //                        }

            //                        //MemoryStream mStream = new MemoryStream();

            //                        //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                        //Bitmap bm = new (mStream, false);
            //                        //mStream.Dispose();
            //                        //if (bm != null)
            //                        //    ImgCidadao.ImageUrl = pData;
            //                    }
            //                    else
            //                    {
            //                        bfotoCNH = obj.LerFotoAtualCNHporRG(TbxRG.Text);
            //                        pData = bfotoCNH;
            //                        if (pData.Length > 1)
            //                        {
            //                            if (pData.Length > 0)
            //                            {
            //                                ImgCidadao.ImageUrl = GetImage(pData);
            //                                TxtImg2.Value = ImgCidadao.ImageUrl;
            //                            }
            //                            else
            //                            {
            //                                ImgCidadao.ImageUrl = null;
            //                                TxtImg2.Value = null;
            //                            }
            //                            //MemoryStream mStream = new MemoryStream();

            //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                            //Bitmap bm = new Bitmap(mStream, false);
            //                            //mStream.Dispose();
            //                            //if (bm != null)
            //                            //    pctbFoto.Image = bm;
            //                        }
            //                        else
            //                        {
            //                            bfotoDRV = obj.LerFotoAtualDRV(sDadosDRV[0].ToString());
            //                            pData = bfotoDRV;
            //                            if (pData.Length > 1)
            //                            {
            //                                if (pData.Length > 0)
            //                                {
            //                                    ImgCidadao.ImageUrl = GetImage(pData);
            //                                    TxtImg2.Value = ImgCidadao.ImageUrl;
            //                                }
            //                                else
            //                                {
            //                                    ImgCidadao.ImageUrl = null;
            //                                    TxtImg2.Value = null;
            //                                }
            //                                //    MemoryStream mStream = new MemoryStream();

            //                                //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                                //    Bitmap bm = new Bitmap(mStream, false);
            //                                //    mStream.Dispose();
            //                                //    if (bm != null)
            //                                //        pctbFoto.Image = bm;
            //                            }


            //                        }
            //                    }

            //                    if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "" && ImgCidadao.ImageUrl != null)
            //                    {

            //                        //retornar o SQ_DRV para uma variavel global e utilizar no salvar 
            //                        bool exitenciaDeRegistro = obj.VerificaExistenciaRG(TbxRG.Text);

            //                        if (exitenciaDeRegistro == false)
            //                        {
            //                            SQ_DRV.Text = obj.Salvar_Entrega(TbxNome.Text, TbxNomePai.Text, TbxNomeMae.Text, TbxRG.Text, TbxCPF.Text, TbxNascimento.Text, "1", TbxCNH.Text);


            //                            //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
            //                            SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("1", SQ_DRV.Text, pData);

            //                        }
            //                        else
            //                        {

            //                            //SQ_DRV_COLETA .Text= obj.SalvarEntregaColetaSSED("1", "2", pData);
            //                            //MessageBox.Show("CPF já cadastrado na DRV", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                        }



            //                    }
            //                    ativaBtnCertificar();


            //                }
            //                else
            //                {
            //                    sDadosCNH = obj.LerRGCNH(TbxRG.Text).Split(';');
            //                    if (sDadosCNH.Length > 1 && sDadosCNH.Length < 3)
            //                    {
            //                        TbxNome.Text = sDadosCNH[0].ToString();
            //                        TbxCNH.Text = sDadosCNH[2].ToString();
            //                        TbxNascimento.Text = sDadosCNH[1].ToString().Substring(6, 4) + "-" + sDadosCNH[1].ToString().Substring(3, 2) + "-" + sDadosCNH[1].ToString().Substring(0, 2); ;
            //                        TbxCPF.Text = sDadosCNH[3].ToString();
            //                        TbxNomePai.Text = sDadosCNH[4].ToString();
            //                        TbxNomeMae.Text = sDadosCNH[5].ToString();

            //                        bfotoCNH = obj.LerFotoAtualCNHporRG(TbxRG.Text);
            //                        byte[] pData = bfotoCNH;
            //                        if (pData.Length > 1)
            //                        {
            //                            if (pData.Length > 0)
            //                            {
            //                                ImgCidadao.ImageUrl = GetImage(pData);
            //                                TxtImg2.Value = ImgCidadao.ImageUrl;
            //                            }
            //                            else
            //                            {
            //                                ImgCidadao.ImageUrl = null;
            //                                TxtImg2.Value = null;
            //                            }
            //                            //MemoryStream mStream = new MemoryStream();

            //                            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //                            //Bitmap bm = new Bitmap(mStream, false);
            //                            //mStream.Dispose();
            //                            //if (bm != null)
            //                            //    pctbFoto.Image = bm;
            //                        }



            //                    }
            //                    else
            //                    {
            //                        //MessageBox.Show("Cidadão não encontrado, realize uma nova consulta ou faça um novo registro", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //                        ativaBtnNenhumRegistro();
            //                        ////teste
            //                        //btnCapturarDigital.Enabled = true;

            //                    }
            //                }
            //            }


            //            //}
            //            //else { LblCPFinvalido.Visible = true; }

            //        }
            //        //else { MessageBox.Show("Digite o CPF", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            //    }
            //    catch (Exception ex)
            //    {
            //        //MessageBox.Show("ERRO: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            }
            private void desativaBtn()
            {
                ////btnliberar.Enabled = false;
                //btnRegistrar.Enabled = false;
                //btnCertificar.Enabled = false;
                //btnCapturarFoto.Enabled = false;
                //TbxNomeMae.Enabled = false;
                //TbxNomePai.Enabled = false;
                //TbxNascimento.Enabled = false;
                //TbxNome.Enabled = false;
                //TbxRG.Enabled = false;
                //TbxCPF.Enabled = true;
                //TbxRG.Enabled = true;
                //TbxCNH.Enabled = true;
                //ImgBtnConsultar.Enabled = true;
                //LblCPFinvalido.Visible = false;


            }
            private void ativaBtnNenhumRegistro()
            {
                ////btnRegistrar.Enabled = true;

                //btnCapturarFoto.Enabled = true;
                //TbxNomeMae.Enabled = true;
                //TbxNomePai.Enabled = true;
                //TbxNascimento.Enabled = true;
                //TbxNome.Enabled = true;
                //TbxRG.Enabled = true;
                //TbxCPF.Enabled = true;
                //TbxCNH.Enabled = true;
                //ImgBtnConsultar.Enabled = true;
                //LblCPFinvalido.Visible = false;


            }
            private void ativaBtnCertificar()
            {
                //btnliberar.Enabled = false;
                //BtnRegistrar.Enabled = false;
                btnCertificar.Enabled = true;
                //btnCapturarDigital.Enabled = false;
                //btnCapturarFoto.Enabled = true;
                TbxCPF.Enabled = false;
                TbxCNH.Enabled = false;
                TbxRG.Enabled = false;
                ImgBtnConsultar.Enabled = false;
                LblCPFinvalido.Visible = false;


            }
            private void limpar()
            {
                //TbxNomeMae.Text = "";
                //TbxNomePai.Text = "";
                //TbxNascimento.Text = "";
                //TbxNome.Text = "";

                ////pctbFoto.Image = null;
                ////resultadoCertificacaoPositivado = 0;
                ////resultadoCertificacaoScore = 0;
                //SQ_DRV.Text = "";
                //SQ_DRV_COLETA.Text = "";
                //ImgCidadao.ImageUrl = null;

                //LblCPFinvalido.Visible = false;
                //btnSalvar.Visible = false;
                //btnCertificarCidadao.Visible = true;
                //TxtImg2.Value = "";
                //TxtImg.Value = "";
                //TbxCPFSupervisor.Text = "";


            }
            private void limparComCPF()
            {
                //TbxNomeMae.Text = "";
                //TbxCPF.Text = "";
                //TbxNomePai.Text = "";
                //TbxNascimento.Text = "";
                //TbxNome.Text = "";
                //TbxRG.Text = "";
                //TbxCNH.Text = "";
                //LblCPFinvalido.Visible = false;
                //ImgCidadao.ImageUrl = null;
                ////resultadoCertificacaoPositivado = 0;
                ////resultadoCertificacaoScore = 0;
                //SQ_DRV.Text = "";
                //SQ_DRV_COLETA.Text = "";
                ////imgFoto = null;
                //btnSalvar.Visible = false;
                //btnCertificarCidadao.Visible = true;
                //TxtImg2.Value = "";
                //TxtImg.Value = "";
                //TbxCPFSupervisor.Text = "";




            }
            protected void BtnSalvarCaptura_Click(object sender, EventArgs e)
            {
                //if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "")
                //{
                //    byte[] pData = null;

                //    if (TxtImg.Value.Length > 21)
                //    {
                //        var b = TxtImg.Value;

                //        ImgCidadao.ImageUrl = b;

                //        pData = Convert.FromBase64String(b.Substring(23));

                //    }

                //    if (TbxNome.Text != "" && TbxNascimento.Text != "" && TbxCPF.Text != "" && pData != null)
                //    {

                //        //string hh_ini_foto = DateTime.Now.ToString();

                //        //nomeDriver = "c:";
                //        //sPathImagem = "C:\\ProjetoDRV\\1";

                //        string[] sDadosDRV = null;


                //        try
                //        {




                //        }
                //        catch (Exception ex)
                //        {


                //            //MessageBox.Show("Erro: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //        finally
                //        {

                //            if (TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "")
                //            {

                //                //retornar o SQ_DRV para uma variavel global e utilizar no salvar 
                //                bool exitenciaDeRegistro = obj.VerificaExistenciaCPF(TbxCPF.Text);


                //                if (exitenciaDeRegistro == false)
                //                {

                //                    SQ_DRV.Text = obj.Salvar_Entrega(TbxNome.Text, TbxNomePai.Text, TbxNomeMae.Text, TbxRG.Text, TbxCPF.Text, TbxNascimento.Text, "1", TbxCNH.Text);

                //                    //salva a foto do cidadão, o tipo de cadastro, e cria um sequencial de coleta
                //                    SQ_DRV_COLETA.Text = obj.SalvarEntregaColetaSSED("1", SQ_DRV.Text, pData);
                //                    mp3.Show();


                //                }
                //                else
                //                {

                //                    sDadosDRV = obj.Ler_Cpf_DRV(TbxCPF.Text).Split(';');
                //                    if (sDadosDRV.Length > 5)
                //                    {
                //                        SQ_DRV.Text = sDadosDRV[0].ToString();

                //                        //salva a foto do cidadão, fazendo um update no sqdrvcol já existente
                //                        obj.SalvarEntregaColetaSSED("3", SQ_DRV_COLETA.Text, pData);
                //                        LblDescricaoMessageBox.Text = "Salvo com sucesso!";
                //                        MessageBoxPopup.Show();
                //                        //ativaBtnCertificar();
                //                    }
                //                    //SQ_DRV_COLETA .Text= obj.SalvarEntregaColetaSSED("3", SQ_DRV, pData);
                //                    //MessageBox.Show("ERRO AO CADASTRAR CPF já cadastrado na DRV");
                //                }



                //            }
                //            //if (/*oMICaptura != null*/)
                //            //{
                //            //    //oMICaptura = null;
                //            //}
                //        }
                //    }
                //    else
                //    {
                //        /*MessageBox.Show("Preencha os dados para realizar um registro, ou realize uma nova consulta antes de capturar uma foto", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); */
                //    }
                //}
            }

            protected void btnCertificarCidadao_Click(object sender, EventArgs e)
            {

                //if (TxtImg.Value != "")
                //{
                //    try
                //    {
                //        //btnSalvar.OnClientClick = "return save_snapshot();";


                //        var c = "";
                //        var d = "";
                //        var a = TxtImg.Value;
                //        var b = TxtImg2.Value;
                //        if (a.Length > 22 && b.Length > 22)
                //        {
                //            c = a.Substring(23);
                //            d = b.Substring(22);
                //            byte[] imgCidadao1 = Convert.FromBase64String(c);
                //            byte[] imgCidadao2 = Convert.FromBase64String(d);

                //            ZFace zface = new ZFace();

                //            var modelsPath = @"C:\inetpub\wwwroot\ProjetoDRV\models";

                //            zface.Config(modelsPath);

                //            //imagem da foto do celular
                //            MemoryStream ms = new MemoryStream(imgCidadao1);
                //            System.Drawing.Image imgFotoCelular = System.Drawing.Image.FromStream(ms);

                //            //imagem da carteira da base de dados da ultima via
                //            ms = new MemoryStream(imgCidadao2);
                //            System.Drawing.Image imgFotoCarteira = System.Drawing.Image.FromStream(ms);


                //            var templateCelular = zface.GenerateFacecode(imgCidadao1, imgFotoCelular.Width, imgFotoCelular.Height, ImageType.JPEG, FaceDetectorType.MTCNN);
                //            var templateCarteira = zface.GenerateFacecode(imgCidadao2, imgFotoCarteira.Width, imgFotoCarteira.Height, ImageType.JPEG, FaceDetectorType.MTCNN);

                //            var dret = Convert.ToInt32(ZFace.CompareFacecodes(templateCelular.Facecode, templateCarteira.Facecode));

                //            if (dret >= 45)
                //            {
                //                var fl_positivado = 1;

                //                obj.SalvarEntregaColetaCompleta(SQ_DRV.Text, imgCidadao2, dret, fl_positivado);

                //                TxtImg.Value = null;
                //                LblDescricaoMessageBox.Text = "Salvo com sucesso!";
                //                MessageBoxPopup.Show();
                //            }
                //            else
                //            {
                //                var fl_positivado = 0;
                //                obj.SalvarEntregaColetaCompleta(SQ_DRV.Text, imgCidadao2, dret, fl_positivado);
                //                //salvar na tabela imagens?

                //                //criar messagebox pessoa não certificada, liberação do supervisor ou tentar novamente
                //                TxtImg.Value = null;
                //                mp3.Show();


                //            }



                //        }

                //    }
                //    catch (Exception ex)
                //    {
                //        LblDescricaoMessageBox.Text = "Erro! - " + ex.Message;
                //        MessageBoxPopup.Show();
                //    }



                //}


            }

            protected void BtnLiberar_Click(object sender, EventArgs e)
            {
                //if (SQ_DRV.Text != "" && TbxCPFSupervisor.Text != "" && TbxCPF.Text != "" && TbxNome.Text != "" && TbxRG.Text != "" && TbxNascimento.Text != "")
                //{
                //    try
                //    {
                //        obj.SalvarSupervisor(SQ_DRV.Text, TbxCPFSupervisor.Text);
                //        LblDescricaoMessageBox.Text = "Salvo com sucesso!";
                //        MessageBoxPopup.Show();
                //    }
                //    catch (Exception ex)
                //    {
                //        LblDescricaoMessageBox.Text = "Erro! - " + ex.Message;
                //        MessageBoxPopup.Show();
                //    }
                //}
                //else
                //{
                //    LblDescricaoMessageBox.Text = "Erro! - Tente novamente";
                //    MessageBoxPopup.Show();
                //}
            }
   
}
}