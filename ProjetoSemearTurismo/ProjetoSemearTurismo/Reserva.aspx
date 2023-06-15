<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Reserva.aspx.cs" Inherits="ProjetoSemearTurismo.Views.Reserva" %>

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

        .PopupReservasGRID {
            background-color: #ffffff;
            padding: 3px;
            z-index: 10001;
            overflow: scroll;
            height: 100%;
            width: 100%;
        }

        .hdnBtn {
            visibility: hidden;
            opacity: 0%;
        }
    </style>
  <script type="text/javascript">

      function filterResults() {
          var inputText = document.getElementById("<%=txtSearch.ClientID%>").value;
    var dropdownList = document.getElementById("<%=DropDownListHospedagemPopupReservaCadastro.ClientID%>");
          for (var i = 0; i < dropdownList.options.length; i++) {
              if (dropdownList.options[i].text.toLowerCase().indexOf(inputText.toLowerCase()) >= 0) {
                  dropdownList.options[i].style.display = "block";
              } else {
                  dropdownList.options[i].style.display = "none";
              }
          }
      }

      function filterResultsCliente() {
          var inputTextCliente = document.getElementById("<%=TextBoxClientePopupReservaCadastro.ClientID%>").value;
    var dropdownList = document.getElementById("<%=DropDownListClientePopupReservaCadastro.ClientID%>");
          for (var i = 0; i < dropdownList.options.length; i++) {
              if (dropdownList.options[i].text.toLowerCase().indexOf(inputTextCliente.toLowerCase()) >= 0) {
                  dropdownList.options[i].style.display = "block";
              } else {
                  dropdownList.options[i].style.display = "none";
              }
          }
      }

      function filterResultsTransporte() {
          var inputText = document.getElementById("<%=TextBoxTransportePopupReservaCadastro.ClientID%>").value;
    var dropdownList = document.getElementById("<%=DropDownListTransportePopupReservaCadastro.ClientID%>");
          for (var i = 0; i < dropdownList.options.length; i++) {
              if (dropdownList.options[i].text.toLowerCase().indexOf(inputText.toLowerCase()) >= 0) {
                  dropdownList.options[i].style.display = "block";
              } else {
                  dropdownList.options[i].style.display = "none";
              }
          }
      }

      function filterResultsViagem() {
          var inputText = document.getElementById("<%=TextBoxViagemPopupReservaCadastro.ClientID%>").value;
    var dropdownList = document.getElementById("<%=DropDownListViagemPopupReservaCadastro.ClientID%>");
          for (var i = 0; i < dropdownList.options.length; i++) {
              if (dropdownList.options[i].text.toLowerCase().indexOf(inputText.toLowerCase()) >= 0) {
                  dropdownList.options[i].style.display = "block";
              } else {
                  dropdownList.options[i].style.display = "none";
              }
          }
  </script>

    <div class="jumbotron">
        <h2>Reserva</h2>
        <p class="lead">Gerencie o cadastro de Reservas, inclusão, edição e exclusão.</p>
        <%--        <p><a runat="server" href="~/Viagem" class="btn btn-primary btn-lg">Reservas &raquo;</a></p>--%>
        <p>
            <asp:Button ID="BtnModalReservasGRID" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Reserva »" OnClick="BtnModalReservasGRID_Click" />
        </p>
        <p>
            <asp:Button ID="hdnBtnModalReservas" runat="server" Text="" CssClass="hdnBtn" />

        </p>
    </div>

    <cc1:ModalPopupExtender ID="MPEReservasGRID" runat="server" PopupControlID="PNLReservasGRID" TargetControlID="hdnBtnModalReservas"
        CancelControlID="btnHDNCancelarPopupReservaCadastro" BackgroundCssClass="modalBackground">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="PNLReservasGRID" runat="server" CssClass="PopupReservasGRID" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
        <h2>
            <asp:Label ID="LblReservasPopupReservaCadastro" runat="server" Text="Reservas"></asp:Label>
        </h2>
        <br />
        <br />
        <h3>
            <asp:Label ID="LblDadosPessoaisPopupReservaCadastro" runat="server" Text="Dados de Reserva"></asp:Label>
        </h3>
        <br />
        <asp:Label ID="LblViagemPopupReservaCadastro" runat="server" Text="Viagem"></asp:Label>
        <br /><br />
           <asp:TextBox ID="TextBoxViagemPopupReservaCadastro" runat="server" onkeyup="filterResultsViagem()" />
          <br />       
        
<asp:DropDownList ID="DropDownListViagemPopupReservaCadastro" runat="server">
 
</asp:DropDownList>

          <br />
        <br />

        <asp:Label ID="LblClientePopupReservaCadastro" runat="server" Text="Cliente" Style="margin-left: 15px"></asp:Label>
                          <br />             <br />       
    
                <asp:Label ID="Label2" runat="server" Text="Filtrar : " Style="margin-left: 15px"></asp:Label>

        <asp:TextBox ID="TextBoxClientePopupReservaCadastro" runat="server" onkeyup="filterResultsCliente()" />
          <br />       
        
<asp:DropDownList ID="DropDownListClientePopupReservaCadastro" runat="server">
 
</asp:DropDownList>


          <br />
        <br />
        <asp:Label ID="LblTransportePopupReservaCadastro" runat="server" Text="Transporte" Style="margin-left: 15px"></asp:Label>
        <br />  <br />
          <asp:TextBox ID="TextBoxTransportePopupReservaCadastro" runat="server" onkeyup="filterResultsTransporte()" />
          <br />     
        
<asp:DropDownList ID="DropDownListTransportePopupReservaCadastro" runat="server">
 
</asp:DropDownList>

         <br />
        <br />
        <asp:Label ID="LblHospedagemPopupReservaCadastro" runat="server" Text="Hospedagem" Style="margin-left: 15px"></asp:Label> 
        <br /> <br />
  <asp:TextBox ID="txtSearch" runat="server" onkeyup="filterResults()" />
          <br />      
        
<asp:DropDownList ID="DropDownListHospedagemPopupReservaCadastro" runat="server">

</asp:DropDownList>





         <br />
        <br />
        <br />
   
     
        <h3>
            <asp:Label ID="lblPerfilPopupReservaCadastro" runat="server" Text="Perfil de Acesso"></asp:Label>
        </h3>
        <br />
        <br />
      
        <asp:Label ID="Label1" runat="server" Text="EXCLUIR ? "></asp:Label>
        <asp:DropDownList ID="DropDownListFlagExcluidoPopupReservaCadastro" runat="server">
            <asp:ListItem Value="0" Text="NÃO"></asp:ListItem>
            <asp:ListItem Value="1" Text="SIM"></asp:ListItem>

        </asp:DropDownList>

      <%--  <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" Enabled="True" TargetControlID="TbxSaldoPopupReservaCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />
        <asp:Label ID="LblSaldoPopupReservaCadastro" runat="server" Text="Saldo" Style="margin-left: 15px"></asp:Label>
        <asp:TextBox ID="TbxSaldoPopupReservaCadastro" runat="server" TextMode="SingleLine">0.00</asp:TextBox>--%>
        <br />
        <br />
        <asp:Button ID="BtnCadastrarPopupReservaCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Reserva" OnClick="BtnCadastrarReservaModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupReservaCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Reserva" OnClick="BtnEditarCadastroPopupReservaCadastro_Click" />
        <asp:Button ID="btnCancelarPopupReservaCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupReservaCadastro_Click" />
        <asp:Button ID="btnLimparPopupReservaCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupReservaCadastro_Click" />
        <asp:Button ID="btnHDNCancelarPopupReservaCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn" />

    </asp:Panel>


    <h2>Reservas cadastradas</h2>
    <br />
    <h4>Pesquisar Reserva</h4>
    <asp:TextBox ID="TbxPesquisarGridReservas" runat="server" Width="265px" Height="35px"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridReservas" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridReservas_Click" />
    <br />
    <br />


    <asp:GridView ID="GridViewReservas" runat="server" CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_PESSOA" OnPageIndexChanging="GridViewReservas_PageIndexChanging" OnRowDeleting="GridViewReservas_RowDeleting" OnSelectedIndexChanged="GridViewReservas_SelectedIndexChanged" OnSelectedIndexChanging="GridViewReservas_SelectedIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="NUMERO" DataField="SQ_PESSOA" Visible="False" />
            <asp:BoundField HeaderText="Nome" DataField="Nome">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Telefone" DataField="Telefone">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Email" DataField="Email">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Data de Nascimento" DataField="Data_Nascimento">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField DataField="CPF" HeaderText="CPF">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField DataField="Passaporte" HeaderText="Passaporte" Visible="False" />
            <asp:BoundField DataField="emissao_passaporte" HeaderText="Emissao passaporte" Visible="False" />
            <asp:BoundField DataField="RG" HeaderText="RG">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField DataField="Validade_Passaporte" HeaderText="Validade do Passaporte" Visible="False" />
            <asp:BoundField DataField="orgao_emissor_RG" HeaderText="orgao_emissor_RG" Visible="False" />
            <asp:BoundField DataField="data_emissao_RG" HeaderText="data_emissao_RG" Visible="False" />
            <asp:BoundField DataField="Perfil_Acesso" HeaderText="Perfil_Acesso" Visible="False" />
            <asp:BoundField DataField="salario" HeaderText="salario" Visible="False" />
            <asp:BoundField DataField="Saldo" HeaderText="Saldo">
                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
            <asp:BoundField DataField="FL_FUNCIONARIO" HeaderText="FL_FUNCIONARIO" Visible="False" />
            <asp:BoundField DataField="FL_EXCLUIDO" HeaderText="EXCLUIDO">

                <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>

            <asp:BoundField DataField="bairro_endereco" HeaderText="bairro_endereco" Visible="False" />

            <asp:BoundField DataField="cidade_endereco" HeaderText="cidade_endereco" Visible="False" />
            <asp:BoundField DataField="uf_endereco" HeaderText="uf_endereco" Visible="False" />
            <asp:BoundField DataField="rua_endereco" HeaderText="rua_endereco" Visible="False" />
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
