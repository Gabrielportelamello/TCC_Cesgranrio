<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Viagem.aspx.cs" Inherits="ProjetoSemearTurismo.Contact" %>

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
            margin-top:25px;
            height: 94%;
            width: 90%;
        }

        .hdnBtn {
          display:none;
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
            <asp:Label ID="LblViagensPopupViagemCadastro" runat="server" Text="Viagens"></asp:Label>
        </h2>
        <br />
     
        <h3>
            <asp:Label ID="LblInfViagemPopupViagemCadastro" runat="server" Text="Informações Viagem"></asp:Label>
        </h3>
        <br />
        <asp:Label ID="LblNomePopupViagemCadastro" runat="server" Text="Nome viagem "></asp:Label>
        <asp:TextBox ID="TbxNomePopupViagemCadastro" runat="server"></asp:TextBox>


        <asp:Label ID="LblDataInicial" runat="server" Text="Data inicial" CssClass="lbl" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxDataInicialPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>
        <asp:Label ID="LblDataFinal" runat="server" Text="Data Final" CssClass="lbl" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxDataFinalPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>

        <br />
      
        <asp:Label ID="LblDescPopupViagemCadastro" runat="server" Text="Descrição"></asp:Label>
        <br />
        <asp:TextBox ID="TbxDescPopupViagemCadastro" runat="server" TextMode="MultiLine" Height="100px" Width="600px"></asp:TextBox>

      
        <br />
        <h3>
            <asp:Label ID="lblobsPopupViagemCadastro" runat="server" Text="Observação"></asp:Label>
        </h3>

        <br />
       
        <asp:Label ID="lblStatus" runat="server" Text="Status "></asp:Label>
        <asp:DropDownList ID="DropDownListViagemPopupViagemCadastro" runat="server">
            <asp:ListItem Value="0" Text="Ativa"></asp:ListItem>
            <asp:ListItem Value="1" Text="Em andamento"></asp:ListItem>
            <asp:ListItem Value="2" Text="Finalizada"></asp:ListItem>
            <asp:ListItem Value="2" Text="Inativa"></asp:ListItem>

        </asp:DropDownList>

        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True" TargetControlID="TbxPrecoViagemPopupViagemCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />

        <asp:Label ID="LblPrecoViagemPopupViagemCadastro" runat="server" Text="Preço" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxPrecoViagemPopupViagemCadastro" runat="server">0000.00</asp:TextBox>



        <br />
      
        <asp:Label ID="LblOBSViagemPopupViagemCadastro" runat="server" Text="Observação"></asp:Label>
        <br />
        <asp:TextBox ID="TbxOBSViagemPopupViagemCadastro" runat="server" TextMode="MultiLine" Height="100px" Width="600px"></asp:TextBox>
        <br />
       
        <asp:Button ID="BtnCadastrarPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Viagem" OnClick="BtnCadastrarViagemModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Viagem" OnClick="BtnEditarCadastroPopupViagemCadastro_Click" />
        <asp:Button ID="btnCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupViagemCadastro_Click" />
        <asp:Button ID="btnLimparPopupViagemCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupViagemCadastro_Click" />
        <asp:Button ID="btnHDNCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn" />

    </asp:Panel>
    <div class="w-100 text-center center-block">
        <h2 >Viagens cadastradas</h2>
   
    </div>

     <div class="w-100 text-left" style="margin-bottom:1%;" >
    
    <asp:Button ID="BtnModalViagensGRID" CssClass="btn btn-primary btn-lg w-100 " runat="server" Text="Cadastrar Viagem »" OnClick="BtnModalViagensGRID_Click" ToolTip="Filtrar por nome:" />

    <asp:TextBox ID="TbxPesquisarGridViagens"  runat="server" Width="265px" Height="35px" ToolTip="Filtrar por nome:"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridViagens" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridViagens_Click" ToolTip="Filtrar por nome:" />
   
   
    </div>

    
    <div class="container w-100 text-center center-block">
        <div class="row">
            <div class="col">
                <div class="w-100">


                    <asp:GridView ID="GridViewViagens"  CssClass="w-100 bg-success container"  runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyNames="SQ_VIAGEM" OnPageIndexChanging="GridViewViagens_PageIndexChanging" OnRowDeleting="GridViewViagens_RowDeleting" OnSelectedIndexChanged="GridViewViagens_SelectedIndexChanged" OnSelectedIndexChanging="GridViewViagens_SelectedIndexChanging">
                        <Columns>
                            <asp:BoundField HeaderText="NUMERO" DataField="SQ_VIAGEM" Visible="False" />
                            <asp:BoundField HeaderText="Nome" DataField="NOME_VIAGEM">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Inicio viagem" DataField="DT_InicialPeriodo_viagem">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Final viagem" DataField="DTFinalperiodo_viagem">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Descricao do pacote" DataField="Descricao_do_pacote">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Tipo_Transporte" HeaderText="Transporte" Visible="False">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Preco" HeaderText="Preço">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Formas_de_pagamento" HeaderText="Formas de pagamento" Visible="False" />
                            <asp:BoundField DataField="OBSERVACAO" HeaderText="Observação">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="FL_STATUS" HeaderText="Status">
                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                            </asp:BoundField>
                            <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btnEditar" UpdateText="Atualizar" SelectText="Editar" ShowSelectButton="True" HeaderText="Editar">

                                <ControlStyle CssClass="btnEditar" Font-Bold="True" Height="40px" BackColor="#339933" BorderStyle="Solid" BorderWidth="6px"></ControlStyle>

                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />

                            </asp:CommandField>
                            <asp:CommandField ButtonType="Button" InsertVisible="False" ShowDeleteButton="True" ControlStyle-CssClass="btnExcluir" HeaderText="Excluir">


                                <ControlStyle CssClass="btnExcluir" Font-Bold="True" Height="40px" BackColor="#FF3300" BorderStyle="Solid" BorderWidth="6px"></ControlStyle>


                                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />


                            </asp:CommandField>

                        </Columns>

                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>





</asp:Content>
