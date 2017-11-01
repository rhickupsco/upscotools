<%@ Page Title="" Language="C#" MasterPageFile="~/OrderViewMaster.master" AutoEventWireup="true" CodeFile="MyOrders.aspx.cs" Inherits="MyOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>My Open Orders</h1>
        <asp:CheckBox ID="cbOnlyMake" runat="server" Checked="True" CssClass="form-control input-lg" Text="If Checked Only Sales Orders that contain MAKE Items will be displayed" />
    <h2>Select Your Sales Team:</h2>
<%--    <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown"><span class="caret"></span></button>
    <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu1" id="ddlSalesTeam" runat="server">--%>
        <asp:DropDownList ID="ddlSalesTeam" runat="server" AppendDataBoundItems="True" CssClass="dropdown divider">
    </asp:DropDownList>
 
    <asp:Button ID="btnGetMySalesOrders" runat="server" OnClick="btnGetMySalesOrders_Click" Text="Load My Sales Orders" CssClass="btn btn-primary btn-lg upscoColors shimDown" />

    <asp:DataList ID="dlMyOrders" runat="server"  RepeatDirection="Horizontal" CellPadding="4" CssClass="shimDown panel panel-group" ForeColor="#333333" RepeatLayout="Flow" Width="100%" ViewStateMode="Enabled" OnItemDataBound="dlMyOrders_ItemDataBound">
        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
        <FooterStyle BackColor="White" Font-Bold="True" ForeColor="Red" Font-Size="XX-Large" />
        <HeaderTemplate>
            <div class="alert-success">You have <%# OrderCount %> Open Orders shown newest (top left) to oldest (bottom right)</div>
        </HeaderTemplate>
        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <ItemTemplate >            
                <asp:Button ID="lblSONum" runat="server" CssClass="order upscoColors"
                    PostBackUrl='<%# UrlHelper("~/SODetails.aspx?id=" ,DataBinder.Eval(Container.DataItem, "SalesOrderNo")) %>'
                    Text='<%# OrderStringBuilder(DataBinder.Eval(Container.DataItem, "CustomerName"), DataBinder.Eval(Container.DataItem, "SalesOrderNo")) %>' />              
        </ItemTemplate>
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <FooterTemplate>
            <asp:Label Visible='<%# bool.Parse((OrderCount == 0).ToString())%>' 
                       runat="server" ID="lblNoRecord" Text="No Orders meet this criteria for your sales team!"></asp:Label>
        </FooterTemplate>
    </asp:DataList>
</asp:Content>

