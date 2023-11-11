<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Transporte.aspx.cs" Inherits="ProjetoSemearTurismo.Transporte" %>

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

        .PopupTransporteGRID {
            background-color: #ffffff;
            padding: 3px;
            z-index: 10001;
            overflow: scroll;
            height: 500px;
            width: 900px;
        }

        .hdnBtn {
            visibility: hidden;
            opacity: 0%;
        }
    </style>


    <cc1:ModalPopupExtender ID="MPETransporteGRID" runat="server" PopupControlID="PNLTransporteGRID" TargetControlID="hdnBtnModalTransporte"
        CancelControlID="btnHDNCancelarPopupTransporteCadastro" BackgroundCssClass="modalBackground">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="PNLTransporteGRID" runat="server" CssClass="PopupTransporteGRID" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
        <h2>
            <asp:Label ID="LblTransportePopupTransporteCadastro" runat="server" Text="Transporte"></asp:Label>
        </h2>
        <br />
        <br />
        <h3>
            <asp:Label ID="LblDadosPessoaisPopupTransporteCadastro" runat="server" Text="Dados Empresariais"></asp:Label>
        </h3>
        <br />
        <asp:Label ID="LblNomePopupTransporteCadastro" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="TbxNomePopupTransporteCadastro" runat="server"></asp:TextBox>
        <asp:Label ID="LblCNPJPopupTransporteCadastro" runat="server" Text="CNPJ" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxCNPJPopupTransporteCadastro" runat="server" Width="99px"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="LblQTDAssentosPopupTransporteCadastro" runat="server" Text="Quantidade de Assentos" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxQTDAssentosPopupTransporteCadastro" runat="server" Width="99px"></asp:TextBox>

        <asp:Label ID="LblPrecoPopupTransporteCadastro" runat="server" Text="Preço Transporte" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxPrecosPopupTransporteCadastro" runat="server" Width="99px"></asp:TextBox>



        <br />
        <br />
        <br />


        <h3>
            <asp:Label ID="LblContatoPrincipalPopupTransporteCadastro" runat="server" Text="Contato"></asp:Label>
        </h3>
        <br />
        <asp:Label ID="LblTel1PopupTransporteCadastro" runat="server" Text="Telefone 1"></asp:Label>
        <asp:TextBox ID="TbxTel1PopupTransporteCadastro" runat="server"></asp:TextBox>



        <asp:Label ID="LblEmailPopupTransporteCadastro" runat="server" Text="E-mail" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxEmailPopupTransporteCadastro" runat="server"></asp:TextBox>

        <br />
        <br />

        <h3>
            <asp:Label ID="LblEnderecoPrincipalPopupTransporteCadastro" runat="server" Text="Endereço"></asp:Label>
        </h3>
        <asp:Label ID="LblEnderecoPopupTransporteCadastro" runat="server" Text="Rua"></asp:Label>
        <asp:TextBox ID="TbxEnderecoPopupTransporteCadastro" runat="server"></asp:TextBox>


        <asp:Label ID="LblCEPPopupTransporteCadastro" runat="server" Text="CEP" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxCEPPopupTransporteCadastro" runat="server" Width="96px"></asp:TextBox>




        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="EXCLUIR ? "></asp:Label>
        <asp:Label ID="hdnLblIDselecionado" runat="server" Visible="false" Text=""></asp:Label>
        <asp:DropDownList ID="DropDownListFlagExcluidoPopupTransporteCadastro" runat="server">
            <asp:ListItem Value="0" Text="NÃO"></asp:ListItem>
            <asp:ListItem Value="1" Text="SIM"></asp:ListItem>

        </asp:DropDownList>


        <asp:Button ID="BtnCadastrarPopupTransporteCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Transporte" OnClick="BtnCadastrarTransporteModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupTransporteCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Transporte" OnClick="BtnEditarCadastroPopupTransporteCadastro_Click" />
        <asp:Button ID="btnCancelarPopupTransporteCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupTransporteCadastro_Click" />
        <asp:Button ID="btnLimparPopupTransporteCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupTransporteCadastro_Click" />
        <asp:Button ID="btnHDNCancelarPopupTransporteCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn" />

    </asp:Panel>

    <h2 class="text-center">Transportes</h2>
    <br />

    <asp:Button ID="hdnBtnModalTransporte" runat="server" Text="" CssClass="hdnBtn" />

    <asp:Button ID="BtnModalTransporteGRID" CssClass="btn btn-primary btn-lg w-100" runat="server" Text="Cadastrar Transporte »" OnClick="BtnModalTransporteGRID_Click" />


    <asp:TextBox ID="TbxPesquisarGridTransporte" runat="server" Width="265px" Height="35px" ToolTip="Filtrar por nome:"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridTransporte" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridTransporte_Click" ToolTip="Filtrar por nome:" />
    <br />
    <br />


    <asp:GridView ID="GridViewTransporte" runat="server" CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_TRANSPORTE" OnPageIndexChanging="GridViewTransporte_PageIndexChanging" OnRowDeleting="GridViewTransporte_RowDeleting" OnSelectedIndexChanged="GridViewTransporte_SelectedIndexChanged" OnSelectedIndexChanging="GridViewTransporte_SelectedIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="NUMERO" DataField="SQ_TRANSPORTE" Visible="False" />
            <asp:BoundField HeaderText="Nome" DataField="Nome">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Telefone" DataField="Telefones">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Email" DataField="Email">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField DataField="CNPJ" HeaderText="CNPJ">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="EXCLUIDO">

                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>

            <asp:BoundField DataField="endereco" HeaderText="endereco" Visible="False" />

            <asp:BoundField DataField="CEP" HeaderText="CEP" Visible="False" />
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




</asp:Content>
