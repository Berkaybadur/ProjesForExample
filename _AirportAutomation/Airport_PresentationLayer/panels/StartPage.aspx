<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="Airport_PresentationLayer.panels.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Start Page</title>
       <link rel="icon" type="image/png" href="../icons/start1.png" />
<link href="../css/bootstrap.min.css" rel="stylesheet" />
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet">
    <link href="../css/grayscale.min.css" rel="stylesheet" />
</head>
<body id="page-top">
    <form id="form1" runat="server">
   <nav class="navbar navbar-expand-lg navbar-light fixed-top" id="mainNav">
    <div class="container">
      <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        Menu
        <i class="fas fa-bars"></i>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive" >
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link js-scroll-trigger" href="#about">Hakkımızda</a>
          </li>
          <li class="nav-item">
            <a class="nav-link js-scroll-trigger" href="./Login.aspx">Giriş Yap</a>
          </li>
          <li class="nav-item">
            <a class="nav-link js-scroll-trigger" href="./Register.aspx">Kaydol</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>
  <!-- Header -->
  <header class="masthead" <%--style="background-image: url('../images/bg_1.jpg');--%> >
    <div class="container d-flex h-100 align-items-center ">
             <div class="mx-auto text-center">
        <h1 class="mx-auto my-0 text-uppercase">AİRPORT </h1>
        <h2 class="text-white-50 mx-auto mt-2 mb-5">Projeyi başlatmak için tıklayabilirsiniz.</h2>
        <a href="./Login.aspx" class="btn btn-primary js-scroll-trigger">PROJEYİ BAŞLAT</a>
      </div>
    </div>
  </header>
  <!-- Projects Section -->
  <section id="projects" class="projects-section bg-light">
    <div class="container">

      <!-- Featured Project Row -->
      <div class="row align-items-center no-gutters mb-4 mb-lg-5">
        <div class="col-xl-8 col-lg-7">
          <img class="img-fluid mb-3 mb-lg-0" src="../images/image_2.jpg" alt="">
        </div>
        <div class="col-xl-4 col-lg-5">
          <div class="featured-text text-center text-lg-left">
            <h4>Seyahat</h4>
            <p class="text-black-50 mb-0">Seyahat kısaca bir gezi veya yolculuk demektir. Zaten Seyahat, yolculuk ve geziş eş anlamlı kelimeler olarak bilinir. Seyahat; Kişi ya da nesnelerin(Uçak, araba, bot, tren) uzak yerler arasında gerçekleştirdiği hareket biçimidir.</p>
          </div>
        </div>
      </div>

      <!-- Project One Row -->
      <div class="row justify-content-center no-gutters mb-5 mb-lg-0">
        <div class="col-lg-6">
          <img class="img-fluid" src="../images/image_2.jpg" alt="">
        </div>
        <div class="col-lg-6">
          <div class="bg-black text-center h-100 project">
            <div class="d-flex h-100">
              <div class="project-text w-100 my-auto text-center text-lg-left">
                <h4 class="text-white">Check in işlemi</h4>
                <p class="mb-0 text-white-50">Check-in işlemi havaalanında bagaj verme ve bilet kontrol işleminden geçme olayıdır.</p>
                <hr class="d-none d-lg-block mb-0 ml-0">
              </div>
            </div>
          </div>
        </div>
      </div>

      <!-- Project Two Row -->
      <div class="row justify-content-center no-gutters">
        <div class="col-lg-6">
          <img class="img-fluid" src="../images/image_2.jpg" alt="">
        </div>
        <div class="col-lg-6 order-lg-first">
          <div class="bg-black text-center h-100 project">
            <div class="d-flex h-100">
              <div class="project-text w-100 my-auto text-center text-lg-right">
                <h4 class="text-white">Rötar</h4>
                <p class="mb-0 text-white-50">Rötar, uçakların planlanan kalkış ve iniş saatinden geç havalanması veya iniş yapmasıdır. Bu gecikme ise başta elverişsiz hava koşulları ve teknik aksaklıklar olmak üzere birçok faktör neden olabilir.</p>
                <hr class="d-none d-lg-block mb-0 mr-0">
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>
  </section>

  <!-- Footer -->
  <footer class="bg-black small text-center text-white-50">
    <div class="container">
   <script>
              document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
            </script>Designed and Coded by 
            <a href="https://www.linkedin.com/in/an%C4%B1l-berkay-badur-478640195" target="_blank">Anıl Berkay Badur</a>. 
    </div>
  </footer>

  <!-- Bootstrap core JavaScript -->
        <script src="../js/jquery.min.js"></script>

  <!-- Plugin JavaScript -->
  <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
        <script src="../js/jquery.easing.1.3.js"></script>

  <!-- Custom scripts for this template -->
        <script src="../js/grayscale.min.js"></script>

    </form>
</body>
</html>
