<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPanel.aspx.cs" Inherits="Airport_PresentationLayer.panels.UserPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User</title>
    <link rel="icon" type="image/png" href="../icons/start1.png" />
    <link href="https://fonts.googleapis.com/css?family=Quicksand:300,400,500,700" rel="stylesheet">
    <link href="../csss/icomoon.css" rel="stylesheet" />
    <link href="../csss/animate.css" rel="stylesheet" />
    <link href="../csss/bootstrap.css" rel="stylesheet" />
    <link href="../csss/magnific-popup.css" rel="stylesheet" />
    <link href="../csss/flexslider.css" rel="stylesheet" />
    <link href="../csss/owl.carousel.min.css" rel="stylesheet" />
    <link href="../csss/owl.theme.default.min.css" rel="stylesheet" />
    <link href="../csss/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="../csss/flaticon.css" rel="stylesheet" />
    <link href="../csss/style.css" rel="stylesheet" />
    <script src="../js/modernizr-2.6.2.min.js"></script>
    <link href="../css/site.css" rel="stylesheet" />
    <link href="../csss/ionicons.min.css" rel="stylesheet" />
    <link href="../csss/flaticons.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" method="post" class="colorlib-form">
        <div class="colorlib-loader"></div>
        <div id="page">
            <nav class="colorlib-nav" role="navigation">
                <div class="top-menu">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-xs-2">
                                <div id="colorlib-logo"><a href="./UserPanel.aspx">AİRPORT</a></div>
                            </div>
                            <div class="col-xs-10 text-right menu-1">
                                <ul>
                                    <li class="active"><a href="./UserPanel.aspx">Anasayfa</a></li>
                                    <li class="has-dropdown">
                                        <a href="./UserTicketPanel.aspx">Bilet Ver</a>
                                    </li>
                                    <li><a href="#colorlib-footer">Hakkımızda</a></li>
                                    <li><a href="Login.aspx">Çıkış</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </nav>
            <aside id="colorlib-hero">
                <div class="flexslider">
                    <ul class="slides">
                        <li style="background-image: url(../images/travel4.jpg);">
                            <div class="overlay"></div>
                            <div class="container-fluid">
                                <div class="row">
                                    <div class="col-md-6 col-md-offset-3 col-sm-12 col-xs-12 slider-text">
                                         <div class="slider-text-inner text-center">
                                            <h1> Türkiye</h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li style="background-image: url(../images/travel1.jpg);">
                            <div class="overlay"></div>
                            <div class="container-fluid">
                                <div class="row">
                                    <div class="col-md-6 col-md-offset-3 col-sm-12 col-xs-12 slider-text">
                                        <div class="slider-text-inner text-center">
                                            <h1>Meksika</h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li style="background-image: url(../images/antalya.jpg);">
                            <div class="overlay"></div>
                            <div class="container-fluids">
                                <div class="row">
                                    <div class="col-md-6 col-md-offset-3 col-sm-12 col-xs-12 slider-text">
                                        <div class="slider-text-inner text-center">
                                            <h1>Portekiz</h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li style="background-image: url(../images/travel3.jpg);">
                            <div class="overlay"></div>
                            <div class="container-fluid">
                                <div class="row">
                                    <div class="col-md-6 col-md-offset-3 col-sm-12 col-xs-12 slider-text">
                                        <div class="slider-text-inner text-center">
                                            <h1>Arjantin</h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </aside>
            <div id="colorlib-reservation">
                <!-- <div class="container"> -->
                <div class="row">
                    <div class="search-wrap">
                        <div class="container">
                            <ul class="nav nav-tabs">
                                <li class="active"><a data-toggle="tab" href="#flight"><i class="far fa-compass"></i>Sefer Arama</a></li>
                            </ul>
                        </div>
                        <div class="tab-content">
                            <div id="flight" class="tab-pane fade in active">
                                <div class="row">
                                    <div class="col-md-2" style="margin-left:115px;">
                                        <div class="form-group">
                                            <label for="date">Nereden</label>
                                            <div class="form-field">
                                                <asp:TextBox ID="txtWhere" runat="server" class="form-control" placeholder="Nereden"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-2">
                                        <div class="form-group">
                                            <label for="date">Nereye</label>
                                            <div class="form-field">
                                                <asp:TextBox ID="txtTo" runat="server" class="form-control" placeholder="Nereden"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-2">
                                        <div class="form-group">
                                            <label for="date">Gidiş Tarih</label>
                                            <div class="form-field">
                                                <i class="icon icon-calendar2"></i>
                                                <asp:TextBox ID="txtWhereDate" runat="server" type="date" class="form-control date" Value="Check-out date"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                        <div class="col-md-2">
                                        <div class="form-group">
                                            <label for="date">Dönüş Tarih</label>
                                            <div class="form-field">
                                                <i class="icon icon-calendar2"></i>
                                                <asp:TextBox ID="txtToDate" runat="server" type="date" class="form-control date" Value="Check-out date"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-1">
                                        <div class="form-group">
                                            <label for="date">Fiyat</label>
                                            <div class="form-field">
                                                <i class="icon icon-calendar2"></i>
                                                <asp:TextBox ID="txtMoney" runat="server" class="form-control" placeholder="Fiyat" style="width:200px;"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-1">
                                        <asp:Button ID="btnSearch" runat="server" Text="Ara" class="btn btn-primary btn-block" style="margin-left:100px" OnClick="btnSearch_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="colorlib-tour colorlib-light-grey">
            <div class="container">
                <div class="row">
                    <div class=" animate-box">
                        <h2 style="margin-left:500px">Bütün Seferler</h2>
                        <asp:GridView ID="dgwUserExpedition" runat="server" CssClass="mGrid" Width="1800px" style="margin-left:-300px;margin-top:50px"></asp:GridView>
                    </div>
                </div>
            </div>

        </div>

        <div class="colorlib-tour">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 col-md-offset-3 text-center colorlib-heading animate-box">
                        <h2>EN POPÜLER ÜLKELER</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="f-tour">
                            <div class="row row-pb-md">
                                <div class="col-md-6">
                                    <div class="row">
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/italya.jpg);">
                                                <div class="desc">
                                                    <h3>İTALYA</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/almanya.jpg);">
                                                <div class="desc">
                                                    <h3>ALMANYA</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/fransa.jpg);">
                                                <div class="desc">
                                                    <h3>FRANSA</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/ingiltere.jpg);">
                                                <div class="desc">
                                                    <h3>İNGİLTERE</h3>
                                                </div>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6 animate-box">
                                    <div class="desc">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>İtalya</h3>
                                                <p>İtalya ya da resmî olarak İtalyan Cumhuriyeti ya da bazen İtalya Cumhuriyeti, Güney Avrupa'da, büyük ölçüde İtalya Yarımadası üzerinde yer alan bir ülke. Akdeniz'in en büyük iki adası Sicilya ve Sardinya da İtalyan topraklarıdır.</p>
                                                <br>    
                                            </div>
                                            <div class="col-md-12">
                                                <h4>Popüler Şehirleri</h4>
                                                <div class="row">
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">Rome</a></li>
                                                            <li><a href="#">Milan</a></li>
                                                            <li><a href="#">Genoa</a></li>
                                                            <li><a href="#">Verona</a></li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">Venice</a></li>
                                                            <li><a href="#">Bologna</a></li>
                                                            <li><a href="#">Trieste</a></li>
                                                            <li><a href="#">Florence</a></li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">Palermo</a></li>
                                                            <li><a href="#">Siena</a></li>
                                                            <li><a href="#">San Marino</a></li>
                                                            <li><a href="#">Naples</a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <p><a href="tours.html" class="btn btn-primary">View All Places</a></p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="f-tour">
                            <div class="row">
                                <div class="col-md-6 col-md-push-6">
                                    <div class="row">
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/istanbul.jpg);">
                                                <div class="desc">
                                                    <h3>TÜRKİYE</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/polonya.jpg);">
                                                <div class="desc">
                                                    <h3>POLONYA</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/portekiz.jpg);">
                                                <div class="desc">
                                                    <h3>PORTEKİZ</h3>
                                                </div>
                                            </a>
                                        </div>
                                        <div class="col-md-6 animate-box">
                                            <a href="https://www.wikiwand.com/tr/%C3%9Clkeler_listesi" class="f-tour-img" style="background-image: url(../images/meksika.jpeg);">
                                                <div class="desc">
                                                    <h3>MEKSİKA</h3>
                                                </div>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6 animate-box col-md-pull-6 text-right">
                                    <div class="desc">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>TÜRKİYE</h3>
                                                <p>	Avrupa ile Asya arasında köprü görevi gören Güney Avrupa, Batı Asya, Anadolu Yarımadası'nda bulunan bir Akdeniz ülkesi.</p>
                                                <br>
                                            </div>
                                            <div class="col-md-12">
                                                <h4>POPÜLER ŞEHİRLERİ</h4>
                                                <div class="row">
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">İstanbul</a></li>
                                                            <li><a href="#">Ankara</a></li>
                                                            <li><a href="#">Antalya</a></li>
                                                            <li><a href="#">İzmir</a></li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">Bodrum</a></li>
                                                            <li><a href="#">Trabzon</a></li>
                                                            <li><a href="#">Edirne</a></li>
                                                            <li><a href="#">Alanya</a></li>
                                                        </ul>
                                                    </div>
                                                    <div class="col-md-4 col-sm-4 col-xs-4">
                                                        <ul>
                                                            <li><a href="#">Malatya</a></li>
                                                            <li><a href="#">Konya</a></li>
                                                            <li><a href="#">Sivas</a></li>
                                                            <li><a href="#">Aydın</a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <p><a href="tours.html" class="btn btn-primary">View All Places</a></p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <footer id="colorlib-footer" role="contentinfo">
            <div class="container">

                <div class="row">
                    <div class="col-md-12 text-center">
                        <p>
                            <script>
                                document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
                            </script>
                            Designed and Coded by 
            <a href="https://www.linkedin.com/in/an%C4%B1l-berkay-badur-478640195" target="_blank">Anıl Berkay Badur</a>. 
                        </p>
                    </div>
                </div>
            </div>
        </footer>

        <div class="gototop js-top">
            <a href="#" class="js-gotop"><i class="icon-arrow-up2"></i></a>
        </div>
    </form>
    <script src="../js/jquery.min.js"></script>
    <script src="../js/jquery.easing.1.3.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/jquery.waypoints.min.js"></script>
    <script src="../js/jquery.flexslider-min.js"></script>
    <script src="../js/owl.carousel.min.js"></script>
    <script src="../js/jquery.magnific-popup.min.js"></script>
    <script src="../js/magnific-popup-options.js"></script>
    <script src="../js/bootstrap-datepicker.js"></script>
    <script src="../js/jquery.stellar.min.js"></script>
    <script src="../csss/main.js"></script>

</body>
</html>
