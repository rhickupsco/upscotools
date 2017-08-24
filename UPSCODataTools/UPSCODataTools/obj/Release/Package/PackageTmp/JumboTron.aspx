<%@ Page Title="Jumbotron" Language="vb" AutoEventWireup="true" MasterPageFile="~/UpscoData.Master" CodeBehind="JumboTron.aspx.vb" Inherits="UPSCODataTools.JumboTron" %>

<asp:Content ContentPlaceHolderID="cp2" runat="server">
<div id="topper">
    <div class="title" id="show"></div>
</div>
    <div id="Summary">
    <div id="nipple" class="deptSection">
        <div class="tablecontainer">
            <div class="tablecontainerrow">
                <div class="column1"><div id="nipTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Nipple</a></div></div>          
            </div>
            <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogNipple"><%=NIPBackLogRemaining%></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedNipple"><%=NIPDTWPlanned%></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedNipple"><%=NIPDTWCompleted%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingNipple"><%=NIPDTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctNipple"><%=NIPDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedNipple"><%= NIPDNWPlanned%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedNipple"><%= NIPDNWCompleted%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingNipple"><%= NIPDNWRemaining%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctNipple"><%= NIPDNWPCTCompleted%></div></div>               
            </div>
        </div>
    </div>
    <div id="noncertWeld" class="deptSection">
       <div class="tablecontainer">
            <div class="tablecontainerrow">
                <div class="column1"><div id="ncwTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Non-Cert Weld</a></div></div>
            </div>
           <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogNonCert"><%=NCWBackLogRemaining %></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedNonCert"><%=NCWDTWPlanned %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedNonCert"><%=NCWDTWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingNonCert"><%=NCWDTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctNonCert"><%=NCWDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedNonCert"><%=NCWDNWPlanned %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedNonCert"><%=NCWDNWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingNonCert"><%=NCWDNWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctNonCert"><%=NCWDNWPCTCompleted %></div></div>               
            </div>
        </div>   
    </div> 
    <div id="certWeld" class="deptSection">
        <div class="tablecontainer">
             <div class="tablecontainerrow">
                <div class="column1"><div id="cwTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Cert-Weld</a></div></div>
            </div>
           <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogCert"><%=CWBackLogRemaining %></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedCert"><%=CWDTWPlanned %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedCert"><%=CWDTWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingCert"><%=CWDTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctCert"><%=CWDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedCert"><%=CWDNWPlanned %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedCert"><%=CWDNWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingCert"><%=CWDNWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctCert"><%=CWDNWPCTCompleted %></div></div>               
            </div>
        </div>
    </div>
    <div id="build" class="deptSection ">
        <div class="tablecontainer">
             <div class="tablecontainerrow">
                <div class="column1"><div id="buildTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Build</a></div></div>
            </div>
            <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogBuild"><%=BLDBackLogRemaining %></div></div>              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedBuild"><%=BLDDTWPlanned %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedBuild"><%=BLDDTWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBuild"><%=BLDDTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctBuild"><%=BLDDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedBuild"><%=BLDDNWPlanned %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedBuild"><%=BLDDNWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingBuild"><%=BLDDNWRemaining %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3">
                    <div id="intNextCompletedPctBuild"><%=BLDDNWPCTCompleted %></div>
                </div>
            </div>
        </div>
    </div>
    <div id="test" class="deptSection">
        <div class="tablecontainer">
             <div class="tablecontainerrow">
                <div class="column1"><div id="testTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Test</a> 1</div></div>
            </div>
           <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogTest"><%=TSTBackLogRemaining %></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedTest"><%=TSTDTWPlanned %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedTest"><%=TSTDTWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingTest"><%=TSTDTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctTest"><%=TSTDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedTest"><%=TSTDNWPlanned %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedTest"><%=TSTDNWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingTest"><%=TSTDNWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctTest"><%=TSTDNWPCTCompleted %></div></div>               
            </div>
        </div>
    </div>
    <div id="paint" class="deptSection">
         <div class="tablecontainer">
            <div class="tablecontainerrow">
                <div class="column1"><div id="paintTitle" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Paint</a></div></div>
            </div>
            <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogPaint"><%=PNTBackLogRemaining %></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedPaint"><%=PNTDTWPlanned %></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedPaint"><%=PNTDTWCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingPaint"><%= PNTDTWRemaining%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctPaint"><%=PNTDTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedPaint"><%=PNTDNWPlanned %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedPaint"><%= PNTDNWCompleted%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingPaint"><%=PNTDNWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctPaint"><%=PNTDNWPCTCompleted %></div></div>               
            </div>
        </div>
    </div>
    <div id="test2" class="deptSection">
        <div class="tablecontainer">
            <div class="tablecontainerrow">
                <div class="column1"><div id="test2Title" runat="server" class="deptTitle"><a href="http://upscosp/searchcenter/missingparts.aspx">Nipple</a></div></div>          
            </div>
            <div class="tablecontainerrow" >
                <div class="column1">Backlog:</div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingBacklogTest2"><%=TST2BackLogRemaining%></div></div>
              
            </div>
            <div class="tablecontainerrow">
                <div class="column1">Due this week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intPlannedTest2"><%=TST2DTWPlanned%></div></div>               
            </div>
            <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intCompletedTest2"><%=TST2DTWCompleted%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intRemainingTest2"><%=TST2DTWRemaining %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intCompletePctTest2"><%=TST2DTWPCTCompleted %></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1">Due Next Week:</div>
                <div class="column2">Planned</div>
                <div class="column3"><div id="intNextPlannedTest2"><%= TST2DNWPlanned%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Completed</div>
                <div class="column3"><div id="intNextCompletedTest2"><%= TST2DNWCompleted%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">Remaining</div>
                <div class="column3"><div id="intNextRemainingTest2"><%= TST2DNWRemaining%></div></div>               
            </div>
             <div class="tablecontainerrow">
                <div class="column1"></div>
                <div class="column2">% Completed</div>
                <div class="column3"><div id="intNextCompletedPctTest2"><%= TST2DNWPCTCompleted%></div></div>               
            </div>
        </div>
    </div>
</div>
<%--<div class="hidden">Build Due Previous Week = <div id="intLastPlannedTest" class="hidden"><%=BLDDPWPlanned %></div></div>--%>

</asp:Content>
<asp:Content ContentPlaceHolderID="cp4" runat="server" ID="floatingFooter">
<div id="shipDate" class="stroke" style=" font-size: 2em;
        color: white;
        vertical-align: middle;
        text-align: center;
        clear: both;
        margin-bottom:1px;"><%=Shipdate%></div>    
</asp:Content>

