<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/UpscoData.Master"  CodeBehind="JumboTron2.aspx.vb" Inherits="UPSCODataTools.JumboTron2" %>

<asp:Content ContentPlaceHolderID="cp2" runat="server">
<div id="topper">
    <div class="title" id="show"></div>
</div>

    <div class="stackedSummary"> 
        <div class="workcenterContainer" runat="server" id="nip">
            <div class="workcenter">
                <label class="deptTitle2">Nipple Workcenter</label>
                    <div class="metrics"><label>Planned:</label><%= NIPDTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= NIPDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= NIPDTWPCTCompleted%></div>   
            </div> 
        </div>
                    

        <div class="workcenterContainer" runat="server" id="non">
           <div class="workcenter">
                <label class="deptTitle2">Non-Certified Weld Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= NCWDTWPlanned %></div>
                     <div class="metrics"><label>Left to build:</label><%= NCWDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= NCWDTWPCTCompleted %></div>    
           </div>
        </div>
           
 
  <div class="workcenterContainer" runat="server" id="cert">
             <div class="workcenter">
                <label class="deptTitle2">Certified Weld Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= CWDTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= CWDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= CWDTWPCTCompleted%></div>    
           </div>
           </div>

 <div class="workcenterContainer" runat="server" id="build">
            <div class="workcenter">
                <label class="deptTitle2">Build Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= BLDDTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= BLDDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= BLDDTWPCTCompleted%></div>    
           </div>
           </div>
 <div class="workcenterContainer" runat="server" id="test1">
            <div runat="server" class="workcenter">
                <label class="deptTitle2">Test 1 Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= TSTDTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= TSTDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= TSTDTWPCTCompleted%></div>    
           </div>
           </div>

 <div class="workcenterContainer" runat="server" id="test2">
            <div class="workcenter">
                <label class="deptTitle2">Test 2 Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= TST2DTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= TST2DTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= TST2DTWPCTCompleted%></div>    
           </div>
           </div>

 <div class="workcenterContainer" runat="server" id="paint">
            <div class="workcenter">
                <label class="deptTitle2">Paint Workcenter</label>
                     <div class="metrics"><label>Planned:</label><%= PNTDTWPlanned%></div>
                     <div class="metrics"><label>Left to build:</label><%= PNTDTWRemaining %></div>
                     <div class="metrics"><label>Percent built:</label><%= PNTDTWPCTCompleted%></div>    
           </div>
</div>



                     
 
</div>
<div id="banner">
    <div id="banner-content">
        <span style="display: block !important; width: 100%; text-align: center; font-family: sans-serif; font-size: 12px;"><a href="http://www.wunderground.com/cgi-bin/findweather/getForecast?query=zmw:13118.1.99999&bannertypeclick=wu_clean2day" title="Moravia, New York Weather Forecast" target="_blank"><img src="http://weathersticker.wunderground.com/weathersticker/cgi-bin/banner/ban/wxBanner?bannertype=wu_clean2day_cond&airportcode=KN03&ForcedCity=Moravia&ForcedState=NY&zip=13118&language=EN" alt="Find more about Weather in Moravia, NY" width="300" /></a></span>
    </div>
</div>

</asp:Content>

<asp:Content ContentPlaceHolderID="cp4" runat="server" ID="floatingFooter">

<div id="shipDate" class="stroke"><%=Shipdate%></div>    
</asp:Content>
