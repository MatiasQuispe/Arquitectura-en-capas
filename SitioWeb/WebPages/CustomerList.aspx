<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="SitioWeb.WebPages.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title>Customer List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer List</h1>
        </div>
        <asp:GridView ID="GrdCustomers" runat="server"
            CssClass="table table-striped table-bordered table-hover"
            AutoGenerateColumns="False"
            AllowPaging="true" PageSize="10"
            OnPageIndexChanging="GrdCustomers_OnPageIndexChanging"
            OnRowDataBound ="GrdCustomers_RowDataBound"
            >
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" />
                <asp:BoundField DataField="ContactName" HeaderText="ContactName" />
                <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" />
            </Columns>
            <SelectedRowStyle BackColor="#808080" Font-Bold="false" ForeColor="#333333" />
        </asp:GridView>
        <br />
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
        <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" />
        <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
    </form>
</body>
</html>
