<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockOutUI.aspx.cs" Inherits="StockManagementApp.UI.StockOutUI" %>

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
                    <asp:DropDownList ID="companyDropDownList" AutoPostBack="true" runat="server" OnSelectedIndexChanged="companyDropDown_Change"></asp:DropDownList>
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
                    <asp:TextBox ID="availableQuantityTextBox" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Stock Out Quantity"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="stockOutTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="stockOutGridView" runat="server">
        </asp:GridView>
        <table>
            <tr>
                <td><asp:Button ID="sellButton" runat="server" Text="Sell" OnClick="sellButton_Click" /></td>
                <td><asp:Button ID="damageButton" runat="server" Text="Damage" /></td>
                 <td><asp:Button ID="lostButton" runat="server" Text="Lost" /></td>
            </tr>
        </table>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
