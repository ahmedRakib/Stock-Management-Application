<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUI.aspx.cs" Inherits="StockManagementApp.UI.StockInUI" %>

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


        <div class="story-container" style="height: 400px; width: 1000px">

            <div class="story-content2">
                <h2 class="story-header">Item Stock In</h2>

                <form id="form2" runat="server">
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="companyDropDownList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="companyDropDown_Change"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList AutoPostBack="true" ID="itemDropDownList" runat="server" CssClass="text" OnSelectedIndexChanged="getItemDropDown_Change"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Recorder Level"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="recorderLevelTextBox" runat="server" ReadOnly="true"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Available Quantity"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="quantityTextBox" runat="server" ReadOnly="true"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Stock In Quantity"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="stockInTextBox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                                </td>
                            </tr>

                        </table>
                    </div>
                    <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>

                </form>
            </div>
        </div>
        <div>
            <footer style="font-family: cursive; background-color: #004C99">Developed By @RAKIB </footer>
        </div>
</body>
</html>


