<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDelete.aspx.cs" Inherits="SitioWeb.WebPages.CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Customer Delete</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Customer Delete</h2>
        </div>
    <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblCustomerID" runat="server" Text="CustomerID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCustomerID" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblCompanyName" runat="server" Text="CompanyName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCompanyName" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblContactName" runat="server" Text="ContactName"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtContactName" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblContactTitle" runat="server" Text="ContactTitle"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtContactTitle" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblAddress" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtAddress" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblCity" runat="server" Text="City"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCity" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblRegion" runat="server" Text="Region"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtRegion" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblPostalCode" runat="server" Text="PostalCode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPostalCode" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblCountry" runat="server" Text="Country"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtCountry" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblPhone" runat="server" Text="Phone"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPhone" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LblFax" runat="server" Text="Fax"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtFax" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click"/>
            <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click"/>
        </div>
    </form>
</body>
</html>
