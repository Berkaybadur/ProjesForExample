<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="WebUi.Kayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">

    <link href="site.css" rel="stylesheet" />

    <%--Sayı Sınırlaması Javascript(onkeypress)--%>
    <script>
        function numeric(evt) {
            var theEvent = evt || window.event;
            var key = theEvent.keyCode || theEvent.which;
            key = String.fromCharCode(key);
            var regex = /[0-9]|\./;
            if (!regex.test(key)) {
                theEvent.returnValue = false;
                if (theEvent.preventDefault) theEvent.preventDefault();
            }
        }</script>

    <style type="text/css">
        .login-form {
            width: 340px;
            margin: 50px auto;
        }

            .login-form form {
                margin-bottom: 15px;
                background: #f7f7f7;
                box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
                padding: 30px;
            }

            .login-form h2 {
                margin: 0 0 15px;
            }

        .form-control, .btn {
            min-height: 38px;
            border-radius: 2px;
        }

        .input-group-addon .fa {
            font-size: 18px;
        }

        .btn {
            font-size: 15px;
            font-weight: bold;
        }
    </style>

    <%-- Harf Sınırlaması Javascript(onkeypress)--%>
    <script>
        function Harf(e) {
            islem = document.all ? window.event : e;
            karakter = document.all ? islem.keyCode : islem.which;
            if (karakter >= 48 && karakter <= 57) {
                if (document.all) { islem.returnValue = false; } else { islem.preventDefault(); }
            }
        }
    </script>

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="bootstrap-3.3.7-dist/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.2.6/semantic.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">


    <div class="container">
        <div class="panel panel-primary">
            <div class="panel-heading">ÜYE OL </div>
            <div class="panel-body" style="background-image: url('icons/register.jpg');">
                <div class="login-form">
                    <tr>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" align="center" placeholder="Kullanıcı Adı"></asp:TextBox>
                                    <br />
                                </td>
                            </div>
                        </div>
                    </tr>



                    <div class="form-group">
                        <div class="input-group">
                            <div class="field">
                                <div class="ui icon input">

                                    <span class="input-group-addon" style="width: 39px"><i class="fa fa-lock"></i></span>
                                    <asp:TextBox ID="txtPassword" runat="server" name="cphBody_txtPassword" placeholder="Şifre" TextMode="Password" Width="300px"></asp:TextBox>
                                    <i class="circular eye link icon" onclick="togglePassword()"></i>
                                </div>
                            </div>
                        </div>

                    </div>





                    <tr>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Ad" onkeypress="Harf(event)"></asp:TextBox><br />
                                </td>
                            </div>
                        </div>
                    </tr>
                    <tr>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtSurName" runat="server" CssClass="form-control" placeholder="Soyad" onkeypress="Harf(event)"></asp:TextBox><br />
                                </td>
                            </div>
                        </div>
                    </tr>
                    <tr>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-phone"></i></span>
                                <td class="auto-style1">

                                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" onkeypress="numeric(event)" class="telefon" placeholder="Telefon Numarası"></asp:TextBox><br />
                                </td>
                            </div>
                        </div>
                    </tr>
                    <tr>
                        <div class="form-group">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtAdress" runat="server" CssClass="form-control" placeholder="Adres"></asp:TextBox><br />
                            </div>
                        </div>
                    </tr>
                </div>

                <tr>
                    <div>
                        <asp:Button CssClass="buttonkayit" runat="server" ID="btnClear" Text="TEMİZLE" OnClick="btnClear_Click" align="left" Width="130px" />
                        <asp:Button CssClass="buttonkayit" runat="server" ID="btnRegister" Text="KAYDOL" align="left" Width="125px" OnClick="btnRegister_Click" />
                        <asp:Button CssClass="buttonkayit" runat="server" ID="btnLogin" Text="GİRİS YAP" align="left" Width="138px" OnClick="btnLogin_Click" />
                        </td>
                    </div>
                </tr>
                <br />



                <div class="form-group">
                    <tr>
                        <td>
                            <asp:GridView ID="dgwRegister" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="datagridview">
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </td>
                    </tr>
                    </table>
                </div>
            </div>



            <script>
                function togglePassword() {
                    var element = document.getElementById('cphBody_txtPassword');
                    element.type = (element.type == 'password' ? 'text' : 'password');
                }
            </script>


            <script type="text/javascript">
                function ShowHidePassword(ID) {
                    if (document.getElementById($("#" + ID).prev().attr('id')).TextMode == "password") {
                        $("#" + ID).attr("data-hint", "Hide");
                        $("#" + ID).find("i").removeClass("icon-eye").addClass("icon-eye-slash");
                        document.getElementById($("#" + ID).prev().attr('id')).type = "text";
                    }
                    else {
                        $("#" + ID).attr("data-hint", "Show");
                        $("#" + ID).find("i").removeClass("icon-eye-slash").addClass("icon-eye");
                        document.getElementById($("#" + ID).prev().attr('id')).type = "password";
                    }
                }
            </script>

     

</asp:Content>
