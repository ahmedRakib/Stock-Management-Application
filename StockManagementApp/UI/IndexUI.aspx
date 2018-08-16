<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="StockManagementApp.UI.IndexUI" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link href="../css/Style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <%--<link href="../css/bootstrap.min.css" rel="stylesheet" />--%>
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <link href="../css/animate.min.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />

</head>
<body>
    <div class="homepage">
        <header id="header">
            <h1 style="background-color: #006080; text-align: center">Stock Management System</h1>
            <nav class="navbar navbar-inverse" role="banner" style="background-color: #336699">
                <div class="container">


                    <div class="collapse navbar-collapse navbar-left">
                        <ul class="nav navbar-nav">
                            <li class="active"><a href="IndexUI.aspx">Home</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Setup<i class="fa fa-angle-down"></i></a>
                                <ul class="dropdown-menu">
                                    <li><a href="CategoryUI.aspx">Category Setup</a></li>
                                    <li><a href="CompanyUI.aspx">Company Setup</a></li>
                                    <li><a href="ItemSetupUI.aspx">Item Setup</a></li>
                                </ul>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Stock Manager<i class="fa fa-angle-down"></i></a>
                                <ul class="dropdown-menu">
                                    <li><a href="StockInUI.aspx">Stock In</a></li>
                                    <li><a href="StockOutUI.aspx">Stock Out</a></li>
                                </ul>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Report<i class="fa fa-angle-down"></i></a>
                                <ul class="dropdown-menu">
                                    <li><a href="SearchAndViewItemUI.aspx">Item Info</a></li>
                                    <li><a href="ViewSalesBetweenDatesUI.aspx">Sell Info</a></li>
                                </ul>
                            </li>


                        </ul>
                    </div>
                </div>
                <!--/.container-->
            </nav>
            <!--/nav-->

        </header>
        <!--/header-->
        <div class="story-container">
            <img src="../images/image.jpg" width="998px;" hight="768px;" alt="logo" />
        </div>
        <footer style="font-family: cursive; background-color: #004C99">Developed By @RAKIB </footer>
    </div>
</body>
</html>

