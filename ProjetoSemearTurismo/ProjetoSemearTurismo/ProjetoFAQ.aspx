<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjetoFAQ.aspx.cs" Inherits="ProjetoSemearTurismo.ProjetoFAQ" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FAQ</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Scripts\jquery-3.6.0.min.js"></script>

    <script type="text/javascript">
        $(function () {
            $(".Asnwer").hide();
            $(".Question").click(function () {

                $(this).siblings(".Asnwer").toggle(300);
            });
        });
    </script>


    <style>
          #btnCadastrar {
            width: 100%;
            height: 50px;
            border: 1px solid;
            background: #2691d9;
            border-radius: 25px;
            font-size: 18px;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
        }
          #btnEditar {
            width: 100%;
            height: 50px;
            border: 1px solid;
            background: #2691d9;
            border-radius: 25px;
            font-size: 18px;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
        }

          #lblFLExluido {
            font-size: 1.1em;
        }

        #lblOrgaos {
            font-size: 1.1em;
        }

        #fPR {
            margin-top: 15px;
        }

        #img2 {
            margin-top: 15px;
        }
        

        #btnCadastrarDV {
            margin-top: 15px;
        }

        body {
            font-family: 'Montserrat', sans-serif;
            /*background: rgb(255,255,255);*/
            /*background: linear-gradient(90deg, rgba(255,255,255,1) 0%, rgba(217,217,217,1) 35%, rgba(194,194,194,1) 100%);*/
            margin: 0;
            padding: 0;
            height: 100vh;
            overflow: hidden;
        }

        .sidebar {
            height: 100%;
            width: 0;
            position: fixed;
            z-index: 1;
            top: 0;
            left: 0;
            background-color: #111;
            overflow-x: hidden;
            transition: 0.5s;
            padding-top: 60px;
        }

            .sidebar a {
                padding: 8px 8px 8px 32px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
                transition: 0.3s;
            }

                .sidebar a:hover {
                    color: #f1f1f1;
                }

            .sidebar .closebtn {
                position: absolute;
                top: 0;
                right: 25px;
                font-size: 36px;
                margin-left: 50px;
            }

        .openbtn {
            font-size: 20px;
            cursor: pointer;
            background-color: #111;
            color: white;
            padding: 10px 15px;
            border: none;
        }

            .openbtn:hover {
                background-color: #444;
            }

        #main {
            transition: margin-left .5s;
            padding: 16px;
        } 
        #ddlistFLExcluido {
            
            transition: margin-left .5s;
           
        }
            #btnCadastrar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

        .Question {
            font-weight: bold;
            color: blue;
            cursor: pointer;
            text-decoration: underline;
        }

        #myQuestion {
            font-size: 1.1em;
        }

        #lblSistemas {
            font-size: 1.1em;
        }

        #lblPergunta {
            font-size: 1.1em;
        }

        #lblResposta {
            font-size: 1.1em;
        }

        #lblOrgaos {
            font-size: 1.1em;
        }

        #fPR {
            margin-top: 15px;
        }

        #img2 {
            margin-top: 15px;
        }

        #btnCadastrarDV {
            margin-top: 15px;
        }

        body {
            font-family: 'Montserrat', sans-serif;
            background: rgb(255,255,255);
            background: linear-gradient(90deg, rgba(255,255,255,1) 0%, rgba(217,217,217,1) 35%, rgba(194,194,194,1) 100%);
            margin: 0;
            padding: 0;
            height: 100vh;
            overflow: hidden;
        }

        .sidebar {
            height: 100%;
            width: 0;
            position: fixed;
            z-index: 1;
            top: 0;
            left: 0;
            background-color: #111;
            overflow-x: hidden;
            transition: 0.5s;
            padding-top: 60px;
        }

            .sidebar a {
                padding: 8px 8px 8px 32px;
                text-decoration: none;
                font-size: 25px;
                color: #818181;
                display: block;
                transition: 0.3s;
            }

                .sidebar a:hover {
                    color: #f1f1f1;
                }

            .sidebar .closebtn {
                position: absolute;
                top: 0;
                right: 25px;
                font-size: 36px;
                margin-left: 50px;
            }

        .openbtn {
            font-size: 20px;
            cursor: pointer;
            background-color: #111;
            color: white;
            padding: 10px 15px;
            border: none;
        }

            .openbtn:hover {
                background-color: #444;
            }

        #main {
            transition: margin-left .5s;
            padding: 16px;
        }

        .centerCadastro {
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            width: 900px;
            height:700px;
            background: white;
            border-radius: 10px;
        }

            .centerCadastro h2 {
                text-align: center;
                padding: 0 0 20px 0;
                border-bottom: 1px solid silver;
            }


            .centerCadastro form1 {
                padding: 0 40px;
                box-sizing: border-box;
            }




        /* On smaller screens, where height is less than 450px, change the style of the sidenav (less padding and a smaller font size) */
        @media screen and (max-height: 450px) {
            .sidebar {
                padding-top: 15px;
            }

                .sidebar a {
                    font-size: 18px;
                }
        }

        .btnEditar {
            border: 2px solid;
            background: #277c00;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
        }

            .btnEditar:hover {
                border-color: #277c00;
                transition: .5s;
            }

        .btnExcluir {
            border: 2px solid;
            background: #ff0000;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
        }

            .btnExcluir:hover {
                border-color: #ff0000;
                transition: .5s;
            }

        .btnCancelar {
            border: 2px solid;
            background: #2691d9;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
        }

            .btnCancelar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

        .BtnCriar {
            border: 2px solid;
            background: #2691d9;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
        }

            .BtnCriar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

        .Background {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
            top: 50%;
            left: 50%;
            transform: translate(-20%,-32%);
            transition: margin-left .5s;
            width: 100000px;
            height: 100000px;
        }

        .Popup {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 800px;
            height: 832px;
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
            
            transform: translate(-15%,-10%);
            background: white;
            border-radius: 10px;
        }
        .Popup2 {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 800px;
            height: 832px;
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
           

            transform: translate(-15%,-10%);
            background: white;
            border-radius: 10px;
        }
        .Popup2 h2 {
                text-align: center;
                padding: 0 0 20px 0;
                border-bottom: 1px solid silver;
            }

        .BtnModal2{
            border: 2px solid;
            background: #2691d9;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 25px;
            visibility:hidden;
            opacity:0;
        }

        .BtnModal2:hover{
             border-color: #2691d9;
             transition: .5s;
        }

        .lbl {
            font-size: 16px;
            font-style: italic;
            font-weight: bold;
        }
    </style>
