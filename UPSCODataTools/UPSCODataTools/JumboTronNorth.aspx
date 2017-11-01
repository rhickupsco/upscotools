<%@ Page Title="JumboTron North" Language="vb" AutoEventWireup="false" MasterPageFile="~/UpscoData.Master" CodeBehind="JumboTronNorth.aspx.vb" Inherits="UPSCODataTools.JumboTronNorth" %>
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
                <div runat="server" id="nip">
                    <div class="fa fa-3x workCenterTitle">Bend Workcenter</div>
                    <div>
                        <ol class="metrics">
                            <li>
                                <div>Backlog:<%= NIPBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= NIPDTWPlanned %></li>
                            <li>Completed:<%= NIPDTWCompleted%></li>
                            <li>Remaining:<%= NIPDTWRemaining%></li>
                            <li>Pct. to Goal:<%= NIPDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= NIPDNWPlanned %></li>
                            <li>Completed:<%= NIPDNWCompleted %></li>
                            <li>Remaining:<%= NIPDNWRemaining %></li>
                            <li>Pct. to Goal:<%= NIPDNWPCTCompleted%></li>
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
                            <li>Pct. to Goal:<%= TST2DTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= TST2DNWPlanned %></li>
                            <li>Completed:<%= TST2DNWCompleted %></li>
                            <li>Remaining:<%= TST2DNWRemaining %></li>
                            <li>Pct. to Goal:<%= TST2DNWPCTCompleted%></li>
                   
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="ncw">
                    <div class="fa fa-3x workCenterTitle">NC Weld Workcenter</div>
                    <div>
                       <ol class="metrics">
                            <li>
                                <div>Backlog:<%= NCWBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= NCWDTWPlanned %></li>
                            <li>Completed:<%= NCWDTWCompleted%></li>
                            <li>Remaining:<%= NCWDTWRemaining%></li>
                            <li>Pct. to Goal:<%= NCWDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= NCWDNWPlanned %></li>
                            <li>Completed:<%= NCWDNWCompleted %></li>
                            <li>Remaining:<%= NCWDNWRemaining %></li>
                            <li>Pct. to Goal:<%= NCWDNWPCTCompleted%></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="wrapper">
                <div runat="server" id="cw">
                    <div class="fa fa-3x workCenterTitle">Cert Weld Workcenter</div>
                    <div>
                        <ol class="metrics">
                            <li>
                                <div>Backlog:<%= CWBackLogRemaining %></div>
                            </li>
                            <li>
                                <div class="deptSection">Current Week</div>
                            </li>
                            <li>Planned:<%= CWDTWPlanned %></li>
                            <li>Completed:<%= CWDTWCompleted%></li>
                            <li>Remaining:<%= CWDTWRemaining%></li>
                            <li>Pct. to Goal:<%= CWDTWPCTCompleted%></li>
                            <li>
                                <div class="deptSection">Next Week</div>
                            </li>
                            <li>Planned:<%= CWDNWPlanned %></li>
                            <li>Completed:<%= CWDNWCompleted %></li>
                            <li>Remaining:<%= CWDNWRemaining %></li>
                            <li>Pct. to Goal:<%= CWDNWPCTCompleted%></li>
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
