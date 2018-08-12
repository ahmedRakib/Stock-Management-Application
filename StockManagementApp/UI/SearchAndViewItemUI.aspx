<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchAndViewItemUI.aspx.cs" Inherits="StockManagementApp.UI.SearchAndViewItemUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table>

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
                        <asp:Label ID="categoryLabel" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="categoryDropDownList" runat="server"></asp:DropDownList>
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
    </form>
</body>
</html>
