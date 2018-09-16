<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditAndDeleteItemUI.aspx.cs" Inherits="StockManagementApp.UI.EditAndDeleteItemUI" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/Style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <link href="../css/animate.min.css" rel="stylesheet" />
    <link href="../css/main.css" rel="stylesheet" />
    <link href="../css/responsive.css" rel="stylesheet" />
    <style>
        label.error {
            color: red;
            font-weight: bold;
            font-style: italic;
        }

        .messageLabel {
            color: red;
            font-weight: bold;
            font-style: italic;
        }
    </style>

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
    </div>

    <div class="story-container" style="height: 400px; width: 1000px">

        <div class="story-content2">
            <h2 class="story-header">Edit Item UI</h2>

            <form id="form1" runat="server">
                <div>
                     <table>

                            <tr>
                                <td>
                                    <asp:Label ID="categoryLabel" runat="server" Text="Category"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="categoryDropDownList" runat="server"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="companyLabel" runat="server" Text="Company"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="companyDropDownList" runat="server"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Item Name"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="itemNameTextBox" runat="server"></asp:TextBox>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <asp:Label ID="recorderLabel" runat="server" Text="Recorder Level"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="recorderLevelTextBox" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="editButton" runat="server" Text="Edit" OnClick="editButton_Click" />
                            </td>
                           
                               
                        </tr>

                        <tr>
                            <td>
                                <span id="messageLabel" class="messageLabel" runat="server"></span>

                            </td>
                        </tr>
                    </table>
                </div>
            </form>
        </div>
    </div>
    <div>
        <footer style="font-family: cursive; background-color: #004C99">Developed By  @RAKIB </footer>
    </div>

    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/jquery-ui-1.12.1.min.js"></script>

   <script>
       $().ready(function () {

           // validate signup form on keyup and submit
           $("#form2").validate({
               rules: {
                   itemNameTextBox: "required",
                   recorderLevelTextBox: {
                       required: true,
                       number: true,
                   },
               },
               messages: {
                   itemNameTextBox: "Please enter Item  name",
                   recorderLevelTextBox: {
                       required: "Please enter a recorder level",
                       number: "Please enter a number",
                   },
               }
           });
       });
        </script>
</body>
</html>


