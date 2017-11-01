<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/UpscoData.Master" CodeBehind="JumboTronMain.aspx.vb" Inherits="UPSCODataTools.JumboTronMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cp1" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cp2" runat="server">

<div class="jumbotron text-center">
<div class="container-fluid">
    <div class="row">
        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="bld">
                    <div class="fa fa-3x workCenterTitle">Build Workcenter</div>
                    <div>
                        <ol class="metrics">
                            <li>
                                <div>Backlog:<%= BLDBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= BLDDTWPlanned %></li>
                            <li>Completed:<%= BLDDTWCompleted%></li>
                            <li>Remaining:<%= BLDDTWRemaining%></li>
                            <li>Percentage to Goal:<%= BLDDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= BLDDNWPlanned %></li>
                            <li>Completed:<%= BLDDNWCompleted %></li>
                            <li>Remaining:<%= BLDDNWRemaining %></li>
                            <li>Percentage to Goal:<%= BLDDNWPCTCompleted%></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>

        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="tst">
                    <div class="fa fa-3x workCenterTitle">Test 1 Workcenter</div>
                    <div>
                        <ol class="metrics">
                            <li>
                                <div>Backlog:<%= TSTBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                         
                            <li>Planned:<%= TSTDTWPlanned %></li>
                            <li>Completed:<%= TSTDTWCompleted%></li>
                            <li>Remaining:<%= TSTDTWRemaining%></li>
                            <li>Percentage to Goal:<%= TSTDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= TSTDNWPlanned %></li>
                            <li>Completed:<%= TSTDNWCompleted %></li>
                            <li>Remaining:<%= TSTDNWRemaining %></li>
                            <li>Percentage to Goal:<%= TSTDNWPCTCompleted%></li>
                   
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="tst2">
                    <div class="fa fa-3x workCenterTitle">Test 2 Workcenter</div>
                    <div>
                       <ol class="metrics">
                            <li>
                                <div>Backlog:<%= TST2BackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= TST2DTWPlanned %></li>
                            <li>Completed:<%= TST2DTWCompleted%></li>
                            <li>Remaining:<%= TST2DTWRemaining%></li>
                            <li>Percentage to Goal:<%= TST2DTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= TST2DNWPlanned %></li>
                            <li>Completed:<%= TST2DNWCompleted %></li>
                            <li>Remaining:<%= TST2DNWRemaining %></li>
                            <li>Percentage to Goal:<%= TST2DNWPCTCompleted%></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="pnt">
                    <div class="fa fa-3x workCenterTitle">Paint Line Workcenter</div>
                    <div>
                        <ol class="metrics">
                            <li>
                                <div>Backlog:<%= PNTBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= PNTDTWPlanned %></li>
                            <li>Completed:<%= PNTDTWCompleted%></li>
                            <li>Remaining:<%= PNTDTWRemaining%></li>
                            <li>Percentage to Goal:<%= PNTDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= PNTDNWPlanned %></li>
                            <li>Completed:<%= PNTDNWCompleted %></li>
                            <li>Remaining:<%= PNTDNWRemaining %></li>
                            <li>Percentage to Goal:<%= PNTDNWPCTCompleted%></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
</div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cp3" runat="server">
 <div id="banner">        
        <div id="shipDate" class="title stroke"><%=Shipdate%></div>  
  </div>
  <p id="encourage">Go For the Green!</p>
</asp:Content>
