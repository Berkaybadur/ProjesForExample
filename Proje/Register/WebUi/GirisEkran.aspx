<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GirisEkran.aspx.cs" Inherits="WebUi.Denemem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
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
    <div class="jumbotron" style="background-image:url(icons/yeni1.jpg);height:500px;margin-top:50px;">
    <div class="login-form">
        <h2 class="text-center" style="color:white;margin-top:-10px;">ÜYE GİRİŞİ</h2> <br /><br />


        <div class="form-group">
        	<div class="input-group">
                 <span class="input-group-addon"><i class="fa fa-user"></i></span>
    <asp:TextBox ID="txtKullaniciAdi" runat="server" CssClass="form-control" placeholder="Kullanıcı Adınız" required="required"></asp:TextBox>
                </div>
            </div>

        <div class="form-group">
        	<div class="input-group">
                 <div class="field">
                    <div class="ui icon input">
                 <span class="input-group-addon" style="width:39px"><i  class="fa fa-lock"></i></span>
     <asp:TextBox ID="txtPassword" runat="server" name="cphBody_txtPassword"  placeholder="Şifreniz" required="required" TextMode="Password" Width="300px"></asp:TextBox>
                 <i class="circular eye link icon" onclick="togglePassword()" style="right: 0.4em; top: 0.4em"></i>
                </div>
            </div>
                </div>
    <br />
            </div>
       
            <div class="form-group">
            <asp:Button ID="btnLogin" runat="server" Text="GİRİŞ YAP" CssClass="btn btn-primary btn-block" OnClick="Giris_Click"  Metin="Onayla" OnClientClick="Confirm()" />
        </div>
    <div class="üyetext"> 
        <br />
           <p class="text-center small" style="color:white;font-size:15px;">HENÜZ ÜYE DEĞİL MİSİNİZ ? <a style="color:white;text-decoration:underline;" href="Kayit.aspx">KAYIT OL</a>.</p>
        <br />
     </div>

        </div>
        </div>
        <script>
            function togglePassword() {
                var element = document.getElementById('cphBody_txtPassword');
                element.type = (element.type == 'password' ? 'text' : 'password');
            }
        </script>
</asp:Content>

