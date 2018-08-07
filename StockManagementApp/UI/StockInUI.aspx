<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUI.aspx.cs" Inherits="StockManagementApp.UI.StockInUI" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="companyDropDownList" runat="server"></asp:DropDownList>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList  AutoPostBack="true" ID="itemDropDownList" runat="server"  CssClass="text" OnSelectedIndexChanged="getItemDropDown_Change"></asp:DropDownList>
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
                <td>
                </td>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
