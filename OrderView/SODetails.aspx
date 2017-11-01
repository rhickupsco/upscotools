<%@ Page Title="" Language="C#" MasterPageFile="~/OrderViewMaster.master" AutoEventWireup="true" CodeFile="SODetails.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p><asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-lg whiteBack" PostBackUrl="~/MyOrders.aspx"><span class="glyphicon glyphicon-circle-arrow-left"></span>Back to Sales Orders</asp:LinkButton></p>
    <asp:Label Visible='<%# bool.Parse((WONumber != null).ToString())%>' runat="server" ID="lblDAS"
        CssClass="shrinkMargin-bottom" Text="Details Analysis Summary"></asp:Label>
<div id="summaryContainer" runat="server" visible='<%# bool.Parse((OrderCount > 0).ToString())%>'>
    <div runat="server" class="dashboard">Promise Date: <%# PromiseDate %></div>
    <div runat="server" id="onTimeDiv" class="dashboard">On Time Status: <%# LateStatus %></div>
    <div runat="server" id="holdDiv" class="dashboard">Hold Status: <%# HoldStatus %></div>
    <div runat="server" id="bomDiv" class="dashboard">BOM Revision: <%# BOMRevision %></div>  
    <div runat="server" id="productionDiv" class="dashboard">Production Status: <%# ProductionStatus %></div>    
</div>
    <asp:Label Visible='<%# bool.Parse((OrderCount > 0).ToString())%>' runat="server" ID="lblLabelInfo"
        CssClass="shrinkMargin-bottom" Text="Labeling Information"></asp:Label>   
<div id="ItemsLabelingInfo" runat="server" class="shrinkMargin-bottom"  
     visible='<%# bool.Parse((OrderCount > 0).ToString())%>'>
    <div runat="server" class="labelsInfo">Customer Name: <%# UDF_Customer %></div>
    <div runat="server" id="itemDescription" class="labelsInfo">Item Description in Item Maintenance: <%# ItemDescription %></div>  
</div>

<div id="panelWrapper" runat="server">     
    <div id="salesOrderDetails">
        <asp:DetailsView ID="dvSODetails" runat="server" Height="50px" Width="500px" HeaderText='<%# SOHeaderTextHere() %>' BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" 
        BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AllowPaging="True" OnPageIndexChanging="dvSODetails_PageIndexChanging" OnDataBound="dvSODetails_DataBound">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="Wheat" />
            <PagerSettings Position="Top" />
            <PagerStyle CssClass="gridview"/>
        </asp:DetailsView>
    </div>
    <div id="workOrderDetails" visible='<%# bool.Parse((WONumber != null).ToString())%>'>
        <asp:DetailsView ID="dvWODetails" runat="server" Height="50px" Width="500px" HeaderText='<%# WOHeaderTextHere() %>' BackColor="White" 
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" ForeColor="Black" 
                AllowPaging="True" CaptionAlign="Top" EmptyDataText="No Work Orders Found" OnPageIndexChanging="dvWODetails_PageIndexChanging" 
                DataKeyNames="WorkOrder" DataMember="WorkOrder" OnDataBound="dvWODetails_DataBound">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <AlternatingRowStyle BackColor="Wheat" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />           
             <PagerSettings Position="Top" />
             <PagerStyle CssClass="gridview"/>
        </asp:DetailsView>
    </div>
    </div>
</div>

<div id="contentBottom" runat="server" visible='<%# bool.Parse((WONumber != null).ToString())%>'>
    <div id="schedulingDetails">
        <asp:GridView ID="gvScheduling" runat="server" Width="80%" Visible="true" OnDataBound="gvScheduling_DataBound">
            <FooterStyle BackColor="wheat" ForeColor="Black" />
            <AlternatingRowStyle BackColor="Wheat" />
            <RowStyle BackColor="white" Font-Bold="True" ForeColor="black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="white" />
            <PagerStyle CssClass="gridview"/>
        </asp:GridView>
    </div>
</div>

</asp:Content>

