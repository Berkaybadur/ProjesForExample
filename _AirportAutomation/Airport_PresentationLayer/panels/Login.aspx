<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Airport_PresentationLayer.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/png" href="../icons/start1.png" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/util.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="../css/flaticon.css" rel="stylesheet" />
    <link href="../css/animate.css" rel="stylesheet" />
    <link href="../css/animsition.min.css" rel="stylesheet" />
    <link href="../css/hamburgers.min.css" rel="stylesheet" />
    <link href="../css/select2.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <link href="../css/icon-font.min.css" rel="stylesheet" />
    <link href="../css/daterangepicker.css" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">

    <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Panele Yönlendiriliyorsunuz...")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>

</head>
<body style="background-color: #666666;">
    <div class="limiter">
        <div class="container-login100">
            <div class="wrap-login100">
                <form class="login100-form validate-form" runat="server">
                    <span class="login100-form-title p-b-43">GİRİŞ YAP
                    </span>
                    <div class="wrap-input100 validate-input">
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="input100" type="text" name="email"></asp:TextBox>
                        <span class="focus-input100"></span>
                        <span class="label-input100">Kullanıcı Adı</span>
                    </div>
                    <div class="wrap-input100 validate-input" data-validate="Password is required">
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="input100" type="password" name="pass"></asp:TextBox>
                        <span class="focus-input100"></span>
                        <span class="label-input100">Şifre</span>
                    </div>
                    <div class="flex-sb-m w-full p-t-3 p-b-32">
                        <div class="contact100-form-checkbox">
                            <asp:CheckBox ID="ckb1" runat="server" CssClass="input-checkbox100" />
                            <label class="label-checkbox100" for="ckb1">
                                Beni Hatırla
                            </label>
                        </div>

                        <div>
                            <a href="#" class="txt1">Şifreni mi Unuttun ?
                            </a>
                        </div>
                    </div>
                    <div class="container-login100-form-btn">
                        <asp:Button ID="btnLogin" Text="GİRİŞ YAP" CssClass="login100-form-btn" runat="server" OnClick="btnLogin_Click" />
                    </div>
                    <div class="text-center p-t-46 p-b-20">
                        <a href="./Register.aspx" class="txt1">Veya Kayıt Ol
                        </a>
                    </div>
                    <div class="login100-form-social flex-c-m">
                        <a href="./Register.aspx" class="login100-form-social-item flex-c-m bg1 m-r-5">
                            <i  class="fas fa-registered" aria-hidden="true"></i>
                        </a>
                        <a href="./StartPage.aspx" class="login100-form-social-item flex-c-m bg2 m-r-5">
                            <i class="fas fa-desktop" aria-hidden="true"></i>
                        </a>
                    </div>
                </form>
                <div class="login100-more" style="background-image: url(../images/airport.jpg); background-position: center;">
                </div>
            </div>
        </div>
    </div>
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/animsition.min.js"></script>
    <script src="../js/daterangepicker.js"></script>
    <script src="../js/moment.min.js"></script>
    <script src="../js/main.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/select2.min.js"></script>
    <script src="../js/countdowntime.js"></script>
    <script src="../js/popper.js"></script>
</body>




</html>
