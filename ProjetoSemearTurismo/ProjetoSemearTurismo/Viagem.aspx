<%@ Page Title="Viagem" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Viagem.aspx.cs" Inherits="ProjetoSemearTurismo.Viagem" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .BtnModalMBOXCSS {
            visibility: hidden;
        }

        .btnExcluir {
            color: whitesmoke;
            border-radius: 3px;
            border-color: whitesmoke;
        }

            .btnExcluir:hover {
                border-color: #FF3300;
                transition: .5s;
            }

        .btnEditar {
            color: whitesmoke;
            border-radius: 3px;
            border-color: whitesmoke;
        }

            .btnEditar:hover {
                border-color: #339933;
                transition: .5s;
            }

        .modalBackground {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
            top: 0px !important;
            left: 0px !important;
            position: absolute !important;
            z-index: 1 !important;
        }

        .PopupViagensGRID {
            background-color: #ffffff;
            padding: 3px;
            z-index: 10001;
            overflow: scroll;
            margin-top: 25px;
            height: 90%;
            width: 100%;
        }

        .hdnBtn {
            display: none;
        }
    </style>

    <div class="w-100 text-center center-block">



        <asp:Button ID="hdnBtnModalViagens" runat="server" Text="" CssClass="hdnBtn w-100" />


    </div>

    <cc1:ModalPopupExtender ID="MPEViagensGRID" runat="server" PopupControlID="PNLViagensGRID" TargetControlID="hdnBtnModalViagens"
        CancelControlID="btnHDNCancelarPopupViagemCadastro" BackgroundCssClass="modalBackground">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="PNLViagensGRID" runat="server" CssClass="PopupViagensGRID w-100 text-center center-block" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
        <h2>
            <asp:Label ID="LblViagensPopupViagemCadastro" runat="server" Text="Viagem"></asp:Label>
        </h2>   
        <br />
        <br />
        <asp:Label ID="LblNomePopupViagemCadastro" runat="server" Text="Nome viagem "></asp:Label>
        <asp:TextBox ID="TbxNomePopupViagemCadastro" runat="server"></asp:TextBox>


        <asp:Label ID="LblDataInicial" runat="server" Text="Data inicial" CssClass="lbl" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxDataInicialPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>
        <asp:Label ID="LblDataFinal" runat="server" Text="Data Final" CssClass="lbl" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxDataFinalPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>

        <br />
        <br />

        <asp:Label ID="LblDescPopupViagemCadastro" runat="server" Text="Descrição"></asp:Label>     
        <asp:TextBox ID="TbxDescPopupViagemCadastro" runat="server" TextMode="MultiLine"></asp:TextBox>       
      

        <asp:Label ID="LblOBSViagemPopupViagemCadastro" runat="server" Text="Observação"></asp:Label>
     
        <asp:TextBox ID="TbxOBSViagemPopupViagemCadastro" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
          <asp:Label ID="lblStatus" runat="server" Text="Status "></asp:Label>
        <asp:DropDownList ID="DropDownListViagemPopupViagemCadastro" runat="server">
            <asp:ListItem Value="0" Text="Ativa"></asp:ListItem>
            <asp:ListItem Value="2" Text="Em andamento"></asp:ListItem>
            <asp:ListItem Value="3" Text="Finalizada"></asp:ListItem>
            <asp:ListItem Value="1" Text="Inativa"></asp:ListItem>

        </asp:DropDownList>

        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True" TargetControlID="TbxPrecoViagemPopupViagemCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />

        <asp:Label ID="LblPrecoViagemPopupViagemCadastro" runat="server" Text="Preço" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxPrecoViagemPopupViagemCadastro" runat="server">0000.00</asp:TextBox>



        <br />
        <br />

        <asp:Button ID="BtnCadastrarPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Viagem" OnClick="BtnCadastrarViagemModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Viagem" OnClick="BtnEditarCadastroPopupViagemCadastro_Click" />
        <asp:Button ID="btnCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupViagemCadastro_Click" />
        <asp:Button ID="btnLimparPopupViagemCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupViagemCadastro_Click" />
        <asp:Button ID="btnHDNCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn" />

    </asp:Panel>
    <div class="w-100 text-center center-block">
        <h2 >Viagem</h2>

    </div>

    <div class="w-100 text-left" style="margin-bottom: 1%;">

        <asp:Button ID="BtnModalViagensGRID" CssClass="btn btn-primary btn-lg w-100" Height="46" runat="server" Text="Cadastrar Viagem »" OnClick="BtnModalViagensGRID_Click" ToolTip="Filtrar por nome:" />

        <asp:TextBox ID="TbxPesquisarGridViagens" runat="server" Width="265px" Height="44px" ToolTip="Filtrar por nome:"></asp:TextBox>
        <asp:ImageButton ID="ImgBtnPesquisarGridViagens" runat="server" Height="46px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridViagens_Click" ToolTip="Filtrar por nome:" />


    </div>


    <div class="container w-100 text-center center-block">
        <div class="row">
            <div class="col">
                <div class="w-100">


                    <asp:GridView ID="GridViewViagens" CssClass="table table-striped table-bordered table-condensed w-100"  runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="SQ_VIAGEM" OnPageIndexChanging="GridViewViagens_PageIndexChanging" OnRowDeleting="GridViewViagens_RowDeleting" OnSelectedIndexChanged="GridViewViagens_SelectedIndexChanged" OnSelectedIndexChanging="GridViewViagens_SelectedIndexChanging">
                        <Columns>
                            <asp:BoundField HeaderText="NUMERO" DataField="SQ_VIAGEM" Visible="False" />
                            <asp:BoundField HeaderText="Nome" DataField="NOME_VIAGEM">
                              
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Inicio viagem" DataField="DT_InicialPeriodo_viagem">
              
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Final viagem" DataField="DTFinalperiodo_viagem">
                              
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Descricao do pacote" DataField="Descricao_do_pacote">
                     
                            </asp:BoundField>
                            <asp:BoundField DataField="Tipo_Transporte" HeaderText="Transporte" Visible="False">
                      
                            </asp:BoundField>
                            <asp:BoundField DataField="Preco" HeaderText="Preço">
                         
                            </asp:BoundField>
                            <asp:BoundField DataField="Formas_de_pagamento" HeaderText="Formas de pagamento" Visible="False" />
                            <asp:BoundField DataField="OBSERVACAO" HeaderText="Observação">
                
                            </asp:BoundField>
                            <asp:BoundField DataField="FL_STATUS" HeaderText="Status">
                           
                            </asp:BoundField>
                            <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btnEditar" UpdateText="Atualizar" SelectText="Editar" ShowSelectButton="True" HeaderText="Editar">

                                <ControlStyle CssClass="btnEditar" Font-Bold="True" Height="40px" BackColor="#339933" BorderStyle="Solid" BorderWidth="6px"></ControlStyle>
 

                            </asp:CommandField>
                            <asp:CommandField ButtonType="Button" InsertVisible="False" ShowDeleteButton="True" ControlStyle-CssClass="btnExcluir" HeaderText="Excluir">


                                <ControlStyle CssClass="btnExcluir" Font-Bold="True" Height="40px" BackColor="#FF3300" BorderStyle="Solid" BorderWidth="6px"></ControlStyle>

 


                            </asp:CommandField>

                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>




        <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</asp:Content>
