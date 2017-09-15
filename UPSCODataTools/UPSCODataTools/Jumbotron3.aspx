<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/UpscoData.Master" CodeBehind="Jumbotron3.aspx.vb" Inherits="UPSCODataTools.Jumbotron3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cp2" runat="server">
<div class="title" id="time"></div>
<div id="slide-window" style="margin-top: 110px;margin-bottom: 50px;">
    <ol id="slides" start="1">    
      <li class="slide color-0 alive countMe">
      <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="nip">  
            <div class="depttitle banner-content">Nipple Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= NIPBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= NIPDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= NIPDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= NIPDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= NIPDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= NIPDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= NIPDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= NIPDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= NIPDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
      
      <li class="slide color-1 countMe">
       <div class="wrapper">
        <div class="workcenterContainer banner-content"   runat="server" id="ncw">  
            <div class="depttitle banner-content">Non-Certified Weld Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= NCWBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= NCWDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= NCWDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= NCWDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= NCWDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= NCWDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= NCWDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= NCWDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= NCWDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
      
      <li class="slide color-2 countMe">
         <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="cw">  
            <div class="depttitle banner-content">Certified Weld Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= CWBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= CWDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= CWDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= CWDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= CWDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= CWDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= CWDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= CWDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= CWDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
      
      <li class="slide color-3 countMe">
        <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="bld">  
            <div class="depttitle banner-content">Build Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= BLDBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= BLDDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= BLDDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= BLDDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= BLDDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= BLDDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= BLDDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= BLDDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= BLDDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
  
      </li>
      
      <li class="slide color-4 countMe">
       <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="tst">  
            <div class="depttitle banner-content">Test 1 Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= TSTBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= TSTDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= TSTDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= TSTDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= TSTDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= TSTDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= TSTDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= TSTDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= TSTDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
      <li class="slide color-5 countMe">
       <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="tst2">  
            <div class="depttitle banner-content">Test 2 Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= TST2BackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= TST2DTWPlanned %></li>
            <li class="metricTitle">Completed:<%= TST2DTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= TST2DTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= TST2DTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= TST2DNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= TST2DNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= TST2DNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= TST2DNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
      <li class="slide color-6 countMe">
      <div class="wrapper">
        <div class="workcenterContainer banner-content" runat="server" id="pnt">  
            <div class="depttitle banner-content">Paint Line Workcenter</div>
            <div class="metrics banner-content">  
            <ol>
            <li><div class="metricTitle">Backlog:<%= PNTBackLogRemaining %></div></li>
            <li><div class="deptSection">Current Week</div></li>          
            <li class="metricTitle">Planned:<%= PNTDTWPlanned %></li>
            <li class="metricTitle">Completed:<%= PNTDTWCompleted%></li>
            <li class="metricTitle">Remaining:<%= PNTDTWRemaining%></li> 
            <li class="metricTitle">Percentage to Goal:<%= PNTDTWPCTCompleted%></li>
            <li><div class="deptSection">Next Week</div></li>  
            <li class="metricTitle">Planned:<%= PNTDNWPlanned %></li> 
            <li class="metricTitle">Completed:<%= PNTDNWCompleted %></li> 
            <li class="metricTitle">Remaining:<%= PNTDNWRemaining %></li>    
            <li class="metricTitle">Percentage to Goal:<%= PNTDNWPCTCompleted%></li>     
            </ol>  
            </div>
        </div> 
        </div>
      </li>
    
    </ol>
    <span class="nav fa fa-chevron-left fa-2x" id="left"></span>
    <span class="nav fa fa-chevron-right fa-2x" id="right"></span>
   
 

    
 <%--   <div id="credit"><span id="count">1</span></div>
    
    </div>
  --%>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cp3" runat="server">
  <div id="banner">
        <div id="banner-content">
            <span style="display: block !important; margin: auto; width: 900px; height: 100px; text-align: center; font-family: FontAwesome; font-size: 12px; overflow:hidden;"><iframe style="display: block; " src="//cdnres.willyweather.com/widget/loadView.html?id=71626" height="92" width="900"></iframe><a style="width: 20px; height: 95px; width: !important  100%; position: relative; margin: auto; clear: both; text-align:center;" href="http://www.willyweather.com/ny/cayuga-county/moravia.html" rel="nofollow">moravia weather forecast</a></span>
        </div>
        <div id="shipDate" class="title stroke"><%=Shipdate%></div>  

  </div>

</asp:Content>
