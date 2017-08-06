<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OORepairParts.aspx.vb" Inherits="Open_Order_Repair_Parts_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Open Order Repair Parts</title>
    <link href="Content/Site.css" rel="stylesheet" />      
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnSearch" defaultfocus="txtSearchParam">
    <div class="wrapper" runat="server"> 
    <div id="searchControls" class="clear-fix"> 
        <asp:Label ID="Label1" CssClass="question" runat="server" Text="What Item or Company Are you Looking For:"></asp:Label>
        <asp:TextBox ID="txtSearchParam" runat="server" CssClass="feature"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Find It" CssClass="button" />
        <asp:Button ID="btnClear" runat="server" Text="Show All" Visible="False" CssClass="button" OnClientClick="window.history.back();return false;" />
    </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SageDS1" DataKeyNames="ItemCode,WarehouseCode" GroupItemCount="5">
         <LayoutTemplate>
                <table runat="server" style="background-color: #FFFFFF; display:inline-block; 
                        border-collapse: collapse;border-color: #999999;border-style:solid;
                        border-width:5px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <tr id="groupPlaceholderContainer" runat="server">
                            <td id="groupPlaceholder" runat="server" ></td>
                    </tr> 
                </table>
               
            </LayoutTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server" ></td>
                    </tr>
            </GroupTemplate>
            <AlternatingItemTemplate>        
                <td runat="server" class="myItemAlternate" >SO #:
                    <asp:Label ID="SalesOrderNoLabel" runat="server" Text='<%# Eval("SalesOrderNo") %>' />
                    <br />
                    Order Type:
                    <asp:Label ID="OrderTypeLabel" runat="server" Text='<%# Eval("OrderType") %>' />
                    <br />
                    Qty Ordered:
                    <asp:Label ID="QuantityOrderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOrdered", "{0:N}") %>' />
                    <br />
                    Qty Shipped:
                    <asp:Label ID="QuantityShippedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityShipped", "{0:N}") %>' />
                    <br />
                    Item:
                    <asp:Label ID="ItemCodeLabel" runat="server" Text='<%# Eval("ItemCode") %>' />
                    <br />
                    Cust:
                    <asp:Label ID="ShipToNameLabel" runat="server" Text='<%# Eval("ShipToName") %>' />
                    <br />
                    Ship To City:
                    <asp:Label ID="ShipToCityLabel" runat="server" Text='<%# Eval("ShipToCity") %>' />
                    <br />
                    Ship To State:
                    <asp:Label ID="ShipToStateLabel" runat="server" Text='<%# Eval("ShipToState") %>' />
                    <br />
                    Promise Date:
                    <asp:Label ID="PromiseDateLabel" CssClass="date" runat="server" Text='<%# Eval("PromiseDate", "{0:d}") %>' />
                    <br />
                    Qty Backordered:
                    <asp:Label ID="QuantityBackorderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityBackordered", "{0:N}") %>' />
                    <br />
                    Order Date:
                    <asp:Label ID="OrderDateLabel" CssClass="date" runat="server" Text='<%# Eval("OrderDate", "{0:d}") %>' />
                    <br />
                    Warehouse Code:
                    <asp:Label ID="WarehouseCodeLabel" runat="server" Text='<%# Eval("WarehouseCode") %>' />
                    <br />
                    Qty On Hand:
                    <asp:Label ID="QuantityOnHandLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnHand", "{0:N}") %>' />
                    <br />
                    Qty On PO:
                    <asp:Label ID="QuantityOnPurchaseOrderLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnPurchaseOrder", "{0:N}") %>' />
                    <br />
                    Order Status:
                    <asp:Label ID="OrderStatusLabel" runat="server" Text='<%# Eval("OrderStatus") %>' />
                    <br />
                </td>
  
            </AlternatingItemTemplate>
            <ItemTemplate>
                <td runat="server" class="myItem">SO #:
                    <asp:Label ID="SalesOrderNoLabel" runat="server" Text='<%# Eval("SalesOrderNo") %>' />
                    <br />
                    Order Type:
                    <asp:Label ID="OrderTypeLabel" runat="server" Text='<%# Eval("OrderType") %>' />
                    <br />
                    Qty Ordered:
                    <asp:Label ID="QuantityOrderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOrdered", "{0:N}") %>' />
                    <br />
                    Qty Shipped:
                    <asp:Label ID="QuantityShippedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityShipped", "{0:N}") %>' />
                    <br />
                    Item:
                    <asp:Label ID="ItemCodeLabel" runat="server" Text='<%# Eval("ItemCode") %>' />
                    <br />
                    Cust:
                    <asp:Label ID="ShipToNameLabel" runat="server" Text='<%# Eval("ShipToName") %>' />
                    <br />
                    Ship To City:
                    <asp:Label ID="ShipToCityLabel" runat="server" Text='<%# Eval("ShipToCity") %>' />
                    <br />
                    Ship To State:
                    <asp:Label ID="ShipToStateLabel" runat="server" Text='<%# Eval("ShipToState") %>' />
                    <br />
                    Promise Date:
                    <asp:Label ID="PromiseDateLabel" CssClass="date" runat="server" Text='<%# Eval("PromiseDate", "{0:d}") %>' />
                    <br />
                    Qty Backordered:
                    <asp:Label ID="QuantityBackorderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityBackordered", "{0:N}") %>' />
                    <br />
                    Order Date:
                    <asp:Label ID="OrderDateLabel" CssClass="date" runat="server" Text='<%# Eval("OrderDate", "{0:d}") %>' />
                    <br />
                    Warehouse Code:
                    <asp:Label ID="WarehouseCodeLabel" runat="server" Text='<%# Eval("WarehouseCode") %>' />
                    <br />
                    Qty On Hand:
                    <asp:Label ID="QuantityOnHandLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnHand", "{0:N}") %>' />
                    <br />
                    Qty On PO:
                    <asp:Label ID="QuantityOnPurchaseOrderLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnPurchaseOrder", "{0:N}") %>' />
                    <br />
                    Order Status:
                    <asp:Label ID="OrderStatusLabel" runat="server" Text='<%# Eval("OrderStatus") %>' />
                    <br />
                </td>

            </ItemTemplate>
           
            <SelectedItemTemplate>
                <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">SalesOrderNo:
                    <asp:Label ID="SalesOrderNoLabel" runat="server" Text='<%# Eval("SalesOrderNo") %>' />
                    <br />
                    Order Type:
                    <asp:Label ID="OrderTypeLabel" runat="server" Text='<%# Eval("OrderType") %>' />
                    <br />
                    Qty Ordered:
                    <asp:Label ID="QuantityOrderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOrdered", "{0:N}") %>' />
                    <br />
                    Qty Shipped:
                    <asp:Label ID="QuantityShippedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityShipped", "{0:N}") %>' />
                    <br />
                    Item:
                    <asp:Label ID="ItemCodeLabel" runat="server" Text='<%# Eval("ItemCode") %>' />
                    <br />
                    Cust:
                    <asp:Label ID="ShipToNameLabel" runat="server" Text='<%# Eval("ShipToName") %>' />
                    <br />
                    Ship To City:
                    <asp:Label ID="ShipToCityLabel" runat="server" Text='<%# Eval("ShipToCity") %>' />
                    <br />
                    Ship To State:
                    <asp:Label ID="ShipToStateLabel" runat="server" Text='<%# Eval("ShipToState") %>' />
                    <br />
                    Promise Date:
                    <asp:Label ID="PromiseDateLabel" CssClass="date" runat="server" Text='<%# Eval("PromiseDate", "{0:d}") %>' />
                    <br />
                    Qty Backordered:
                    <asp:Label ID="QuantityBackorderedLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityBackordered", "{0:N}") %>' />
                    <br />
                    Order Date:
                    <asp:Label ID="OrderDateLabel" CssClass="date" runat="server" Text='<%# Eval("OrderDate", "{0:d}") %>' />
                    <br />
                    Warehouse Code:
                    <asp:Label ID="WarehouseCodeLabel" runat="server" Text='<%# Eval("WarehouseCode") %>' />
                    <br />
                    Qty On Hand:
                    <asp:Label ID="QuantityOnHandLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnHand", "{0:N}") %>' />
                    <br />
                    Qty On PO:
                    <asp:Label ID="QuantityOnPurchaseOrderLabel" CssClass="numbers" runat="server" Text='<%# Eval("QuantityOnPurchaseOrder", "{0:N}") %>' />
                    <br />
                    Order Status:
                    <asp:Label ID="OrderStatusLabel" runat="server" Text='<%# Eval("OrderStatus") %>' />
                    <br />
                </td>
            </SelectedItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td runat="server" />
            </EmptyItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SageDS1" runat="server" ConnectionString="<%$ ConnectionStrings:csSage %>" ProviderName="<%$ ConnectionStrings:csSage.ProviderName %>" 
        SelectCommand="SELECT SOD.SalesOrderNo, SOH.OrderType, SOD.QuantityOrdered, SOD.QuantityShipped, 
        SOD.ItemCode, SOH.ShipToName, SOH.ShipToCity, SOH.ShipToState, SOD.PromiseDate, SOD.QuantityBackordered, 
        SOH.OrderDate, IMW.WarehouseCode, IMW.QuantityOnHand, IMW.QuantityOnPurchaseOrder, SOH.OrderStatus 
        FROM IM_ItemWarehouse IMW, SO_SalesOrderDetail SOD, SO_SalesOrderHeader SOH WHERE (IMW.ItemCode = SOD.ItemCode) 
        AND (SOD.SalesOrderNo = SOH.SalesOrderNo) AND (SOD.WarehouseCode = 'RPR') AND (IMW.WarehouseCode = 'RPR') 
        AND (SOH.OrderType &lt;&gt; 'Q') AND (SOD.DropShip = 'N') 
        ORDER BY SOD.SalesOrderNo DESC, SOD.ItemCode ASC"></asp:SqlDataSource>   
    
    </div>
    </form>
</body>
</html>
