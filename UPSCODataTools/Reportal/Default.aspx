<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Select the Tool You Would Like To Use</h2>
            </hgroup>
            <p>
               
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Inventory Related Reports</h3>
    <ol class="round">
        <li class="one">
            <h5>Item Promises</h5>
           <a href="OORepairParts.aspx">Repair Parts on Open Orders</a>
        </li>     
        <li class="two">
            <h5>WO Transaction Error Locator</h5>
           <a href="MissingParts.aspx">Work Orders closed out for incorrect count finder</a>
        </li>       
    </ol>
</asp:Content>
