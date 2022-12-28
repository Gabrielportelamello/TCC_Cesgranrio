<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="ProjetoSemearTurismo.teste" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Scripts\jquery-3.6.0.min.js"></script>

    <title>Projeto DRV Web</title>
    <style>
        .tbxPai {
            margin-top: 15px;
            margin-left: 39px;
        }

        .tbx2 {
            margin-top: 15px;
            margin-left: 18px;
        }

        .lbl {
            margin-top: 15px;
            margin-left: 15px;
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
            width: 960px;
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
            color: Black;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
        }

            .btnCancelar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

            .btnCancelar:disabled {
                background: rgba(217,217,217,1);
            }

        .btnRegistrar {
            border: 0px solid;
            background: #2691d9;
            color: Black;
            cursor: pointer;
            outline: none;
            border-radius: 0px;
            visibility: hidden;
        }

            .btnRegistrar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

            .btnRegistrar:disabled {
                background: rgba(217,217,217,1);
            }

        .btnConsultar {
            border: 2px solid;
            background: #2691d9;
            padding: 2px;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
            position: absolute;
            top: 119px;
            right: 380px;
            font-size: 36px;
            margin-left: 50px;
        }

            .btnConsultar:hover {
                border-color: #2691d9;
                transition: .5s;
            }

        .imgCidadao {
            border: 2px solid;
            padding: 2px;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
            position: absolute;
            top: 110px;
            right: 40px;
            font-size: 36px;
            margin-left: 50px;
        }

            .imgCidadao:hover {
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
            top: 32%;
            left: 20%;
            transform: translate(-10%,-16%);
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
            top: 20%;
            left: 32%;
            transform: translate(-20%,-12%);
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
            height: 650px;
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
            top: 20%;
            left: 32%;
            transform: translate(-20%,-12%);
            background: white;
            border-radius: 10px;
        }

        .Popup3 {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 400px;
            height: 250px;
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
            top: 20%;
            left: 32%;
            transform: translate(-20%,-12%);
            background: white;
            border-radius: 10px;
        }

        .PopupMessageBox {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            padding-top: 10px;
            padding-left: 10px;
            width: 400px;
            height: 250px;
            transition: margin-left .5s;
            padding: 16px;
            position: absolute;
            top: 20%;
            left: 32%;
            transform: translate(-20%,-12%);
            background: white;
            border-radius: 10px;
        }

        .BtnModal2 {
            border: 2px solid;
            background: #2691d9;
            color: #e9f4fb;
            cursor: pointer;
            outline: none;
            border-radius: 25px;
            visibility: hidden;
            opacity: 0;
        }

            .BtnModal2:hover {
                border-color: #2691d9;
                transition: .5s;
            }

        .lbl {
            font-size: 16px;
            font-style: italic;
            font-weight: bold;
        }

        .lblCPFinvalido {
            font-size: 12px;
            font-style: italic;
            font-weight: bold;
            color: red;
            margin-left: 83px;
        }

        div {
            display: inline-block;
            margin-top: 0px;
        }

        .tbx {
            margin-left: 31px;
            margin-top: 15px;
        }

        .btnConsultar {
            margin-left: 0px;
            margin-top: 0px;
        }

        #my_camera {
            width: 320px;
            height: 240px;
            border: 1px solid black;
        }

        #btnCapturar {
            margin-left: 15px;
            border: 2px solid;
            background: #2691d9;
            color: Black;
            cursor: pointer;
            outline: none;
            border-radius: 10px;
            display: normal;
        }

            #btnCapturar:hover {
                border-color: #2691d9;
                transition: .5s;
            }
    </style>