</head>
<body style="overflow:scroll; height:auto; width:auto; ">
    
    <div id="mySidebar" class="sidebar">
        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">×</a>
        <a href="javascript:void(0)" class="inicioLink" onclick="openInicio()">INICIO</a>
        <a href="javascript:void(0)" class="cadastroLink" onclick="openCadastro()">CADASTRO</a>
        
    </div>


    <div id="main">
        <button class="openbtn" onclick="openNav()">☰ Menu</button>

    </div>

    <div class="centerCadastro" id="centerCadastroDV">
        <h2>
            <asp:Label ID="lblFAQ" runat="server" Text="Registros"></asp:Label>
        </h2>
                        <asp:Label ID="lblNumeroRegistro" runat="server" Text="Label" Enabled="False" Visible="False"></asp:Label>

        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Button ID="BtnCriar" runat="server" Text="Criar registro" CssClass="btnCancelar" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="False" Height="40px" OnClick="BtnCriar_Click" />
          <%--  <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="BtnCriar"
                CancelControlID="BtnCancelar" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>
            <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
                <iframe style="width: 790px; height: 800px;" id="irm1" src="FormularioCadastroPR.aspx" runat="server"></iframe>
                <br />
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" CssClass="btnCancelar" Height="40px" Font-Bold="True" />
            </asp:Panel>--%>

            <asp:Button ID="BtnModal2" runat="server" Text="update" CssClass="BtnModal2"  />

            <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Pan2" TargetControlID="BtnModal2"
                CancelControlID="BtnCancelar2" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>
            <asp:Panel ID="Pan2" runat="server" CssClass="Popup2" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
            <h2>
            <asp:Label ID="lblCadastrar" runat="server" Text="Cadastrar"></asp:Label>
            </h2>
                <div style="overflow:scroll; height:700px; width:auto; ">

                <div id="combos">

                    <asp:Label ID="lblOrgaos" runat="server" Text="Orgãos" CssClass="txt_field"></asp:Label>

                    <asp:DropDownList ID="DropDownListOrgaos" runat="server" OnLoad="preencheCmbOrgaos" Style="margin-left: 42px" Width="253px">
                    </asp:DropDownList>
                  
        
                    <asp:Label ID="lblSistemas" runat="server" Text="Sistemas" CssClass="txt_field"></asp:Label>
                    <asp:DropDownList ID="DropDownListSistemas" runat="server" OnLoad="preencheCmbSistemas" Style="margin-left: 25px" Height="18px" Width="256px">
                    </asp:DropDownList>
                    <br />
                </div>

                <div id="ddlistFLExcluido" style="margin-right:360px;">
                    <asp:Label ID="lblFLExluido" runat="server" Text="Excluído" ></asp:Label>
                    <asp:DropDownList ID="DropDownListFLExcluidos" runat="server" OnLoad="preencheCmbOrgaos" Style="margin-left: 33px; margin-top: 15px;" Width="253px">
                        <asp:ListItem Value="0">NÃO</asp:ListItem>
                        <asp:ListItem Value="1">SIM</asp:ListItem>
                    </asp:DropDownList>      
                    <br />
                </div>
                <div id="fPR">
                    <asp:Label ID="lblPergunta" runat="server" Text="Pergunta" ></asp:Label>
                    <asp:TextBox ID="tbxPergunta" runat="server" Style="margin-left: 26px" Height="118px" Width="250px" TextMode="MultiLine"></asp:TextBox>
                    <asp:Label ID="lblResposta" runat="server" Text="Resposta" Style="margin-left: 15px"></asp:Label>
                    <asp:TextBox ID="tbxResposta" runat="server" Style="margin-left: 15px" Height="118px" Width="250px" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div style="margin-top:15px">
                      <asp:Label ID="lblImg1" runat="server" Text="Imagem 1" CssClass="txt_field"></asp:Label>
                </div>
                <div id="img1" style="width: 730px; height: 580px; border: 2px solid rgb(225, 226, 233); box-shadow: rgb(246, 246, 249) 0px 0px 5px inset; background-color: rgba(251, 235, 235, 0.4);">
                                      

                    <asp:Image ID="imgBanner1" runat="server" ImageUrl="~/" Style="border-width: 0px; position:  inherit; min-height: 130px; min-width: 130px; top: 20px; bottom: 0; left: 0; right: 0; margin: auto; max-width: 730px; max-height: 580px;" />

                </div>
                <br />
                <br />
                <asp:FileUpload ID="fileUpload1" accept="image/*" runat="server" Style="margin-bottom: 15px" />

                <div>
                <asp:Label ID="lblImg2" runat="server" Text="Imagem 2" CssClass="txt_field"></asp:Label>
                </div>

                <div id="img2" style="width: 730px; height: 580px; border: 2px solid rgb(225, 226, 233); box-shadow: rgb(246, 246, 249) 0px 0px 5px inset; background-color: rgba(251, 235, 235, 0.4);">

                    <asp:Image ID="imgBanner2" runat="server" ImageUrl="~/" Style="border-width: 0px; position: inherit; min-height: 130px; min-width: 130px; top: 20px; bottom: 0; left: 0; right: 0; margin: auto; max-width: 730px; max-height: 580px;" />

                </div>
                <br />
                <br />
                <asp:FileUpload ID="fileUpload2" accept="image/*" runat="server" Style="margin-bottom: 15px" />
                <br />

                <div>
                <asp:Label ID="lblImg3" runat="server" Text="Imagem 3" CssClass="txt_field"></asp:Label>
                </div>

                <div id="img3"  style="width: 730px; height: 580px; border: 2px solid rgb(225, 226, 233); box-shadow: rgb(246, 246, 249) 0px 0px 5px inset; background-color: rgba(251, 235, 235, 0.4);">

                <asp:Image ID="imgBanner3" runat="server" ImageUrl="~/" Style="border-width: 0px; position: inherit; min-height: 130px; min-width: 130px; top: 20px; bottom: 0; left: 0; right: 0; margin: auto; max-width: 730px; max-height: 580px;" />

                </div>
                <br />
                <br />

                <asp:FileUpload ID="fileUpload3" accept="image/*" runat="server" />


                <div id="btnCadastrarDV" runat="server">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Salvar" OnClick="realizaCadastro" Style="margin-left: 0px; border-radius: 6px" />
                    <asp:Button ID="btnEditar" runat="server" Text="Salvar" OnClick="realizaEdicaoCadastro" Style="margin-left: 0px; border-radius: 6px" />
                </div>

                </div> 
               
                <asp:Button ID="BtnCancelar2" runat="server" Text="Cancelar" CssClass="btnCancelar" Height="40px" Font-Bold="True" OnClick="BtnCancelar2_Click"  />
              
            </asp:Panel>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" BorderStyle="Inset" AllowPaging="True" DataKeyNames="SQ_FAQ"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnPageIndexChanging="GridView1_PageIndexChanging" >
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField HeaderText="NUMERO" DataField="SQ_FAQ" />
                    <asp:BoundField HeaderText="NU_SISTEMA" DataField="NU_SISTEMA" Visible="False" />
                    <asp:BoundField HeaderText="CO_ORGAO" DataField="CO_ORGAO" Visible="False" />
                    <asp:BoundField HeaderText="SISTEMA" DataField="DE_APLICATIVO" />
                    <asp:BoundField HeaderText="ORGÃO" DataField="DE_ORGAO" />
                    <asp:BoundField HeaderText="PERGUNTA" DataField="DE_PERGUNTA" />
                    <asp:BoundField HeaderText="RESPOSTA" DataField="DE_RESPOSTA" />
                    <asp:BoundField DataField="FL_EXCLUIDO" HeaderText="EXCLUIDO" />
                    <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btnEditar" UpdateText="Atualizar" SelectText="Editar" ShowSelectButton="True">

                        <ControlStyle CssClass="btnEditar" Font-Bold="True" Height="40px"></ControlStyle>

                    </asp:CommandField>
                    <asp:CommandField ButtonType="Button" InsertVisible="False" ShowDeleteButton="True" ControlStyle-CssClass="btnExcluir">


                        <ControlStyle CssClass="btnExcluir" Font-Bold="True" Height="40px"></ControlStyle>


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

            <%--</div>--%>
        </form>
           
    </div>


    <script>
        function openNav() {
            document.getElementById("mySidebar").style.width = "250px";
            document.getElementById("main").style.marginLeft = "250px";
            //document.getElementById("combos").style.marginLeft = "250px";
            document.getElementById("centerCadastroDV").style.marginLeft = "250px";





        }
        function clearScreen() {

            //document.getElementById("combos").style.marginLeft = "0";
            document.getElementById("centerCadastroDV").style.marginLeft = "0";


        }

        function closeNav() {
            document.getElementById("mySidebar").style.width = "0";
            document.getElementById("main").style.marginLeft = "0";
            //document.getElementById("combos").style.marginLeft = "0";
            document.getElementById("centerCadastroDV").style.marginLeft = "0";


        }
        function openInicio() {
            clearScreen();
            closeNav();
            window.location.href = "FormularioProjetoFAQ.aspx";

            return false;
        }
        function openCadastro() {
            clearScreen();
            closeNav();
            window.location.href = "FormularioCEE.aspx";

            return false;
        }
       

    </script>

    <script>
            $("#<%=fileUpload1.ClientID%>").on('change', function () {
                if (this.files[0].type.indexOf("image") > -1) {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        $('#<%=imgBanner1.ClientID%>').attr('src', e.target.result);
                    }
                    reader.readAsDataURL(this.files[0]);
                    

                }
                else {
                    $('#<%=imgBanner1.ClientID%>').attr('src', '');
                    alert('Não é uma imagem válida')
                }
            });
        </script>
    <script>
            $("#<%=fileUpload2.ClientID%>").on('change', function () {
                if (this.files[0].type.indexOf("image") > -1) {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        $('#<%=imgBanner2.ClientID%>').attr('src', e.target.result);
                    }
                    reader.readAsDataURL(this.files[0]);
                }
                else {
                    $('#<%=imgBanner2.ClientID%>').attr('src', '');
                    alert('Não é uma imagem válida')
                }
            });
        </script>
    <script>
            $("#<%=fileUpload3.ClientID%>").on('change', function () {
                if (this.files[0].type.indexOf("image") > -1) {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        $('#<%=imgBanner3.ClientID%>').attr('src', e.target.result);
                    }
                    reader.readAsDataURL(this.files[0]);
                }
                else {
                    $('#<%=imgBanner3.ClientID%>').attr('src', '');
                    alert('Não é uma imagem válida')
                }
            });
    </script>




</body>
</html>


