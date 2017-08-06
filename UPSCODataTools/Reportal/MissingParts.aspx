<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MissingParts.aspx.vb" Inherits="MissingParts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Missing Parts</title>
    <link href="Content/Site.css" rel="stylesheet" />      
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper" runat="server"> 
    <div id="searchControls" class="clear-fix"> 
        <asp:Label ID="Label1" CssClass="question" runat="server" Text="WorkOrders Closed for Qty Less than Planned"></asp:Label>
    </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SageDS1" DataKeyNames="WorkOrder" GroupItemCount="5">
         <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                            <td runat="server" >
                                <table id="groupPlaceholderContainer" runat="server" border="1" 
                                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;
                                border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                    </tr> 
                    <tr runat="server">
                        <td runat="server" style="text-align: left;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                    </tr>
                </table>
               
            </LayoutTemplate>
          
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server" ></td>
                    </tr>
            </GroupTemplate>
            <AlternatingItemTemplate >        
                <td runat="server" style="background-color: #FFFFFF;color: #284775;" class="myItemAlternate">WorkOrder:
                    <asp:Label ID="WorkOrderLabel" runat="server" Text='<%# Eval("WorkOrder") %>' />
                    <br />
                    QtyPlanned:
                    <asp:Label ID="QtyPlannedLabel" runat="server" Text='<%# Eval("QtyPlanned", "{0:N}") %>' />
                    <br />
                     QtyCompleted:
                    <asp:Label ID="QtyCompletedLabel" runat="server" Text='<%# Eval("QtyCompleted", "{0:N}") %>' />
                    <br />
                    WODueDate:
                    <asp:Label ID="WODueDateLabel" runat="server" Text='<%# Eval("WODueDate", "{0:d}") %>' />
                    <br />
                    StepNumber:
                    <asp:Label ID="StepNumberLabel" runat="server" Text='<%# Eval("StepNumber") %>' />
                    <br />
                    Status:
                    <asp:Label ID="StatusLabel" runat="server" Text='<%# Eval("Status") %>' />
                    <br />
                    WorkCenter:
                    <asp:Label ID="WorkCenterLabel" runat="server" Text='<%# Eval("WorkCenter") %>' />
                    <br />
                    OperationCode:
                    <asp:Label ID="OperationCodeLabel" runat="server" Text='<%# Eval("OperationCode") %>' />
                    <br />
                    StepDescription:
                    <asp:Label ID="StepDescriptionLabel" runat="server" Text='<%# Eval("StepDescription") %>' />
                    <br />
                    StepComplete:
                    <asp:Label ID="StepCompleteLabel" runat="server" Text='<%# Eval("StepComplete") %>' />
                    <br />
                   
                    StdRunTime:
                    <asp:Label ID="StdRunTimeLabel" runat="server" Text='<%# Eval("StdRunTime") %>' />
                    <br />
                    ExtdStdTime:
                    <asp:Label ID="ExtdStdTimeLabel" runat="server" Text='<%# Eval("ExtdStdTime") %>' />
                    <br />
                    ActualRunTime:
                    <asp:Label ID="ActualRunTimeLabel" runat="server" Text='<%# Eval("ActualRunTime") %>' />
                    <br />
                    StdLaborCost:
                    <asp:Label ID="StdLaborCostLabel" runat="server" Text='<%# Eval("StdLaborCost") %>' />
                    <br />
                    StdMaterialCost:
                    <asp:Label ID="StdMaterialCostLabel" runat="server" Text='<%# Eval("StdMaterialCost") %>' />
                    <br />
                    StdLaborVariableOHCost:
                    <asp:Label ID="StdLaborVariableOHCostLabel" runat="server" Text='<%# Eval("StdLaborVariableOHCost") %>' />
                    <br />
                    ActualLaborCost:
                    <asp:Label ID="ActualLaborCostLabel" runat="server" Text='<%# Eval("ActualLaborCost") %>' />
                    <br />
                    ActualMaterialCost:
                    <asp:Label ID="ActualMaterialCostLabel" runat="server" Text='<%# Eval("ActualMaterialCost") %>' />
                    <br />
                    ActualOutsideProcessCost:
                    <asp:Label ID="ActualOutsideProcessCostLabel" runat="server" Text='<%# Eval("ActualOutsideProcessCost") %>' />
                    <br />
                    ActualLaborFixedOH:
                    <asp:Label ID="ActualLaborFixedOHLabel" runat="server" Text='<%# Eval("ActualLaborFixedOH") %>' />
                    <br />
                    ActualLaborVariableOHCost:
                    <asp:Label ID="ActualLaborVariableOHCostLabel" runat="server" Text='<%# Eval("ActualLaborVariableOHCost") %>' />
                    <br />
                    RunHoursSchedOnStartDate:
                    <asp:Label ID="RunHoursSchedOnStartDateLabel" runat="server" Text='<%# Eval("RunHoursSchedOnStartDate") %>' />
                    <br />
                </td>
  
            </AlternatingItemTemplate>

            <ItemTemplate>
                <td runat="server" style="background-color: #E0FFFF;color: #333333;" class="myItem">WorkOrder:
                    <asp:Label ID="WorkOrderLabel" runat="server" Text='<%# Eval("WorkOrder") %>' />
                    <br />
                    QtyPlanned:
                    <asp:Label ID="QtyPlannedLabel" runat="server" Text='<%# Eval("QtyPlanned", "{0:N}") %>' />
                    <br />
                     QtyCompleted:
                    <asp:Label ID="QtyCompletedLabel" runat="server" Text='<%# Eval("QtyCompleted", "{0:N}") %>' />
                    <br />
                    WODueDate:
                    <asp:Label ID="WODueDateLabel" runat="server" Text='<%# Eval("WODueDate", "{0:d}") %>' />
                    <br />
                    StepNumber:
                    <asp:Label ID="StepNumberLabel" runat="server" Text='<%# Eval("StepNumber") %>' />
                    <br />
                    Status:
                    <asp:Label ID="StatusLabel" runat="server" Text='<%# Eval("Status") %>' />
                    <br />
                    WorkCenter:
                    <asp:Label ID="WorkCenterLabel" runat="server" Text='<%# Eval("WorkCenter") %>' />
                    <br />
                    OperationCode:
                    <asp:Label ID="OperationCodeLabel" runat="server" Text='<%# Eval("OperationCode") %>' />
                    <br />
                    StepDescription:
                    <asp:Label ID="StepDescriptionLabel" runat="server" Text='<%# Eval("StepDescription") %>' />
                    <br />
                    StepComplete:
                    <asp:Label ID="StepCompleteLabel" runat="server" Text='<%# Eval("StepComplete") %>' />
                    <br />
                   
                    StdRunTime:
                    <asp:Label ID="StdRunTimeLabel" runat="server" Text='<%# Eval("StdRunTime") %>' />
                    <br />
                    ExtdStdTime:
                    <asp:Label ID="ExtdStdTimeLabel" runat="server" Text='<%# Eval("ExtdStdTime") %>' />
                    <br />
                    ActualRunTime:
                    <asp:Label ID="ActualRunTimeLabel" runat="server" Text='<%# Eval("ActualRunTime") %>' />
                    <br />
                    StdLaborCost:
                    <asp:Label ID="StdLaborCostLabel" runat="server" Text='<%# Eval("StdLaborCost") %>' />
                    <br />
                    StdMaterialCost:
                    <asp:Label ID="StdMaterialCostLabel" runat="server" Text='<%# Eval("StdMaterialCost") %>' />
                    <br />
                    StdLaborVariableOHCost:
                    <asp:Label ID="StdLaborVariableOHCostLabel" runat="server" Text='<%# Eval("StdLaborVariableOHCost") %>' />
                    <br />
                    ActualLaborCost:
                    <%--<asp:Label ID="ActualLaborCostLabel" runat="server" Text='<%# Eval("ActualLaborCost") %>' />--%>
                    <br />
                    ActualMaterialCost:
                    <asp:Label ID="ActualMaterialCostLabel" runat="server" Text='<%# Eval("ActualMaterialCost") %>' />
                    <br />
                    ActualOutsideProcessCost:
                    <asp:Label ID="ActualOutsideProcessCostLabel" runat="server" Text='<%# Eval("ActualOutsideProcessCost") %>' />
                    <br />
                    ActualLaborFixedOH:
                    <asp:Label ID="ActualLaborFixedOHLabel" runat="server" Text='<%# Eval("ActualLaborFixedOH") %>' />
                    <br />
                    ActualLaborVariableOHCost:
                    <asp:Label ID="ActualLaborVariableOHCostLabel" runat="server" Text='<%# Eval("ActualLaborVariableOHCost") %>' />
                    <br />
                    RunHoursSchedOnStartDate:
                    <asp:Label ID="RunHoursSchedOnStartDateLabel" runat="server" Text='<%# Eval("RunHoursSchedOnStartDate") %>' />
                    <br />
                </td>

            </ItemTemplate>
           
            <SelectedItemTemplate>
                <td runat="server" style="background-color:#E2DED6; font-weight: bold;color: #333333;">WorkOrder:
                    <asp:Label ID="WorkOrderLabel" runat="server" Text='<%# Eval("WorkOrder") %>' />
                    <br />
                    QtyPlanned:
                    <asp:Label ID="QtyPlannedLabel" runat="server" Text='<%# Eval("QtyPlanned", "{0:N}") %>' />
                    <br />
                    QtyCompleted:
                    <asp:Label ID="QtyCompletedLabel" runat="server" Text='<%# Eval("QtyCompleted", "{0:N}") %>' />
                    <br />
                    WODueDate:
                    <asp:Label ID="WODueDateLabel" runat="server" Text='<%# Eval("WODueDate", "{0:d}") %>' />
                    <br />
                    StepNumber:
                    <asp:Label ID="StepNumberLabel" runat="server" Text='<%# Eval("StepNumber") %>' />
                    <br />
                    Status:
                    <asp:Label ID="StatusLabel" runat="server" Text='<%# Eval("Status") %>' />
                    <br />
                    WorkCenter:
                    <asp:Label ID="WorkCenterLabel" runat="server" Text='<%# Eval("WorkCenter") %>' />
                    <br />
                    OperationCode:
                    <asp:Label ID="OperationCodeLabel" runat="server" Text='<%# Eval("OperationCode") %>' />
                    <br />
                    StepDescription:
                    <asp:Label ID="StepDescriptionLabel" runat="server" Text='<%# Eval("StepDescription") %>' />
                    <br />
                    StepComplete:
                    <asp:Label ID="StepCompleteLabel" runat="server" Text='<%# Eval("StepComplete") %>' />
                    <br />
                    
                    StdRunTime:
                    <asp:Label ID="StdRunTimeLabel" runat="server" Text='<%# Eval("StdRunTime") %>' />
                    <br />
                    ExtdStdTime:
                    <asp:Label ID="ExtdStdTimeLabel" runat="server" Text='<%# Eval("ExtdStdTime") %>' />
                    <br />
                    ActualRunTime:
                    <asp:Label ID="ActualRunTimeLabel" runat="server" Text='<%# Eval("ActualRunTime") %>' />
                    <br />
                    StdLaborCost:
                    <asp:Label ID="StdLaborCostLabel" runat="server" Text='<%# Eval("StdLaborCost") %>' />
                    <br />
                    StdMaterialCost:
                    <asp:Label ID="StdMaterialCostLabel" runat="server" Text='<%# Eval("StdMaterialCost") %>' />
                    <br />
                    StdLaborVariableOHCost:
                    <asp:Label ID="StdLaborVariableOHCostLabel" runat="server" Text='<%# Eval("StdLaborVariableOHCost") %>' />
                    <br />
                    ActualLaborCost:
                    <asp:Label ID="ActualLaborCostLabel" runat="server" Text='<%# Eval("ActualLaborCost") %>' />
                    <br />
                    ActualMaterialCost:
                    <asp:Label ID="ActualMaterialCostLabel" runat="server" Text='<%# Eval("ActualMaterialCost") %>' />
                    <br />
                    ActualOutsideProcessCost:
                    <asp:Label ID="ActualOutsideProcessCostLabel" runat="server" Text='<%# Eval("ActualOutsideProcessCost") %>' />
                    <br />
                    ActualLaborFixedOH:
                    <asp:Label ID="ActualLaborFixedOHLabel" runat="server" Text='<%# Eval("ActualLaborFixedOH") %>' />
                    <br />
                    ActualLaborVariableOHCost:
                    <asp:Label ID="ActualLaborVariableOHCostLabel" runat="server" Text='<%# Eval("ActualLaborVariableOHCost") %>' />
                    <br />
                    RunHoursSchedOnStartDate:
                    <asp:Label ID="RunHoursSchedOnStartDateLabel" runat="server" Text='<%# Eval("RunHoursSchedOnStartDate") %>' />
                    <br />
                </td>
            </SelectedItemTemplate>
        </asp:ListView>
      
        <asp:SqlDataSource ID="SageDS1" runat="server" ConnectionString="<%$ ConnectionStrings:csSage %>" ProviderName="<%$ ConnectionStrings:csSage.ProviderName %>" >
                      
        </asp:SqlDataSource>
      
    </div>
    </form>
</body>
</html>
