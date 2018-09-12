<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSalesBetweenDatesUI.aspx.cs" Inherits="StockManagementApp.UI.ViewSalesBetweenDatesUI" %>

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
    <link href="../Content/themes/base/jquery-ui.css" rel="stylesheet" />

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
                <h2 class="story-header">Stock Out Summary</h2>

                <form id="form2" runat="server">
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <label for="fromDateTextBox">From Date:</label>
                                </td>
                                <td>
                                    <input type="text" class="datepicker" runat="server" id="fromDateTextBox" name="fromDateTextBox" />
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <label for="toDateTextBox">To Date:</label>
                                </td>
                                <td>
                                    <input type="text" class="datepicker" runat="server" id="toDateTextBox" name="toDateTextBox" />
                                </td>
                            </tr>

                            <tr>
                                <td></td>
                                <td>
                                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                                </td>
                            </tr>

                        </table>
                    </div>

                    <asp:GridView ID="stockOutInfoGridView" runat="server" Width="584px" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                        <RowStyle HorizontalAlign="Center" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL" HeaderStyle-Width="5px">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Item Name">
                                <ItemTemplate>
                                    <asp:Label runat="server"><%#Eval("Name")%></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="StockOut Quantity">
                                <ItemTemplate>
                                    <asp:Label runat="server"><%#Eval("StockOutQuantity")%></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Stock Out Type">
                                <ItemTemplate>
                                    <asp:Label runat="server"><%#Eval("StockOutTypeName")%></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>

                    <br />

                </form>
            </div>
        </div>
        <div>
            <footer style="font-family: cursive; background-color: #004C99">Developed By @RAKIB </footer>
        </div>
        <script src="../Scripts/jquery-3.3.1.min.js"></script>
        <script src="../Scripts/jquery.validate.js"></script>
        <script src="../Scripts/jquery-ui-1.12.1.min.js"></script>

        <script>
            $(function () {
                $('#fromDateTextBox').datepicker(
                {
                    dateFormat: 'yy/mm/dd',
                    changeMonth: true,
                    changeYear: true,
                    yearRange: '1950:2100'
                });

                $('#toDateTextBox').datepicker(
              {
                  dateFormat: 'yy/mm/dd',
                  changeMonth: true,
                  changeYear: true,
                  yearRange: '1950:2100'
              });
                // validate signup form on keyup and submit
                $("#form2").validate({
                    rules: {
                        fromDateTextBox: "required",
                        toDateTextBox: "required",
                        },
                    messages: {
                        fromDateTextBox: "Please select a date",
                        toDateTextBox: "Please select a date",
                    }
                });

                //greater or equal checker
                $("#toDateTextBox").change(function () {
                    var startDate = document.getElementById("fromDateTextBox").value;
                    var endDate = document.getElementById("toDateTextBox").value;

                    if ((Date.parse(startDate) >= Date.parse(endDate))) {
                        alert("End date should be greater than Start date");
                        document.getElementById("EndDate").value = "";
                    }
                });
            })
        </script>
</body>
</html>




