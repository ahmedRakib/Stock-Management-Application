<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSalesBetweenDatesUI.aspx.cs" Inherits="StockManagementApp.UI.ViewSalesBetweenDatesUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link href="../Content/themes/base/jquery-ui.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
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
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                    </td>
                </tr>

            </table>

        </div>

         <br />
        <br />
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
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
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
        })
</script>  
</body>
</html>
