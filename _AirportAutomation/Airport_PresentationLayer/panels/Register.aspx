<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Airport_PresentationLayer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Kayıt Formu</title>
    <link href="site.css" rel="stylesheet" />
           <link rel="icon" type="image/png" href="../icons/start1.png" />
    <link href="../css/styleregister.css" rel="stylesheet" />
    <link href="../css/material-design-iconic-font.min.css" rel="stylesheet" />
        <script type = "text/javascript">
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
<body>
         <div class="main">
        <div class="container">
            <form runat="server" class="appointment-form">
                <h2>Kayıt Formu</h2>
                <div class="form-group-1">
<%--                    <asp:TextBox ID="txtCustomerId" type="text" runat="server" disabled="" placeholder="Id"></asp:TextBox>--%>
                    <asp:TextBox ID="txtTc" runat="server"  type="text" placeholder="TC"></asp:TextBox>
                    <asp:TextBox ID="txtFirstname" runat="server"  type="text" placeholder="İsim"></asp:TextBox>
                    <asp:TextBox ID="txtLastname" runat="server"  type="text" placeholder="Soyisim"></asp:TextBox>
                    <asp:TextBox ID="txtUsername" runat="server"  type="text" placeholder="Kullanıcı Adı"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server"  type="text" placeholder="Şifre"></asp:TextBox>
                    <asp:TextBox ID="txtCustomerMail" type="email" runat="server" placeholder="Email"></asp:TextBox>
                    <asp:DropDownList ID="ddlDistrict" runat="server" type="text" value="City"></asp:DropDownList>
                    <asp:TextBox ID="txtPhone" type="text" runat="server" placeholder="Telefon"></asp:TextBox>
                    <asp:TextBox ID="txtAddress" type="text" runat="server" placeholder="Adres"></asp:TextBox>
                    <asp:DropDownList ID="ddlDegree" runat="server" type="text" disabled=""></asp:DropDownList>

                </div>
                <div class="form-submit">
                    <asp:Button ID="btnRegister" Text="KAYIT OL" runat="server" class="submit" style="width:500px" OnClick="btnRegister_Click" />
                    <asp:Button ID="btnClear" Text="TEMİZLE" runat="server" class="submit" style="width:500px" OnClick="btnClear_Click" />
                    <asp:Button ID="btnLogin" Text="GİRİŞ YAP" class="submit" runat="server" style="width:500px" OnClick="btnLogin_Click" />
                </div>
            </form>
        </div>
    </div>

    <!-- JS -->
    <script src="../js/main.js"></script>
    <script src="../js/jquery.min.js"></script>
</body>
</html>
