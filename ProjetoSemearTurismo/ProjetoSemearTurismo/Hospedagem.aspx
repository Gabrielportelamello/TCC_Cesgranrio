<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="Hospedagem.aspx.cs" Inherits="ProjetoSemearTurismo.Views.Hospedagem" %>


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

  .PopupHospedagemsGRID

  {

    background-color: #ffffff;

    padding: 3px;

    z-index: 10001;
    overflow:scroll; 
    height:100%;
    width:100%;

  }
  .hdnBtn{
      visibility:hidden;
      opacity:0%;
  }
         </style>
    
  
    <cc1:ModalPopupExtender ID="MPEHospedagemsGRID" runat="server" PopupControlID="PNLHospedagemsGRID" TargetControlID="hdnBtnModalHospedagems"
                CancelControlID="btnHDNCancelarPopupHospedagemCadastro" BackgroundCssClass="modalBackground" >
  </cc1:ModalPopupExtender>    

       <asp:Panel ID="PNLHospedagemsGRID" runat="server" CssClass="PopupHospedagemsGRID" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
            <h2>
            <asp:Label ID="LblHospedagemsPopupHospedagemCadastro" runat="server" Text="Hospedagems"></asp:Label>
            </h2>
             <br />  <br />
         <h3>
            <asp:Label ID="LblDadosEmpresariaisPopupHospedagemCadastro" runat="server" Text="Dados Empresarias"></asp:Label>
         </h3>
            <br />
         <asp:Label ID="LblNomePopupHospedagemCadastro" runat="server" Text="Nome" ></asp:Label>
         <asp:TextBox ID="TbxNomePopupHospedagemCadastro" runat="server"></asp:TextBox>
         <asp:Label ID="LblCNPJPopupHospedagemCadastro" runat="server" Text="CNPJ" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCNPJPopupHospedagemCadastro" runat="server" Width="99px"></asp:TextBox>
        
         <%--<asp:Label ID="LblNascimento" runat="server" Text="Nascimento" CssClass="lbl" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxNascimentoPopupHospedagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>--%>
           <br />  <br /> <br />
           <h4>
            <asp:Label ID="LblCkeckPrincipalPopupHospedagemCadastro" runat="server" Text="Checkin/Checkout"></asp:Label>
         </h4>
            <br />
             <asp:Label ID="LblChekinPopupHospedagemCadastro" runat="server" Text="Data Checkin" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxChekinPopupHospedagemCadastro" runat="server" Width="99px" TextMode="Date"></asp:TextBox>
                <asp:Label ID="LblChekoutPopupHospedagemCadastro" runat="server" Text="Data Checkout" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxChekoutPopupHospedagemCadastro" runat="server" Width="99px" TextMode="Date"></asp:TextBox>
         <br />  <br /> <br />
                    
         <h3>
            <asp:Label ID="LblContatoPrincipalPopupHospedagemCadastro" runat="server" Text="Contato"></asp:Label>
         </h3>
           <br />
         <asp:Label ID="LblTel1PopupHospedagemCadastro" runat="server" Text="Telefone 1" ></asp:Label>
         <asp:TextBox ID="TbxTel1PopupHospedagemCadastro" runat="server"></asp:TextBox>

         <%--<asp:Label ID="LblTel2PopupHospedagemCadastro" runat="server" Text="Telefone 2" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxTel2PopupHospedagemCadastro" runat="server"></asp:TextBox>--%>
        
         <asp:Label ID="LblEmailPopupHospedagemCadastro" runat="server" Text="E-mail" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxEmailPopupHospedagemCadastro" runat="server"></asp:TextBox>
         
         <br />  <br />
         
         <h3>
            <asp:Label ID="LblEnderecoPrincipalPopupHospedagemCadastro" runat="server" Text="Endereço"></asp:Label>
         </h3>
         <asp:Label ID="LblRuaPopupHospedagemCadastro" runat="server" Text="Rua" ></asp:Label>
         <asp:TextBox ID="TbxRuaPopupHospedagemCadastro" runat="server"></asp:TextBox>

         <asp:Label ID="LblBairroPopupHospedagemCadastro" runat="server" Text="Bairro" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxBairroPopupHospedagemCadastro" runat="server" Width="103px"></asp:TextBox>
        
         <asp:Label ID="LblCidadePopupHospedagemCadastro" runat="server" Text="Cidade" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCidadePopupHospedagemCadastro" runat="server" Width="107px"></asp:TextBox>
         
          <asp:Label ID="LblUFPopupHospedagemCadastro" runat="server" Text="UF" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxUFPopupHospedagemCadastro" runat="server" Width="39px"></asp:TextBox>
                  <asp:Label ID="LblCEPPopupHospedagemCadastro" runat="server" Text="CEP" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxCEPPopupHospedagemCadastro" runat="server" Width="96px"></asp:TextBox>
                  
   
           <br />  <br />
       
            <asp:Label ID="Label1" runat="server" Text="EXCLUIR ? "></asp:Label>
         <asp:DropDownList ID="DropDownListFlagExcluidoPopupHospedagemCadastro" runat="server" >
             <asp:ListItem Value="0" Text="NÃO"></asp:ListItem>
            <asp:ListItem Value="1" Text="SIM"></asp:ListItem>

         </asp:DropDownList>

           <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" Enabled="True" TargetControlID="TbxPrecoPopupHospedagemCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />
             <asp:Label ID="LblPrecoPopupHospedagemCadastro" runat="server" Text="Preço" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxPrecoPopupHospedagemCadastro" runat="server" TextMode="SingleLine">0.00</asp:TextBox> 
           <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True" TargetControlID="TbxQTDQuartosPopupHospedagemCadastro" FilterMode="ValidChars" ValidChars="1234567890" />
             <asp:Label ID="LblQTDQuartosPopupHospedagemCadastro" runat="server" Text="Quantidade Quartos" Style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxQTDQuartosPopupHospedagemCadastro" runat="server" TextMode="SingleLine">0</asp:TextBox>
         <br />  <br />
        <asp:Button ID="BtnCadastrarPopupHospedagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Hospedagem" OnClick="BtnCadastrarHospedagemModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupHospedagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Hospedagem" OnClick="BtnEditarCadastroPopupHospedagemCadastro_Click"  />
                <asp:Button ID="btnCancelarPopupHospedagemCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupHospedagemCadastro_Click"   />
                <asp:Button ID="btnLimparPopupHospedagemCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupHospedagemCadastro_Click"   />
                <asp:Button ID="btnHDNCancelarPopupHospedagemCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn"   />
    
           </asp:Panel>     

    

      

      <h2>Hospedagems</h2>
    <br />
     <asp:Button ID="BtnModalHospedagemsGRID" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Hospedagem »" OnClick="BtnModalHospedagemsGRID_Click" />
        
            <asp:Button ID="hdnBtnModalHospedagems" runat="server" Text="" CssClass="hdnBtn" />

      
    <asp:TextBox ID="TbxPesquisarGridHospedagems" runat="server" Width="265px" Height="35px" ToolTip="Filtrar por nome"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridHospedagems" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridHospedagems_Click" ToolTip="Filtrar por nome" />
        <br />
        <br />
       
 
    <asp:GridView ID="GridViewHospedagems" runat="server" CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SEQ_Hospedagem" OnPageIndexChanging="GridViewHospedagems_PageIndexChanging" OnRowDeleting="GridViewHospedagems_RowDeleting" OnSelectedIndexChanged="GridViewHospedagems_SelectedIndexChanged" OnSelectedIndexChanging="GridViewHospedagems_SelectedIndexChanging"  >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
        <asp:BoundField DataField="SEQ_HOSPEDAGEM" HeaderText="SEQ_HOSPEDAGEM" ReadOnly="True" SortExpression="SEQ_HOSPEDAGEM" Visible="False" >
              <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="Endereco" HeaderText="Endereço" SortExpression="Endereco" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="CNPJ" HeaderText="CNPJ" SortExpression="CNPJ" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="Telefones" HeaderText="Telefones" SortExpression="Telefones" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="CEP" HeaderText="CEP" SortExpression="CEP" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="qtd_quartos" HeaderText="Quantidade de Quartos" SortExpression="qtd_quartos" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="data_checkin" HeaderText="Data Check-In" SortExpression="data_checkin" DataFormatString="{0:d}" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="data_checkout" HeaderText="Data Check-Out" SortExpression="data_checkout" DataFormatString="{0:d}" >
            <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
            </asp:BoundField>
        <asp:BoundField DataField="preco" HeaderText="Preço" SortExpression="preco" DataFormatString="{0:C2}" >
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
