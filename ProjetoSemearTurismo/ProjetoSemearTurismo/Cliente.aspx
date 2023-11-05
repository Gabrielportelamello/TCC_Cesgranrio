<%@ Page Title="Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="ProjetoSemearTurismo.About" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <style>
          .BtnModalMBOXCSS {
           visibility:hidden;
        }
          .btnExcluir{
              color:whitesmoke;
              border-radius:3px;
              border-color:whitesmoke;
          }
          .btnExcluir:hover{
              border-color:#FF3300;
              transition: .5s;
          }
           .btnEditar{
              color:whitesmoke;
              border-radius:3px;
              border-color:whitesmoke;
          }
          .btnEditar:hover{
              border-color:#339933;
              transition: .5s;
          }
          .modalBackground

  {
   background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;

    top: 0px !important;

    left: 0px !important;

    position: absolute !important;

    z-index: 1 !important;

  }

  .PopupClientesGRID

  {

    background-color: #ffffff;

    padding: 3px;

    z-index: 10001;
    overflow:scroll; 
    height:500px;
    width:900px;

  }
  .hdnBtn{
      visibility:hidden;
      opacity:0%;
  }
         </style>
    

            <asp:Button ID="hdnBtnModalClientes" runat="server" Text="" CssClass="hdnBtn" />



    <cc1:ModalPopupExtender ID="MPEClientesGRID" runat="server" PopupControlID="PNLClientesGRID" TargetControlID="hdnBtnModalClientes"
                CancelControlID="btnHDNCancelarPopupClienteCadastro" BackgroundCssClass="modalBackground" >
  </cc1:ModalPopupExtender>    

       <asp:Panel ID="PNLClientesGRID" runat="server" CssClass="PopupClientesGRID" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
            <h2>
            <asp:Label ID="LblClientesPopupClienteCadastro" runat="server" Text="Clientes"></asp:Label>
            </h2>
             <br />  <br />
         <h3>
            <asp:Label ID="LblDadosPessoaisPopupClienteCadastro" runat="server" Text="Dados pessoais"></asp:Label>
         </h3>
            <br />
         <asp:Label ID="LblNomePopupClienteCadastro" runat="server" Text="Nome" ></asp:Label>
         <asp:TextBox ID="TbxNomePopupClienteCadastro" runat="server"></asp:TextBox>
         <asp:Label ID="LblCPFPopupClienteCadastro" runat="server" Text="CPF" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCPFPopupClienteCadastro" runat="server" Width="99px"></asp:TextBox>
        
         <asp:Label ID="LblNascimento" runat="server" Text="Nascimento" CssClass="lbl" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxNascimentoPopupClienteCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>
           <br />  <br /> <br />
           <h4>
            <asp:Label ID="LblFiliacaoPrincipalPopupClienteCadastro" runat="server" Text="Filiação"></asp:Label>
         </h4>
            <br />
         <asp:Label ID="LblNomePaiPopupClienteCadastro" runat="server" Text="Nome PAI" ></asp:Label>
         <asp:TextBox ID="TbxNomePaiPopupClienteCadastro" runat="server"></asp:TextBox>
         <asp:Label ID="LblNomeMaePopupClienteCadastro" runat="server" Text="Nome MÃE" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxNomeMaePopupClienteCadastro" runat="server"></asp:TextBox>
         <br />  <br /> <br />
             <h3>
            <asp:Label ID="LblDocumentosPrincipalPopupClienteCadastro" runat="server" Text="Documentos"></asp:Label>
         </h3>
         <br />  
          <h4>
            <asp:Label ID="LblRPrincipalGPopupClienteCadastro" runat="server" Text="RG"></asp:Label>
         </h4>
         <br />  
            <asp:Label ID="LblNumRGPopupClienteCadastro" runat="server" Text="Numeração RG"  style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxNumRGPopupClienteCadastro" runat="server" Width="99px"></asp:TextBox>
         <asp:Label ID="LblOrgaoEmissorPopupClienteCadastro" runat="server" Text="Orgão emissor" ></asp:Label>
         <asp:TextBox ID="TbxOrgaoEmissorPopupClienteCadastro" runat="server"></asp:TextBox>
         <asp:Label ID="LblDataEmissRGPopupClienteCadastro" runat="server" Text="Data Emissão" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxDataEmissRGPopupClienteCadastro" runat="server" Width="99px" TextMode="Date"></asp:TextBox>

         <br />  <br /> <br />
          <h4>
            <asp:Label ID="LblPassaportePrincipalPopupClienteCadastro" runat="server" Text="Passaporte"></asp:Label>
         </h4>

         <br />  <br />
           <asp:Label ID="LblNumPassPopupClienteCadastro" runat="server" Text="Numeração Passaporte" ></asp:Label>
         <asp:TextBox ID="TbxNumPassPopupClienteCadastro" runat="server"></asp:TextBox>
         <asp:Label ID="LblDataEmissPassPopupClienteCadastro" runat="server" Text="Data Emissão" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxDataEmissPassPopupClienteCadastro" runat="server" Width="99px" TextMode="Date"></asp:TextBox>
        <asp:Label ID="LblDataValiPassPopupClienteCadastro" runat="server" Text="Data Validade" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxDataValiPassPopupClienteCadastro" runat="server" Width="99px" TextMode="Date"></asp:TextBox>
        
           
         
       <br />  <br />
         
         <h3>
            <asp:Label ID="LblContatoPrincipalPopupClienteCadastro" runat="server" Text="Contato"></asp:Label>
         </h3>
           <br />
         <asp:Label ID="LblTel1PopupClienteCadastro" runat="server" Text="Telefone 1" ></asp:Label>
         <asp:TextBox ID="TbxTel1PopupClienteCadastro" runat="server"></asp:TextBox>

         <%--<asp:Label ID="LblTel2PopupClienteCadastro" runat="server" Text="Telefone 2" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxTel2PopupClienteCadastro" runat="server"></asp:TextBox>--%>
        
         <asp:Label ID="LblEmailPopupClienteCadastro" runat="server" Text="E-mail" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxEmailPopupClienteCadastro" runat="server"></asp:TextBox>
         
         <br />  <br />
         
         <h3>
            <asp:Label ID="LblEnderecoPrincipalPopupClienteCadastro" runat="server" Text="Endereço"></asp:Label>
         </h3>
         <asp:Label ID="LblRuaPopupClienteCadastro" runat="server" Text="Rua" ></asp:Label>
         <asp:TextBox ID="TbxRuaPopupClienteCadastro" runat="server"></asp:TextBox>

         <asp:Label ID="LblBairroPopupClienteCadastro" runat="server" Text="Bairro" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxBairroPopupClienteCadastro" runat="server" Width="103px"></asp:TextBox>
        
         <asp:Label ID="LblCidadePopupClienteCadastro" runat="server" Text="Cidade" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCidadePopupClienteCadastro" runat="server" Width="107px"></asp:TextBox>
         
          <asp:Label ID="LblUFPopupClienteCadastro" runat="server" Text="UF" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxUFPopupClienteCadastro" runat="server" Width="39px"></asp:TextBox>
                  <asp:Label ID="LblCEPPopupClienteCadastro" runat="server" Text="CEP" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCEPPopupClienteCadastro" runat="server" Width="96px"></asp:TextBox>
                  
         
           <br />  <br />
         <h3>
            <asp:Label ID="lblPerfilPopupClienteCadastro" runat="server" Text="Perfil de Acesso"></asp:Label>
         </h3>

         <br />  <br />
          <asp:Label ID="lblFuncao" runat="server" Text="É funcionário? "></asp:Label>
         <asp:DropDownList ID="DropDownListFuncionarioPopupClienteCadastro" runat="server" OnSelectedIndexChanged="DropDownListFuncionarioPopupClienteCadastro_SelectedIndexChanged" OnTextChanged="DropDownListFuncionarioPopupClienteCadastro_TextChanged">
             <asp:ListItem Value="0" Text="NÃO"></asp:ListItem>
            <asp:ListItem Value="1" Text="SIM"></asp:ListItem>

         </asp:DropDownList>

                      <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True" TargetControlID="TbxSalarioFuncionaroPopupClienteCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />

             <asp:Label ID="LblSalarioFuncionaroPopupClienteCadastro" runat="server" Text="Salário" Style="margin-left: 15px" ></asp:Label>
         <asp:TextBox ID="TbxSalarioFuncionaroPopupClienteCadastro" runat="server"  >0000.00</asp:TextBox>
           <br />
           <br />
            <asp:Label ID="Label1" runat="server" Text="EXCLUIR ? "></asp:Label>
         <asp:DropDownList ID="DropDownListFlagExcluidoPopupClienteCadastro" runat="server" >
             <asp:ListItem Value="0" Text="NÃO"></asp:ListItem>
            <asp:ListItem Value="1" Text="SIM"></asp:ListItem>

         </asp:DropDownList>

           <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" Enabled="True" TargetControlID="TbxSaldoPopupClienteCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />
             <asp:Label ID="LblSaldoPopupClienteCadastro" runat="server" Text="Saldo" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxSaldoPopupClienteCadastro" runat="server" TextMode="SingleLine">0.00</asp:TextBox>
         <br />  <br />
        <asp:Button ID="BtnCadastrarPopupClienteCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar cliente" OnClick="BtnCadastrarClienteModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupClienteCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar cliente" OnClick="BtnEditarCadastroPopupClienteCadastro_Click"  />
                <asp:Button ID="btnCancelarPopupClienteCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupClienteCadastro_Click"   />
                <asp:Button ID="btnLimparPopupClienteCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupClienteCadastro_Click"   />
                <asp:Button ID="btnHDNCancelarPopupClienteCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn"   />
    
           </asp:Panel>     

    
  <h2 class="text-center">Clientes</h2>
    <br />
    <asp:Button ID="BtnModalClientesGRID" CssClass="btn btn-primary btn-lg w-100" runat="server" Text="Cadastrar Cliente »" OnClick="BtnModalClientesGRID_Click" />


    <asp:TextBox ID="TbxPesquisarGridClientes" runat="server" Width="265px" Height="35px"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridClientes" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridClientes_Click" />
        <br />
        <br />
       
 
    <asp:GridView ID="GridViewClientes" runat="server" CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_PESSOA" OnPageIndexChanging="GridViewClientes_PageIndexChanging" OnRowDeleting="GridViewClientes_RowDeleting" OnSelectedIndexChanged="GridViewClientes_SelectedIndexChanged" OnSelectedIndexChanging="GridViewClientes_SelectedIndexChanging"  >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField HeaderText="NUMERO" DataField="SQ_PESSOA" Visible="False" />
                    <asp:BoundField HeaderText="Nome" DataField="Nome" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Telefone" DataField="Telefone" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Email" DataField="Email" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Data de Nascimento" DataField="Data_Nascimento" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="CPF" HeaderText="CPF" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Passaporte" HeaderText="Passaporte" Visible="False" />
                    <asp:BoundField DataField="emissao_passaporte" HeaderText="Emissao passaporte" Visible="False" />
                    <asp:BoundField DataField="RG" HeaderText="RG" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Validade_Passaporte" HeaderText="Validade do Passaporte" Visible="False" />
                    <asp:BoundField DataField="orgao_emissor_RG" HeaderText="orgao_emissor_RG" Visible="False" />
                    <asp:BoundField DataField="data_emissao_RG" HeaderText="data_emissao_RG" Visible="False" />
                    <asp:BoundField DataField="Perfil_Acesso" HeaderText="Perfil_Acesso" Visible="False" />
                    <asp:BoundField DataField="salario" HeaderText="salario" Visible="False" />
                    <asp:BoundField DataField="Saldo" HeaderText="Saldo"  >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FL_FUNCIONARIO" HeaderText="FL_FUNCIONARIO" Visible="False" />
                    <asp:BoundField DataField="FL_EXCLUIDO" HeaderText="EXCLUIDO" >

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
