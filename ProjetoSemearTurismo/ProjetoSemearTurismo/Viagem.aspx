<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Viagem.aspx.cs" Inherits="ProjetoSemearTurismo.Contact" %>

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

  .PopupViagensGRID

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
    
    <div class="jumbotron">
        <h2>Viagem</h2>
        <p class="lead">Gerencie o cadastro de Viagens, inclusão, edição e exclusão.</p>
<%--        <p><a runat="server" href="~/Viagem" class="btn btn-primary btn-lg">Viagens &raquo;</a></p>--%>
        <p><asp:Button ID="BtnModalViagensGRID" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Viagem »" OnClick="BtnModalViagensGRID_Click" /> </p>
        <p>
            <asp:Button ID="hdnBtnModalViagens" runat="server" Text="" CssClass="hdnBtn" />

        </p>
    </div>

    <cc1:ModalPopupExtender ID="MPEViagensGRID" runat="server" PopupControlID="PNLViagensGRID" TargetControlID="hdnBtnModalViagens"
                CancelControlID="btnHDNCancelarPopupViagemCadastro" BackgroundCssClass="modalBackground" >
  </cc1:ModalPopupExtender>    

       <asp:Panel ID="PNLViagensGRID" runat="server" CssClass="PopupViagensGRID" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
            <h2>
            <asp:Label ID="LblViagensPopupViagemCadastro" runat="server" Text="Viagens"></asp:Label>
            </h2>
             <br />  <br />
         <h3>
            <asp:Label ID="LblInfViagemPopupViagemCadastro" runat="server" Text="Informações Viagem"></asp:Label>
         </h3>
            <br />
         <asp:Label ID="LblNomePopupViagemCadastro" runat="server" Text="Nome viagem " ></asp:Label>
         <asp:TextBox ID="TbxNomePopupViagemCadastro" runat="server"></asp:TextBox>

        
         <asp:Label ID="LblDataInicial" runat="server" Text="Data inicial" CssClass="lbl" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxDataInicialPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>
        <asp:Label ID="LblDataFinal" runat="server" Text="Data Final" CssClass="lbl" style="margin-left: 15px"></asp:Label>
         <asp:TextBox ID="TbxDataFinalPopupViagemCadastro" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px"></asp:TextBox>
        
           <br />  <br />
             <asp:Label ID="LblDescPopupViagemCadastro" runat="server" Text="Descrição" ></asp:Label>
           <br />
         <asp:TextBox ID="TbxDescPopupViagemCadastro" runat="server" TextMode="MultiLine"  Height="100px" Width="600px"></asp:TextBox>
          
           <br />  <br />
         <h3>
            <asp:Label ID="lblobsPopupViagemCadastro" runat="server" Text="Observação"></asp:Label>
         </h3>

         <br />  <br />
          <asp:Label ID="lblStatus" runat="server" Text="Status "></asp:Label>
         <asp:DropDownList ID="DropDownListViagemPopupViagemCadastro" runat="server" >
             <asp:ListItem Value="0" Text="Ativa"></asp:ListItem>
            <asp:ListItem Value="1" Text="Em andamento"></asp:ListItem>
            <asp:ListItem Value="2" Text="Finalizada"></asp:ListItem>
            <asp:ListItem Value="2" Text="Inativa"></asp:ListItem>

         </asp:DropDownList>

                      <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" Enabled="True" TargetControlID="TbxPrecoViagemPopupViagemCadastro" FilterMode="ValidChars" ValidChars="1234567890.," />

             <asp:Label ID="LblPrecoViagemPopupViagemCadastro" runat="server" Text="Preço" Style="margin-left: 15px" ></asp:Label>
         <asp:TextBox ID="TbxPrecoViagemPopupViagemCadastro" runat="server"  >0000.00</asp:TextBox>
           

          
         <br />  <br />
              <asp:Label ID="LblOBSViagemPopupViagemCadastro" runat="server" Text="Observação" ></asp:Label>
           <br />
         <asp:TextBox ID="TbxOBSViagemPopupViagemCadastro" runat="server" TextMode="MultiLine" Height="100px" Width="600px"></asp:TextBox>
         <br />  <br />
        <asp:Button ID="BtnCadastrarPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Cadastrar Viagem" OnClick="BtnCadastrarViagemModal_Click" />
        <asp:Button ID="BtnEditarCadastroPopupViagemCadastro" CssClass="btn btn-primary btn-lg" runat="server" Text="Editar Viagem" OnClick="BtnEditarCadastroPopupViagemCadastro_Click"  />
                <asp:Button ID="btnCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="btn btn-primary btn-lg" OnClick="btnCancelarPopupViagemCadastro_Click"   />
                <asp:Button ID="btnLimparPopupViagemCadastro" runat="server" Text="Limpar" CssClass="btn btn-primary btn-lg" OnClick="btnLimparPopupViagemCadastro_Click"   />
                <asp:Button ID="btnHDNCancelarPopupViagemCadastro" runat="server" Text="Cancelar" CssClass="hdnBtn"   />
    
           </asp:Panel>     

    

      


