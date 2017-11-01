<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PartFinder.aspx.cs" Inherits="PartFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parts Locator</title>
    <style type="text/css">
    .toUpper
            {
            text-transform: uppercase;          
            }
    #searchArea{
    line-height:50px;
    width: 600px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<asp:ScriptManager runat="server" ID="scriptMan"></asp:ScriptManager>

    <div id="searchArea">
     <p>
            <asp:Label ID="Label1" runat="server" Text="Part #:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search By P/N" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="btnDescriptionSearch" runat="server" OnClick="btnDescription_Click" Text="Search By Description" />
        </p>
    </div>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ItemCode" DataSourceID="sageDS" PageSize="15">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="ItemCode" HeaderText="Part Number" ReadOnly="True" SortExpression="ItemCode">
                <ControlStyle CssClass="toUpper" />
                </asp:BoundField>
                <asp:BoundField DataField="ItemCodeDesc" HeaderText="Description" SortExpression="ItemCodeDesc" >
                <ItemStyle CssClass="toUpper" />
                </asp:BoundField>
                <asp:BoundField DataField="TotalQuantityOnHand" DataFormatString="{0:0}" HeaderText="QOH" SortExpression="TotalQuantityOnHand" />
                <asp:BoundField DataField="StandardUnitOfMeasure" HeaderText="UOM" SortExpression="StandardUnitOfMeasure" />
                <asp:BoundField DataField="StandardUnitCost" DataFormatString="{0:c}" HeaderText="Our Price" SortExpression="StandardUnitCost" />
                <asp:BoundField DataField="StandardUnitPrice" DataFormatString="{0:c}" HeaderText="Sell Price" SortExpression="StandardUnitPrice" />
                <asp:BoundField DataField="AverageUnitCost" DataFormatString="{0:c}" HeaderText="Avg Cost" ReadOnly="True" SortExpression="AverageUnitCost" />
                <asp:BoundField DataField="DropShip" HeaderText="D/S" ReadOnly="True" SortExpression="DropShip" />
                <asp:BoundField DataField="PrimaryVendorNo" HeaderText="Vendor" SortExpression="PrimaryVendorNo" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="sageDS" runat="server" ConnectionString="<%$ ConnectionStrings:sageCS %>" ProviderName="<%$ ConnectionStrings:sageCS.ProviderName %>" SelectCommand="SELECT CI_Item.ItemCode, CI_Item.ItemCodeDesc,  CI_Item.TotalQuantityOnHand,CI_Item.StandardUnitOfMeasure, CI_Item.StandardUnitCost,  CI_Item.StandardUnitPrice, CI_Item.AverageUnitCost, CI_Item.DropShip, CI_Item.PrimaryVendorNo
FROM CI_Item CI_Item
Where CI_Item.ItemCode not like '/%' and ItemCodeDesc not like '%DO NOT USE%' and ItemCodeDesc  not like '%obsolete%'"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
