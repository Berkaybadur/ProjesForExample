<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Airport_PresentationLayer.panels.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hakkımızda</title>
    <link rel="icon" type="image/png" href="../icons/start1.png" />
    <link href="../css/site.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/now-ui-dashboard.min.css" rel="stylesheet" />
    <link href="../css/now-ui-dashboard.css" rel="stylesheet" />
    <link href="../css/demo.css" rel="stylesheet" />
    <script src="../js/bootstrap.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper ">
            <div class="sidebar" data-color="orange">
                <!--
        Tip 1: You can change the color of the sidebar using: data-color="blue | green | orange | red | yellow"
    -->
                <div class="logo">
                    <a class="simple-text logo-mini">
                        <span style="font-size: 28px; color: aliceblue;">
                            <i class="fas fa-fighter-jet"></i></a>
                    <a class="simple-text logo-normal">
                        <span style="font-size: 28px; color: white;">AİRPORT</a>
                </div>
                <div class="sidebar-wrapper" id="sidebar-wrapper">
                    <ul class="nav">
                        <li>
                            <a href="./AdminPanels.aspx">
                                <i class="fa fa-list"></i>
                                <p>Admin Panel</p>
                            </a>
                        </li>
                        <li>
                            <a href="./PersonelPanel.aspx">
                                <i class="fa fa-user"></i>
                                <p>Müşteri</p>
                            </a>
                        </li>
                        <li>
                            <a href="./ExpeditionPanel.aspx">
                                <i class="far fa-compass"></i>
                                <p>Sefer</p>
                            </a>
                        </li>
                        <li>
                            <a href="./PersonelPanel.aspx">
                                <i class="far fa-address-card"></i>
                                <p>Personel</p>
                            </a>
                        </li>
                        <li>
                            <a href="./TicketPanel.aspx">
                                <i class="fas fa-clipboard"></i>
                                <p>Bilet</p>
                            </a>
                        </li>
                        <li>
                            <a href="./AirplanePanel.aspx">
                                <i class="fas fa-fighter-jet"></i>
                                <p>Uçak</p>
                            </a>
                        </li>
                        <li class="active ">
                            <a href="./AboutUs.aspx">
                                <i class="far fa-question-circle"></i>
                                <p>Hakkımda</p>
                            </a>
                        </li>
                        <li class="active-pro">
                            <a href="./Login.aspx">
                                <i class="fas fa-power-off"></i>
                                <p>ÇIKIŞ </p>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>

            <div class="main-panel" id="main-panel">
                <!-- Navbar -->
                <nav class="navbar navbar-expand-lg navbar-transparent  bg-primary  navbar-absolute">
                    <div class="container-fluid">
                        <div class="navbar-wrapper">
                            <div class="navbar-toggle">
                                <button type="button" class="navbar-toggler">
                                    <span class="navbar-toggler-bar bar1"></span>
                                    <span class="navbar-toggler-bar bar2"></span>
                                    <span class="navbar-toggler-bar bar3"></span>
                                </button>
                            </div>
                        </div>
                        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-bar navbar-kebab"></span>
                            <span class="navbar-toggler-bar navbar-kebab"></span>
                            <span class="navbar-toggler-bar navbar-kebab"></span>
                        </button>
                        <div class="collapse navbar-collapse justify-content-end" id="navigation">
                            <div class="input-group no-border">
                                <input type="text" value="" class="form-control" placeholder="Search...">
                                <div class="input-group-append">
                                    <div class="input-group-text">
                                        <i class="fas fa-search"></i>
                                    </div>
                                </div>
                            </div>
                            <ul class="navbar-nav">
                                <li class="nav-item">
                                    <a class="nav-link" href="https://github.com/Berkaybadur">
                                        <i class="fab fa-git"></i>
                                        <p>
                                            <span class="d-lg-none d-md-block">Git</span>
                                        </p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#pablo">
                                        <i class="far fa-address-book"></i>
                                        <p>
                                            <span class="d-lg-none d-md-block">Kullanıcı</span>
                                        </p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="./Login.aspx">
                                        <i class="fas fa-power-off"></i>
                                        <p>
                                            <span class="d-lg-none d-md-block">Close</span>
                                        </p>
                                    </a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </nav>
                <!-- End Navbar -->

                <div class="panel-header">
                    <div class="header text-center">
                        <h2 class="title">Hakkımda</h2>
                        <p class="category">
                            Projem Github Hesabımda Mevcuttur.
           
                            <a target="_blank" href="https://github.com/Berkaybadur">Anıl Berkay Badur</a>
                        </p>
                    </div>
                </div>
                <div class="content">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="card">
                                <div class="card-header">
                                    <h4 class="card-title">İletişim Bilgilerim</h4>
                                </div>
                                <div class="card-body">
                                    <div class="alert alert-info">
                                        <i class="far fa-bookmark"></i>
                                        <a href="https://www.linkedin.com/in/an%C4%B1l-berkay-badur-478640195/" style="color: white;">Linkedin Hesabıma Buradan Kolayca Ulaşabilirsiniz.</a>. 
               
                                    </div>
                                    <div class="alert alert-info">
                                        <i class="far fa-bookmark"></i>
                                        <a href="https://github.com/Berkaybadur" style="color: white;">Github Hesabıma Buradan Kolayca Ulaşabilirsiniz.</a>. 
                                   
                                    </div>
                                    <div class="alert alert-info">
                                        <i class="far fa-bookmark"></i>
                                        <a href="https://www.gmail.com" style="color: white;">İletişim İçin :berkaybadur5@gmail.com'dan Kolayca Ulaşabilirsiniz.</a>. 
                                   
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <footer class="footer">
                    <div class="container-fluid">
                        <nav>
                            <ul>
                                <li>
                                    <a href="https://www.linkedin.com/in/an%C4%B1l-berkay-badur-478640195">Lınkedin
                                    </a>
                                </li>
                                <li>
                                    <a href="https://github.com/Berkaybadur">Github
                                    </a>
                                </li>
                                <li>
                                    <a href="http://blog.creative-tim.com">Blog
                                    </a>
                                </li>
                            </ul>
                        </nav>
                        <div class="copyright" id="copyright">
                            &copy;
           
                            <script>
                                document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
                            </script>
                            Designed and Coded by 
           
                            <a href="https://www.linkedin.com/in/an%C4%B1l-berkay-badur-478640195" target="_blank">Anıl Berkay Badur</a>. 
         
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <!--   Core JS Files   -->
        <script src="../assets/js/core/jquery.min.js"></script>
        <script src="../assets/js/core/popper.min.js"></script>
        <script src="../assets/js/core/bootstrap.min.js"></script>
        <script src="../assets/js/plugins/perfect-scrollbar.jquery.min.js"></script>
        <!--  Google Maps Plugin    -->
        <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>
        <!-- Chart JS -->
        <script src="../assets/js/plugins/chartjs.min.js"></script>
        <!--  Notifications Plugin    -->
        <script src="../assets/js/plugins/bootstrap-notify.js"></script>
        <!-- Control Center for Now Ui Dashboard: parallax effects, scripts for the example pages etc -->
        <script src="../assets/js/now-ui-dashboard.min.js?v=1.3.0" type="text/javascript"></script>
        <!-- Now Ui Dashboard DEMO methods, don't include it in your project! -->
        <script src="../assets/demo/demo.js"></script>
        <script>
            $(document).ready(function () {
                // Javascript method's body can be found in assets/js/demos.js
                demo.initDashboardPageCharts();

            });
        </script>

    </form>
</body>

</html>
