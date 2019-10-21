<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ilan.aspx.cs" Inherits="WebUi.Pages.Deneme2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <link href="site.css" rel="stylesheet" />
    <script type="text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("İLANINIZ VERİLDİ.")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
    </script>
    <script>
        function clickButton(e, buttonid) {
            var evt = e ? e : window.event;
            var bt = document.getElementById(buttonid);
            if (bt) {
                if (evt.keyCode == 13) {
                    bt.click();
                    return false;
                }
            }
        }
    </script>

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
    </script>





    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="bootstrap-3.3.7-dist/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">




    <style type="text/css">
        .auto-style15 {
            margin-left: 65px;
        }

        .auto-style16 {
            height: 25px;
            color: black;
            border: 2px solid #337ab7;
            margin-left: 400px;
            padding-left: 35px;
            background-color: white;
            background-image: url('icons/search.png');
            background-repeat: no-repeat;
            background-position: 5px 5px;
            border-radius: 8px;
        }

        .düzenle {
            text-decoration: none;
            font-family: 'Red Hat Text', sans-serif;
            font-size: 17px;
        }

            .düzenle:hover {
                font-family: 'Times New Roman';
                font-size: 17px;
                color: #FF9933;
                text-decoration: none;
            }

        .auto-style18 {
            color: white;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            border-radius: 8px;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            margin-left: 450px;
            background-image: url();
            background-color: #1864ba;
        }

            .auto-style18:hover {
                color: white;
                background: #0089ff;
            }

        .auto-style19 {
            color: white;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            border-radius: 8px;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            background-image: url();
            background-color: #1864ba;
            margin-left: 35px;
        }

            .auto-style19:hover {
            }

        .carousel-inner img {
            width: 50%;
            height: 50%;
        }

        .genislikb {
            width: 150px;
            border-radius: 8px;
            color: black;
        }

        .genislika {
            width: 150px;
            border-radius: 8px;
            color: black;
        }

        .MoneyInfo::before {
            content: "$";
            color: #606060;
        }

        .MoneyInfo:not(:empty)::before {
            content: "$";
            color: #606060;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <asp:Button ID="btnClose" runat="server" Text="" CssClass="buttonclose" OnClick="btnClose_Click" Height="64px" Width="64px" />
    <%--Slider Gelicek Ve Altında Ücretsiz İlan Ver Olacak.3 Resim indir--%>
    <div class="container" style="margin-left: 181px">
        <h3>EN İYİ ARAÇLAR</h3>
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item">
                    <img src="icons/m3.png" alt="Chicago" style="width: 55%;">
                    <div class="carousel-caption">
                        <h3 style="color: black; text-align: right">BMW</h3>
                        <p style="color: black; text-align: right">M3</p>
                    </div>
                </div>
                <div class="item active">
                    <img src="icons/araç6.png" alt="Los Angeles" style="width: 60%;">
                    <div class="carousel-caption">
                        <h3 style="color: black; text-align: right;">MERCEDES</h3>
                        <p style="color: black; text-align: right;">CLA 2019</p>
                    </div>
                </div>
                <div class="item">
                    <img src="icons/tt.png" alt="New York" style="width: 70%;">
                    <div class="carousel-caption">
                        <h3 style="color: black; text-align: right">Audi</h3>
                        <p style="color: black; text-align: right">TT</p>
                    </div>
                </div>
            </div>
            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" style="left: 20%; top: 50%; width: 4px"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>

    <div class="col-xs-1">

        <div class="panel panel-primary" style="width: 175px;">
            <div class="panel-heading">FİLTRELEME</div>
            <div class="panel-body">
                <div style="margin-right=-100px;">
                    <asp:Label runat="server" CssClass="labelaciklama"> KM:</asp:Label>
                    <asp:TextBox ID="txtGKM" runat="server" onkeypress="numeric(event)" class="para" Width="150px"></asp:TextBox><br />
                    <br />
                    <asp:Label runat="server" CssClass="labelaciklama"> Fiyat:</asp:Label>
                    <asp:TextBox ID="txtGFiyat" runat="server" onkeypress="numeric(event)" class="para" Width="150px"></asp:TextBox><br />
                    <br />
                    <asp:Label runat="server" CssClass="labelaciklama"> Yıl:</asp:Label>
                    <asp:TextBox ID="txtGYil" runat="server" onkeypress="numeric(event)" Width="150px"></asp:TextBox><br />
                    <br />
                    <asp:Label runat="server" CssClass="labelaciklama"> Vites:</asp:Label>
                    <asp:DropDownList ID="ddlGVites" runat="server" AutoPostBack="true" AppendDataBoundItems="True" Width="150px"></asp:DropDownList><br />
                    <br />
                    <asp:Label runat="server" CssClass="labelaciklama"> Renk:</asp:Label>
                    <asp:DropDownList ID="ddlGRenk" runat="server" AutoPostBack="true" AppendDataBoundItems="True" Width="150px"></asp:DropDownList><br />
                    <br />
                    <asp:Button ID="btnAra" runat="server" Text="Ara" CssClass="auto-style19" OnClick="btnAra_Click" BorderColor="#ebebeb" Height="30px" Width="87px" />
                </div>
            </div>
        </div>

    </div>


    <div style="margin-left: 110px;">
        <div class="form-group">
            <div class="container">

                <div class="panel panel-primary">
                    <div class="panel-heading">ÜCRETSİZ İLAN VER</div>
                    <div class="panel-body">
                        <div class="form-group" style="background-image: url('icons/register.jpg');">
                            <br />
                            <div class="form-group">
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label runat="server" CssClass="kullanici" ID="labelkullanici"> Kullanıcı : </asp:Label>
                                        <asp:Label ID="lblKullanici" runat="server" CssClass="kullanici"></asp:Label>
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                                <br />
                                <div class="dropdown">
                                    <tr>
                                        <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                                            <td class="auto-style1">
                                                <asp:Label ID="lblArac" runat="server" CssClass="labelaracddl">  Araçlar</asp:Label>
                                                <asp:DropDownList ID="ddlArac" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArac_SelectedIndexChanged" CssClass="ddlArac" AppendDataBoundItems="True"></asp:DropDownList><br />
                                            </td>
                                        </button>
                                    </tr>
                                    <tr>
                                        <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                                            <td class="auto-style1">
                                                <td>
                                                    <asp:Label ID="lblAracModel" runat="server" CssClass="labelmodelddl"> Araç Model</asp:Label></td>
                                                <td>
                                                    <asp:DropDownList ID="ddlAracModel" runat="server" AutoPostBack="true" CssClass="ddlModel"></asp:DropDownList><br />
                                                </td>
                                            </td>
                                    </tr>
                                    </tr>
                                </div>
                                <br />

                                <div class="dropdown">
                                    <tr>
                                        <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                                            <td class="auto-style1">
                                                <asp:Label ID="Label1" runat="server" CssClass="labelaracddl">  VİTES</asp:Label>
                                                <asp:DropDownList ID="ddlvites" runat="server" AutoPostBack="true" CssClass="ddlArac" AppendDataBoundItems="True"></asp:DropDownList><br />
                                            </td>
                                        </button>
                                    </tr>
                                    <tr>
                                        <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                                            <td class="auto-style1">
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" CssClass="labelmodelddl">RENK</asp:Label></td>
                                                <td>
                                                    <asp:DropDownList ID="ddlrenk" runat="server" AutoPostBack="true" CssClass="ddlModel"></asp:DropDownList><br />
                                                </td>
                                            </td>
                                    </tr>
                                </div>
                                <br />
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label runat="server" CssClass="labelbüyük"> Başlangıç Tarih:</asp:Label>
                                        <asp:TextBox ID="txtBTarih" runat="server" CssClass="textboxilan"> </asp:TextBox>
                                        <br />
                                    </td>
                                </tr>
                                <br />
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label runat="server" CssClass="labelbüyük">Bitiş Tarih :</asp:Label>
                                        <asp:TextBox ID="txtFTarih" runat="server" CssClass="tarih"> </asp:TextBox><br />
                                    </td>
                                </tr>
                                <br />
                                <tr>
                                    <td class="auto-style1">
                                        <asp:Label runat="server" CssClass="labelaciklama"> Açıklama:</asp:Label>
                                        <asp:TextBox ID="txtDes" runat="server" CssClass="aciklama"></asp:TextBox><br />
                                    </td>
                                    <br />
                                </tr>

                                <asp:Label runat="server" CssClass="labelKM"> KM:</asp:Label>
                                <asp:TextBox ID="txtKM" runat="server" CssClass="textKM" onkeypress="numeric(event)"></asp:TextBox><br />
                                <br />
                                <asp:Label runat="server" CssClass="labelKM"> Yıl:</asp:Label>
                                <asp:TextBox runat="server" ID="txtYil" CssClass="textyil" onkeypress="numeric(event)"></asp:TextBox><br />
                                <br />
                                <asp:Label runat="server" CssClass="labelKM"> Fiyat:</asp:Label>
                                <asp:TextBox runat="server" ID="txtFiyat" CssClass="textfiyat" onkeypress="numeric(event)"></asp:TextBox>


                                <tr>
                                </tr>




                            </div>
                            <asp:Button ID="Ilanver" runat="server" Text="İLAN VER" CssClass="button" OnClick="Ilanver_Click" />
                            <asp:Button ID="btnTemizle" runat="server" Text="TEMİZLE" CssClass="button" OnClick="btnTemizle_Click" />
                            <asp:Button ID="btnDelete" runat="server" Text="KAYIT SİL" CssClass="button" OnClick="btnDelete_Click" />
                            <br />
                            <br />
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="auto-style16" placeholder="Araç adı ile ara" onkeypress="myFunction()"></asp:TextBox>
                            <asp:Button ID="btnSeacrh" runat="server" Text="Ara" CssClass="auto-style18" OnClick="btnSeacrh_Click" BorderColor="#ebebeb" Height="30px" Width="87px" />
                            <br />
                            <br />
                            <div class="table-responsive">
                                <asp:DataGrid ID="dgwIlan" runat="server" UseAccessibleHeader="True" CssClass="auto-style15" CellPadding="4" ForeColor="#333333" GridLines="None">
                                    <AlternatingItemStyle BackColor="White" />
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <a class="düzenle" href='Ilan.aspx?id=<%#Eval("id")%>'>Düzenle
                                                </a>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <EditItemStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <ItemStyle BackColor="#EFF3FB" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                </asp:DataGrid>
                            </div>
                            <br />
                            <br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script>
            $(function () {
                $("#cphBody_txtBTarih").datepicker({
                    showOn: "button",
                    buttonImage: "takvim.png",
                    buttonImageOnly: true,
                    dateFormat: "dd.mm.yy",
                    monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
                    dayNamesMin: ["Pts", "Sl", "Çrş", "Prş", "Cm", "Cts", "Pzr"]
                });
            });
    </script>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script src="https://code.jquery.com/jquery-1.11.3.min.js"></script>

    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script src="sources/jquery.masknumber.js"></script>
    <script>
            $(function () {
                $("#cphBody_txtFTarih").datepicker({
                    showOn: "button",
                    buttonImage: "takvim.png",
                    buttonImageOnly: true,
                    dateFormat: "dd.mm.yy",
                    monthNames: ["Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"],
                    dayNamesMin: ["Pts", "Sl", "Çrş", "Prş", "Cm", "Cts", "Pzr"]
                });
            });
    </script>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.12.4/jquery.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.0/jquery.mask.js"></script>



    <script>

            $(document).ready(function () {
                $('.para').mask('000.000.000.000.000.00');
            });

    </script>
</asp:Content>




