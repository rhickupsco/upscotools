<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/UpscoData.Master" CodeBehind="Jumbotron3.aspx.vb" Inherits="UPSCODataTools.Jumbotron3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cp2" runat="server">
<div id="slide-window" style="margin-top: 110px;margin-bottom: 50px;">
  <div class="title" id="time"></div>
    <ol id="slides" start="1">    
      <li class="slide color-0 alive">
        <div class="workcenterContainer" runat="server" id="nip">
     
           <div class="workcenter">
                <label class="deptTitle2">Nipple Workcenter</label>
                     <div class="metrics"><label>Percent built:</label><%= NIPDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned This Week:</label><%= NIPDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= NIPDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= NIPDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= NIPDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= NIPDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= NIPDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= NIPDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= NIPDNWPCTCompleted%></div>
          
        </div>
        </div>
      </li>
      
      <li class="slide color-1">
        <div class="workcenterContainer" runat="server" id="non">
           <div class="workcenter">
                <label class="deptTitle2">Non-Certified Weld Workcenter</label>
                    <div class="metrics"><label>Planned This Week:</label><%= NCWDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= NCWDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= NCWDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= NCWDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= NCWDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= NCWDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= NCWDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= NCWDNWPCTCompleted%></div>
           </div>
        </div>
      </li>
      
      <li class="slide color-2">
        <div class="workcenterContainer" runat="server" id="cert">
       <div class="workcenter">
                <label class="deptTitle2">Certified Weld Workcenter</label>
                     <div class="metrics"><label>Planned This Week:</label><%= CWDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= CWDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= CWDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= CWDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= CWDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= CWDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= CWDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= CWDNWPCTCompleted%></div>
       </div>
       </div>
      </li>
      
      <li class="slide color-3">
        <div class="workcenterContainer" runat="server" id="build">

      <div class="workcenter">
                <label class="deptTitle2">Build Workcenter</label>
                <div class="metrics"><label>Planned This Week:</label><%= BLDDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= BLDDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= BLDDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= BLDDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= BLDDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= BLDDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= BLDDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= BLDDNWPCTCompleted%></div>
                    
      </div>
      </div>
  
      </li>
      
      <li class="slide color-4">
        <div class="workcenterContainer" runat="server" id="test1">

       <div runat="server" class="workcenter">

                <label class="deptTitle2">Test 1 Workcenter</label>
                <div class="metrics"><label>Planned This Week:</label><%= TSTDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= TSTDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= TSTDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= TSTDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= TSTDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= TSTDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= TSTDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= TSTDNWPCTCompleted%></div>
                   
      </div>
      </div>

      </li>
      <li class="slide color-4">
        <div class="workcenterContainer" runat="server" id="test2">
        <div class="workcenter">
                <label class="deptTitle2">Test 2 Workcenter</label>
                <div class="metrics"><label>Planned This Week:</label><%= TST2DTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= TST2DTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= TST2DTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= TST2DTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= TST2DNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= TST2DNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= TST2DNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= TST2DNWPCTCompleted%></div>
                    
       </div>
       </div>

      </li>
      <li class="slide color-4">
       <div class="workcenterContainer" runat="server" id="paint">
            <div class="workcenter">
                <label class="deptTitle2">Paint Workcenter</label>
                     <div class="metrics"><label>Planned This Week:</label><%= PNTDTWPlanned%></div>
                     <div class="metrics"><label>Completed This Week:</label><%= PNTDTWCompleted%></div>
                     <div class="metrics"><label>Remaining This Week:</label><%= PNTDTWRemaining%></div>
                     <div class="metrics"><label>Percent Built This Week:</label><%= PNTDTWPCTCompleted%></div>
                     <div class="metrics"><label>Planned Next Week:</label><%= PNTDNWPlanned %></div>
                     <div class="metrics"><label>Completed Next Week:</label><%= PNTDNWCompleted%></div>
                     <div class="metrics"><label>Remaining Next Week:</label><%= PNTDNWRemaining%></div>
                     <div class="metrics"><label>Percent Completed Next Week:</label><%= PNTDNWPCTCompleted%></div>
                    
           </div>
       </div>
      </li>
    
    </ol>
    <span class="nav fa fa-chevron-left fa-2x" id="left"></span>
    <span class="nav fa fa-chevron-right fa-2x" id="right"></span>
   
 

    
    <%--<div id="credit"><span id="count">1</span></div>--%>
    
    </div>
  
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cp3" runat="server">
  <div id="banner">
        <div id="banner-content">
            <span style="display: block !important; width: 100%; text-align: center; font-family: FontAwesome; font-size: 12px;"><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:13118.1.99999&bannertypeclick=wu_clean2day" title="Moravia, New York Weather Forecast" target="_blank">
                <img src="http://weathersticker.wunderground.com/weathersticker/cgi-bin/banner/ban/wxBanner?bannertype=wu_clean2day_cond&airportcode=KN03&ForcedCity=Moravia&ForcedState=NY&zip=13118&language=EN" alt="Find more about Weather in Moravia, NY" width="300" /></a></span>
        </div>
    </div>
<div id="shipDate" class="stroke"><%=Shipdate%></div>  
</asp:Content>
