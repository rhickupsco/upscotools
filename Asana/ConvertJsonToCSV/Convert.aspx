<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convert.aspx.cs" Inherits="ConvertJsonToCSV.Convert" ValidateRequest="false"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style/cssReset.css" rel="stylesheet" />
    <link href="style/bootstrap.css" rel="stylesheet" />
    <link href="style/helpdeskStyle.css" rel="stylesheet" />
    <script src="scripts/fade.js" type="text/javascript"></script>
    <title>Scorecard Export JSON From Asana</title>
</head>
<body>


    <form id="frmConvert" runat="server">

            <div id="scoreCard">
            <h2>Scorecard Summary for Inside IT Support Last Week (Monday through Friday)</h2>
            <div class="tuck"><%=InclusiveDates%></div>          
                <div class="label"><%=AverageDaysOpen%></div>
                <div class="label"><%=AverageDaysToComplete%></div>
                <div class="label"><%=TotalHelpdeskCount%></div>            
                <div class="label"><%=CompleteTotal%></div>
                <div class="label"><%=QuantityOpenTotal%></div>
                <div class="label"><%=PercentageCompleteTotal%></div>
            </div>
    <div id="powerUser">
    <div class="pad">
        <a href="https://app.asana.com/0/163961464543147/list" id="lblInstructions" target="_blank" class="title">Export</a> the data from the Asana Project that you want and Save all text from that file as [ServerRoot]:\\AsanaExports\result.json, and then click CONVERT</div>
        <div id="imageHolder" runat="server" class="pad-left">
        <a href="https://app.asana.com/0/163961464543147/list" target="_blank" id="imgHyperlink"><img id="hdExportImage" src="images/helpdeskExport.PNG" /></a>
    
         <br />
             </div>
     </div>
     <div class="pad">
         <asp:Button ID="btnConvert" runat="server" Text="Calculate Scorecard Data" Width="400px" OnClick="btnConvert_Click" />   
         </div>
         <div class="container-fluid height-full">
  <div class="row">
    <div class="col-xs-12">
        <div style="width:auto; font-size:small; text-align:left;">     
            <asp:GridView ID="gvIssues" runat="server" AllowSorting="False" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" Width="100%" AutoGenerateColumns="false" AllowPaging="false" BorderWidth="1px" 
                CellPadding="3" Visible="False" AlternatingRowStyle-BackColor="#FFFFCC">
                <Columns>
                <asp:BoundField DataField="id" HeaderText="Job Id" HeaderStyle-Width="50px" SortExpression="id">
                    <ItemStyle Width="5%" />
                </asp:BoundField>
                <asp:BoundField DataField="project_name" HeaderStyle-Width="30px" HeaderText="Project">
                    <ItemStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="created_at" HeaderStyle-Width="300px" HeaderText="Request Time" SortExpression="created_at">
                    <ItemStyle Width="15%" />
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="Request">
                    <ItemStyle Width="40%" />
                </asp:BoundField>
                <asp:BoundField DataField="assignee" HeaderText="Assigned To" SortExpression="assignee">
                    <ItemStyle Width="10%" />
                </asp:BoundField>
                <asp:BoundField DataField="completed_at" HeaderText="Time Completed" SortExpression="completed_at">
                    <ItemStyle />
                </asp:BoundField>
                   <asp:BoundField DataField="durationString" HeaderText="Minutes Elapsed">
                      <ItemStyle Width="5%" />
                </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"/>                
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <sortedascendingcellstyle backcolor="#F1F1F1" />
                <sortedascendingheaderstyle backcolor="#007DBB" />
                <sorteddescendingcellstyle backcolor="#CAC9C9" />
                <sorteddescendingheaderstyle backcolor="#00547E" />
            </asp:GridView>           
            </div>
    </div>
  </div>
</div>
    </form>
</body>

</html>