<%--
    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Viagens</h2>
            <p> O gerenciamento de Viagens permite cadastrar, editar e excluir os Viagens e funcionarios da empresa.
                
                </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Viagem">Viagens &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Reservas </h2>
            <p>
               Local de gerenciamento de reservas feitas por Viagens, status de pagamento de cada reserva, inclusao e cancelamento de reservas.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Reserva">Reservas &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Viagens</h2>
            <p>
                O gerenciamento de Viagens permite cadastrar, editar e excluir Viagens </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Viagem">Viagens &raquo;</a>
            </p>
        </div>
    </div>
    
    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Transportes</h2>
            <p> O gerenciamento de transportes permite cadastrar, editar e excluir os transportes que atenderão os Viagens.
                
                </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Transporte">Transportes &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Hospedagem  </h2>
            <p>
               Local de gerenciamento de hospedagem de cada viagem .
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Hospedagem">Hospedagens &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Relatórios</h2>
            <p>
                O gerenciamento de Viagens permite cadastrar, editar e excluir Viagens </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Viagem">Viagens &raquo;</a>
            </p>
        </div>
    </div>--%>
      <h2>Viagens cadastrados</h2>
    <br />
      <h4>Pesquisar Viagem</h4>
    <asp:TextBox ID="TbxPesquisarGridViagens" runat="server" Width="265px" Height="35px"></asp:TextBox>
    <asp:ImageButton ID="ImgBtnPesquisarGridViagens" runat="server" Height="48px" CssClass="btn btn-primary btn-lg" ImageUrl="~/Imagens/kisspng-magnifying-glass-computer-icons-search-box-icon-search-drawing-icon-5ab0b21d220e43.5318324015215293731395.png" Width="59px" ImageAlign="Middle" OnClick="ImgBtnPesquisarGridViagens_Click" />
        <br />
        <br />
       
 
    <asp:GridView ID="GridViewViagens" runat="server" CellPadding="10" ForeColor="#333333" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_VIAGEM" OnPageIndexChanging="GridViewViagens_PageIndexChanging" OnRowDeleting="GridViewViagens_RowDeleting" OnSelectedIndexChanged="GridViewViagens_SelectedIndexChanged" OnSelectedIndexChanging="GridViewViagens_SelectedIndexChanging"  >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField HeaderText="NUMERO" DataField="SQ_VIAGEM" Visible="False" />
                    <asp:BoundField HeaderText="Nome" DataField="NOME_VIAGEM" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Inicio viagem" DataField="DT_InicialPeriodo_viagem" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Final viagem" DataField="DTFinalperiodo_viagem" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="Descricao do pacote" DataField="Descricao_do_pacote" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Tipo_Transporte" HeaderText="Transporte" Visible="False" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Preco" HeaderText="Preço" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Formas_de_pagamento" HeaderText="Formas de pagamento" Visible="False" />
                    <asp:BoundField DataField="OBSERVACAO" HeaderText="Observação" >
                    <HeaderStyle BorderStyle="Solid" BorderWidth="10px" />
                    <ItemStyle BorderStyle="Solid" BorderWidth="10px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="FL_STATUS" HeaderText="Status" >
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