</head>
<body>
    <div id="mySidebar" class="sidebar">
        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">×</a>
        <a href="javascript:void(0)" class="inicioLink" onclick="openInicio()">INICIO</a>
        <%--<a href="javascript:void(0)" class="cadastroLink" onclick="openCadastro()">CADASTRO</a>--%>

    </div>

    <div id="main">
        <button class="openbtn" onclick="openNav()">☰ Menu</button>

    </div>

    <div class="centerCadastro" id="centerCadastroDV">
        <h2>
            <asp:Label ID="lblFAQ" runat="server" Text="Diretoria de Registro de Veículos"></asp:Label>
        </h2>

        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Button ID="btnMessageBox" runat="server" CssClass="btnRegistrar" Text="" />

            <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel1" TargetControlID="btnCertificar"
                CancelControlID="BtnCancelar2" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>
            <asp:Panel ID="Panel1" runat="server" CssClass="Popup2" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">

                <div id="my_camera"></div>
                <br />
                <br />
                <div id="btn" style="padding: 15px" runat="server">

                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvarCaptura_Click" CssClass="btnCancelar" Height="40px" Font-Bold="True" CausesValidation="False" />
                    <asp:Button ID="btnCertificarCidadao" runat="server" Text="Certificar" CssClass="btnCancelar" Height="40px" Font-Bold="True" Visible="False" OnClick="btnCertificarCidadao_Click" CausesValidation="False" UseSubmitBehavior="False" />
                    <input type="button" id="btnCapturar" value="Capturar foto" onclick="take_snapshot()" runat="server" style="height: 40px; font-weight: bold;">
                    <input type="text" id="TxtImg" hidden="hidden" runat="server" />
                    <input type="text" id="TxtImg2" hidden="hidden" runat="server" />

                </div>
                <br />
                <br />
                <div id="results" runat="server">
                    <asp:Label ID="lblImg" runat="server" Visible="false"></asp:Label>
                </div>
                <br />
                <br />
                <div id="fechar">
                    <asp:Button ID="BtnCancelar2" runat="server" Text="Cancelar" CssClass="btnCancelar" Height="40px" Font-Bold="True" />

                </div>

            </asp:Panel>

            <cc1:ModalPopupExtender ID="mp3" runat="server" PopupControlID="Panel2" TargetControlID="btnRegistrar"
                CancelControlID="BtnCancelar3" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>
            <asp:Panel ID="Panel2" runat="server" CssClass="Popup3" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
                <br />

                <div id="dvDescricao">
                    <asp:Label ID="LblDescricao" runat="server" Text="Pessoa não certificada, solicite a liberação do supervisor" CssClass="lbl"></asp:Label>
                </div>
                <br />
                <br />

                <div id="Div1" style="padding: 15px" runat="server">
                    <asp:Label ID="lblCPFSupervisor" runat="server" Text="CPF do supervisor : " CssClass="lbl"></asp:Label>

                    <asp:TextBox ID="TbxCPFSupervisor" runat="server" MaxLength="11"></asp:TextBox>


                </div>
                <br />
                <br />
                <br />
                <br />

                <div id="fecharbtn">
                    <asp:Button ID="BtnLiberar" runat="server" Text="Liberar" CssClass="btnCancelar" Height="40px" Font-Bold="True" CausesValidation="False" OnClick="BtnLiberar_Click" />

                    <asp:Button ID="btnCancelar3" runat="server" Text="Cancelar" CssClass="btnCancelar" Height="40px" Font-Bold="True" />

                </div>



            </asp:Panel>

            <cc1:ModalPopupExtender ID="MessageBoxPopup" runat="server" PopupControlID="PanelMessageBox" TargetControlID="btnMessageBox"
                CancelControlID="BtnCancelarMessageBox" BackgroundCssClass="Background">
            </cc1:ModalPopupExtender>
            <asp:Panel ID="PanelMessageBox" runat="server" CssClass="PopupMessageBox" align="center" Style="display: none; border-width: 3px; border-radius: 10px;">
                <br />

                <div id="dvDescricaoMessageBox">
                    <asp:Label ID="LblDescricaoMessageBox" runat="server" Text="" CssClass="lbl"></asp:Label>
                </div>

                <br />
                <br />
                <br />
                <br />

                <div id="fecharbtnMessageBox">
                    <asp:Button ID="BtnOK" runat="server" Text="OK" CssClass="btnCancelar" Height="40px" Font-Bold="True" CausesValidation="False" Width="70px" />

                    <asp:Button ID="btnCancelarMessageBox" runat="server" Text="Cancelar" CssClass="btnCancelar" Height="40px" Font-Bold="True" />


                </div>



            </asp:Panel>



            <div style="width: 756px; height: 197px; margin-top: 0px; padding-top: 0px;">
                <div style="width: 665px; height: 56px;">
                    <asp:Label ID="LblCPF" runat="server" Text="CPF" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxCPF" runat="server" CssClass="tbx" Width="108px" OnTextChanged="TbxCPF_TextChanged" ValidationGroup="cpf" AutoCompleteType="Disabled" Height="25px"></asp:TextBox>



                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
                        AcceptAMPM="false" Mask="99999999999" Enabled="True"
                        OnFocusCssClass="MaskedEditFocus"
                        OnInvalidCssClass="MaskedEditError"
                        TargetControlID="TbxCPF" AutoComplete="False" PromptCharacter="" AcceptNegative="Left" />
                    <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator4" runat="server"
                        ControlExtender="MaskedEditExtender1"
                        ControlToValidate="TbxCPF"
                        Display="Dynamic"
                        MaximumValue="99999999999" MinimumValue="00000000000" />

                    <asp:Label ID="LblCNH" runat="server" Text="CNH" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxCNH" runat="server" Style="margin-left: 15px" CssClass="tbx" Width="108px" MaxLength="11"></asp:TextBox>

                    <asp:Label ID="LblRG" runat="server" Text="RG" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxRG" runat="server" Style="margin-left: 15px" CssClass="tbx" Width="108px" MaxLength="10"></asp:TextBox>



                    <asp:ImageButton ID="ImgBtnConsultar" runat="server" AlternateText="Consultar" CssClass="btnConsultar" Height="19px" ImageUrl="~/imagens/pngegg.png" BackColor="#2691D9" OnClick="ImgBtnConsultar_Click" />



                </div>
                <br />
                <div>
                    <asp:Label ID="LblCPFinvalido" runat="server" Text="CPF inválido!" CssClass="lblCPFinvalido" Visible="False"></asp:Label>
                </div>

                <br />
                <div style="width: 752px; height: 42px; margin-top: 0px; margin-left: 0px;">
                    <asp:Label ID="Label1" runat="server" Text="Nome" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxNome" runat="server" CssClass="tbx2" Width="321px" Enabled="False"></asp:TextBox>
                    <asp:Label ID="LblNascimento" runat="server" Text="Nascimento" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxNascimento" runat="server" Style="margin-left: 15px" CssClass="tbx" TextMode="Date" Width="105px" Enabled="False"></asp:TextBox>

                </div>

                <div style="width: 468px; height: 42px;">
                    <asp:Label ID="Label2" runat="server" Text="Pai" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxNomePai" runat="server" CssClass="tbxPai" Width="322px" Enabled="False"></asp:TextBox>

                </div>

                <div style="width: 469px; height: 43px;">
                    <asp:Label ID="Label3" runat="server" Text="Mãe" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="TbxNomeMae" runat="server" CssClass="tbx" Width="321px" Enabled="False"></asp:TextBox>

                    <asp:Label ID="SQ_DRV" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="SQ_DRV_IMAGENS" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="SQ_DRV_COLETA" runat="server" Visible="False"></asp:Label>

                </div>


            </div>
            <asp:Image ID="ImgCidadao" runat="server" BorderStyle="Solid" Height="336px" Width="247px" Style="margin-left: 0px; margin-top: 0px; margin-bottom: 0px" CssClass="imgCidadao" BorderColor="Black" BorderWidth="2px" />


            <div style="margin-top: 170px; margin-left: 678px;">
                <asp:Button ID="btnCapturarFoto" runat="server" Text="Capturar foto" Style="margin-left: 0px" Width="262px" CssClass="btnCancelar" Enabled="False" Height="33px" Font-Bold="True" OnClick="btnCapturarFoto_Click" />
            </div>
            <br />
            <div style="margin-top: 0px; margin-left: 678px; margin-bottom: 0px;">
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="0px" CssClass="btnRegistrar" Enabled="False" Height="0px" Font-Bold="True" OnClick="btnRegistrar_Click" />
            </div>
            <br />
            <div style="margin-top: 9px; margin-left: 678px;">
                <asp:Button ID="btnCertificar" runat="server" Text="Certificar" Style="margin-left: 0px" Width="262px" CssClass="btnCancelar" Enabled="False" Height="33px" Font-Bold="True" OnClick="btnCertificar_Click" />
            </div>
            <br />
            <div style="margin-top: 10px; margin-left: 678px;">
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="262px" CssClass="btnCancelar" Height="33px" Font-Bold="True" OnClick="BtnLimpar_Click" CausesValidation="False" />
            </div>
            <br />



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
            window.location.href = "FormularioPrincipal.aspx";

            return false;
        }
        function openCadastro() {
            clearScreen();
            closeNav();
            window.location.href = "FormularioPrincipal.aspx";

            return false;
        }

    </script>

    <script>
        var inputEle = document.getElementById("TbxCPF");
        $(document).ready(function () {
            $(".resetCursor").mouseup(function () {
                //this.setSelectionRange(0, indice);    
                if (inputEle != null) {
                    if (inputEle.createTextRange) {
                        var range = inputEle.createTextRange();
                        range.move('character', -1);
                        range.select();
                    }
                    else {
                        if (inputEle.selectionStart) {
                            inputEle.focus();
                            inputEle.setSelectionRange(0, 0);
                        }
                        else
                            inputEle.focus();
                    }

                }
            });
        });

    </script>
    <script type="text/javascript" src="webcamjs/webcam.min.js"></script>




    <script>

        Webcam.set({
            width: 320,
            height: 240,
            image_format: 'jpeg',
            jpeg_quality: 100
        });
        Webcam.attach('#my_camera');

        // preload shutter audio clip
        var shutter = new Audio();
        shutter.autoplay = true;
        shutter.src = navigator.userAgent.match(/Firefox/) ? 'shutter.ogg' : 'shutter.mp3';


        function take_snapshot() {
            // play sound effect
            shutter.play();

            // take snapshot and get image data
            Webcam.snap(function (data_uri) {
                // display results in page
                document.getElementById('results').innerHTML =
                    '<img src="' + data_uri + '" id="imgResult"/>';
            });
            save_snapshot()
        }
    </script>


    <script>
        function save_snapshot() {

            const image = document.getElementById('imgResult');

            // Get the remote image as a Blob with the fetch API
            fetch(image.src)
                .then((res) => res.blob())
                .then((blob) => {
                    // Read the Blob as DataURL using the FileReader API
                    const reader = new FileReader();
                    reader.onloadend = () => {
                        document.getElementById('TxtImg').innerHTML = reader.result;
                        TxtImg.value = reader.result;
                        //alert(TxtImg.value);
                        //                        alert(TxtImg2);

                        // Logs data:image/jpeg;base64,wL2dvYWwgbW9yZ...

                        // Convert to Base64 string
                        const base64 = getBase64StringFromDataURL(reader.result);
                        document.getElementById('TxtImg').innerText = base64;
                        TxtImg.value = base64;
                        //alert(base64);
                        //alert(TxtImg2);
                        // Logs wL2dvYWwgbW9yZ...
                    };
                    reader.readAsDataURL(blob);


                });

        }
    </script>




</body>
</html>



