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

        <br />
        <br />
        <asp:GridView ID="itemInfoGridView" runat="server" Width="584px" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
                <asp:TemplateField HeaderText="Company Name">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("CompanyName")%></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Available Quantity">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("AvailableQuantity")%></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Recorder Level">
                    <ItemTemplate>
                        <asp:Label runat="server"><%#Eval("RecorderLevel")%></asp:Label>
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
</body>
</html>
