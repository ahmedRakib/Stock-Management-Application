﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="StockManagementApp.UI.IndexUI" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        
   <title></title>
    <link href="../css/Style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <%--<link href="../css/bootstrap.min.css" rel="stylesheet" />--%>
    <link href="../css/font-awesome.min.css" rel="stylesheet"/>
    <link href="../css/animate.min.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet"/>
    <link href="../css/responsive.css" rel="stylesheet"/>
    
</head>
<body>
     <div class="homepage">
    <header id="header">
        <h1 style="background-color: brown;text-align: center"> Stock Management System</h1>
        <nav class="navbar navbar-inverse" role="banner" style="background-color:  #336699">
            <div class="container">

				
                <div class="collapse navbar-collapse navbar-left">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="Index.aspx">Home</a></li> 
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Setup<i class="fa fa-angle-down"></i></a>
                            <ul class="dropdown-menu">
                                <li><a href="TestTypeSetup.aspx">Category Setup</a></li>                        
                                <li><a href="TestSetup.aspx">Company Setup</a></li> 
                                  <li><a href="TestSetup.aspx">Item Setup</a></li>                               
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Stock Manager<i class="fa fa-angle-down"></i></a>
                            <ul class="dropdown-menu">
                                <li><a href="TestRequestEntry.aspx">Stock In</a></li>                        
                                <li><a href="Payment.aspx">Stock Out</a></li>                              
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Report<i class="fa fa-angle-down"></i></a>
                            <ul class="dropdown-menu">
                                <li><a href="TestWiseReport.aspx">Item Info</a></li>                        
                                <li><a href="TypeWiseReport.aspx">Sell Info</a></li>                              
                            </ul>
                        </li>   
                                                                   
                                     
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
		
    </header><!--/header-->
 <div class="story-container">  
 <img src="../images/3.jpg" width="1000px;" hight="768px;" alt="logo">
     </div>
        <footer style="font-family: cursive;background-color: #004C99">Developed By Group ANONYMOUS </footer>
         </div>
</body>
</html>

