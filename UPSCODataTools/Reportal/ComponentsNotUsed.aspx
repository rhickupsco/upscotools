<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ComponentsNotUsed.aspx.vb" Inherits="ComponentsNotUsed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvComponentsList" runat="server" AutoGenerateColumns="False" DataKeyNames="WorkOrder" DataSourceID="dsComponents"><Columns>
<asp:BoundField DataField="WorkOrder" HeaderText="WorkOrder" ReadOnly="True" SortExpression="WorkOrder"></asp:BoundField>
<asp:BoundField DataField="ComponentItemNumber" HeaderText="ComponentItemNumber" SortExpression="ComponentItemNumber"></asp:BoundField>
<asp:BoundField DataField="ExtdQtyRequired" HeaderText="ExtdQtyRequired" SortExpression="ExtdQtyRequired"></asp:BoundField>
<asp:BoundField DataField="QtyIssued" HeaderText="QtyIssued" SortExpression="QtyIssued"></asp:BoundField>
<asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
</Columns>
</asp:GridView>
    <asp:SqlDataSource runat="server" ID="dsComponents" ConnectionString="<%$ ConnectionStrings:csSage %>" ProviderName="<%$ ConnectionStrings:csSage.ProviderName %>"
    SelectCommand="SELECT 
WOM.WorkOrder, 
WOMD.ComponentItemNumber, 
WOMD.ExtdQtyRequired, 
WOMD.QtyIssued, 
WOM.Status, 
(WOMD.ExtdQtyRequired - WOMD.QtyIssued) AS [Difference]
FROM WO1_WorkOrderMaster WOM, WO2_WorkOrderMaterialDetail WOMD
WHERE  WOMD.WorkOrder = WOM.WorkOrder
AND WOMD.ExtdQtyRequired&lt;&gt;WOMD.QtyIssued"></asp:SqlDataSource>
</div>
    </form>
</body>
</html>
