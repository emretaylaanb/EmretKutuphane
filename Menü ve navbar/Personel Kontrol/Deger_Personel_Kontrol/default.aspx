<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Deger_Personel_Kontrol._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width,initial-scale=1,shrink-to-fit=no,user-scalable=no,viewport-fit=cover"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <link rel="icon" href="img/Deger_icon.ico" type="image/x-icon" />
    <title>Değer Personel Yönetim Portalı</title>
    <%--<link rel="shortcut icon" type="image/x-icon" href="https://bizce.com.tr/favicon.ico" />--%>
    <!-- Custom fonts for this template-->
    <link href="Vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="Css/sb-admin-2.min.css" rel="stylesheet"/>

    <!-- Bootstrap core JavaScript-->
    <script src="Js/jquery.min.js"></script>
    <script src="Js/bootstrap.min.js"></script>
    <!-- Core plugin JavaScript-->
   <%-- <script src="vendor/jquery-easing/jquery.easing.min.js"></script>--%>

    <link href="Css/toastr.min.css" rel="stylesheet" />
    <script src="Js/toastr.min.js"></script>
    <script>
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": true,
            "positionClass": "toast-top-center",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "4000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
    </script>
    <style>
        .bg-gradient-primary {
            background-image: url('img/body.jpeg') !important;
            background-size: cover;
        }

        @font-face {
            font-family: 'DINPro-Light';
            font-style: normal;
            font-weight: normal;
            src: local('DINPro-Light'), url('fonts/DINPro-Light_13935.woff') format('woff');
        }

        .h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {
            font-weight: 600;
        }
    </style>
</head>
<body class="bg-gradient-primary" onload="document.getElementById('txt_usern').focus();" style="font-family: DINPro-Light;">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h3 class="h4 text-gray-900 mb-4">
                                            <h5 class="h5 text-gray-900 mb-4">
                                                <img src="img/logo.png" height="170px" /><br />
                                                <br />
                                                 Yönetim </h5>
                                        </h3>

                                    </div>
                                    <form id="form1" runat="server">
                                        <div id="login">
                                            <div class="form-group">
                                                <input type="text" class="form-control form-control-user" id="txt_usern" value="admin" aria-describedby="emailHelp" runat="server" placeholder="Kullanıcı Adınız"/>
                                            </div>
                                            <div class="form-group">
                                                <input type="password" class="form-control form-control-user" id="txt_passw" value="admin" placeholder="Şifre" runat="server"/>
                                            </div>
                                            <div class="form-group">
                                                <div class="custom-control custom-checkbox small">
                                                    <input type="checkbox" class="custom-control-input" id="customCheck" runat="server"/>
                                                    <label class="custom-control-label" for="customCheck">Beni Hatırla</label>
                                                </div>
                                            </div>
                                            <asp:Button ID="btn_login" CssClass="btn btn-primary btn-user btn-block" runat="server" Text="Giriş" OnClick="btn_login_Click" />

                                        </div>
                                        <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                            <div class="modal-dialog" role="document">
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <h5 class="modal-title" id="exampleModalLabel">Şifremi Unuttum</h5>
                                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                            <span aria-hidden="true">&times;</span>
                                                        </button>
                                                    </div>
                                                    <div class="modal-body">
                                                        <input type="text" class="form-control form-control-user" id="txt_email" aria-describedby="emailHelp" runat="server" placeholder="Email Adresiniz"/>
                                                    </div>
                                                    <div class="modal-footer">
                                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Kapat</button>
                                                        <asp:Button ID="btn_unuttum" CssClass="btn btn-primary btn-user " runat="server" Text="Şifremi Değiştir" OnClick="btn_unuttum_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                    <hr>
                                    <%--     <div class="text-center">
                                        <a class="small" href="#" data-toggle="modal" data-target="#exampleModal">Şifremi Unuttum</a>
                                        <br />
                                        <div class="text-center">
                                            <div class="small">v2.0 <%=Request["ck"] %></div>
                                        </div>
                                     <div class="text-center" style='<%=Request["ck"]==null?"": "display:none" %>'>
                                            <a href="https://www.sirketimguvende.com/app/BizceTalep.apk">
                                                <img style="width: 120px;" src="img/android-button.png" alt="Android İndirme"></a>
                                            &nbsp;&nbsp;
   
                                            <a href="itms-services://?action=download-manifest&url=https://www.sirketimguvende.com/app/BizceTalep.plist">
                                                <img style="width: 120px;" src="img/ios-button.png" alt="iOS İndirme"></a>
                                        </div>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Custom scripts for all pages-->
    <script src="Js/sb-admin-2.min.js"></script>
</body>

</html>
